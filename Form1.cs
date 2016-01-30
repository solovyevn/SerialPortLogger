using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace SerialPortLogger
{
    public partial class Form1 : Form
    {
        private static string defaultLogFileName = "SerialPortLog.log";
        private string logFile = @Environment.CurrentDirectory + @"\" + defaultLogFileName;
        private BinaryWriter binLogStream = null;
        private SerialPort serialPortToLog = null;
        private StreamWriter hexLogStream = null;
        private bool extraWide = false;
        delegate void SetTextCallback(string text);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeFields();
        }

        private void buttonRefreshPortSelect_Click(object sender, EventArgs e)
        {
            initializePortListComboBox();
        }

        private void buttonFileSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = saveLogFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                logFile = saveLogFileDialog.FileName;
                textBoxFile.Text = logFile;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            logFile = textBoxFile.Text;
            if (!CreateLogFile(logFile)) return;
            serialPortToLog = initializeSerialPort();
            if (serialPortToLog == null) return;
            serialPortToLog.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceivedHandler);
            try
            {
                if (radioButtonHex.Checked)
                {
                    hexLogStream = new StreamWriter(logFile, true, Encoding.ASCII);
                }
                else
                {
                    binLogStream = new BinaryWriter(File.Open(logFile,FileMode.Append), Encoding.ASCII);
                }
                serialPortToLog.Open();
            }
            catch (Exception ex)
            {
                serialPortToLog.Close();
                hexLogStream.Close();
                MessageBox.Show(ex.Message, "Exception opening log file or port!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            notifyIcon1.Text = "Running...";
            buttonFileSelect.Enabled = false;
            buttonRefreshPortSelect.Enabled = false;
            buttonStart.Enabled = false;
            textBoxFile.Enabled = false;
            comboBoxPortSelect.Enabled = false;
            textBoxBaudRate.Enabled = false;
            textBoxDataBits.Enabled = false;
            comboBoxHandshake.Enabled = false;
            comboBoxParity.Enabled = false;
            comboBoxStopBits.Enabled = false;
            radioButtonHex.Enabled = false;
            radioButtonBinary.Enabled = false;
            buttonStop.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if(serialPortToLog!=null) serialPortToLog.Close();
            if (hexLogStream!=null) hexLogStream.Close();
            if(binLogStream!=null)binLogStream.Close();
            notifyIcon1.Text = "Stopped";
            buttonFileSelect.Enabled = true;
            buttonRefreshPortSelect.Enabled = true;
            buttonStart.Enabled = true;
            textBoxFile.Enabled = true;
            comboBoxPortSelect.Enabled = true;
            textBoxBaudRate.Enabled = true;
            textBoxDataBits.Enabled = true;
            comboBoxHandshake.Enabled = true;
            comboBoxParity.Enabled = true;
            comboBoxStopBits.Enabled = true;
            radioButtonHex.Enabled = true;
            radioButtonBinary.Enabled = true;
            buttonStop.Enabled = false;
        }




        #region Icon
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = false;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
        #endregion

        private bool CreateLogFile(string FullFileName)
        {
            try
            {
                if (!File.Exists(FullFileName))
                {
                    FileStream mFS = File.Create(FullFileName);
                    mFS.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creating log file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void initializePortListComboBox()
        {
            comboBoxPortSelect.Items.Clear();
            try
            {
                comboBoxPortSelect.Items.AddRange(SerialPort.GetPortNames());
                comboBoxPortSelect.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error enumerating serial ports! Restart your system and try again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void initializeFields()
        {
            radioButtonHex.Checked = true;
            textBoxFile.Text = logFile;
            initializePortListComboBox();
            textBoxBaudRate.Text = "2400";
            textBoxDataBits.Text = "8";
            comboBoxHandshake.Items.Clear();
            comboBoxHandshake.Items.Add("None");
            comboBoxHandshake.Items.Add("RTS");
            comboBoxHandshake.Items.Add("XON/XOFF");
            comboBoxHandshake.Items.Add("RTS and XON/XOFF");
            comboBoxHandshake.SelectedIndex=0;
            comboBoxParity.Items.Clear();
            comboBoxParity.Items.Add("None");
            comboBoxParity.Items.Add("Even");
            comboBoxParity.Items.Add("Odd");
            comboBoxParity.Items.Add("Mark");
            comboBoxParity.Items.Add("Space");
            comboBoxParity.SelectedIndex = 0;
            comboBoxStopBits.Items.Clear();
            comboBoxStopBits.Items.Add("None");
            comboBoxStopBits.Items.Add("1");
            comboBoxStopBits.Items.Add("1.5");
            comboBoxStopBits.Items.Add("2");
            comboBoxStopBits.SelectedIndex = 1;
            saveLogFileDialog.FileName = defaultLogFileName;
        }

        private SerialPort initializeSerialPort()
        {
            int baudRate;
            int dataBits;
            try
            {
                SerialPort serialPort = new SerialPort(comboBoxPortSelect.SelectedItem.ToString());
                if (Regex.IsMatch(textBoxBaudRate.Text, @"^\d+$"))
                {
                    baudRate=Convert.ToInt32(textBoxBaudRate.Text);
                    if (baudRate <= 0)
                    {
                            throw new ArgumentOutOfRangeException("Baud rate value must be number bigger then 0");
                    }
                }
                else throw new ArgumentOutOfRangeException("Baud rate value must be number bigger then 0");
                serialPort.BaudRate = baudRate;
                if (Regex.IsMatch(textBoxDataBits.Text, @"^\d+$"))
                {
                    dataBits = Convert.ToInt32(textBoxDataBits.Text);
                    if (dataBits <= 0)
                    {
                        throw new ArgumentOutOfRangeException("Data bits value must be number bigger then 0");
                    }
                }
                else throw new ArgumentOutOfRangeException("Data bits value must be number bigger then 0");
                serialPort.DataBits=dataBits;
                switch (comboBoxStopBits.SelectedIndex)
                {
                    case 0: serialPort.StopBits=StopBits.None;
                        break;
                    case 1: serialPort.StopBits=StopBits.One;
                        break;
                    case 2: serialPort.StopBits=StopBits.OnePointFive;
                        break;
                    case 3: serialPort.StopBits=StopBits.Two;
                        break;
                }
                switch (comboBoxParity.SelectedIndex)
                {
                    case 0: serialPort.Parity = Parity.None;
                        break;
                    case 1: serialPort.Parity = Parity.Even;
                        break;
                    case 2: serialPort.Parity = Parity.Odd;
                        break;
                    case 3: serialPort.Parity = Parity.Mark;
                        break;
                    case 4: serialPort.Parity = Parity.Space;
                        break;
                }
                switch (comboBoxParity.SelectedIndex)
                {
                    case 0: serialPort.Handshake = Handshake.None;
                        break;
                    case 1: serialPort.Handshake = Handshake.RequestToSend;
                        break;
                    case 2: serialPort.Handshake = Handshake.XOnXOff;
                        break;
                    case 3: serialPort.Handshake = Handshake.RequestToSendXOnXOff;
                        break;
                }
                return serialPort;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error initializing serial port!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }

        private void SerialPortDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;
            string data = serialPort.ReadExisting();
            StringBuilder sb = new StringBuilder();
            foreach (byte dataByte in data) sb.AppendFormat("{0,3:X2}", dataByte);
            if (radioButtonHex.Checked)
            {
                hexLogStream.Write(sb.ToString());
            }
            else
            {
                binLogStream.Write(Encoding.ASCII.GetBytes(data));
            }
            RealTimeText(sb.ToString());

        }


        private void RealTimeText(string text)
        {
            if (this.textBoxRealTime.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(RealTimeText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxRealTime.AppendText(text);
            }
        }
        
        private void buttonWiden_Click(object sender, EventArgs e)
        {
            if (!extraWide)
            {
                Width = 885;
                extraWide = true;
                buttonWiden.Text = "<<";
            }
            else
            {
                Width = 295;
                extraWide = false;
                buttonWiden.Text = ">>";
            }
        }

    }
}
