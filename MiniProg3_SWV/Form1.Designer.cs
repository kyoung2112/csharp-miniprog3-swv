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
            this.gbProtocol.SuspendLayout();
            this.gbMode.SuspendLayout();
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
            this.rtbLog.Location = new System.Drawing.Point(5, 77);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(318, 278);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
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
    }
}

