using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;

namespace QuickTNC
{
    public partial class QuickTNC : Form
    {
        SerialPort serialPort;
        delegate void TextCallback(string text);
        delegate void ButtonCallback(Boolean state);
        Thread writeThread;
        ScriptParser parser = new ScriptParser();

        public QuickTNC()
        {
            InitializeComponent();

            String[] ports = SerialPort.GetPortNames();
            foreach (String port in ports)
            {
                comPortCombo.Items.Add(port);
            }

            if (ports.Length == 1)
            {
                comPortCombo.SelectedItem = ports[0];
            }
        }

        private void commSettingsChanged(object sender, EventArgs e)
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }

            Parity parity;
            switch (parityCombo.Text)
            {
                case "None":
                    parity = Parity.None;
                    break;
                case "Even":
                    parity = Parity.Even;
                    break;
                case "Odd":
                    parity = Parity.Odd;
                    break;
                case "Mark":
                    parity = Parity.Mark;
                    break;
                case "Space":
                    parity = Parity.Space;
                    break;
                default:
                    throw new Exception("Incorrect parity setting");
            }

            StopBits stopBits;
            switch (stopBitsCombo.Text)
            {
                case "None":
                    stopBits = StopBits.None;
                    break;
                case "1":
                    stopBits = StopBits.One;
                    break;
                case "1.5":
                    stopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    stopBits = StopBits.Two;
                    break;
                default:
                    throw new Exception("Incorrect stop-bit setting");
            }

            serialPort = new SerialPort(comPortCombo.Text,
                                        int.Parse(speedCombo.Text),
                                        parity,
                                        int.Parse(dataBitsCombo.Text),
                                        stopBits);

            serialPort.Encoding = Encoding.ASCII;
            serialPort.Handshake = Handshake.RequestToSend;
            serialPort.NewLine = "\r\n";
            serialPort.Open();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(dataReceived);
        }

        private void appendOutputText(String text)
        {
            if (outputText.InvokeRequired)
            {
                TextCallback d = new TextCallback(appendOutputText);
                Invoke(d, new object[] { text });
            } else {
                outputText.AppendText(text);
            }
        }

        private void enableSendButton(Boolean state)
        {
            if (sendButton.InvokeRequired)
            {
                ButtonCallback b = new ButtonCallback(enableSendButton);
                Invoke(b, new object[] { state });
            }
            else
            {
                sendButton.Enabled = state;
            }
        }

        private void dataReceived(Object sender, EventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            String data = sp.ReadExisting();
            //Console.Write(data);
            appendOutputText(data);
        }


        private void sendButton_Click(object sender, EventArgs e)
        {
            if (serialPort == null)
            {
                MessageBox.Show("You must select a serial port first!", "Invalid COM Port");
                return;
            }
            enableSendButton(false);
            String [] script = Regex.Split(scriptText.Text, "[\\r\\n]+");
            writeThread = new Thread(new ThreadStart(delegate
            {
                Regex pattern = new Regex("^\\s*;.*$");
                foreach (String line in script)
                {
                    Match match = pattern.Match(line);
                    if (! match.Success)
                    {
                        String output = parser.parse(line);
                        //byte [] output = Encoding.ASCII.GetBytes(toSend + "\r");
                        //serialPort.Write(output, 0, output.Length);
                        serialPort.Write(output + "\r");
                    }
                }
                enableSendButton(true);
            }));
            writeThread.Start();
        }

        private void QuickTNC_Deactivate(object sender, EventArgs e)
        {
            if (writeThread != null)
            {
                writeThread.Abort();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputText.Clear();
        }

        private void scriptClearButton_Click(object sender, EventArgs e)
        {
            scriptText.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutQuickTNC()).Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deactivate();
        }
    }
}
