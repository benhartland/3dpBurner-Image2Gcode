﻿﻿/*  3dpBurner Image2Gcode. A Image to GCODE converter for GRBL based devices.
    This file is part of 3dpBurner Image2Gcode application.
   
    Copyright (C) 2015  Adrian V. J. (villamany) contact: villamany@gmail.com
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.
    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.
    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
//Form 1 (Main form design)

namespace _3dpBurnerImage2Gcode
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBoxOffCode = new System.Windows.Forms.GroupBox();
			this.comboBoxOffCode = new System.Windows.Forms.ComboBox();
			this.groupBoxOnCode = new System.Windows.Forms.GroupBox();
			this.comboBoxOnCode = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cbEngravingPattern = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbUseS = new System.Windows.Forms.RadioButton();
			this.rbUseZ = new System.Windows.Forms.RadioButton();
			this.cbEdgeLines = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.rtbPostGcode = new System.Windows.Forms.RichTextBox();
			this.rtbPreGcode = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.tbThreshold = new System.Windows.Forms.TextBox();
			this.cbOptimizedRaster = new System.Windows.Forms.CheckBox();
			this.label20 = new System.Windows.Forms.Label();
			this.cbLaserDecimal = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.tbProfileName = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.cmbProfile = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.lblFeedRateUnits = new System.Windows.Forms.Label();
			this.tbFeedRate = new System.Windows.Forms.TextBox();
			this.tbProfilePower = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbLaserMax = new System.Windows.Forms.TextBox();
			this.tbLaserMin = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.ori8 = new System.Windows.Forms.RadioButton();
			this.ori7 = new System.Windows.Forms.RadioButton();
			this.ori6 = new System.Windows.Forms.RadioButton();
			this.ori5 = new System.Windows.Forms.RadioButton();
			this.ori4 = new System.Windows.Forms.RadioButton();
			this.ori3 = new System.Windows.Forms.RadioButton();
			this.ori2 = new System.Windows.Forms.RadioButton();
			this.ori1 = new System.Windows.Forms.RadioButton();
			this.ori0 = new System.Windows.Forms.RadioButton();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.cbDirthering = new System.Windows.Forms.ComboBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.lblGamma = new System.Windows.Forms.Label();
			this.tBarGamma = new System.Windows.Forms.TrackBar();
			this.lblBrightness = new System.Windows.Forms.Label();
			this.tBarBrightness = new System.Windows.Forms.TrackBar();
			this.lblContrast = new System.Windows.Forms.Label();
			this.tBarContrast = new System.Windows.Forms.TrackBar();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnInvert = new System.Windows.Forms.Button();
			this.btnRotateLeft = new System.Windows.Forms.Button();
			this.btnRotateRight = new System.Windows.Forms.Button();
			this.btnVertMirror = new System.Windows.Forms.Button();
			this.btnHorizMirror = new System.Windows.Forms.Button();
			this.gbDimensions = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tbRes = new System.Windows.Forms.TextBox();
			this.cbLockRatio = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tbHeight = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbWidth = new System.Windows.Forms.TextBox();
			this.btnCheckOrig = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autoZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.metricmmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imperialinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnNew = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBoxOffCode.SuspendLayout();
			this.groupBoxOnCode.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tBarGamma)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBarBrightness)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBarContrast)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.gbDimensions.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp)| *.jpg; *.jpeg; *.jpe; *" +
    ".jfif; *.png; *.bmp|All files(*.*)|*.*";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = ".gco";
			this.saveFileDialog1.Filter = "G-Code Files(*.GCODE;*.CNC;*.NC;*.TAP;*.TXT)|*.GCO;*.GCODE;*.CNC;*.NC;*.TAP;*.TXT" +
    "|All files (*.*)|*.*";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(118, 15);
			this.lblStatus.Text = "toolStripStatusLabel1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.statusStrip1.Location = new System.Drawing.Point(0, 579);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(875, 20);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
			this.tabPage2.Controls.Add(this.groupBoxOffCode);
			this.tabPage2.Controls.Add(this.groupBoxOnCode);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.cbEngravingPattern);
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Controls.Add(this.cbEdgeLines);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.rtbPostGcode);
			this.tabPage2.Controls.Add(this.rtbPreGcode);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.btnGenerate);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(200, 526);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "GCODE";
			// 
			// groupBoxOffCode
			// 
			this.groupBoxOffCode.Controls.Add(this.comboBoxOffCode);
			this.groupBoxOffCode.Location = new System.Drawing.Point(2, 374);
			this.groupBoxOffCode.Name = "groupBoxOffCode";
			this.groupBoxOffCode.Size = new System.Drawing.Size(195, 45);
			this.groupBoxOffCode.TabIndex = 22;
			this.groupBoxOffCode.TabStop = false;
			this.groupBoxOffCode.Text = "Laser Power Off MCODE";
			// 
			// comboBoxOffCode
			// 
			this.comboBoxOffCode.FormattingEnabled = true;
			this.comboBoxOffCode.Items.AddRange(new object[] {
            "M05",
            "M107",
            "M105"});
			this.comboBoxOffCode.Location = new System.Drawing.Point(10, 18);
			this.comboBoxOffCode.Name = "comboBoxOffCode";
			this.comboBoxOffCode.Size = new System.Drawing.Size(164, 21);
			this.comboBoxOffCode.TabIndex = 0;
			// 
			// groupBoxOnCode
			// 
			this.groupBoxOnCode.Controls.Add(this.comboBoxOnCode);
			this.groupBoxOnCode.Location = new System.Drawing.Point(1, 323);
			this.groupBoxOnCode.Name = "groupBoxOnCode";
			this.groupBoxOnCode.Size = new System.Drawing.Size(196, 45);
			this.groupBoxOnCode.TabIndex = 21;
			this.groupBoxOnCode.TabStop = false;
			this.groupBoxOnCode.Text = "Laser Power On MCODE";
			// 
			// comboBoxOnCode
			// 
			this.comboBoxOnCode.FormattingEnabled = true;
			this.comboBoxOnCode.Items.AddRange(new object[] {
            "M03 S",
            "M106 S",
            "M103 S"});
			this.comboBoxOnCode.Location = new System.Drawing.Point(10, 18);
			this.comboBoxOnCode.Name = "comboBoxOnCode";
			this.comboBoxOnCode.Size = new System.Drawing.Size(164, 21);
			this.comboBoxOnCode.TabIndex = 0;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(8, 429);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(91, 13);
			this.label12.TabIndex = 20;
			this.label12.Text = "Engraving pattern";
			// 
			// cbEngravingPattern
			// 
			this.cbEngravingPattern.FormattingEnabled = true;
			this.cbEngravingPattern.Items.AddRange(new object[] {
            "Horizontal scanning",
            "Diagonal scanning"});
			this.cbEngravingPattern.Location = new System.Drawing.Point(8, 445);
			this.cbEngravingPattern.Name = "cbEngravingPattern";
			this.cbEngravingPattern.Size = new System.Drawing.Size(187, 21);
			this.cbEngravingPattern.TabIndex = 4;
			this.cbEngravingPattern.Text = "Horizontal scanning";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbUseS);
			this.groupBox2.Controls.Add(this.rbUseZ);
			this.groupBox2.Location = new System.Drawing.Point(1, 269);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(196, 48);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Laser power command";
			// 
			// rbUseS
			// 
			this.rbUseS.AutoSize = true;
			this.rbUseS.Checked = true;
			this.rbUseS.Location = new System.Drawing.Point(21, 16);
			this.rbUseS.Name = "rbUseS";
			this.rbUseS.Size = new System.Drawing.Size(94, 17);
			this.rbUseS.TabIndex = 2;
			this.rbUseS.TabStop = true;
			this.rbUseS.Text = "Use \'S\' Param.";
			this.rbUseS.UseVisualStyleBackColor = true;
			this.rbUseS.CheckedChanged += new System.EventHandler(this.rbUseS_CheckedChanged);
			// 
			// rbUseZ
			// 
			this.rbUseZ.AutoSize = true;
			this.rbUseZ.Location = new System.Drawing.Point(117, 16);
			this.rbUseZ.Name = "rbUseZ";
			this.rbUseZ.Size = new System.Drawing.Size(58, 17);
			this.rbUseZ.TabIndex = 2;
			this.rbUseZ.Text = "Use \'Z\'";
			this.rbUseZ.UseVisualStyleBackColor = true;
			this.rbUseZ.CheckedChanged += new System.EventHandler(this.rbUseZ_CheckedChanged);
			// 
			// cbEdgeLines
			// 
			this.cbEdgeLines.AutoSize = true;
			this.cbEdgeLines.Checked = true;
			this.cbEdgeLines.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbEdgeLines.Location = new System.Drawing.Point(46, 474);
			this.cbEdgeLines.Name = "cbEdgeLines";
			this.cbEdgeLines.Size = new System.Drawing.Size(112, 17);
			this.cbEdgeLines.TabIndex = 5;
			this.cbEdgeLines.Text = "Engrave edge line";
			this.cbEdgeLines.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 107);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Gcode Footer";
			// 
			// rtbPostGcode
			// 
			this.rtbPostGcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtbPostGcode.Location = new System.Drawing.Point(1, 121);
			this.rtbPostGcode.Name = "rtbPostGcode";
			this.rtbPostGcode.Size = new System.Drawing.Size(196, 83);
			this.rtbPostGcode.TabIndex = 1;
			this.rtbPostGcode.Text = "(Footer)\nG0 X0 Y0\n(Footer end)";
			this.rtbPostGcode.WordWrap = false;
			// 
			// rtbPreGcode
			// 
			this.rtbPreGcode.Location = new System.Drawing.Point(1, 20);
			this.rtbPreGcode.Name = "rtbPreGcode";
			this.rtbPreGcode.Size = new System.Drawing.Size(196, 83);
			this.rtbPreGcode.TabIndex = 0;
			this.rtbPreGcode.Text = "(Header)\nG0 X0 Y0\n(Header end)";
			this.rtbPreGcode.WordWrap = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(2, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Gcode Header";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(37, 499);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(133, 23);
			this.btnGenerate.TabIndex = 6;
			this.btnGenerate.Text = "Generate file...";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label22);
			this.tabPage3.Controls.Add(this.label21);
			this.tabPage3.Controls.Add(this.tbThreshold);
			this.tabPage3.Controls.Add(this.cbOptimizedRaster);
			this.tabPage3.Controls.Add(this.label20);
			this.tabPage3.Controls.Add(this.cbLaserDecimal);
			this.tabPage3.Controls.Add(this.groupBox1);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.tbLaserMax);
			this.tabPage3.Controls.Add(this.tbLaserMin);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(200, 526);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Laser profile";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(111, 225);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(15, 13);
			this.label22.TabIndex = 45;
			this.label22.Text = "%";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(12, 225);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(54, 13);
			this.label21.TabIndex = 46;
			this.label21.Text = "Threshold";
			// 
			// tbThreshold
			// 
			this.tbThreshold.Enabled = false;
			this.tbThreshold.Location = new System.Drawing.Point(72, 222);
			this.tbThreshold.MaxLength = 3;
			this.tbThreshold.Name = "tbThreshold";
			this.tbThreshold.Size = new System.Drawing.Size(35, 20);
			this.tbThreshold.TabIndex = 45;
			this.tbThreshold.Text = "0";
			this.toolTip1.SetToolTip(this.tbThreshold, "This value determines the white areas of the image for optimization. \r\nTry increa" +
        "sing values until the white space is sufficiently ignored.");
			this.tbThreshold.TextChanged += new System.EventHandler(this.tbThreshold_TextChanged);
			this.tbThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbThreshold_KeyPress);
			// 
			// cbOptimizedRaster
			// 
			this.cbOptimizedRaster.AutoSize = true;
			this.cbOptimizedRaster.Location = new System.Drawing.Point(11, 184);
			this.cbOptimizedRaster.Name = "cbOptimizedRaster";
			this.cbOptimizedRaster.Size = new System.Drawing.Size(186, 17);
			this.cbOptimizedRaster.TabIndex = 44;
			this.cbOptimizedRaster.Text = "Optimized Raster (Horizontal Only)";
			this.cbOptimizedRaster.UseVisualStyleBackColor = true;
			this.cbOptimizedRaster.CheckedChanged += new System.EventHandler(this.cbOptimizedRaster_CheckedChanged);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(5, 145);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(114, 13);
			this.label20.TabIndex = 43;
			this.label20.Text = "Experimental Features:";
			// 
			// cbLaserDecimal
			// 
			this.cbLaserDecimal.AutoSize = true;
			this.cbLaserDecimal.Location = new System.Drawing.Point(10, 161);
			this.cbLaserDecimal.Name = "cbLaserDecimal";
			this.cbLaserDecimal.Size = new System.Drawing.Size(135, 17);
			this.cbLaserDecimal.TabIndex = 42;
			this.cbLaserDecimal.Text = "Enable Decimal Values";
			this.cbLaserDecimal.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnNew);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Controls.Add(this.tbProfileName);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.cmbProfile);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.lblFeedRateUnits);
			this.groupBox1.Controls.Add(this.tbFeedRate);
			this.groupBox1.Controls.Add(this.tbProfilePower);
			this.groupBox1.Location = new System.Drawing.Point(1, 295);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(198, 225);
			this.groupBox1.TabIndex = 41;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Profiles";
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.DarkRed;
			this.btnDelete.Location = new System.Drawing.Point(161, 150);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(27, 23);
			this.btnDelete.TabIndex = 51;
			this.btnDelete.Text = "X";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(80, 150);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tbProfileName
			// 
			this.tbProfileName.Location = new System.Drawing.Point(86, 46);
			this.tbProfileName.Name = "tbProfileName";
			this.tbProfileName.Size = new System.Drawing.Size(104, 20);
			this.tbProfileName.TabIndex = 50;
			this.tbProfileName.Text = "Max";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(8, 49);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(67, 13);
			this.label15.TabIndex = 49;
			this.label15.Text = "Profile Name";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(7, 101);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(49, 13);
			this.label14.TabIndex = 48;
			this.label14.Text = "Feedrate";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(7, 75);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(72, 13);
			this.label13.TabIndex = 2;
			this.label13.Text = "Output Power";
			// 
			// cmbProfile
			// 
			this.cmbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProfile.FormattingEnabled = true;
			this.cmbProfile.Location = new System.Drawing.Point(4, 19);
			this.cmbProfile.Name = "cmbProfile";
			this.cmbProfile.Size = new System.Drawing.Size(188, 21);
			this.cmbProfile.TabIndex = 47;
			this.cmbProfile.SelectedIndexChanged += new System.EventHandler(this.cmbProfile_SelectedIndexChanged);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(125, 76);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(15, 13);
			this.label19.TabIndex = 36;
			this.label19.Text = "%";
			// 
			// lblFeedRateUnits
			// 
			this.lblFeedRateUnits.AutoSize = true;
			this.lblFeedRateUnits.Location = new System.Drawing.Point(120, 101);
			this.lblFeedRateUnits.Name = "lblFeedRateUnits";
			this.lblFeedRateUnits.Size = new System.Drawing.Size(44, 13);
			this.lblFeedRateUnits.TabIndex = 5;
			this.lblFeedRateUnits.Text = "mm/min";
			// 
			// tbFeedRate
			// 
			this.tbFeedRate.Location = new System.Drawing.Point(86, 98);
			this.tbFeedRate.Name = "tbFeedRate";
			this.tbFeedRate.Size = new System.Drawing.Size(33, 20);
			this.tbFeedRate.TabIndex = 3;
			this.tbFeedRate.Text = "1000";
			this.tbFeedRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tbProfilePower
			// 
			this.tbProfilePower.Location = new System.Drawing.Point(86, 72);
			this.tbProfilePower.Name = "tbProfilePower";
			this.tbProfilePower.Size = new System.Drawing.Size(33, 20);
			this.tbProfilePower.TabIndex = 2;
			this.tbProfilePower.Text = "100";
			this.tbProfilePower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(7, 66);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(184, 66);
			this.label10.TabIndex = 30;
			this.label10.Text = "GrayScale values (0-255) will be interpolated between Min and Max Power Values.";
			// 
			// tbLaserMax
			// 
			this.tbLaserMax.Location = new System.Drawing.Point(104, 34);
			this.tbLaserMax.Name = "tbLaserMax";
			this.tbLaserMax.Size = new System.Drawing.Size(37, 20);
			this.tbLaserMax.TabIndex = 1;
			this.tbLaserMax.Text = "255";
			this.tbLaserMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLaserMax_KeyPress);
			// 
			// tbLaserMin
			// 
			this.tbLaserMin.Location = new System.Drawing.Point(8, 34);
			this.tbLaserMin.Name = "tbLaserMin";
			this.tbLaserMin.Size = new System.Drawing.Size(35, 20);
			this.tbLaserMin.TabIndex = 0;
			this.tbLaserMin.Text = "0";
			this.tbLaserMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLaserMin_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(104, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Max Power";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Min Power";
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
			this.tabPage1.Controls.Add(this.groupBox7);
			this.tabPage1.Controls.Add(this.groupBox6);
			this.tabPage1.Controls.Add(this.groupBox5);
			this.tabPage1.Controls.Add(this.groupBox4);
			this.tabPage1.Controls.Add(this.gbDimensions);
			this.tabPage1.Controls.Add(this.btnCheckOrig);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(200, 526);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Image";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.ori8);
			this.groupBox7.Controls.Add(this.ori7);
			this.groupBox7.Controls.Add(this.ori6);
			this.groupBox7.Controls.Add(this.ori5);
			this.groupBox7.Controls.Add(this.ori4);
			this.groupBox7.Controls.Add(this.ori3);
			this.groupBox7.Controls.Add(this.ori2);
			this.groupBox7.Controls.Add(this.ori1);
			this.groupBox7.Controls.Add(this.ori0);
			this.groupBox7.Location = new System.Drawing.Point(1, 417);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(99, 106);
			this.groupBox7.TabIndex = 28;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Origin";
			// 
			// ori8
			// 
			this.ori8.AutoSize = true;
			this.ori8.Location = new System.Drawing.Point(69, 26);
			this.ori8.Name = "ori8";
			this.ori8.Size = new System.Drawing.Size(14, 13);
			this.ori8.TabIndex = 8;
			this.ori8.Tag = "ori8";
			this.ori8.UseVisualStyleBackColor = true;
			// 
			// ori7
			// 
			this.ori7.AutoSize = true;
			this.ori7.Location = new System.Drawing.Point(40, 26);
			this.ori7.Name = "ori7";
			this.ori7.Size = new System.Drawing.Size(14, 13);
			this.ori7.TabIndex = 7;
			this.ori7.Tag = "ori7";
			this.ori7.UseVisualStyleBackColor = true;
			// 
			// ori6
			// 
			this.ori6.AutoSize = true;
			this.ori6.Location = new System.Drawing.Point(12, 26);
			this.ori6.Name = "ori6";
			this.ori6.Size = new System.Drawing.Size(14, 13);
			this.ori6.TabIndex = 6;
			this.ori6.Tag = "ori6";
			this.ori6.UseVisualStyleBackColor = true;
			// 
			// ori5
			// 
			this.ori5.AutoSize = true;
			this.ori5.Location = new System.Drawing.Point(69, 50);
			this.ori5.Name = "ori5";
			this.ori5.Size = new System.Drawing.Size(14, 13);
			this.ori5.TabIndex = 5;
			this.ori5.Tag = "ori5";
			this.ori5.UseVisualStyleBackColor = true;
			// 
			// ori4
			// 
			this.ori4.AutoSize = true;
			this.ori4.Location = new System.Drawing.Point(40, 50);
			this.ori4.Name = "ori4";
			this.ori4.Size = new System.Drawing.Size(14, 13);
			this.ori4.TabIndex = 4;
			this.ori4.Tag = "ori4";
			this.ori4.UseVisualStyleBackColor = true;
			// 
			// ori3
			// 
			this.ori3.AutoSize = true;
			this.ori3.Location = new System.Drawing.Point(12, 50);
			this.ori3.Name = "ori3";
			this.ori3.Size = new System.Drawing.Size(14, 13);
			this.ori3.TabIndex = 3;
			this.ori3.Tag = "ori3";
			this.ori3.UseVisualStyleBackColor = true;
			// 
			// ori2
			// 
			this.ori2.AutoSize = true;
			this.ori2.Location = new System.Drawing.Point(69, 75);
			this.ori2.Name = "ori2";
			this.ori2.Size = new System.Drawing.Size(14, 13);
			this.ori2.TabIndex = 2;
			this.ori2.Tag = "ori2";
			this.ori2.UseVisualStyleBackColor = true;
			// 
			// ori1
			// 
			this.ori1.AutoSize = true;
			this.ori1.Location = new System.Drawing.Point(40, 75);
			this.ori1.Name = "ori1";
			this.ori1.Size = new System.Drawing.Size(14, 13);
			this.ori1.TabIndex = 1;
			this.ori1.Tag = "ori1";
			this.ori1.UseVisualStyleBackColor = true;
			// 
			// ori0
			// 
			this.ori0.AutoSize = true;
			this.ori0.Checked = true;
			this.ori0.Location = new System.Drawing.Point(12, 75);
			this.ori0.Name = "ori0";
			this.ori0.Size = new System.Drawing.Size(14, 13);
			this.ori0.TabIndex = 0;
			this.ori0.TabStop = true;
			this.ori0.Tag = "ori0";
			this.ori0.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.cbDirthering);
			this.groupBox6.Location = new System.Drawing.Point(1, 368);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(196, 48);
			this.groupBox6.TabIndex = 27;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Mode";
			// 
			// cbDirthering
			// 
			this.cbDirthering.FormattingEnabled = true;
			this.cbDirthering.Items.AddRange(new object[] {
            "GrayScale 8 bit",
            "Dirthering FS 1 bit"});
			this.cbDirthering.Location = new System.Drawing.Point(9, 17);
			this.cbDirthering.Name = "cbDirthering";
			this.cbDirthering.Size = new System.Drawing.Size(169, 21);
			this.cbDirthering.TabIndex = 14;
			this.cbDirthering.Text = "GrayScale 8 bit";
			this.cbDirthering.SelectedIndexChanged += new System.EventHandler(this.cbDirthering_SelectedIndexChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.lblGamma);
			this.groupBox5.Controls.Add(this.tBarGamma);
			this.groupBox5.Controls.Add(this.lblBrightness);
			this.groupBox5.Controls.Add(this.tBarBrightness);
			this.groupBox5.Controls.Add(this.lblContrast);
			this.groupBox5.Controls.Add(this.tBarContrast);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Controls.Add(this.label2);
			this.groupBox5.Controls.Add(this.label1);
			this.groupBox5.Location = new System.Drawing.Point(1, 30);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(196, 218);
			this.groupBox5.TabIndex = 3;
			this.groupBox5.TabStop = false;
			// 
			// lblGamma
			// 
			this.lblGamma.AutoSize = true;
			this.lblGamma.Location = new System.Drawing.Point(86, 150);
			this.lblGamma.Name = "lblGamma";
			this.lblGamma.Size = new System.Drawing.Size(13, 13);
			this.lblGamma.TabIndex = 19;
			this.lblGamma.Text = "1";
			// 
			// tBarGamma
			// 
			this.tBarGamma.BackColor = System.Drawing.SystemColors.Window;
			this.tBarGamma.Location = new System.Drawing.Point(3, 164);
			this.tBarGamma.Maximum = 500;
			this.tBarGamma.Minimum = 1;
			this.tBarGamma.Name = "tBarGamma";
			this.tBarGamma.Size = new System.Drawing.Size(190, 45);
			this.tBarGamma.TabIndex = 2;
			this.tBarGamma.TickFrequency = 22;
			this.tBarGamma.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.tBarGamma.Value = 50;
			this.tBarGamma.Scroll += new System.EventHandler(this.tBarGamma_Scroll);
			// 
			// lblBrightness
			// 
			this.lblBrightness.AutoSize = true;
			this.lblBrightness.Location = new System.Drawing.Point(86, 17);
			this.lblBrightness.Name = "lblBrightness";
			this.lblBrightness.Size = new System.Drawing.Size(13, 13);
			this.lblBrightness.TabIndex = 16;
			this.lblBrightness.Text = "0";
			// 
			// tBarBrightness
			// 
			this.tBarBrightness.BackColor = System.Drawing.SystemColors.Window;
			this.tBarBrightness.Location = new System.Drawing.Point(3, 31);
			this.tBarBrightness.Maximum = 127;
			this.tBarBrightness.Minimum = -127;
			this.tBarBrightness.Name = "tBarBrightness";
			this.tBarBrightness.Size = new System.Drawing.Size(190, 45);
			this.tBarBrightness.TabIndex = 0;
			this.tBarBrightness.TickFrequency = 10;
			this.tBarBrightness.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.tBarBrightness.Scroll += new System.EventHandler(this.tBarBrightness_Scroll);
			// 
			// lblContrast
			// 
			this.lblContrast.AutoSize = true;
			this.lblContrast.Location = new System.Drawing.Point(86, 83);
			this.lblContrast.Name = "lblContrast";
			this.lblContrast.Size = new System.Drawing.Size(13, 13);
			this.lblContrast.TabIndex = 13;
			this.lblContrast.Text = "0";
			// 
			// tBarContrast
			// 
			this.tBarContrast.BackColor = System.Drawing.SystemColors.Window;
			this.tBarContrast.Location = new System.Drawing.Point(3, 97);
			this.tBarContrast.Maximum = 127;
			this.tBarContrast.Minimum = -127;
			this.tBarContrast.Name = "tBarContrast";
			this.tBarContrast.Size = new System.Drawing.Size(190, 45);
			this.tBarContrast.TabIndex = 1;
			this.tBarContrast.TickFrequency = 10;
			this.tBarContrast.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.tBarContrast.Scroll += new System.EventHandler(this.tBarContrast_Scroll);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "Gamma";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Brightness";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Contrast";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnInvert);
			this.groupBox4.Controls.Add(this.btnRotateLeft);
			this.groupBox4.Controls.Add(this.btnRotateRight);
			this.groupBox4.Controls.Add(this.btnVertMirror);
			this.groupBox4.Controls.Add(this.btnHorizMirror);
			this.groupBox4.Location = new System.Drawing.Point(1, 244);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(196, 54);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			// 
			// btnInvert
			// 
			this.btnInvert.BackgroundImage = global::_3dpBurnerImage2Gcode.Properties.Resources.inv2;
			this.btnInvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnInvert.Location = new System.Drawing.Point(155, 16);
			this.btnInvert.Name = "btnInvert";
			this.btnInvert.Size = new System.Drawing.Size(28, 28);
			this.btnInvert.TabIndex = 9;
			this.btnInvert.UseVisualStyleBackColor = true;
			this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
			// 
			// btnRotateLeft
			// 
			this.btnRotateLeft.AccessibleDescription = "";
			this.btnRotateLeft.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.btnRotateLeft.BackgroundImage = global::_3dpBurnerImage2Gcode.Properties.Resources.left;
			this.btnRotateLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRotateLeft.Location = new System.Drawing.Point(7, 16);
			this.btnRotateLeft.Name = "btnRotateLeft";
			this.btnRotateLeft.Size = new System.Drawing.Size(28, 28);
			this.btnRotateLeft.TabIndex = 5;
			this.btnRotateLeft.UseVisualStyleBackColor = true;
			this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
			// 
			// btnRotateRight
			// 
			this.btnRotateRight.BackgroundImage = global::_3dpBurnerImage2Gcode.Properties.Resources.right;
			this.btnRotateRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRotateRight.Location = new System.Drawing.Point(46, 16);
			this.btnRotateRight.Name = "btnRotateRight";
			this.btnRotateRight.Size = new System.Drawing.Size(28, 28);
			this.btnRotateRight.TabIndex = 6;
			this.btnRotateRight.UseVisualStyleBackColor = true;
			this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
			// 
			// btnVertMirror
			// 
			this.btnVertMirror.BackgroundImage = global::_3dpBurnerImage2Gcode.Properties.Resources.flip_vertical;
			this.btnVertMirror.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnVertMirror.Location = new System.Drawing.Point(119, 16);
			this.btnVertMirror.Name = "btnVertMirror";
			this.btnVertMirror.Size = new System.Drawing.Size(28, 28);
			this.btnVertMirror.TabIndex = 8;
			this.btnVertMirror.UseVisualStyleBackColor = true;
			this.btnVertMirror.Click += new System.EventHandler(this.btnVertMirror_Click);
			// 
			// btnHorizMirror
			// 
			this.btnHorizMirror.BackgroundImage = global::_3dpBurnerImage2Gcode.Properties.Resources.flip_horizontal;
			this.btnHorizMirror.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHorizMirror.Location = new System.Drawing.Point(83, 16);
			this.btnHorizMirror.Name = "btnHorizMirror";
			this.btnHorizMirror.Size = new System.Drawing.Size(28, 28);
			this.btnHorizMirror.TabIndex = 7;
			this.btnHorizMirror.UseVisualStyleBackColor = true;
			this.btnHorizMirror.Click += new System.EventHandler(this.btnHorizMirror_Click);
			// 
			// gbDimensions
			// 
			this.gbDimensions.Controls.Add(this.label11);
			this.gbDimensions.Controls.Add(this.tbRes);
			this.gbDimensions.Controls.Add(this.cbLockRatio);
			this.gbDimensions.Controls.Add(this.label9);
			this.gbDimensions.Controls.Add(this.tbHeight);
			this.gbDimensions.Controls.Add(this.label8);
			this.gbDimensions.Controls.Add(this.tbWidth);
			this.gbDimensions.Location = new System.Drawing.Point(1, 299);
			this.gbDimensions.Name = "gbDimensions";
			this.gbDimensions.Size = new System.Drawing.Size(196, 67);
			this.gbDimensions.TabIndex = 5;
			this.gbDimensions.TabStop = false;
			this.gbDimensions.Text = "Output (mm)";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(105, 43);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(34, 13);
			this.label11.TabIndex = 25;
			this.label11.Text = "Resol";
			// 
			// tbRes
			// 
			this.tbRes.Location = new System.Drawing.Point(142, 40);
			this.tbRes.Name = "tbRes";
			this.tbRes.Size = new System.Drawing.Size(34, 20);
			this.tbRes.TabIndex = 12;
			this.tbRes.Text = "0.18";
			this.tbRes.Enter += new System.EventHandler(this.tbRes_Enter);
			this.tbRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRes_KeyPress);
			this.tbRes.Leave += new System.EventHandler(this.tbRes_Leave);
			// 
			// cbLockRatio
			// 
			this.cbLockRatio.AutoSize = true;
			this.cbLockRatio.Checked = true;
			this.cbLockRatio.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbLockRatio.Location = new System.Drawing.Point(105, 20);
			this.cbLockRatio.Name = "cbLockRatio";
			this.cbLockRatio.Size = new System.Drawing.Size(82, 17);
			this.cbLockRatio.TabIndex = 13;
			this.cbLockRatio.Text = "Aspect ratio";
			this.cbLockRatio.UseVisualStyleBackColor = true;
			this.cbLockRatio.CheckedChanged += new System.EventHandler(this.cbLockRatio_CheckedChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 43);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 22;
			this.label9.Text = "Height";
			// 
			// tbHeight
			// 
			this.tbHeight.Location = new System.Drawing.Point(56, 40);
			this.tbHeight.Name = "tbHeight";
			this.tbHeight.Size = new System.Drawing.Size(43, 20);
			this.tbHeight.TabIndex = 11;
			this.tbHeight.Text = "100";
			this.tbHeight.Enter += new System.EventHandler(this.tbHeight_Enter);
			this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHeight_KeyPress);
			this.tbHeight.Leave += new System.EventHandler(this.tbHeight_Leave);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Width";
			// 
			// tbWidth
			// 
			this.tbWidth.Location = new System.Drawing.Point(56, 19);
			this.tbWidth.Name = "tbWidth";
			this.tbWidth.Size = new System.Drawing.Size(43, 20);
			this.tbWidth.TabIndex = 10;
			this.tbWidth.Text = "60";
			this.tbWidth.Enter += new System.EventHandler(this.tbWidth_Enter);
			this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWidth_KeyPress);
			this.tbWidth.Leave += new System.EventHandler(this.tbWidth_Leave);
			// 
			// btnCheckOrig
			// 
			this.btnCheckOrig.Location = new System.Drawing.Point(51, 6);
			this.btnCheckOrig.Name = "btnCheckOrig";
			this.btnCheckOrig.Size = new System.Drawing.Size(93, 23);
			this.btnCheckOrig.TabIndex = 1;
			this.btnCheckOrig.Text = "Check Original";
			this.btnCheckOrig.UseVisualStyleBackColor = true;
			this.btnCheckOrig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCheckOrig_MouseDown);
			this.btnCheckOrig.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCheckOrig_MouseUp);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 26);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(208, 552);
			this.tabControl1.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(207, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(668, 547);
			this.panel1.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(666, 542);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.unitsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(875, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip2";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.openToolStripMenuItem.Text = "Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoZoomToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// autoZoomToolStripMenuItem
			// 
			this.autoZoomToolStripMenuItem.CheckOnClick = true;
			this.autoZoomToolStripMenuItem.Name = "autoZoomToolStripMenuItem";
			this.autoZoomToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.autoZoomToolStripMenuItem.Text = "Preview AutoZoom";
			this.autoZoomToolStripMenuItem.Click += new System.EventHandler(this.autoZoomToolStripMenuItem_Click);
			// 
			// unitsToolStripMenuItem
			// 
			this.unitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metricmmToolStripMenuItem,
            this.imperialinToolStripMenuItem});
			this.unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
			this.unitsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.unitsToolStripMenuItem.Text = "Units";
			// 
			// metricmmToolStripMenuItem
			// 
			this.metricmmToolStripMenuItem.CheckOnClick = true;
			this.metricmmToolStripMenuItem.Name = "metricmmToolStripMenuItem";
			this.metricmmToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.metricmmToolStripMenuItem.Text = "Metric (mm)";
			this.metricmmToolStripMenuItem.Click += new System.EventHandler(this.metricmmToolStripMenuItem_Click);
			// 
			// imperialinToolStripMenuItem
			// 
			this.imperialinToolStripMenuItem.CheckOnClick = true;
			this.imperialinToolStripMenuItem.Name = "imperialinToolStripMenuItem";
			this.imperialinToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.imperialinToolStripMenuItem.Text = "Imperial (in)";
			this.imperialinToolStripMenuItem.Click += new System.EventHandler(this.imperialinToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(5, 150);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(69, 23);
			this.btnNew.TabIndex = 52;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(875, 599);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Image2Gcode";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.groupBoxOffCode.ResumeLayout(false);
			this.groupBoxOnCode.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tBarGamma)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBarBrightness)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBarContrast)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.gbDimensions.ResumeLayout(false);
			this.gbDimensions.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbEngravingPattern;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbUseS;
        private System.Windows.Forms.RadioButton rbUseZ;
        private System.Windows.Forms.CheckBox cbEdgeLines;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbPostGcode;
        private System.Windows.Forms.RichTextBox rtbPreGcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbDirthering;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblGamma;
        private System.Windows.Forms.TrackBar tBarGamma;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.TrackBar tBarBrightness;
        private System.Windows.Forms.Label lblContrast;
        private System.Windows.Forms.TrackBar tBarContrast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnRotateLeft;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Button btnVertMirror;
        private System.Windows.Forms.Button btnHorizMirror;
        private System.Windows.Forms.GroupBox gbDimensions;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.CheckBox cbLockRatio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Button btnCheckOrig;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbLaserMin;
        private System.Windows.Forms.TextBox tbLaserMax;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metricmmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imperialinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoZoomToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxOnCode;
        private System.Windows.Forms.GroupBox groupBoxOffCode;
        private System.Windows.Forms.ComboBox comboBoxOffCode;
        private System.Windows.Forms.ComboBox comboBoxOnCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblFeedRateUnits;
        private System.Windows.Forms.TextBox tbFeedRate;
        private System.Windows.Forms.TextBox tbProfilePower;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton ori8;
        private System.Windows.Forms.RadioButton ori7;
        private System.Windows.Forms.RadioButton ori6;
        private System.Windows.Forms.RadioButton ori5;
        private System.Windows.Forms.RadioButton ori4;
        private System.Windows.Forms.RadioButton ori3;
        private System.Windows.Forms.RadioButton ori2;
        private System.Windows.Forms.RadioButton ori1;
        private System.Windows.Forms.RadioButton ori0;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox cbLaserDecimal;
        private System.Windows.Forms.CheckBox cbOptimizedRaster;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbThreshold;
        private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ComboBox cmbProfile;
		private System.Windows.Forms.TextBox tbProfileName;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnNew;
	}
}

