namespace Interface_Arduino_V1._1
{
    partial class frmInterfaceSerial
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
            this.cmdConnect = new System.Windows.Forms.Button();
            this.cmdLcd = new System.Windows.Forms.Button();
            this.txtDataReceiver = new System.Windows.Forms.TextBox();
            this.txtLCDData = new System.Windows.Forms.TextBox();
            this.cbPort1 = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblDataReceiver = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tmrCom1 = new System.Windows.Forms.Timer(this.components);
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataBit = new System.Windows.Forms.Label();
            this.cbRtsEnable = new System.Windows.Forms.ComboBox();
            this.lblRstEnable = new System.Windows.Forms.Label();
            this.lblLcdData = new System.Windows.Forms.Label();
            this.cmdOutput3 = new System.Windows.Forms.Button();
            this.cmdOutput2 = new System.Windows.Forms.Button();
            this.cmdOutput1 = new System.Windows.Forms.Button();
            this.cmdIndicator = new System.Windows.Forms.Button();
            this.lblInputStatus = new System.Windows.Forms.Label();
            this.txtSerialData = new System.Windows.Forms.TextBox();
            this.cmdSerial = new System.Windows.Forms.Button();
            this.lblSerialData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(354, 57);
            this.cmdConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(158, 35);
            this.cmdConnect.TabIndex = 0;
            this.cmdConnect.Text = "CONNECT";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // cmdLcd
            // 
            this.cmdLcd.Location = new System.Drawing.Point(364, 166);
            this.cmdLcd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdLcd.Name = "cmdLcd";
            this.cmdLcd.Size = new System.Drawing.Size(147, 31);
            this.cmdLcd.TabIndex = 1;
            this.cmdLcd.Text = "SEND LCD";
            this.cmdLcd.UseVisualStyleBackColor = true;
            this.cmdLcd.Click += new System.EventHandler(this.cmdLcd_Click);
            // 
            // txtDataReceiver
            // 
            this.txtDataReceiver.Location = new System.Drawing.Point(34, 362);
            this.txtDataReceiver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDataReceiver.Multiline = true;
            this.txtDataReceiver.Name = "txtDataReceiver";
            this.txtDataReceiver.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataReceiver.Size = new System.Drawing.Size(637, 101);
            this.txtDataReceiver.TabIndex = 2;
            this.txtDataReceiver.Text = "  ";
            // 
            // txtLCDData
            // 
            this.txtLCDData.Location = new System.Drawing.Point(39, 166);
            this.txtLCDData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLCDData.Name = "txtLCDData";
            this.txtLCDData.Size = new System.Drawing.Size(314, 26);
            this.txtLCDData.TabIndex = 3;
            // 
            // cbPort1
            // 
            this.cbPort1.FormattingEnabled = true;
            this.cbPort1.Location = new System.Drawing.Point(423, 18);
            this.cbPort1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPort1.Name = "cbPort1";
            this.cbPort1.Size = new System.Drawing.Size(86, 28);
            this.cbPort1.TabIndex = 4;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(354, 23);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(56, 20);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "PORT:";
            // 
            // lblDataReceiver
            // 
            this.lblDataReceiver.AutoSize = true;
            this.lblDataReceiver.Location = new System.Drawing.Point(30, 328);
            this.lblDataReceiver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataReceiver.Name = "lblDataReceiver";
            this.lblDataReceiver.Size = new System.Drawing.Size(215, 20);
            this.lblDataReceiver.TabIndex = 6;
            this.lblDataReceiver.Text = "SERIAL DATA RECEIVER : ";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(156, 18);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(127, 28);
            this.cbBaudRate.TabIndex = 7;
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbDataBits.Location = new System.Drawing.Point(156, 60);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(127, 28);
            this.cbDataBits.TabIndex = 10;
            // 
            // tmrCom1
            // 
            this.tmrCom1.Tick += new System.EventHandler(this.tmrCom1_Tick);
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(34, 23);
            this.lblBaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(110, 20);
            this.lblBaudRate.TabIndex = 12;
            this.lblBaudRate.Text = "BAUDRATE  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 13;
            // 
            // lblDataBit
            // 
            this.lblDataBit.AutoSize = true;
            this.lblDataBit.Location = new System.Drawing.Point(54, 65);
            this.lblDataBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataBit.Name = "lblDataBit";
            this.lblDataBit.Size = new System.Drawing.Size(89, 20);
            this.lblDataBit.TabIndex = 16;
            this.lblDataBit.Text = "DATA BIT :";
            // 
            // cbRtsEnable
            // 
            this.cbRtsEnable.FormattingEnabled = true;
            this.cbRtsEnable.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cbRtsEnable.Location = new System.Drawing.Point(156, 102);
            this.cbRtsEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRtsEnable.Name = "cbRtsEnable";
            this.cbRtsEnable.Size = new System.Drawing.Size(127, 28);
            this.cbRtsEnable.TabIndex = 18;
            // 
            // lblRstEnable
            // 
            this.lblRstEnable.AutoSize = true;
            this.lblRstEnable.Location = new System.Drawing.Point(27, 106);
            this.lblRstEnable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRstEnable.Name = "lblRstEnable";
            this.lblRstEnable.Size = new System.Drawing.Size(117, 20);
            this.lblRstEnable.TabIndex = 19;
            this.lblRstEnable.Text = "RTS ENABLE :";
            // 
            // lblLcdData
            // 
            this.lblLcdData.AutoSize = true;
            this.lblLcdData.Location = new System.Drawing.Point(48, 142);
            this.lblLcdData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLcdData.Name = "lblLcdData";
            this.lblLcdData.Size = new System.Drawing.Size(96, 20);
            this.lblLcdData.TabIndex = 20;
            this.lblLcdData.Text = "LCD DATA :";
            // 
            // cmdOutput3
            // 
            this.cmdOutput3.Location = new System.Drawing.Point(276, 282);
            this.cmdOutput3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdOutput3.Name = "cmdOutput3";
            this.cmdOutput3.Size = new System.Drawing.Size(112, 35);
            this.cmdOutput3.TabIndex = 21;
            this.cmdOutput3.Text = "OUTPUT 3";
            this.cmdOutput3.UseVisualStyleBackColor = true;
            this.cmdOutput3.Click += new System.EventHandler(this.cmdOutput3_Click);
            // 
            // cmdOutput2
            // 
            this.cmdOutput2.Location = new System.Drawing.Point(154, 283);
            this.cmdOutput2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdOutput2.Name = "cmdOutput2";
            this.cmdOutput2.Size = new System.Drawing.Size(112, 35);
            this.cmdOutput2.TabIndex = 22;
            this.cmdOutput2.Text = "OUTPUT 2";
            this.cmdOutput2.UseVisualStyleBackColor = true;
            this.cmdOutput2.Click += new System.EventHandler(this.cmdOutput2_Click);
            // 
            // cmdOutput1
            // 
            this.cmdOutput1.Location = new System.Drawing.Point(33, 283);
            this.cmdOutput1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdOutput1.Name = "cmdOutput1";
            this.cmdOutput1.Size = new System.Drawing.Size(112, 35);
            this.cmdOutput1.TabIndex = 23;
            this.cmdOutput1.Text = "OUTPUT 1";
            this.cmdOutput1.UseVisualStyleBackColor = true;
            this.cmdOutput1.Click += new System.EventHandler(this.cmdOutput1_Click);
            // 
            // cmdIndicator
            // 
            this.cmdIndicator.Location = new System.Drawing.Point(544, 283);
            this.cmdIndicator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdIndicator.Name = "cmdIndicator";
            this.cmdIndicator.Size = new System.Drawing.Size(129, 34);
            this.cmdIndicator.TabIndex = 25;
            this.cmdIndicator.UseVisualStyleBackColor = true;
            // 
            // lblInputStatus
            // 
            this.lblInputStatus.AutoSize = true;
            this.lblInputStatus.Location = new System.Drawing.Point(398, 289);
            this.lblInputStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputStatus.Name = "lblInputStatus";
            this.lblInputStatus.Size = new System.Drawing.Size(131, 20);
            this.lblInputStatus.TabIndex = 26;
            this.lblInputStatus.Text = "INPUT STATUS :";
            // 
            // txtSerialData
            // 
            this.txtSerialData.Location = new System.Drawing.Point(34, 231);
            this.txtSerialData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSerialData.Name = "txtSerialData";
            this.txtSerialData.Size = new System.Drawing.Size(319, 26);
            this.txtSerialData.TabIndex = 27;
            // 
            // cmdSerial
            // 
            this.cmdSerial.Location = new System.Drawing.Point(364, 231);
            this.cmdSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSerial.Name = "cmdSerial";
            this.cmdSerial.Size = new System.Drawing.Size(147, 32);
            this.cmdSerial.TabIndex = 28;
            this.cmdSerial.Text = "SEND SERIAL";
            this.cmdSerial.UseVisualStyleBackColor = true;
            this.cmdSerial.Click += new System.EventHandler(this.cmdSerial_Click);
            // 
            // lblSerialData
            // 
            this.lblSerialData.AutoSize = true;
            this.lblSerialData.Location = new System.Drawing.Point(22, 206);
            this.lblSerialData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerialData.Name = "lblSerialData";
            this.lblSerialData.Size = new System.Drawing.Size(123, 20);
            this.lblSerialData.TabIndex = 29;
            this.lblSerialData.Text = "SERIAL DATA :";
            // 
            // frmInterfaceSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 485);
            this.Controls.Add(this.lblSerialData);
            this.Controls.Add(this.cmdSerial);
            this.Controls.Add(this.txtSerialData);
            this.Controls.Add(this.lblInputStatus);
            this.Controls.Add(this.cmdIndicator);
            this.Controls.Add(this.cmdOutput1);
            this.Controls.Add(this.cmdOutput2);
            this.Controls.Add(this.cmdOutput3);
            this.Controls.Add(this.lblLcdData);
            this.Controls.Add(this.lblRstEnable);
            this.Controls.Add(this.cbRtsEnable);
            this.Controls.Add(this.lblDataBit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.cbDataBits);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.lblDataReceiver);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.cbPort1);
            this.Controls.Add(this.txtLCDData);
            this.Controls.Add(this.txtDataReceiver);
            this.Controls.Add(this.cmdLcd);
            this.Controls.Add(this.cmdConnect);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInterfaceSerial";
            this.Text = "Serial Interface by Rhog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Button cmdLcd;
        private System.Windows.Forms.TextBox txtDataReceiver;
        private System.Windows.Forms.TextBox txtLCDData;
        private System.Windows.Forms.ComboBox cbPort1;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblDataReceiver;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer tmrCom1;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataBit;
        private System.Windows.Forms.ComboBox cbRtsEnable;
        private System.Windows.Forms.Label lblRstEnable;
        private System.Windows.Forms.Label lblLcdData;
        private System.Windows.Forms.Button cmdOutput3;
        private System.Windows.Forms.Button cmdOutput2;
        private System.Windows.Forms.Button cmdOutput1;
        private System.Windows.Forms.Button cmdIndicator;
        private System.Windows.Forms.Label lblInputStatus;
        private System.Windows.Forms.TextBox txtSerialData;
        private System.Windows.Forms.Button cmdSerial;
        private System.Windows.Forms.Label lblSerialData;
    }
}

