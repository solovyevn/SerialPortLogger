namespace SerialPortLogger
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
            this.comboBoxPortSelect = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.buttonRefreshPortSelect = new System.Windows.Forms.Button();
            this.saveLogFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonFileSelect = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelBaud = new System.Windows.Forms.Label();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelHandshake = new System.Windows.Forms.Label();
            this.textBoxBaudRate = new System.Windows.Forms.TextBox();
            this.textBoxDataBits = new System.Windows.Forms.TextBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxHandshake = new System.Windows.Forms.ComboBox();
            this.buttonWiden = new System.Windows.Forms.Button();
            this.textBoxRealTime = new System.Windows.Forms.TextBox();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.radioButtonBinary = new System.Windows.Forms.RadioButton();
            this.groupBoxLogFormat = new System.Windows.Forms.GroupBox();
            this.groupBoxLogFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPortSelect
            // 
            this.comboBoxPortSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPortSelect.FormattingEnabled = true;
            this.comboBoxPortSelect.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBoxPortSelect.Location = new System.Drawing.Point(80, 22);
            this.comboBoxPortSelect.Name = "comboBoxPortSelect";
            this.comboBoxPortSelect.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPortSelect.Sorted = true;
            this.comboBoxPortSelect.TabIndex = 0;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(9, 25);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 13);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Port:";
            // 
            // buttonRefreshPortSelect
            // 
            this.buttonRefreshPortSelect.Location = new System.Drawing.Point(196, 20);
            this.buttonRefreshPortSelect.Name = "buttonRefreshPortSelect";
            this.buttonRefreshPortSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshPortSelect.TabIndex = 2;
            this.buttonRefreshPortSelect.Text = "Refresh";
            this.buttonRefreshPortSelect.UseVisualStyleBackColor = true;
            this.buttonRefreshPortSelect.Click += new System.EventHandler(this.buttonRefreshPortSelect_Click);
            // 
            // saveLogFileDialog
            // 
            this.saveLogFileDialog.Title = "Log File";
            // 
            // buttonFileSelect
            // 
            this.buttonFileSelect.Location = new System.Drawing.Point(196, 248);
            this.buttonFileSelect.Name = "buttonFileSelect";
            this.buttonFileSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonFileSelect.TabIndex = 3;
            this.buttonFileSelect.Text = "Browse";
            this.buttonFileSelect.UseVisualStyleBackColor = true;
            this.buttonFileSelect.Click += new System.EventHandler(this.buttonFileSelect_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(9, 234);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(44, 13);
            this.labelFile.TabIndex = 4;
            this.labelFile.Text = "Log file:";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(12, 250);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(178, 20);
            this.textBoxFile.TabIndex = 5;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(53, 285);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 30);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(139, 285);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(80, 30);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Serial Port Logger";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(9, 52);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(56, 13);
            this.labelBaud.TabIndex = 8;
            this.labelBaud.Text = "Baud rate:";
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(9, 79);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(52, 13);
            this.labelDataBits.TabIndex = 9;
            this.labelDataBits.Text = "Data bits:";
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Location = new System.Drawing.Point(9, 106);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(51, 13);
            this.labelStopBits.TabIndex = 10;
            this.labelStopBits.Text = "Stop bits:";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(9, 134);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(36, 13);
            this.labelParity.TabIndex = 11;
            this.labelParity.Text = "Parity:";
            // 
            // labelHandshake
            // 
            this.labelHandshake.AutoSize = true;
            this.labelHandshake.Location = new System.Drawing.Point(9, 161);
            this.labelHandshake.Name = "labelHandshake";
            this.labelHandshake.Size = new System.Drawing.Size(65, 13);
            this.labelHandshake.TabIndex = 12;
            this.labelHandshake.Text = "Handshake:";
            // 
            // textBoxBaudRate
            // 
            this.textBoxBaudRate.Location = new System.Drawing.Point(80, 49);
            this.textBoxBaudRate.Name = "textBoxBaudRate";
            this.textBoxBaudRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxBaudRate.TabIndex = 13;
            this.textBoxBaudRate.Text = "9600";
            // 
            // textBoxDataBits
            // 
            this.textBoxDataBits.Location = new System.Drawing.Point(80, 76);
            this.textBoxDataBits.Name = "textBoxDataBits";
            this.textBoxDataBits.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataBits.TabIndex = 14;
            this.textBoxDataBits.Text = "8";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(80, 103);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStopBits.TabIndex = 15;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(80, 131);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(100, 21);
            this.comboBoxParity.TabIndex = 16;
            // 
            // comboBoxHandshake
            // 
            this.comboBoxHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHandshake.FormattingEnabled = true;
            this.comboBoxHandshake.Location = new System.Drawing.Point(80, 158);
            this.comboBoxHandshake.Name = "comboBoxHandshake";
            this.comboBoxHandshake.Size = new System.Drawing.Size(100, 21);
            this.comboBoxHandshake.TabIndex = 17;
            // 
            // buttonWiden
            // 
            this.buttonWiden.Location = new System.Drawing.Point(208, 103);
            this.buttonWiden.Name = "buttonWiden";
            this.buttonWiden.Size = new System.Drawing.Size(47, 49);
            this.buttonWiden.TabIndex = 18;
            this.buttonWiden.Text = ">>";
            this.buttonWiden.UseVisualStyleBackColor = true;
            this.buttonWiden.Click += new System.EventHandler(this.buttonWiden_Click);
            // 
            // textBoxRealTime
            // 
            this.textBoxRealTime.Location = new System.Drawing.Point(305, 12);
            this.textBoxRealTime.Multiline = true;
            this.textBoxRealTime.Name = "textBoxRealTime";
            this.textBoxRealTime.ReadOnly = true;
            this.textBoxRealTime.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRealTime.Size = new System.Drawing.Size(552, 283);
            this.textBoxRealTime.TabIndex = 19;
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Checked = true;
            this.radioButtonHex.Location = new System.Drawing.Point(10, 18);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(44, 17);
            this.radioButtonHex.TabIndex = 20;
            this.radioButtonHex.TabStop = true;
            this.radioButtonHex.Text = "Hex";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            // 
            // radioButtonBinary
            // 
            this.radioButtonBinary.AutoSize = true;
            this.radioButtonBinary.Location = new System.Drawing.Point(69, 18);
            this.radioButtonBinary.Name = "radioButtonBinary";
            this.radioButtonBinary.Size = new System.Drawing.Size(54, 17);
            this.radioButtonBinary.TabIndex = 21;
            this.radioButtonBinary.Text = "Binary";
            this.radioButtonBinary.UseVisualStyleBackColor = true;
            // 
            // groupBoxLogFormat
            // 
            this.groupBoxLogFormat.Controls.Add(this.radioButtonHex);
            this.groupBoxLogFormat.Controls.Add(this.radioButtonBinary);
            this.groupBoxLogFormat.Location = new System.Drawing.Point(12, 185);
            this.groupBoxLogFormat.Name = "groupBoxLogFormat";
            this.groupBoxLogFormat.Size = new System.Drawing.Size(130, 46);
            this.groupBoxLogFormat.TabIndex = 23;
            this.groupBoxLogFormat.TabStop = false;
            this.groupBoxLogFormat.Text = "Log format";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(279, 327);
            this.Controls.Add(this.groupBoxLogFormat);
            this.Controls.Add(this.textBoxRealTime);
            this.Controls.Add(this.buttonWiden);
            this.Controls.Add(this.comboBoxHandshake);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.textBoxDataBits);
            this.Controls.Add(this.textBoxBaudRate);
            this.Controls.Add(this.labelHandshake);
            this.Controls.Add(this.labelParity);
            this.Controls.Add(this.labelStopBits);
            this.Controls.Add(this.labelDataBits);
            this.Controls.Add(this.labelBaud);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.buttonFileSelect);
            this.Controls.Add(this.buttonRefreshPortSelect);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.comboBoxPortSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Serial Port Logger by Nikita Solovyev";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBoxLogFormat.ResumeLayout(false);
            this.groupBoxLogFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPortSelect;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button buttonRefreshPortSelect;
        private System.Windows.Forms.SaveFileDialog saveLogFileDialog;
        private System.Windows.Forms.Button buttonFileSelect;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Label labelHandshake;
        private System.Windows.Forms.TextBox textBoxBaudRate;
        private System.Windows.Forms.TextBox textBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxHandshake;
        private System.Windows.Forms.Button buttonWiden;
        private System.Windows.Forms.TextBox textBoxRealTime;
        private System.Windows.Forms.RadioButton radioButtonHex;
        private System.Windows.Forms.RadioButton radioButtonBinary;
        private System.Windows.Forms.GroupBox groupBoxLogFormat;
    }
}

