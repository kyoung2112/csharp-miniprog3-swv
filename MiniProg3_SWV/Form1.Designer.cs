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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbProtocol = new System.Windows.Forms.GroupBox();
            this.rbUART = new System.Windows.Forms.RadioButton();
            this.rbManchester = new System.Windows.Forms.RadioButton();
            this.btnExecute = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.timerUI = new System.Windows.Forms.Timer(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
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
            this.btnClear = new System.Windows.Forms.Button();
            this.cbFreq = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProtocol.SuspendLayout();
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
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(86, 48);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Start";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.Color.White;
            this.rtbLog.HideSelection = false;
            this.rtbLog.Location = new System.Drawing.Point(5, 77);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(498, 281);
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
            this.btnConnect.Location = new System.Drawing.Point(5, 48);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbVoltage
            // 
            this.gbVoltage.Controls.Add(this.rbExt);
            this.gbVoltage.Controls.Add(this.rb1p8V);
            this.gbVoltage.Controls.Add(this.rb2p5V);
            this.gbVoltage.Controls.Add(this.rb3p3V);
            this.gbVoltage.Controls.Add(this.rb5p0V);
            this.gbVoltage.Location = new System.Drawing.Point(176, 2);
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
            this.gbConn.Location = new System.Drawing.Point(414, 2);
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
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(167, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbFreq
            // 
            this.cbFreq.FormattingEnabled = true;
            this.cbFreq.Items.AddRange(new object[] {
            "24,000,000",
            "16,000,000",
            "12,000,000",
            "9,600,000",
            "8,000,000",
            "6,857,143",
            "6,000,000",
            "5,333,333",
            "4,800,000",
            "4,363,636",
            "4,000,000",
            "3,692,308",
            "3,428,571",
            "3,200,000",
            "3,000,000",
            "2,823,529",
            "2,666,667",
            "2,526,316",
            "2,400,000",
            "2,285,714",
            "2,181,818",
            "2,086,957",
            "2,000,000",
            "1,920,000",
            "1,846,154",
            "1,777,778",
            "1,714,286",
            "1,655,172",
            "1,600,000",
            "1,548,387",
            "1,500,000",
            "1,454,545",
            "1,411,765",
            "1,371,429",
            "1,333,333",
            "1,297,297",
            "1,263,158",
            "1,230,769",
            "1,200,000",
            "1,170,732",
            "1,142,857",
            "1,116,279",
            "1,090,909",
            "1,066,667",
            "1,043,478",
            "1,021,277",
            "1,000,000",
            "979,592",
            "960,000",
            "941,176",
            "923,077",
            "905,660",
            "888,889",
            "872,727",
            "857,143",
            "842,105",
            "827,586",
            "813,559",
            "800,000",
            "786,885",
            "774,194",
            "761,905",
            "750,000",
            "738,462",
            "727,273",
            "716,418",
            "705,882",
            "695,652",
            "685,714",
            "676,056",
            "666,667",
            "657,534",
            "648,649",
            "640,000",
            "631,579",
            "623,377",
            "615,385",
            "607,595",
            "600,000",
            "592,593",
            "585,366",
            "578,313",
            "571,429",
            "564,706",
            "558,140",
            "551,724",
            "545,455",
            "539,326",
            "533,333",
            "527,473",
            "521,739",
            "516,129",
            "510,638",
            "505,263",
            "500,000",
            "494,845",
            "489,796",
            "484,848",
            "480,000",
            "475,248",
            "470,588",
            "466,019",
            "461,538",
            "457,143",
            "452,830",
            "448,598",
            "444,444",
            "440,367",
            "436,364",
            "432,432",
            "428,571",
            "424,779",
            "421,053",
            "417,391",
            "413,793",
            "410,256",
            "406,780",
            "403,361",
            "400,000",
            "396,694",
            "393,443",
            "390,244",
            "387,097",
            "384,000",
            "380,952",
            "377,953",
            "375,000",
            "372,093",
            "369,231",
            "366,412",
            "363,636",
            "360,902",
            "358,209",
            "355,556",
            "352,941",
            "350,365",
            "347,826",
            "345,324",
            "342,857",
            "340,426",
            "338,028",
            "335,664",
            "333,333",
            "331,034",
            "328,767",
            "326,531",
            "324,324",
            "322,148",
            "320,000",
            "317,881",
            "315,789",
            "313,725",
            "311,688",
            "309,677",
            "307,692",
            "305,732",
            "303,797",
            "301,887",
            "300,000",
            "298,137",
            "296,296",
            "294,479",
            "292,683",
            "290,909",
            "289,157",
            "287,425",
            "285,714",
            "284,024",
            "282,353",
            "280,702",
            "279,070",
            "277,457",
            "275,862",
            "274,286",
            "272,727",
            "271,186",
            "269,663",
            "268,156",
            "266,667",
            "265,193",
            "263,736",
            "262,295",
            "260,870",
            "259,459",
            "258,065",
            "256,684",
            "255,319",
            "253,968",
            "252,632",
            "251,309",
            "250,000",
            "248,705",
            "247,423",
            "246,154",
            "244,898",
            "243,655",
            "242,424",
            "241,206",
            "240,000",
            "238,806",
            "237,624",
            "236,453",
            "235,294",
            "234,146",
            "233,010",
            "231,884",
            "230,769",
            "229,665",
            "228,571",
            "227,488",
            "226,415",
            "225,352",
            "224,299",
            "223,256",
            "222,222",
            "221,198",
            "220,183",
            "219,178",
            "218,182",
            "217,195",
            "216,216",
            "215,247",
            "214,286",
            "213,333",
            "212,389",
            "211,454",
            "210,526",
            "209,607",
            "208,696",
            "207,792",
            "206,897",
            "206,009",
            "205,128",
            "204,255",
            "203,390",
            "202,532",
            "201,681",
            "200,837",
            "200,000",
            "199,170",
            "198,347",
            "197,531",
            "196,721",
            "195,918",
            "195,122",
            "194,332",
            "193,548",
            "192,771",
            "192,000",
            "191,235",
            "190,476",
            "189,723",
            "188,976",
            "188,235"});
            this.cbFreq.Location = new System.Drawing.Point(414, 50);
            this.cbFreq.Name = "cbFreq";
            this.cbFreq.Size = new System.Drawing.Size(90, 21);
            this.cbFreq.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Tag = "F";
            this.label1.Text = "Bit Rate (bps)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFreq);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbConn);
            this.Controls.Add(this.gbVoltage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.gbProtocol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(3000, 3000);
            this.MinimumSize = new System.Drawing.Size(530, 400);
            this.Name = "Form1";
            this.Text = "Cypress Serial Debug Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbProtocol.ResumeLayout(false);
            this.gbProtocol.PerformLayout();
            this.gbVoltage.ResumeLayout(false);
            this.gbVoltage.PerformLayout();
            this.gbConn.ResumeLayout(false);
            this.gbConn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProtocol;
        private System.Windows.Forms.RadioButton rbUART;
        private System.Windows.Forms.RadioButton rbManchester;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Timer timerUI;
        private System.Windows.Forms.Button btnConnect;
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbFreq;
        private System.Windows.Forms.Label label1;
    }
}

