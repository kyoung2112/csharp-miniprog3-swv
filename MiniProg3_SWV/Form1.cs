using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using PP_COM_Wrapper;

namespace MiniProg3_SWV
{
    public partial class Form1 : Form
    {
        PSoCProgrammerCOM_ObjectClass pp;
        string m_sLastError = "";

        //External definitions for "Close" button
        private const int SC_CLOSE = 0xF060;
        private const int MF_ENABLED = 0x00;
        private const int MF_GRAYED = 0x01;
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(IntPtr hMenu, int wIDEnableItem, int wEnable);
        
        Thread hThread;

        public Form1()
        {
            InitializeComponent();
            InitPPCOM();
        }

        bool SUCCEEDED(int hr)
        {
            return hr >= 0;
        }

        void AppendTextToLog(string text)
        {
            rtbLog.AppendText(text);
            rtbLog.AppendText("\r\n");
        }

        void StartCommand(GUI_Settings guiSettings)
        {
            int hr = 0;
            enumSWVMode enumMode;

            ThreadMonitor.SetAbortFlag(false);

            if (guiSettings.prot == Protocol.MANCHESTER)
                enumMode = enumSWVMode.MANCHESTER;
            else
                enumMode = enumSWVMode.TX8;

            hr = pp.SWV_Setup(enumMode, 6000000, null, out m_sLastError);
            if (!SUCCEEDED(hr))
            {
                AppendTextToLog("==> Error! Can't setup SWV configuration in PP COM. " + m_sLastError);
                return;
            }

            if (guiSettings.cmdMode == CommandMode.Sync)
                StartInterpretThread();
            else
            {
                //Start Async mode in COM-level
                string strError = "";
                hr = pp.USB2IIC_AsyncMode1(2, null, out strError);  //Start bulk async mode in COM
                if (!SUCCEEDED(hr))
                {
                    AppendTextToLog("==> Error! Can't set async mode in PP COM. " + m_sLastError);
                    return;
                }
            }

            guiStatusNow.Busy = Busy.BUSY;

        }

        void StopCommand(GUI_Settings guiSettings)
        {
            //Stop Sync mode thread
            KillThread();

            //Stop Async mode thread
            string strError = "";
            int hr = pp.USB2IIC_AsyncMode1(0, null, out strError);  //Stop bulk async mode
            if (!SUCCEEDED(hr))
            {
                AppendTextToLog("==> Error! Can't stop async mode in PP COM. " + m_sLastError);
                return;
            }

            guiStatusNow.Busy = Busy.IDLE;
        }
                
        #region GUI_Options

        public enum Protocol { MANCHESTER, UART };
        public enum CommandMode { Sync, Async };

        class GUI_Settings
        {
            public Protocol prot;
            public CommandMode cmdMode;

            public GUI_Settings()
            {
                this.prot = Protocol.MANCHESTER;
                this.cmdMode = CommandMode.Sync;
            }
        }

        void GetGUISettings(out GUI_Settings guiSettings)
        {
            guiSettings = new GUI_Settings();

            if (rbManchester.Checked)
                guiSettings.prot = Protocol.MANCHESTER;
            else
                guiSettings.prot = Protocol.UART;

            if (rbSync.Checked)
                guiSettings.cmdMode = CommandMode.Sync;
            else
                guiSettings.cmdMode = CommandMode.Async;

        }

        void SetGUISettings(GUI_Settings guiSettings)
        {
            if (guiSettings.prot == Protocol.MANCHESTER)
                rbManchester.Checked = true;
            else
                rbUART.Checked = true;

            if (guiSettings.cmdMode == CommandMode.Sync)
                rbSync.Checked = true;
            else
                rbAsync.Checked = true;
        }

        #endregion GUI_Options

        #region PP_COM_INITIALIZATION

        private int OpenPort(out string strError)
        {
            int hr;
            //Open Port - get last (connected) port in the ports list
            object ports;
            string[] portsStr;
            hr = pp.GetPorts(out ports, out strError);
            if (!SUCCEEDED(hr)) return hr;
            portsStr = ports as string[];

            if (portsStr.Length <= 0)
            {
                strError = "==> Error! Connect MiniProg3 to PC!";
                return -1;
            }

            bool bFound = true;
            string portName = "";
            for (int i = 0; i < portsStr.Length; i++)
            {
                if (portsStr[i].StartsWith("MiniProg3"))
                {
                    portName = portsStr[i];
                    bFound = true;
                    break;
                }
            }

            if (!bFound)
            {
                strError = "==> Error! Connect MiniProg3 to PC!";
                return -1;
            }

            hr = pp.OpenPort(portName, out strError);

            return hr;
        }

