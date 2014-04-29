namespace MiniProg3_SWV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbProtocol = new System.Windows.Forms.GroupBox();
            this.rbUART = new System.Windows.Forms.RadioButton();
            this.rbManchester = new System.Windows.Forms.RadioButton();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbAsync = new System.Windows.Forms.RadioButton();
            this.rbSync = new System.Windows.Forms.RadioButton();
            this.btnExecute = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.timerUI = new System.Windows.Forms.Timer(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.gbVoltage = new System.Windows.Forms.GroupBox();
            this.rbExt = new System.Windows.Forms.RadioButton();
            this.rb1p8V = new System.Windows.Forms.RadioButton();
            this.rb2p5V = new System.Windows.Forms.RadioButton();
            this.rb3p3V = new System.Windows.Forms.RadioButton();
            this.rb5p0V = new System.Windows.Forms.RadioButton();
            this.gbConn = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.rb5pin = new System.Windows.Forms.RadioButton();
            this.rb10pin = new System.Windows.Forms.RadioButton();
            this.gbProtocol.SuspendLayout();
            this.gbMode.SuspendLayout();
            this.gbVoltage.SuspendLayout();
            this.gbConn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProtocol
            // 
            this.gbProtocol.Controls.Add(this.rbUART);
            this.gbProtocol.Controls.Add(this.rbManchester);
            this.gbProtocol.Location = new System.Drawing.Point(5, 2);
            this.gbProtocol.Name = "gbProtocol";
            this.gbProtocol.Size = new System.Drawing.Size(165, 40);
            this.gbProtocol.TabIndex = 0;
            this.gbProtocol.TabStop = false;
            this.gbProtocol.Text = "Protocol";
            // 
            // rbUART
            // 
            this.rbUART.AutoSize = true;
            this.rbUART.Location = new System.Drawing.Point(95, 16);
            this.rbUART.Name = "rbUART";
            this.rbUART.Size = new System.Drawing.Size(55, 17);
            this.rbUART.TabIndex = 1;
            this.rbUART.Text = "UART";
            this.rbUART.UseVisualStyleBackColor = true;
            // 
            // rbManchester
            // 
            this.rbManchester.AutoSize = true;
            this.rbManchester.Checked = true;
            this.rbManchester.Location = new System.Drawing.Point(8, 16);
            this.rbManchester.Name = "rbManchester";
            this.rbManchester.Size = new System.Drawing.Size(81, 17);
            this.rbManchester.TabIndex = 0;
            this.rbManchester.TabStop = true;
            this.rbManchester.Text = "Manchester";
            this.rbManchester.UseVisualStyleBackColor = true;
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbAsync);
            this.gbMode.Controls.Add(this.rbSync);
            this.gbMode.Location = new System.Drawing.Point(176, 2);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(139, 40);
            this.gbMode.TabIndex = 1;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Command Mode";
            // 
            // rbAsync
            // 
            this.rbAsync.AutoSize = true;
            this.rbAsync.Checked = true;
            this.rbAsync.Location = new System.Drawing.Point(10, 16);
            this.rbAsync.Name = "rbAsync";
            this.rbAsync.Size = new System.Drawing.Size(54, 17);
            this.rbAsync.TabIndex = 1;
            this.rbAsync.TabStop = true;
            this.rbAsync.Text = "Async";
            this.rbAsync.UseVisualStyleBackColor = true;
            // 
            // rbSync
            // 
            this.rbSync.AutoSize = true;
            this.rbSync.Location = new System.Drawing.Point(74, 17);
            this.rbSync.Name = "rbSync";
            this.rbSync.Size = new System.Drawing.Size(49, 17);
            this.rbSync.TabIndex = 0;
            this.rbSync.Text = "Sync";
            this.rbSync.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(5, 48);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Start";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(5, 116);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(318, 239);
            this.rtbLog.TabIndex = 4;
            this.rtbLog.Text = "";
            // 
            // timerUI
            // 
            this.timerUI.Enabled = true;
            this.timerUI.Interval = 350;
            this.timerUI.Tick += new System.EventHandler(this.timerUI_Tick);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(167, 48);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(248, 48);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // gbVoltage
            // 
            this.gbVoltage.Controls.Add(this.rbExt);
            this.gbVoltage.Controls.Add(this.rb1p8V);
            this.gbVoltage.Controls.Add(this.rb2p5V);
            this.gbVoltage.Controls.Add(this.rb3p3V);
            this.gbVoltage.Controls.Add(this.rb5p0V);
            this.gbVoltage.Location = new System.Drawing.Point(5, 77);
            this.gbVoltage.Name = "gbVoltage";
            this.gbVoltage.Size = new System.Drawing.Size(232, 40);
            this.gbVoltage.TabIndex = 7;
            this.gbVoltage.TabStop = false;
            this.gbVoltage.Text = "Voltage";
            // 
            // rbExt
            // 
            this.rbExt.AutoSize = true;
            this.rbExt.Location = new System.Drawing.Point(192, 16);
            this.rbExt.Name = "rbExt";
            this.rbExt.Size = new System.Drawing.Size(40, 17);
            this.rbExt.TabIndex = 4;
            this.rbExt.Text = "Ext";
            this.rbExt.UseVisualStyleBackColor = true;
            // 
            // rb1p8V
            // 
            this.rb1p8V.AutoSize = true;
            this.rb1p8V.Location = new System.Drawing.Point(146, 16);
            this.rb1p8V.Name = "rb1p8V";
            this.rb1p8V.Size = new System.Drawing.Size(40, 17);
            this.rb1p8V.TabIndex = 3;
            this.rb1p8V.Text = "1.8";
            this.rb1p8V.UseVisualStyleBackColor = true;
            // 
            // rb2p5V
            // 
            this.rb2p5V.AutoSize = true;
            this.rb2p5V.Location = new System.Drawing.Point(100, 16);
            this.rb2p5V.Name = "rb2p5V";
            this.rb2p5V.Size = new System.Drawing.Size(40, 17);
            this.rb2p5V.TabIndex = 2;
            this.rb2p5V.Text = "2.5";
            this.rb2p5V.UseVisualStyleBackColor = true;
            // 
            // rb3p3V
            // 
            this.rb3p3V.AutoSize = true;
            this.rb3p3V.Location = new System.Drawing.Point(54, 16);
            this.rb3p3V.Name = "rb3p3V";
            this.rb3p3V.Size = new System.Drawing.Size(40, 17);
            this.rb3p3V.TabIndex = 1;
            this.rb3p3V.Text = "3.3";
            this.rb3p3V.UseVisualStyleBackColor = true;
            // 
            // rb5p0V
            // 
            this.rb5p0V.AutoSize = true;
            this.rb5p0V.Checked = true;
            this.rb5p0V.Location = new System.Drawing.Point(8, 16);
            this.rb5p0V.Name = "rb5p0V";
            this.rb5p0V.Size = new System.Drawing.Size(40, 17);
            this.rb5p0V.TabIndex = 0;
            this.rb5p0V.TabStop = true;
            this.rb5p0V.Text = "5.0";
            this.rb5p0V.UseVisualStyleBackColor = true;
            // 
            // gbConn
            // 
            this.gbConn.Controls.Add(this.radioButton4);
            this.gbConn.Controls.Add(this.radioButton5);
            this.gbConn.Controls.Add(this.radioButton6);
            this.gbConn.Controls.Add(this.rb5pin);
            this.gbConn.Controls.Add(this.rb10pin);
            this.gbConn.Location = new System.Drawing.Point(233, 77);
            this.gbConn.Name = "gbConn";
            this.gbConn.Size = new System.Drawing.Size(90, 40);
            this.gbConn.TabIndex = 8;
            this.gbConn.TabStop = false;
            this.gbConn.Text = "Conn (Pins)";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(192, 16);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(40, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "Ext";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(146, 16);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(40, 17);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.Text = "1.8";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(100, 16);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(40, 17);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.Text = "2.5";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // rb5pin
            // 
            this.rb5pin.AutoSize = true;
            this.rb5pin.Location = new System.Drawing.Point(54, 16);
            this.rb5pin.Name = "rb5pin";
            this.rb5pin.Size = new System.Drawing.Size(31, 17);
            this.rb5pin.TabIndex = 1;
            this.rb5pin.Text = "5";
            this.rb5pin.UseVisualStyleBackColor = true;
            // 
            // rb10pin
            // 
            this.rb10pin.AutoSize = true;
            this.rb10pin.Checked = true;
            this.rb10pin.Location = new System.Drawing.Point(8, 16);
            this.rb10pin.Name = "rb10pin";
            this.rb10pin.Size = new System.Drawing.Size(37, 17);
            this.rb10pin.TabIndex = 0;
            this.rb10pin.TabStop = true;
            this.rb10pin.Text = "10";
            this.rb10pin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.gbConn);
            this.Controls.Add(this.gbVoltage);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.gbProtocol);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 397);
            this.MinimumSize = new System.Drawing.Size(350, 397);
            this.Name = "Form1";
            this.Text = "MiniProg3 SWV Debug Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbProtocol.ResumeLayout(false);
            this.gbProtocol.PerformLayout();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbVoltage.ResumeLayout(false);
            this.gbVoltage.PerformLayout();
            this.gbConn.ResumeLayout(false);
            this.gbConn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProtocol;
        private System.Windows.Forms.RadioButton rbUART;
        private System.Windows.Forms.RadioButton rbManchester;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbAsync;
        private System.Windows.Forms.RadioButton rbSync;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Timer timerUI;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox gbVoltage;
        private System.Windows.Forms.RadioButton rb3p3V;
        private System.Windows.Forms.RadioButton rb5p0V;
        private System.Windows.Forms.RadioButton rbExt;
        private System.Windows.Forms.RadioButton rb1p8V;
        private System.Windows.Forms.RadioButton rb2p5V;
        private System.Windows.Forms.GroupBox gbConn;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton rb5pin;
        private System.Windows.Forms.RadioButton rb10pin;
    }
}

