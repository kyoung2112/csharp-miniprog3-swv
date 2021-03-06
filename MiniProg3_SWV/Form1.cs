﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using PP_ComLib_Wrapper;
using System.Globalization;

namespace MiniProg3_SWV
{    
    public partial class Form1 : Form
    {
        PP_ComLib_WrapperClass pp;
        string m_sLastError = "";

        //External definitions for "Close" button
        private const int SC_CLOSE = 0xF060;
        private const int MF_ENABLED = 0x00;
        private const int MF_GRAYED = 0x01;
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(IntPtr hMenu, int wIDEnableItem, int wEnable);

        public Form1()
        {
            InitializeComponent();
            
            /* Go ahead and attempt connection with Miniprog3 */
            //InitPPCOM();
        }

        bool SUCCEEDED(int hr)
        {
            return hr >= 0;
        }

        void AppendTextToLog(string text)
        {
            rtbLog.AppendText("\r\n");
            rtbLog.AppendText(text);
        }

        void StartCommand(GUI_Settings guiSettings)
        {
            int hr = 0;
            int swvclk;
            enumSWVMode enumMode;
            byte[] outBytes;

            ThreadMonitor.SetAbortFlag(false);

            if (guiSettings.prot == Protocol.MANCHESTER)
                enumMode = enumSWVMode.MANCHESTER;
            else
                enumMode = enumSWVMode.TX8;
            if (pp == null)
            {
                AppendTextToLog("==> Error! Not connected to programmer.");
                return;
            }
           
            swvclk = int.Parse(cbFreq.SelectedItem.ToString(), NumberStyles.AllowThousands);

            hr = pp.SWV_Setup(enumMode, swvclk, out outBytes, out m_sLastError);
            if (!SUCCEEDED(hr))
            {
                AppendTextToLog("==> Error! Can't setup SWV configuration in PP COM. " + m_sLastError);
                return;
            }

            //Start Async mode in COM-level
            string strError = "";
            hr = pp.USB2IIC_AsyncMode1(2, null, out strError);  //Start bulk async mode in COM
            if (!SUCCEEDED(hr))
            {
                AppendTextToLog("==> Error! Can't set async mode in PP COM. " + m_sLastError);
                return;
            }
         

            guiStatusNow.Busy = Busy.BUSY;

        }