        private void InitPPCOM()
        {
            int hr;
            string strError;

            if (pp != null) return; //Programmer already started

            pp = new PSoCProgrammerCOM_ObjectClass();

            //Open and Configure MiniProg3 port
            hr = OpenPort(out strError);
            if (!SUCCEEDED(hr))
            {
                rtbLog.AppendText(strError);
                rtbLog.AppendText("\r\n");
                return;
            }

            pp.SetProtocolClock(enumFrequencies.FREQ_03_0, out strError);
            pp.SetProtocolConnector(1, out strError);
            pp.SetProtocol(enumInterfaces.SWD_SWV, out strError);
            pp.SetPowerVoltage("5.0", out strError);
            pp.PowerOn(out strError);

            pp.USB2IIC_ReceivedData += new _IPSoCProgrammerCOM_ObjectEvents_USB2IIC_ReceivedDataEventHandler(pp_USB2IIC_ReceivedData);

            object ports;
            hr = pp.GetPorts(out ports, out strError);
            string[] portsStr = ports as string[];
            AppendTextToLog("Start-up. Connected to '" + portsStr[0] + "' programmer!");
        }

        private void ReleaseCOM()
        {
            //Close Port first
            if (pp != null) pp.ClosePort(out m_sLastError);

            //Disconnect from COM-object and unload it
            pp = null;
            GC.GetTotalMemory(true);
        }

        #endregion PP_COM_INITIALIZATION

        #region GUI_Events

        private void btnExecute_Click(object sender, EventArgs e)
        {
            GUI_Settings guiSettings;
            GetGUISettings(out guiSettings);

            if (guiStatusNow.Busy == Busy.IDLE)
                StartCommand(guiSettings);
            else
                StopCommand(guiSettings);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ReleaseCOM();
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReleaseCOM();
        }

        #endregion GUI_Events

        #region Sync_Mode_Thread_Operations

        private void StartInterpretThread()
        {
            hThread = new Thread(new ThreadStart(RunRepeatProc));
            hThread.Start();
        }

        private void KillThread()
        {
            if (hThread == null) return;
            hThread.Abort();
            hThread.Join(1000);
            Thread.Sleep(100);
            ThreadMonitor.SetAbortFlag(true);
            hThread = null;            
        }

        private void RunRepeatProc()
        {
            long hr = 0;
            string strError = "";
            object arr = null;
            byte[] data = null;

            while (true)
            {
                if (ThreadMonitor.IsAborted()) break;
                hr = pp.SWV_ReadData(out arr, out strError);                
                data = arr as byte[];
                if (hr < 0) continue;

                for (int i = 0; i < data.Length; i++)
                {
                    ShowRepeatData(data[i].ToString("X2") + " ");
                }
            }
        }

        #endregion Sync_Mode_Thread_Operations

        #region Async_Mode_Thread_Operations

        public void pp_USB2IIC_ReceivedData(object dataOUT)
        {
            byte[] data = dataOUT as byte[];
            for (int i = 0; i < data.Length; i++)
            {
                ShowRepeatData(data[i].ToString("X2") + " ");
            }
        }

        delegate void ShowRepeatDataDelegate(string text);

        public void ShowRepeatData(string text)
        {
            if (this.InvokeRequired)
            {
                ShowRepeatDataDelegate showRepeatData =
                    new ShowRepeatDataDelegate(_ShowRepeatData);
                this.Invoke(showRepeatData, new Object[] { text });
            }
            else
                _ShowRepeatData(text);
        }

        private void _ShowRepeatData(string text)
        {
            rtbLog.AppendText(text);
        }

        #endregion Async_Mode_Thread_Operations
    }

    static class ThreadMonitor
    {
        static bool fAborted;

        public static bool IsAborted()
        {
            return fAborted;
        }

        public static void SetAbortFlag(bool Aborted)
        {
            fAborted = Aborted;
        }
    }
}