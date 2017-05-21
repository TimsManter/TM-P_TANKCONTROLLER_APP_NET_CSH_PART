namespace ArduinoTank
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.connectGroup = new System.Windows.Forms.GroupBox();
            this.baud = new System.Windows.Forms.ComboBox();
            this.scroll = new System.Windows.Forms.CheckBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.portsList = new System.Windows.Forms.ComboBox();
            this.connectState = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.writeLine = new System.Windows.Forms.TextBox();
            this.console = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.streamBoth = new System.Windows.Forms.RadioButton();
            this.streamWrite = new System.Windows.Forms.RadioButton();
            this.streamRead = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bothDown = new System.Windows.Forms.Button();
            this.bothUp = new System.Windows.Forms.Button();
            this.rightDown = new System.Windows.Forms.Button();
            this.rightUp = new System.Windows.Forms.Button();
            this.leftDown = new System.Windows.Forms.Button();
            this.leftUp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rotRight = new System.Windows.Forms.Button();
            this.rotLeft = new System.Windows.Forms.Button();
            this.expandCheck = new System.Windows.Forms.CheckBox();
            this.connectGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectGroup
            // 
            this.connectGroup.Controls.Add(this.expandCheck);
            this.connectGroup.Controls.Add(this.baud);
            this.connectGroup.Controls.Add(this.scroll);
            this.connectGroup.Controls.Add(this.RefreshButton);
            this.connectGroup.Controls.Add(this.portsList);
            this.connectGroup.Controls.Add(this.connectState);
            this.connectGroup.Controls.Add(this.connectButton);
            this.connectGroup.Location = new System.Drawing.Point(310, 6);
            this.connectGroup.Name = "connectGroup";
            this.connectGroup.Padding = new System.Windows.Forms.Padding(10);
            this.connectGroup.Size = new System.Drawing.Size(153, 200);
            this.connectGroup.TabIndex = 0;
            this.connectGroup.TabStop = false;
            this.connectGroup.Text = "Połączenie";
            // 
            // baud
            // 
            this.baud.FormattingEnabled = true;
            this.baud.Items.AddRange(new object[] {
            "300 baud",
            "1200 baud",
            "2400 baud",
            "4800 baud",
            "9600 baud",
            "14400 baud",
            "19200 baud",
            "28800 baud",
            "38400 baud",
            "57600 baud",
            "115200 baud"});
            this.baud.Location = new System.Drawing.Point(10, 53);
            this.baud.Name = "baud";
            this.baud.Size = new System.Drawing.Size(130, 21);
            this.baud.TabIndex = 5;
            this.baud.Text = "9600 baud";
            this.baud.Click += new System.EventHandler(this.baud_Click);
            // 
            // scroll
            // 
            this.scroll.AutoSize = true;
            this.scroll.Checked = true;
            this.scroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scroll.Location = new System.Drawing.Point(10, 155);
            this.scroll.Name = "scroll";
            this.scroll.Size = new System.Drawing.Size(74, 17);
            this.scroll.TabIndex = 4;
            this.scroll.Text = "AutoScroll";
            this.scroll.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = global::ArduinoTank.Properties.Resources.refresh_icon;
            this.RefreshButton.Location = new System.Drawing.Point(117, 25);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 23);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // portsList
            // 
            this.portsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portsList.FormattingEnabled = true;
            this.portsList.Location = new System.Drawing.Point(10, 26);
            this.portsList.Name = "portsList";
            this.portsList.Size = new System.Drawing.Size(101, 21);
            this.portsList.TabIndex = 1;
            // 
            // connectState
            // 
            this.connectState.BackColor = System.Drawing.Color.Red;
            this.connectState.Enabled = false;
            this.connectState.Location = new System.Drawing.Point(10, 126);
            this.connectState.Name = "connectState";
            this.connectState.Size = new System.Drawing.Size(130, 20);
            this.connectState.TabIndex = 2;
            this.connectState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(10, 80);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(130, 40);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Połącz";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 1000;
            this.serialPort1.RtsEnable = true;
            this.serialPort1.WriteTimeout = 1000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // writeLine
            // 
            this.writeLine.Location = new System.Drawing.Point(10, 186);
            this.writeLine.Name = "writeLine";
            this.writeLine.Size = new System.Drawing.Size(260, 20);
            this.writeLine.TabIndex = 2;
            this.writeLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.writeLine_KeyPress);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.Black;
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.console.Location = new System.Drawing.Point(10, 31);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.console.Size = new System.Drawing.Size(294, 147);
            this.console.TabIndex = 3;
            this.console.TabStop = false;
            this.console.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(276, 185);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(28, 22);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.streamBoth);
            this.panel1.Controls.Add(this.streamWrite);
            this.panel1.Controls.Add(this.streamRead);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 15);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pokazuj:";
            // 
            // streamBoth
            // 
            this.streamBoth.AutoSize = true;
            this.streamBoth.Checked = true;
            this.streamBoth.Location = new System.Drawing.Point(54, -1);
            this.streamBoth.Name = "streamBoth";
            this.streamBoth.Size = new System.Drawing.Size(45, 17);
            this.streamBoth.TabIndex = 2;
            this.streamBoth.TabStop = true;
            this.streamBoth.Text = "Oba";
            this.streamBoth.UseVisualStyleBackColor = true;
            // 
            // streamWrite
            // 
            this.streamWrite.AutoSize = true;
            this.streamWrite.Location = new System.Drawing.Point(213, 0);
            this.streamWrite.Name = "streamWrite";
            this.streamWrite.Size = new System.Drawing.Size(68, 17);
            this.streamWrite.TabIndex = 1;
            this.streamWrite.Text = "Wysłane";
            this.streamWrite.UseVisualStyleBackColor = true;
            // 
            // streamRead
            // 
            this.streamRead.AutoSize = true;
            this.streamRead.Location = new System.Drawing.Point(118, -1);
            this.streamRead.Name = "streamRead";
            this.streamRead.Size = new System.Drawing.Size(72, 17);
            this.streamRead.TabIndex = 0;
            this.streamRead.Text = "Odebrane";
            this.streamRead.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rotLeft);
            this.groupBox1.Controls.Add(this.rotRight);
            this.groupBox1.Controls.Add(this.bothDown);
            this.groupBox1.Controls.Add(this.bothUp);
            this.groupBox1.Controls.Add(this.rightDown);
            this.groupBox1.Controls.Add(this.rightUp);
            this.groupBox1.Controls.Add(this.leftDown);
            this.groupBox1.Controls.Add(this.leftUp);
            this.groupBox1.Location = new System.Drawing.Point(10, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 213);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontrola:";
            // 
            // bothDown
            // 
            this.bothDown.Location = new System.Drawing.Point(184, 143);
            this.bothDown.Name = "bothDown";
            this.bothDown.Size = new System.Drawing.Size(75, 42);
            this.bothDown.TabIndex = 5;
            this.bothDown.Text = "Obie Tył";
            this.bothDown.UseVisualStyleBackColor = true;
            this.bothDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bothDown_MouseDown);
            this.bothDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bothDown_MouseUp);
            // 
            // bothUp
            // 
            this.bothUp.Location = new System.Drawing.Point(185, 33);
            this.bothUp.Name = "bothUp";
            this.bothUp.Size = new System.Drawing.Size(75, 42);
            this.bothUp.TabIndex = 4;
            this.bothUp.Text = "Obie Przód";
            this.bothUp.UseVisualStyleBackColor = true;
            this.bothUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bothUp_MouseDown);
            this.bothUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bothUp_MouseUp);
            // 
            // rightDown
            // 
            this.rightDown.Location = new System.Drawing.Point(265, 143);
            this.rightDown.Name = "rightDown";
            this.rightDown.Size = new System.Drawing.Size(75, 42);
            this.rightDown.TabIndex = 3;
            this.rightDown.Text = "Prawa Tył";
            this.rightDown.UseVisualStyleBackColor = true;
            this.rightDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightDown_MouseDown);
            this.rightDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rightDown_MouseUp);
            // 
            // rightUp
            // 
            this.rightUp.Location = new System.Drawing.Point(266, 33);
            this.rightUp.Name = "rightUp";
            this.rightUp.Size = new System.Drawing.Size(75, 42);
            this.rightUp.TabIndex = 2;
            this.rightUp.Text = "Prawa Przód";
            this.rightUp.UseVisualStyleBackColor = true;
            this.rightUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightUp_MouseDown);
            this.rightUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rightUp_MouseUp);
            // 
            // leftDown
            // 
            this.leftDown.Location = new System.Drawing.Point(102, 143);
            this.leftDown.Name = "leftDown";
            this.leftDown.Size = new System.Drawing.Size(75, 42);
            this.leftDown.TabIndex = 1;
            this.leftDown.Text = "Lewa Tył";
            this.leftDown.UseVisualStyleBackColor = true;
            this.leftDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.leftDown_MouseDown);
            this.leftDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.leftDown_MouseUp);
            // 
            // leftUp
            // 
            this.leftUp.Location = new System.Drawing.Point(104, 33);
            this.leftUp.Name = "leftUp";
            this.leftUp.Size = new System.Drawing.Size(75, 42);
            this.leftUp.TabIndex = 0;
            this.leftUp.Text = "Lewa Przód";
            this.leftUp.UseVisualStyleBackColor = true;
            this.leftUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.leftUp_MouseDown);
            this.leftUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.leftUp_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rotRight
            // 
            this.rotRight.Location = new System.Drawing.Point(226, 86);
            this.rotRight.Name = "rotRight";
            this.rotRight.Size = new System.Drawing.Size(75, 42);
            this.rotRight.TabIndex = 6;
            this.rotRight.Text = "Obrót Prawo";
            this.rotRight.UseVisualStyleBackColor = true;
            this.rotRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rotRight_MouseDown);
            this.rotRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rotRight_MouseUp);
            // 
            // rotLeft
            // 
            this.rotLeft.Location = new System.Drawing.Point(145, 86);
            this.rotLeft.Name = "rotLeft";
            this.rotLeft.Size = new System.Drawing.Size(75, 42);
            this.rotLeft.TabIndex = 7;
            this.rotLeft.Text = "Obrót Lewo";
            this.rotLeft.UseVisualStyleBackColor = true;
            this.rotLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rotLeft_MouseDown);
            this.rotLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rotLeft_MouseUp);
            // 
            // expandCheck
            // 
            this.expandCheck.AutoSize = true;
            this.expandCheck.Checked = true;
            this.expandCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.expandCheck.Location = new System.Drawing.Point(10, 179);
            this.expandCheck.Name = "expandCheck";
            this.expandCheck.Size = new System.Drawing.Size(69, 17);
            this.expandCheck.TabIndex = 6;
            this.expandCheck.Text = "Rozszerz";
            this.expandCheck.UseVisualStyleBackColor = true;
            this.expandCheck.CheckedChanged += new System.EventHandler(this.expandCheck_CheckedChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 434);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.console);
            this.Controls.Add(this.writeLine);
            this.Controls.Add(this.connectGroup);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Tank";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.connectGroup.ResumeLayout(false);
            this.connectGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox connectGroup;
        private System.Windows.Forms.Button RefreshButton;
        public System.Windows.Forms.TextBox connectState;
        public System.Windows.Forms.ComboBox portsList;
        public System.Windows.Forms.TextBox writeLine;
        public System.Windows.Forms.RichTextBox console;
        public System.Windows.Forms.Button connectButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox scroll;
        private System.Windows.Forms.ComboBox baud;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton streamBoth;
        private System.Windows.Forms.RadioButton streamWrite;
        private System.Windows.Forms.RadioButton streamRead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bothDown;
        private System.Windows.Forms.Button bothUp;
        private System.Windows.Forms.Button rightDown;
        private System.Windows.Forms.Button rightUp;
        private System.Windows.Forms.Button leftDown;
        private System.Windows.Forms.Button leftUp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button rotLeft;
        private System.Windows.Forms.Button rotRight;
        private System.Windows.Forms.CheckBox expandCheck;
    }
}