        void StopCommand(GUI_Settings guiSettings)
        {
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
        public enum Voltage {V5_0, V3_3, V2_5, V1_8, EXT};
        public enum Connector {P10,P5};

        class GUI_Settings
        {
            public Protocol prot;
            public Voltage volt;
            public Connector conn;

            public GUI_Settings()
            {
                this.prot = Protocol.MANCHESTER;
                this.volt = Voltage.V3_3;
                this.conn = Connector.P10;
            }
        }

        void GetGUISettings(out GUI_Settings guiSettings)
        {
            guiSettings = new GUI_Settings();

            if (rbManchester.Checked)
                guiSettings.prot = Protocol.MANCHESTER;
            else
                guiSettings.prot = Protocol.UART;

            if (rb5p0V.Checked)
                guiSettings.volt = Voltage.V5_0;
            else if (rb3p3V.Checked)
                guiSettings.volt = Voltage.V3_3;
            else if (rb2p5V.Checked)
                guiSettings.volt = Voltage.V2_5;
            else if (rb1p8V.Checked)
                guiSettings.volt = Voltage.V1_8;
            else
                guiSettings.volt = Voltage.EXT;

            if (rb10pin.Checked)
                guiSettings.conn = Connector.P10;
            else
                guiSettings.conn = Connector.P5;

        }

        void SetGUISettings(GUI_Settings guiSettings)
        {
            if (guiSettings.prot == Protocol.MANCHESTER)
                rbManchester.Checked = true;
            else
                rbUART.Checked = true;

            if (guiSettings.volt == Voltage.V5_0)
                rb5p0V.Checked = true;
            else if (guiSettings.volt == Voltage.V3_3)
                rb3p3V.Checked = true;
            else if (guiSettings.volt == Voltage.V2_5)
                rb2p5V.Checked = true;
            else if (guiSettings.volt == Voltage.V1_8)
                rb1p8V.Checked = true;
            else if (guiSettings.volt == Voltage.EXT)
                rbExt.Checked = true;

            if (guiSettings.conn == Connector.P10)
                rb10pin.Checked = true;
            else
                rb5pin.Checked = true;
        }

        #endregion GUI_Options

        #region PP_COM_INITIALIZATION

        private int OpenPort(out string strError)
        {
            int hr;
            //Open Port - get last (connected) port in the ports list           
            string[] portsStr;
            hr = pp.GetPorts(out portsStr, out strError);
            if (!SUCCEEDED(hr)) return hr;

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

        int connected = 0;  // DTV

        private void InitPPCOM(GUI_Settings guiSettings)
        {
            int hr;
            string strVolt;
            string strError;

            if (pp != null) return; //Programmer already started

            pp = new PP_ComLib_WrapperClass();

            if (!pp.w_IsConnected())
            {
                if (pp.w_ConnectToLatest() == 0)
                {
                    AppendTextToLog("Detected PSoC Programmer COM object version " + pp.Version());
                }
                else 
                {
                    AppendTextToLog("PSoC Programmer not installed. Please install PSoC Programmer and try again.");
                    
                    //Disconnect from COM-object and unload it
                    pp = null;
                    GC.GetTotalMemory(true);
                    return;
                }
            }

            //Open and Configure MiniProg3 port
            hr = OpenPort(out strError);
            if (!SUCCEEDED(hr))
            {
                rtbLog.AppendText("Connect error: "+strError);
                rtbLog.AppendText("\r\n");

                //Disconnect from COM-object and unload it
                pp = null;
                GC.GetTotalMemory(true);
                return;
            }

            pp.SetProtocolClock(enumFrequencies.FREQ_03_0, out strError);
            if (guiSettings.conn == Connector.P10)
            {
                pp.SetProtocolConnector(1, out strError);
            }
            else
            {
                pp.SetProtocolConnector(0, out strError);
            }
            
            pp.SetProtocol(enumInterfaces.SWD_SWV, out strError);

            if (guiSettings.volt == Voltage.V5_0)
                strVolt = "5.0";
            else if (guiSettings.volt == Voltage.V3_3)
                strVolt = "3.3";
            else if (guiSettings.volt == Voltage.V2_5)
                strVolt = "2.5";
            else if (guiSettings.volt == Voltage.V1_8)
                strVolt = "1.8";
            else
                strVolt = "EXT";

            if (strVolt != "EXT")
            {
                pp.SetPowerVoltage(strVolt, out strError);
                pp.PowerOn(out strError);
            }

            /* Init the event handler for received data */
            pp.OnUSB2IIC_DataReceived += new PP_ComLib_Wrapper.PP_ComLib_WrapperClass.DelegateByteArrayParam(pp_USB2IIC_ReceivedData);

            //object ports;
            string[] portsStr;
            hr = pp.GetPorts(out portsStr, out strError);
            //string[] portsStr = ports as string[];
            AppendTextToLog("Connected to '" + portsStr[0] + "' programmer!");
            btnConnect.Text = "Disconnect";     // DTV
            connected = 1;                      // DTV
        }

        private void ReleaseCOM()
        {
            //Close Port first
            if (pp != null)
            {
                /* Turn power off first (in case the user is switching to ext power) */
                pp.PowerOff(out m_sLastError);
                pp.ClosePort(out m_sLastError);
            }
            else
            {
                AppendTextToLog("Disconnect attempted - not connected!");
            }
            if (m_sLastError != "")
            {
                AppendTextToLog("Disconnect error: " + m_sLastError);
            }
            else
            {
                AppendTextToLog("Successfully disconnected from programmer!");
            }


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

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // DTV

            GUI_Settings guiSettings;
            GetGUISettings(out guiSettings);
            
            if (connected == 0)
            {          
                InitPPCOM(guiSettings);
                StartCommand(guiSettings);

                /* Disable connection setting elements */
                gbProtocol.Enabled = false;
                gbVoltage.Enabled = false;
                gbConn.Enabled = false;
                cbFreq.Enabled = false;
            }
            else
            {
                
                StopCommand(guiSettings);
                ReleaseCOM();
                connected = 0;
                btnConnect.Text = "Connect";

                /* Re-enable connection setting elements */
                gbProtocol.Enabled = true;
                gbVoltage.Enabled = true;
                gbConn.Enabled = true;
                cbFreq.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbLog.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFreq.SelectedIndex = 6; //Default to 6 MHz
        }

        #endregion GUI_Events


        #region Async_Mode_Thread_Operations

        public void pp_USB2IIC_ReceivedData(object dataOUT)
        {
            byte[] data = dataOUT as byte[];
            for (int i = 0; i < data.Length; i++)
            {
                //KLY
#if false
                /* Show raw output for debug purposes */
                ShowRepeatData(data[i].ToString("X2") + " ");
                //ShowRepeatData(data[i].ToString());
#else
                /* Copy the proper data to the form. We are using channel 0 and just sending one byte, so 0x01 is the header for each
                 * data packet. The sync frame is 0x00 and 0x80, so ignore these too. All other bytes are 
                 * printed to the form */
                /* TODO: 
                 * 1. Look for sync and read headers to determine channel and payload length to make it more generic.
                 * 2. Print timestamps. */
           
                if ((data[i] != 0x01) && (data[i] != 0x00) && (data[i] != 0x80))
                {
                    ShowRepeatData(Encoding.ASCII.GetString(new byte[] { data[i] }));
                }
#endif
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
            if( text != "\r")
            {
                rtbLog.AppendText(text);
            }
            //DTV - rtbLog Set HideSelection to FALSE to keep focus and maintain scrolling
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