﻿namespace GluonCS
{
    partial class LiveUavPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiveUavPanel));
            this._cockpitPanel = new BSE.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._zgAlt = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._lblHomeDistance = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._cbAltitudeMode = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this._lblAltitude = new System.Windows.Forms.Label();
            this._lblVoltage = new System.Windows.Forms.Label();
            this._lblSpeed = new System.Windows.Forms.Label();
            this._lblGpsSat = new System.Windows.Forms.Label();
            this._artificialHorizon = new ArtificialHorizon.ArtificialHorizon();
            this._imageListGps = new System.Windows.Forms.ImageList(this.components);
            this._navigationPanel = new BSE.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._btn_up = new System.Windows.Forms.ToolStripButton();
            this._btn_down = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this._nav_open = new System.Windows.Forms.ToolStripMenuItem();
            this._nav_save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this._btnNaviRead = new System.Windows.Forms.ToolStripMenuItem();
            this._btnNaviWrite = new System.Windows.Forms.ToolStripMenuItem();
            this._btnNaviReload = new System.Windows.Forms.ToolStripMenuItem();
            this._btnAutoSync = new System.Windows.Forms.ToolStripButton();
            this._btnNaviBurn = new System.Windows.Forms.ToolStripButton();
            this._lv_navigation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._gmapContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this._cockpitPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this._navigationPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cockpitPanel
            // 
            this._cockpitPanel.AssociatedSplitter = null;
            this._cockpitPanel.BackColor = System.Drawing.Color.Transparent;
            this._cockpitPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._cockpitPanel.CaptionFont = new System.Drawing.Font("Trebuchet MS", 8.75F, System.Drawing.FontStyle.Bold);
            this._cockpitPanel.CaptionHeight = 20;
            this._cockpitPanel.Controls.Add(this.tabControl1);
            this._cockpitPanel.Controls.Add(this._lblHomeDistance);
            this._cockpitPanel.Controls.Add(this.label11);
            this._cockpitPanel.Controls.Add(this.label10);
            this._cockpitPanel.Controls.Add(this.button3);
            this._cockpitPanel.Controls.Add(this.button2);
            this._cockpitPanel.Controls.Add(this.button1);
            this._cockpitPanel.Controls.Add(this.label9);
            this._cockpitPanel.Controls.Add(this.label8);
            this._cockpitPanel.Controls.Add(this.tableLayoutPanel2);
            this._cockpitPanel.Controls.Add(this.tableLayoutPanel1);
            this._cockpitPanel.Controls.Add(this._lblAltitude);
            this._cockpitPanel.Controls.Add(this._lblVoltage);
            this._cockpitPanel.Controls.Add(this._lblSpeed);
            this._cockpitPanel.Controls.Add(this._lblGpsSat);
            this._cockpitPanel.Controls.Add(this._artificialHorizon);
            this._cockpitPanel.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this._cockpitPanel.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this._cockpitPanel.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this._cockpitPanel.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this._cockpitPanel.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(164)))), ((int)(((byte)(224)))));
            this._cockpitPanel.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(252)))));
            this._cockpitPanel.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this._cockpitPanel.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(136)))));
            this._cockpitPanel.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this._cockpitPanel.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this._cockpitPanel.CustomColors.ContentGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this._cockpitPanel.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this._cockpitPanel.CustomColors.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._cockpitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cockpitPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cockpitPanel.Image = null;
            this._cockpitPanel.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this._cockpitPanel.Location = new System.Drawing.Point(0, 0);
            this._cockpitPanel.MinimumSize = new System.Drawing.Size(20, 20);
            this._cockpitPanel.Name = "_cockpitPanel";
            this._cockpitPanel.PanelStyle = BSE.Windows.Forms.PanelStyle.Default;
            this._cockpitPanel.ShowExpandIcon = true;
            this._cockpitPanel.Size = new System.Drawing.Size(316, 636);
            this._cockpitPanel.TabIndex = 0;
            this._cockpitPanel.Text = "Cockpit";
            this._cockpitPanel.ToolTipTextCloseIcon = null;
            this._cockpitPanel.ToolTipTextExpandIconPanelCollapsed = null;
            this._cockpitPanel.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 290);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(310, 135);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._zgAlt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(302, 109);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Altitude";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _zgAlt
            // 
            this._zgAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this._zgAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._zgAlt.IsAntiAlias = true;
            this._zgAlt.Location = new System.Drawing.Point(3, 3);
            this._zgAlt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._zgAlt.Name = "_zgAlt";
            this._zgAlt.ScrollGrace = 0D;
            this._zgAlt.ScrollMaxX = 0D;
            this._zgAlt.ScrollMaxY = 0D;
            this._zgAlt.ScrollMaxY2 = 0D;
            this._zgAlt.ScrollMinX = 0D;
            this._zgAlt.ScrollMinY = 0D;
            this._zgAlt.ScrollMinY2 = 0D;
            this._zgAlt.Size = new System.Drawing.Size(296, 103);
            this._zgAlt.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(302, 109);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Speed";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _lblHomeDistance
            // 
            this._lblHomeDistance.AutoSize = true;
            this._lblHomeDistance.Location = new System.Drawing.Point(11, 208);
            this._lblHomeDistance.Name = "_lblHomeDistance";
            this._lblHomeDistance.Size = new System.Drawing.Size(39, 13);
            this._lblHomeDistance.TabIndex = 24;
            this._lblHomeDistance.Text = "1234m";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "ETA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "ETA:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 21;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 20;
            this.button2.Text = "Loiter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "RTH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Target:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Home: ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(306, 16);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Altitude mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Autopilot mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Control mode";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this._cbAltitudeMode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 24);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // _cbAltitudeMode
            // 
            this._cbAltitudeMode.BackColor = System.Drawing.Color.Lime;
            this._cbAltitudeMode.FormattingEnabled = true;
            this._cbAltitudeMode.Items.AddRange(new object[] {
            "Waypoint",
            "RC-transmitter",
            "GCS"});
            this._cbAltitudeMode.Location = new System.Drawing.Point(3, 3);
            this._cbAltitudeMode.Name = "_cbAltitudeMode";
            this._cbAltitudeMode.Size = new System.Drawing.Size(88, 21);
            this._cbAltitudeMode.TabIndex = 11;
            this._cbAltitudeMode.Text = "Waypoint";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Yellow;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RC-transmitter",
            "GCS (None)",
            "GCS (Joystick)"});
            this.comboBox1.Location = new System.Drawing.Point(207, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "RC-transmitter";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Red;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Manual",
            "Stabilized",
            "Autopilot",
            "Return home",
            "Loiter"});
            this.comboBox2.Location = new System.Drawing.Point(105, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(86, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "Manual";
            // 
            // _lblAltitude
            // 
            this._lblAltitude.AutoSize = true;
            this._lblAltitude.Location = new System.Drawing.Point(229, 124);
            this._lblAltitude.Name = "_lblAltitude";
            this._lblAltitude.Size = new System.Drawing.Size(24, 13);
            this._lblAltitude.TabIndex = 4;
            this._lblAltitude.Text = "0 m";
            // 
            // _lblVoltage
            // 
            this._lblVoltage.AutoSize = true;
            this._lblVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblVoltage.Location = new System.Drawing.Point(259, 71);
            this._lblVoltage.Name = "_lblVoltage";
            this._lblVoltage.Size = new System.Drawing.Size(27, 15);
            this._lblVoltage.TabIndex = 3;
            this._lblVoltage.Text = "0 V";
            // 
            // _lblSpeed
            // 
            this._lblSpeed.Location = new System.Drawing.Point(6, 128);
            this._lblSpeed.Name = "_lblSpeed";
            this._lblSpeed.Size = new System.Drawing.Size(74, 12);
            this._lblSpeed.TabIndex = 2;
            this._lblSpeed.Text = "0 km/h";
            this._lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _lblGpsSat
            // 
            this._lblGpsSat.AutoSize = true;
            this._lblGpsSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblGpsSat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lblGpsSat.ImageKey = "ERROR";
            this._lblGpsSat.Location = new System.Drawing.Point(6, 71);
            this._lblGpsSat.Name = "_lblGpsSat";
            this._lblGpsSat.Size = new System.Drawing.Size(65, 15);
            this._lblGpsSat.TabIndex = 1;
            this._lblGpsSat.Text = "GPS: N/A";
            // 
            // _artificialHorizon
            // 
            this._artificialHorizon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._artificialHorizon.AutoScroll = true;
            this._artificialHorizon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this._artificialHorizon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._artificialHorizon.Location = new System.Drawing.Point(90, 73);
            this._artificialHorizon.Name = "_artificialHorizon";
            this._artificialHorizon.pitch_angle = 0D;
            this._artificialHorizon.roll_angle = 0D;
            this._artificialHorizon.Size = new System.Drawing.Size(130, 115);
            this._artificialHorizon.TabIndex = 0;
            // 
            // _imageListGps
            // 
            this._imageListGps.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imageListGps.ImageStream")));
            this._imageListGps.TransparentColor = System.Drawing.Color.Black;
            this._imageListGps.Images.SetKeyName(0, "OK");
            this._imageListGps.Images.SetKeyName(1, "NOK");
            this._imageListGps.Images.SetKeyName(2, "ERROR");
            // 
            // _navigationPanel
            // 
            this._navigationPanel.AssociatedSplitter = null;
            this._navigationPanel.BackColor = System.Drawing.Color.Transparent;
            this._navigationPanel.CaptionFont = new System.Drawing.Font("Trebuchet MS", 8.75F, System.Drawing.FontStyle.Bold);
            this._navigationPanel.CaptionHeight = 21;
            this._navigationPanel.Controls.Add(this.toolStrip1);
            this._navigationPanel.Controls.Add(this._lv_navigation);
            this._navigationPanel.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this._navigationPanel.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this._navigationPanel.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this._navigationPanel.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this._navigationPanel.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(164)))), ((int)(((byte)(224)))));
            this._navigationPanel.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(252)))));
            this._navigationPanel.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this._navigationPanel.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(136)))));
            this._navigationPanel.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this._navigationPanel.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this._navigationPanel.CustomColors.ContentGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this._navigationPanel.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(218)))), ((int)(((byte)(250)))));
            this._navigationPanel.CustomColors.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._navigationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._navigationPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._navigationPanel.Image = null;
            this._navigationPanel.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this._navigationPanel.Location = new System.Drawing.Point(0, 431);
            this._navigationPanel.MinimumSize = new System.Drawing.Size(21, 21);
            this._navigationPanel.Name = "_navigationPanel";
            this._navigationPanel.PanelStyle = BSE.Windows.Forms.PanelStyle.Default;
            this._navigationPanel.ShowExpandIcon = true;
            this._navigationPanel.Size = new System.Drawing.Size(316, 205);
            this._navigationPanel.TabIndex = 2;
            this._navigationPanel.Text = "Navigation";
            this._navigationPanel.ToolTipTextCloseIcon = null;
            this._navigationPanel.ToolTipTextExpandIconPanelCollapsed = null;
            this._navigationPanel.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btn_up,
            this._btn_down,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this._btnAutoSync,
            this._btnNaviBurn});
            this.toolStrip1.Location = new System.Drawing.Point(1, 22);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(314, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _btn_up
            // 
            this._btn_up.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btn_up.Image = ((System.Drawing.Image)(resources.GetObject("_btn_up.Image")));
            this._btn_up.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btn_up.Name = "_btn_up";
            this._btn_up.Size = new System.Drawing.Size(23, 22);
            this._btn_up.Text = "Move up";
            this._btn_up.Click += new System.EventHandler(this._btn_up_Click);
            // 
            // _btn_down
            // 
            this._btn_down.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btn_down.Image = ((System.Drawing.Image)(resources.GetObject("_btn_down.Image")));
            this._btn_down.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btn_down.Name = "_btn_down";
            this._btn_down.Size = new System.Drawing.Size(23, 22);
            this._btn_down.Text = "Move down";
            this._btn_down.Click += new System.EventHandler(this._btn_down_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._nav_open,
            this._nav_save});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(54, 22);
            this.toolStripDropDownButton1.Text = "&File";
            // 
            // _nav_open
            // 
            this._nav_open.Image = ((System.Drawing.Image)(resources.GetObject("_nav_open.Image")));
            this._nav_open.Name = "_nav_open";
            this._nav_open.Size = new System.Drawing.Size(103, 22);
            this._nav_open.Text = "&Open";
            this._nav_open.Click += new System.EventHandler(this._nav_open_Click);
            // 
            // _nav_save
            // 
            this._nav_save.Image = ((System.Drawing.Image)(resources.GetObject("_nav_save.Image")));
            this._nav_save.Name = "_nav_save";
            this._nav_save.Size = new System.Drawing.Size(103, 22);
            this._nav_save.Text = "&Save";
            this._nav_save.Click += new System.EventHandler(this._nav_save_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btnNaviRead,
            this._btnNaviWrite,
            this._btnNaviReload});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(56, 22);
            this.toolStripDropDownButton2.Text = "&Uav";
            // 
            // _btnNaviRead
            // 
            this._btnNaviRead.Name = "_btnNaviRead";
            this._btnNaviRead.Size = new System.Drawing.Size(167, 22);
            this._btnNaviRead.Text = "&Read";
            this._btnNaviRead.Click += new System.EventHandler(this._btnNaviRead_Click);
            // 
            // _btnNaviWrite
            // 
            this._btnNaviWrite.Name = "_btnNaviWrite";
            this._btnNaviWrite.Size = new System.Drawing.Size(167, 22);
            this._btnNaviWrite.Text = "&Write";
            this._btnNaviWrite.Click += new System.EventHandler(this._btnNaviWrite_Click);
            // 
            // _btnNaviReload
            // 
            this._btnNaviReload.Name = "_btnNaviReload";
            this._btnNaviReload.Size = new System.Drawing.Size(167, 22);
            this._btnNaviReload.Text = "Re&load from flash";
            this._btnNaviReload.Click += new System.EventHandler(this._btnNaviReload_Click);
            // 
            // _btnAutoSync
            // 
            this._btnAutoSync.Checked = true;
            this._btnAutoSync.CheckOnClick = true;
            this._btnAutoSync.CheckState = System.Windows.Forms.CheckState.Checked;
            this._btnAutoSync.Image = ((System.Drawing.Image)(resources.GetObject("_btnAutoSync.Image")));
            this._btnAutoSync.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnAutoSync.Name = "_btnAutoSync";
            this._btnAutoSync.Size = new System.Drawing.Size(82, 22);
            this._btnAutoSync.Text = "Auto-sync";
            this._btnAutoSync.CheckedChanged += new System.EventHandler(this._btnAutoSync_CheckedChanged);
            // 
            // _btnNaviBurn
            // 
            this._btnNaviBurn.Image = ((System.Drawing.Image)(resources.GetObject("_btnNaviBurn.Image")));
            this._btnNaviBurn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnNaviBurn.Name = "_btnNaviBurn";
            this._btnNaviBurn.Size = new System.Drawing.Size(52, 22);
            this._btnNaviBurn.Text = "Burn";
            this._btnNaviBurn.Click += new System.EventHandler(this._btnNaviBurn_Click);
            // 
            // _lv_navigation
            // 
            this._lv_navigation.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this._lv_navigation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._lv_navigation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this._lv_navigation.FullRowSelect = true;
            this._lv_navigation.GridLines = true;
            this._lv_navigation.HideSelection = false;
            this._lv_navigation.Location = new System.Drawing.Point(0, 46);
            this._lv_navigation.MultiSelect = false;
            this._lv_navigation.Name = "_lv_navigation";
            this._lv_navigation.Size = new System.Drawing.Size(316, 158);
            this._lv_navigation.TabIndex = 0;
            this._lv_navigation.UseCompatibleStateImageBehavior = false;
            this._lv_navigation.View = System.Windows.Forms.View.Details;
            this._lv_navigation.ItemActivate += new System.EventHandler(this._lv_navigation_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Command";
            this.columnHeader2.Width = 276;
            // 
            // _gmapContextMenuStrip
            // 
            this._gmapContextMenuStrip.Name = "_gmapContextMenuStrip";
            this._gmapContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 428);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(316, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // LiveUavPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this._navigationPanel);
            this.Controls.Add(this._cockpitPanel);
            this.Name = "LiveUavPanel";
            this.Size = new System.Drawing.Size(316, 636);
            this._cockpitPanel.ResumeLayout(false);
            this._cockpitPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this._navigationPanel.ResumeLayout(false);
            this._navigationPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BSE.Windows.Forms.Panel _cockpitPanel;
        private BSE.Windows.Forms.Panel _navigationPanel;
        private ArtificialHorizon.ArtificialHorizon _artificialHorizon;
        private System.Windows.Forms.Label _lblGpsSat;
        private System.Windows.Forms.Label _lblAltitude;
        private System.Windows.Forms.Label _lblVoltage;
        private System.Windows.Forms.Label _lblSpeed;
        private System.Windows.Forms.ListView _lv_navigation;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ContextMenuStrip _gmapContextMenuStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem _nav_open;
        private System.Windows.Forms.ToolStripMenuItem _nav_save;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem _btnNaviRead;
        private System.Windows.Forms.ToolStripMenuItem _btnNaviWrite;
        private System.Windows.Forms.ToolStripButton _btnAutoSync;
        private System.Windows.Forms.ToolStripButton _btn_up;
        private System.Windows.Forms.ToolStripButton _btn_down;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ImageList _imageListGps;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox _cbAltitudeMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton _btnNaviBurn;
        private System.Windows.Forms.ToolStripMenuItem _btnNaviReload;
        private System.Windows.Forms.Label _lblHomeDistance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl _zgAlt;
    }
}
