using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PP_ComLib_Wrapper;

namespace MiniProg3_SWV
{
    partial class Form1
    {
        public enum Busy { IDLE, BUSY }
        public enum Connection { CONNECTED, NOT_CONNECTED }

        struct GUI_Status
        {
            public Connection Connection;
            public Busy Busy;

            public void CopyTo(ref GUI_Status dest)
            {
                dest.Connection = this.Connection;
                dest.Busy = this.Busy;
            }
        }

        GUI_Status guiStatusNow, guiStatusPrev;

        private void timerUI_Tick(object sender, EventArgs e)
        {
            //Get Current Status on which GUI controls are dependent on
            GetCurrentStatus();  // guiStatusNow <= collect current status
            // Update controls if (guiStatusNow != guiStatusPrev) or status just changed
            UpdateControls();    // guiStatusPrev <= guiStatusNow
        }

        private bool IsPortOpened()
        {
            int isOpen;
            if (pp == null) return false;
            pp.IsPortOpen(out isOpen, out m_sLastError);
            if (isOpen == 0) return false;
            return true;
        }

        private void GetCurrentStatus()
        {
            // Update programmer status
            //if (IsBusy())
            //    guiStatusNow.Busy = Busy.BUSY;
            //else
            //{
            //    guiStatusNow.Busy = Busy.IDLE;
                if (IsPortOpened())
                    guiStatusNow.Connection = Connection.CONNECTED;
                else
                    guiStatusNow.Connection = Connection.NOT_CONNECTED;
            //}
        }

        private void UpdateControls()
        {
            //All other control must be updated only when Status Changed
            if (!IsGuiStatusChanged()) return;

            //Start/Stop button
            if (guiStatusNow.Busy == Busy.IDLE)
            {
                btnExecute.Text = "Start";
            }
            else
            {
                btnExecute.Text = "Stop";
            }

            //"Close" button on the Form
            if (guiStatusNow.Busy == Busy.BUSY) EnableMenuItem(GetSystemMenu(this.Handle, false), SC_CLOSE, MF_GRAYED);
            else EnableMenuItem(GetSystemMenu(this.Handle, false), SC_CLOSE, MF_ENABLED);

            //Assign guiStatusNow -> guiStatusPrev
            guiStatusNow.CopyTo(ref guiStatusPrev);
        }

        bool IsGuiStatusChanged()
        {
            bool val = false;

            if (guiStatusNow.Connection == guiStatusPrev.Connection &&
                guiStatusNow.Busy == guiStatusPrev.Busy)
            {
                val = false;
            }
            else
                val = true;

            return val;
        }
    }
}
