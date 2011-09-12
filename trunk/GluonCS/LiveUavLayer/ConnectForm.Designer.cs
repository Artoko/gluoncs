﻿namespace GluonCS.LiveUavLayer
{
    partial class ConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.xPanderPanelList1 = new BSE.Windows.Forms.XPanderPanelList();
            this.xPanderPanel2 = new BSE.Windows.Forms.XPanderPanel();
            this._rbReplay = new System.Windows.Forms.RadioButton();
            this._rbViaComPort = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._btnBrowseLoggedFile = new System.Windows.Forms.Button();
            this._tbLoggedFilename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._cbBaudrate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this._cb_portnames = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xPanderPanel1 = new BSE.Windows.Forms.XPanderPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this._lblFilename = new System.Windows.Forms.Label();
            this._btnChangeFilename = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this._cbLogToFile = new System.Windows.Forms.CheckBox();
            this.xPanderPanel3 = new BSE.Windows.Forms.XPanderPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._tbFlightgear = new System.Windows.Forms.TextBox();
            this._cbSimulation = new System.Windows.Forms.CheckBox();
            this._btn_connect = new System.Windows.Forms.Button();
            this._btn_connectionless = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this._btn_portrefresh = new System.Windows.Forms.Button();
            this.xPanderPanelList1.SuspendLayout();
            this.xPanderPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.xPanderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.xPanderPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanderPanelList1
            // 
            this.xPanderPanelList1.CaptionStyle = BSE.Windows.Forms.CaptionStyle.Normal;
            this.xPanderPanelList1.Controls.Add(this.xPanderPanel2);
            this.xPanderPanelList1.Controls.Add(this.xPanderPanel1);
            this.xPanderPanelList1.Controls.Add(this.xPanderPanel3);
            this.xPanderPanelList1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xPanderPanelList1.GradientBackground = System.Drawing.Color.Empty;
            this.xPanderPanelList1.Location = new System.Drawing.Point(0, 0);
            this.xPanderPanelList1.Name = "xPanderPanelList1";
            this.xPanderPanelList1.PanelColors = null;
            this.xPanderPanelList1.Size = new System.Drawing.Size(275, 243);
            this.xPanderPanelList1.TabIndex = 0;
            this.xPanderPanelList1.Text = "xPanderPanelList1";
            // 
            // xPanderPanel2
            // 
            this.xPanderPanel2.CaptionFont = new System.Drawing.Font("Trebuchet MS", 8.75F, System.Drawing.FontStyle.Bold);
            this.xPanderPanel2.Controls.Add(this._rbReplay);
            this.xPanderPanel2.Controls.Add(this._rbViaComPort);
            this.xPanderPanel2.Controls.Add(this.groupBox2);
            this.xPanderPanel2.Controls.Add(this.groupBox1);
            this.xPanderPanel2.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xPanderPanel2.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.xPanderPanel2.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(154)))));
            this.xPanderPanel2.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(76)))));
            this.xPanderPanel2.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(116)))));
            this.xPanderPanel2.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.xPanderPanel2.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(164)))), ((int)(((byte)(224)))));
            this.xPanderPanel2.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(252)))));
            this.xPanderPanel2.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(62)))));
            this.xPanderPanel2.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(154)))));
            this.xPanderPanel2.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(109)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(136)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
            this.xPanderPanel2.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(252)))));
            this.xPanderPanel2.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.xPanderPanel2.CustomColors.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanel2.Expand = true;
            this.xPanderPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel2.Image = null;
            this.xPanderPanel2.Name = "xPanderPanel2";
            this.xPanderPanel2.PanelStyle = BSE.Windows.Forms.PanelStyle.Default;
            this.xPanderPanel2.Size = new System.Drawing.Size(275, 193);
            this.xPanderPanel2.TabIndex = 1;
            this.xPanderPanel2.Text = "Basic settings";
            this.xPanderPanel2.ToolTipTextCloseIcon = null;
            this.xPanderPanel2.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPanel2.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // _rbReplay
            // 
            this._rbReplay.AutoSize = true;
            this._rbReplay.Location = new System.Drawing.Point(20, 116);
            this._rbReplay.Name = "_rbReplay";
            this._rbReplay.Size = new System.Drawing.Size(88, 17);
            this._rbReplay.TabIndex = 3;
            this._rbReplay.Text = "Replay logfile";
            this._rbReplay.UseVisualStyleBackColor = true;
            // 
            // _rbViaComPort
            // 
            this._rbViaComPort.AutoSize = true;
            this._rbViaComPort.Checked = true;
            this._rbViaComPort.Location = new System.Drawing.Point(20, 33);
            this._rbViaComPort.Name = "_rbViaComPort";
            this._rbViaComPort.Size = new System.Drawing.Size(125, 17);
            this._rbViaComPort.TabIndex = 0;
            this._rbViaComPort.TabStop = true;
            this._rbViaComPort.Text = "Connect to COM-port";
            this._rbViaComPort.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._btnBrowseLoggedFile);
            this.groupBox2.Controls.Add(this._tbLoggedFilename);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(10, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   ";
            // 
            // _btnBrowseLoggedFile
            // 
            this._btnBrowseLoggedFile.Location = new System.Drawing.Point(209, 16);
            this._btnBrowseLoggedFile.Name = "_btnBrowseLoggedFile";
            this._btnBrowseLoggedFile.Size = new System.Drawing.Size(26, 21);
            this._btnBrowseLoggedFile.TabIndex = 2;
            this._btnBrowseLoggedFile.Text = "...";
            this._btnBrowseLoggedFile.UseVisualStyleBackColor = true;
            this._btnBrowseLoggedFile.Click += new System.EventHandler(this._btnBrowseLoggedFile_Click);
            // 
            // _tbLoggedFilename
            // 
            this._tbLoggedFilename.Location = new System.Drawing.Point(63, 17);
            this._tbLoggedFilename.Name = "_tbLoggedFilename";
            this._tbLoggedFilename.Size = new System.Drawing.Size(139, 20);
            this._tbLoggedFilename.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "File:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btn_portrefresh);
            this.groupBox1.Controls.Add(this._cbBaudrate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._cb_portnames);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(10, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "      ";
            // 
            // _cbBaudrate
            // 
            this._cbBaudrate.FormattingEnabled = true;
            this._cbBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this._cbBaudrate.Location = new System.Drawing.Point(72, 43);
            this._cbBaudrate.Name = "_cbBaudrate";
            this._cbBaudrate.Size = new System.Drawing.Size(156, 21);
            this._cbBaudrate.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Baudrate:";
            // 
            // _cb_portnames
            // 
            this._cb_portnames.FormattingEnabled = true;
            this._cb_portnames.Location = new System.Drawing.Point(72, 17);
            this._cb_portnames.Name = "_cb_portnames";
            this._cb_portnames.Size = new System.Drawing.Size(156, 21);
            this._cb_portnames.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Port:";
            // 
            // xPanderPanel1
            // 
            this.xPanderPanel1.CaptionFont = new System.Drawing.Font("Trebuchet MS", 8.75F, System.Drawing.FontStyle.Bold);
            this.xPanderPanel1.Controls.Add(this.label2);
            this.xPanderPanel1.Controls.Add(this.numericUpDown1);
            this.xPanderPanel1.Controls.Add(this._lblFilename);
            this.xPanderPanel1.Controls.Add(this._btnChangeFilename);
            this.xPanderPanel1.Controls.Add(this.checkBox2);
            this.xPanderPanel1.Controls.Add(this._cbLogToFile);
            this.xPanderPanel1.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xPanderPanel1.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.xPanderPanel1.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(154)))));
            this.xPanderPanel1.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(76)))));
            this.xPanderPanel1.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(116)))));
            this.xPanderPanel1.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel1.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel1.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.xPanderPanel1.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(164)))), ((int)(((byte)(224)))));
            this.xPanderPanel1.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(252)))));
            this.xPanderPanel1.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(62)))));
            this.xPanderPanel1.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(154)))));
            this.xPanderPanel1.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(109)))));
            this.xPanderPanel1.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.xPanderPanel1.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(136)))));
            this.xPanderPanel1.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
            this.xPanderPanel1.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel1.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel1.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(252)))));
            this.xPanderPanel1.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.xPanderPanel1.CustomColors.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel1.Image = null;
            this.xPanderPanel1.Name = "xPanderPanel1";
            this.xPanderPanel1.PanelStyle = BSE.Windows.Forms.PanelStyle.Default;
            this.xPanderPanel1.Size = new System.Drawing.Size(275, 25);
            this.xPanderPanel1.TabIndex = 0;
            this.xPanderPanel1.Text = "Advanced";
            this.xPanderPanel1.ToolTipTextCloseIcon = null;
            this.xPanderPanel1.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPanel1.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port number";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(99, 113);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            6170,
            0,
            0,
            0});
            // 
            // _lblFilename
            // 
            this._lblFilename.AutoSize = true;
            this._lblFilename.Location = new System.Drawing.Point(63, 66);
            this._lblFilename.Name = "_lblFilename";
            this._lblFilename.Size = new System.Drawing.Size(16, 13);
            this._lblFilename.TabIndex = 3;
            this._lblFilename.Text = "...";
            // 
            // _btnChangeFilename
            // 
            this._btnChangeFilename.Enabled = false;
            this._btnChangeFilename.Location = new System.Drawing.Point(32, 61);
            this._btnChangeFilename.Name = "_btnChangeFilename";
            this._btnChangeFilename.Size = new System.Drawing.Size(25, 23);
            this._btnChangeFilename.TabIndex = 2;
            this._btnChangeFilename.Text = "...";
            this._btnChangeFilename.UseVisualStyleBackColor = true;
            this._btnChangeFilename.Click += new System.EventHandler(this._btnChangeFilename_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(12, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(226, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Proxy read-only connection to TCP/IP port";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // _cbLogToFile
            // 
            this._cbLogToFile.AutoSize = true;
            this._cbLogToFile.Location = new System.Drawing.Point(13, 38);
            this._cbLogToFile.Name = "_cbLogToFile";
            this._cbLogToFile.Size = new System.Drawing.Size(96, 17);
            this._cbLogToFile.TabIndex = 0;
            this._cbLogToFile.Text = "Log data to file";
            this._cbLogToFile.UseVisualStyleBackColor = true;
            this._cbLogToFile.CheckedChanged += new System.EventHandler(this._cbLogToFile_CheckedChanged);
            // 
            // xPanderPanel3
            // 
            this.xPanderPanel3.CaptionFont = new System.Drawing.Font("Trebuchet MS", 8.75F, System.Drawing.FontStyle.Bold);
            this.xPanderPanel3.Controls.Add(this.label1);
            this.xPanderPanel3.Controls.Add(this._tbFlightgear);
            this.xPanderPanel3.Controls.Add(this._cbSimulation);
            this.xPanderPanel3.CustomColors.BackColor = System.Drawing.SystemColors.Control;
            this.xPanderPanel3.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.xPanderPanel3.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(154)))));
            this.xPanderPanel3.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(76)))));
            this.xPanderPanel3.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(116)))));
            this.xPanderPanel3.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.xPanderPanel3.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(164)))), ((int)(((byte)(224)))));
            this.xPanderPanel3.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(252)))));
            this.xPanderPanel3.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(62)))));
            this.xPanderPanel3.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(154)))));
            this.xPanderPanel3.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(109)))));
            this.xPanderPanel3.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.xPanderPanel3.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(136)))));
            this.xPanderPanel3.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(172)))));
            this.xPanderPanel3.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(252)))));
            this.xPanderPanel3.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.xPanderPanel3.CustomColors.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanderPanel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xPanderPanel3.Image = null;
            this.xPanderPanel3.Name = "xPanderPanel3";
            this.xPanderPanel3.PanelStyle = BSE.Windows.Forms.PanelStyle.Default;
            this.xPanderPanel3.Size = new System.Drawing.Size(275, 25);
            this.xPanderPanel3.TabIndex = 2;
            this.xPanderPanel3.Text = "Simulation";
            this.xPanderPanel3.ToolTipTextCloseIcon = null;
            this.xPanderPanel3.ToolTipTextExpandIconPanelCollapsed = null;
            this.xPanderPanel3.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flightgear path:";
            // 
            // _tbFlightgear
            // 
            this._tbFlightgear.Location = new System.Drawing.Point(10, 88);
            this._tbFlightgear.Name = "_tbFlightgear";
            this._tbFlightgear.Size = new System.Drawing.Size(256, 20);
            this._tbFlightgear.TabIndex = 1;
            this._tbFlightgear.Text = "D:\\Program Files\\FlightGear\\";
            // 
            // _cbSimulation
            // 
            this._cbSimulation.AutoSize = true;
            this._cbSimulation.Location = new System.Drawing.Point(13, 34);
            this._cbSimulation.Name = "_cbSimulation";
            this._cbSimulation.Size = new System.Drawing.Size(233, 30);
            this._cbSimulation.TabIndex = 0;
            this._cbSimulation.Text = "Set Gluonpilot in Flightgear simulation mode \r\nand launch Flightgear";
            this._cbSimulation.UseVisualStyleBackColor = true;
            // 
            // _btn_connect
            // 
            this._btn_connect.Location = new System.Drawing.Point(138, 10);
            this._btn_connect.Name = "_btn_connect";
            this._btn_connect.Size = new System.Drawing.Size(120, 23);
            this._btn_connect.TabIndex = 5;
            this._btn_connect.Text = "&Connect";
            this._btn_connect.UseVisualStyleBackColor = true;
            this._btn_connect.Click += new System.EventHandler(this._btn_connect_Click);
            // 
            // _btn_connectionless
            // 
            this._btn_connectionless.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btn_connectionless.Location = new System.Drawing.Point(9, 10);
            this._btn_connectionless.Name = "_btn_connectionless";
            this._btn_connectionless.Size = new System.Drawing.Size(119, 23);
            this._btn_connectionless.TabIndex = 6;
            this._btn_connectionless.Text = "Work connection&less";
            this._btn_connectionless.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._btn_connect);
            this.panel1.Controls.Add(this._btn_connectionless);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 45);
            this.panel1.TabIndex = 1;
            // 
            // _btn_portrefresh
            // 
            this._btn_portrefresh.FlatAppearance.BorderSize = 0;
            this._btn_portrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btn_portrefresh.ForeColor = System.Drawing.Color.Transparent;
            this._btn_portrefresh.Image = ((System.Drawing.Image)(resources.GetObject("_btn_portrefresh.Image")));
            this._btn_portrefresh.Location = new System.Drawing.Point(231, 18);
            this._btn_portrefresh.Name = "_btn_portrefresh";
            this._btn_portrefresh.Size = new System.Drawing.Size(15, 18);
            this._btn_portrefresh.TabIndex = 4;
            this._btn_portrefresh.UseVisualStyleBackColor = true;
            this._btn_portrefresh.Click += new System.EventHandler(this._btn_portrefresh_Click);
            // 
            // ConnectForm
            // 
            this.AcceptButton = this._btn_connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btn_connectionless;
            this.ClientSize = new System.Drawing.Size(275, 288);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xPanderPanelList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ConnectForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "  Connect to your UAV...";
            this.xPanderPanelList1.ResumeLayout(false);
            this.xPanderPanel2.ResumeLayout(false);
            this.xPanderPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.xPanderPanel1.ResumeLayout(false);
            this.xPanderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.xPanderPanel3.ResumeLayout(false);
            this.xPanderPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private BSE.Windows.Forms.XPanderPanelList xPanderPanelList1;
        private BSE.Windows.Forms.XPanderPanel xPanderPanel2;
        private BSE.Windows.Forms.XPanderPanel xPanderPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label _lblFilename;
        private System.Windows.Forms.Button _btnChangeFilename;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox _cbLogToFile;
        private System.Windows.Forms.RadioButton _rbReplay;
        private System.Windows.Forms.RadioButton _rbViaComPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btn_connectionless;
        private System.Windows.Forms.Button _btn_connect;
        private System.Windows.Forms.TextBox _tbLoggedFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cbBaudrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox _cb_portnames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private BSE.Windows.Forms.XPanderPanel xPanderPanel3;
        private System.Windows.Forms.CheckBox _cbSimulation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbFlightgear;
        private System.Windows.Forms.Button _btnBrowseLoggedFile;
        private System.Windows.Forms.Button _btn_portrefresh;
    }
}