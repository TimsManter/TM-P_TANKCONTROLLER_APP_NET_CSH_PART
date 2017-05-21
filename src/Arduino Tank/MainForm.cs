using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace ArduinoTank
{
    public partial class mainForm : Form
    {
        string ports;
        string port;
        int rate = 9600;
        bool isOpen;
        bool connection;
        bool autoScroll = true;
        bool streamR = true;
        bool streamW = true;
        byte[] data;
        bool expand = true;

        public mainForm()
        {
            
            InitializeComponent();
            checkExpand();
            if (expand) expandCheck.Checked = true;
            else expandCheck.Checked = false;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            refreshPorts(false);
            connection = serialPort1.IsOpen;
            conSwitch();
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            refreshPorts();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!connection) connect();
            else disconnect();
        }

        private void writeLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (sendLine(false, writeLine.Text, true)) e.Handled = true; ;
            }
        }

        public void setSerialPort()
        {
            ports = portsList.Text;
            isOpen = serialPort1.IsOpen;
            port = portsList.SelectedItem.ToString();
            serialPort1.PortName = port;
            serialPort1.BaudRate = rate;
        }

        public void setState()
        {
            if (connection)
            {
                connectButton.Text = "Rozłącz";
                connectState.BackColor = Color.Lime;
            }
            else 
            {
                connectButton.Text = "Połącz";
                connectState.BackColor = Color.Red;
            }
        }

        public bool sendLine(bool isByte, string text = "", bool clearLine = false, byte[] dataByte = null)
        {
            if (writeLine.Text != "" || isByte)
            {
                if (connection)
                {
                    try
                    {
                        if (!isByte) serialPort1.Write(text);
                        else serialPort1.Write(dataByte, 0, dataByte.Length);
                        if (streamW)
                        {
                            if (console.TextLength != 0) console.AppendText("\n");
                            AddTime(console);
                            AddText(console, text, Color.Chartreuse);
                            if (scroll.Checked && clearLine) console.ScrollToCaret();
                        }

                        if (clearLine) writeLine.Text = "";
                        return true;
                    }
                    catch (TimeoutException)
                    {
                        MessageBox.Show("Upłynął czas oczekiwania.", "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        disconnect();
                        connect();
                        return false;
                    }

                    catch (InvalidOperationException f)
                    {
                        MessageBox.Show(f.Message.ToString(), "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Najpierw musisz się połaczyć! Połączyć teraz?", "Brak połączenia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        connect();
                        return true;
                    }
                    return false;
                }
            }
            else return false;

        }


        public void connect()
        {
            setSerialPort();
            if (port == "Wybierz port") MessageBox.Show("Najpierw wybierz port", "Błędny port", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (port == "") MessageBox.Show("Błędny port");
            else
            {
                try
                {
                    string baudrate = baud.Text.Split(new Char[] { ' ' })[0];
                    rate = Convert.ToInt32(baudrate);
                    serialPort1.BaudRate = rate;

                    if (!isOpen)
                    {
                        try
                        {
                            serialPort1.Open();
                            serialPort1.RtsEnable = true;

                            connection = true;
                            setState();
                            conSwitch();
                        }
                        catch (IOException e)
                        {
                            MessageBox.Show(e.Message.ToString(), "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            refreshPorts(false);
                        }
                        catch (UnauthorizedAccessException e)
                        {
                            MessageBox.Show(e.Message.ToString(), "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            refreshPorts(false);
                        }
                    
                    }

                    else MessageBox.Show("Na tym porcie trwa już połączenie.", "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Błędny format Baud Rate");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Nieprawidłowy przedział");
                }
            }
        }

        public void disconnect()
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.RtsEnable = false;
                    serialPort1.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("To połączenie jest już zamnknięte.", "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    refreshPorts(false);
                }
            }
            else
            {
                MessageBox.Show("To połączenie jest już zamnknięte.", "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                refreshPorts(false);
            }

              connection = false;
              setState();
              conSwitch();
        }

        public void refreshPorts(bool msg = true)
        {
            int item = portsList.SelectedIndex;
            portsList.Items.Clear();
            portsList.Items.Add("Wybierz port");
            string[] porty = SerialPort.GetPortNames();
            foreach (string port1 in porty)
            {
                Console.WriteLine(port1);
                portsList.Items.Add(port1);
            }
            if (porty.Length == 0)
            {
                portsList.SelectedIndex = 0;

                if (msg == true)
                {
                    DialogResult result = MessageBox.Show("Brak dostępnych portów.", "Wyszukiwanie nieudane", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    if (result == System.Windows.Forms.DialogResult.Retry) refreshPorts();
                }
            }
            else
            {
                if (item <= 0) portsList.SelectedIndex = 1;
                else portsList.SelectedIndex = item;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.Invoke(new EventHandler(DisplayText));
             //   MessageBox.Show(serialPort1.ReadByte().ToString());
            }
            catch (TimeoutException)
            {

            }
        }

        private void DisplayText(object sender, EventArgs e)
        {
            string text = serialPort1.ReadLine().Replace("\r", "");
            if (streamR)
            {
                if (console.Text != "") console.AppendText("\n");
                AddTime(console);
                AddText(console, text, Color.DeepSkyBlue);
                if (scroll.Checked) console.ScrollToCaret();
            }

        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                serialPort1.RtsEnable = false;
                serialPort1.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Upłynął czas oczekiwania.", "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        private void AddTime(RichTextBox box)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = Color.LightGray;
            box.AppendText("<" + DateTime.Now.ToString("HH:mm:ss") + ">" + "  ");
            box.SelectionColor = box.ForeColor;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            sendLine(false, writeLine.Text, true);
            writeLine.Focus();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (streamBoth.Checked)
            {
                streamR = true;
                streamW = true;
            }
            else if (streamRead.Checked)
            {
                streamR = true;
                streamW = false;
            }
            else if (streamWrite.Checked)
            {
                streamR = false;
                streamW = true;
            }
            else
            {
                streamR = false;
                streamW = false;
            }
        }

        private void baud_Click(object sender, EventArgs e)
        {
            baud.DroppedDown = true;
        }

        private void convByte(params string[] stringByte)
        {
            byte[] dataByte = new byte[stringByte.Length];
            for (int i = 0; i < stringByte.Length; i++)
            {
                dataByte[i] = Convert.ToByte(stringByte[i]);
            }
            data = dataByte;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!connection) timer1.Stop();
            sendLine(true, "Przesłano polecenie", false, data);
        }

        private void leftUp_MouseDown(object sender, MouseEventArgs e)
        {
            convByte("1", "0", "0", "0");
        //    sendLine(true, "Przesłano polecenie", false, data);
            timer1.Start();
        }

        private void leftDown_MouseDown(object sender, MouseEventArgs e)
        {
            convByte("0", "1", "0", "0");
        //    sendLine(true, "Przesłano polecenie", false, data);
            timer1.Start();
        }

        private void rightUp_MouseDown(object sender, MouseEventArgs e)
        {
            convByte("0", "0", "1", "0");
        //    sendLine(true, "Przesłano polecenie", false, data);
            timer1.Start();
        }

        private void rightDown_MouseDown(object sender, MouseEventArgs e)
        {
            convByte("0", "0", "0", "1");
        //    sendLine(true, "Przesłano polecenie", false, data);
            timer1.Start();
        }

        private void leftUp_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void leftDown_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void rightUp_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void rightDown_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void bothUp_MouseDown(object sender, MouseEventArgs e)
        {
            convByte("1", "0", "1", "0");
        //    sendLine(true, "Przesłano polecenie", false, data);
            timer1.Start();
        }

        private void bothDown_MouseDown(object sender, MouseEventArgs e)
        {
            convByte("0", "1", "0", "1");
        //    sendLine(true, "Przesłano polecenie", false, data);
            timer1.Start();
        }

        private void bothUp_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void bothDown_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void rotLeft_MouseDown(object sender, MouseEventArgs e)
        {
            convByte("0", "1", "1", "0");
         //   sendLine(true, "Przesłano polecenie", false, data);
            timer1.Start();
        }

        private void rotRight_MouseDown(object sender, MouseEventArgs e)
        {
            convByte("1", "0", "0", "1");
        //    sendLine(true, "Przesłano polecenie", false, data);
            timer1.Start();
        }

        private void rotLeft_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void rotRight_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void expandCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (expandCheck.Checked)
            {
                expand = true;
            }
            else
            {
                expand = false;
            }
            checkExpand();
        }

        private void checkExpand()
        {
            if (expand)
            {
             /*   if (this.Height != 473)
                {
                    for (int i = this.Height; i == 473; i++)
                    {
                        this
                    }
                }*/
                this.Height = 473;
            }
            else
            {
                this.Height = 251;
            }
        }

        private void conSwitch()
        {
            if (connection)
            {
                portsList.Enabled = false;
                RefreshButton.Enabled = false;
                baud.Enabled = false;
            }
            else
            {
                portsList.Enabled = true;
                RefreshButton.Enabled = true;
                baud.Enabled = true;
            }
        }


    }
}
