namespace LTU_MATE_ROV_2019_2020_Control_Software {
	partial class MainInterface {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.ControlsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.KeyboardMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.JoystickMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ethernetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hardwarePingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.speedTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toggleLedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.simulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.KeyboardBtn = new System.Windows.Forms.RadioButton();
			this.PowerMeter = new Meters.LinearMeter();
			this.InputDataTimer = new System.Windows.Forms.Timer(this.components);
			this.JoystickBtn = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.TestBtnMeter = new Meters.IOMeter();
			this.TempLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.EulerX = new System.Windows.Forms.Label();
			this.EulerY = new System.Windows.Forms.Label();
			this.EulerZ = new System.Windows.Forms.Label();
			this.AccelX = new System.Windows.Forms.Label();
			this.AccelY = new System.Windows.Forms.Label();
			this.AccelZ = new System.Windows.Forms.Label();
			this.WaterTempLabel = new System.Windows.Forms.Label();
			this.PressureLabel = new System.Windows.Forms.Label();
			this.AltitudeLabel = new System.Windows.Forms.Label();
			this.DepthLabel = new System.Windows.Forms.Label();
			this.PosTrackBar = new System.Windows.Forms.TrackBar();
			this.MinTrackBar = new System.Windows.Forms.TrackBar();
			this.PosLabel = new System.Windows.Forms.Label();
			this.MaxTrackBar = new System.Windows.Forms.TrackBar();
			this.MinNum = new System.Windows.Forms.NumericUpDown();
			this.MaxNum = new System.Windows.Forms.NumericUpDown();
			this.EnableServo = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.MenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PosTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MinTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MaxTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MinNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MaxNum)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(468, 228);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// MenuStrip
			// 
			this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ControlsMenu,
            this.developerToolStripMenuItem,
            this.simulatorToolStripMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(938, 28);
			this.MenuStrip.TabIndex = 1;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// ControlsMenu
			// 
			this.ControlsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KeyboardMenu,
            this.JoystickMenu});
			this.ControlsMenu.Name = "ControlsMenu";
			this.ControlsMenu.Size = new System.Drawing.Size(76, 24);
			this.ControlsMenu.Text = "Controls";
			this.ControlsMenu.Click += new System.EventHandler(this.ControlsMenu_Click);
			// 
			// KeyboardMenu
			// 
			this.KeyboardMenu.Name = "KeyboardMenu";
			this.KeyboardMenu.Size = new System.Drawing.Size(148, 26);
			this.KeyboardMenu.Text = "Keyboard";
			this.KeyboardMenu.Click += new System.EventHandler(this.KeyboardMenu_Click);
			// 
			// JoystickMenu
			// 
			this.JoystickMenu.Name = "JoystickMenu";
			this.JoystickMenu.Size = new System.Drawing.Size(148, 26);
			this.JoystickMenu.Text = "Joystick";
			this.JoystickMenu.Click += new System.EventHandler(this.JoystickMenu_Click);
			// 
			// developerToolStripMenuItem
			// 
			this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveExcelToolStripMenuItem,
            this.saveCSVToolStripMenuItem,
            this.ethernetToolStripMenuItem,
            this.logToolStripMenuItem});
			this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
			this.developerToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
			this.developerToolStripMenuItem.Text = "Developer";
			// 
			// saveExcelToolStripMenuItem
			// 
			this.saveExcelToolStripMenuItem.Name = "saveExcelToolStripMenuItem";
			this.saveExcelToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.saveExcelToolStripMenuItem.Text = "Save Excel";
			this.saveExcelToolStripMenuItem.Click += new System.EventHandler(this.saveExcelToolStripMenuItem_Click);
			// 
			// saveCSVToolStripMenuItem
			// 
			this.saveCSVToolStripMenuItem.Name = "saveCSVToolStripMenuItem";
			this.saveCSVToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.saveCSVToolStripMenuItem.Text = "Save CSV";
			this.saveCSVToolStripMenuItem.Click += new System.EventHandler(this.saveCSVToolStripMenuItem_Click);
			// 
			// ethernetToolStripMenuItem
			// 
			this.ethernetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.hardwarePingToolStripMenuItem,
            this.pingToolStripMenuItem,
            this.speedTestToolStripMenuItem,
            this.toggleLedToolStripMenuItem});
			this.ethernetToolStripMenuItem.Name = "ethernetToolStripMenuItem";
			this.ethernetToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.ethernetToolStripMenuItem.Text = "Ethernet";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.connectToolStripMenuItem.Text = "Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.disconnectToolStripMenuItem.Text = "Disconnect";
			this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
			// 
			// hardwarePingToolStripMenuItem
			// 
			this.hardwarePingToolStripMenuItem.Name = "hardwarePingToolStripMenuItem";
			this.hardwarePingToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.hardwarePingToolStripMenuItem.Text = "Hardware Ping";
			this.hardwarePingToolStripMenuItem.Click += new System.EventHandler(this.hardwarePingToolStripMenuItem_Click);
			// 
			// pingToolStripMenuItem
			// 
			this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
			this.pingToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.pingToolStripMenuItem.Text = "Ping";
			this.pingToolStripMenuItem.Click += new System.EventHandler(this.pingToolStripMenuItem_Click);
			// 
			// speedTestToolStripMenuItem
			// 
			this.speedTestToolStripMenuItem.Name = "speedTestToolStripMenuItem";
			this.speedTestToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.speedTestToolStripMenuItem.Text = "Speed Test";
			this.speedTestToolStripMenuItem.Click += new System.EventHandler(this.speedTestToolStripMenuItem_Click);
			// 
			// toggleLedToolStripMenuItem
			// 
			this.toggleLedToolStripMenuItem.Name = "toggleLedToolStripMenuItem";
			this.toggleLedToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.toggleLedToolStripMenuItem.Text = "Toggle Led";
			this.toggleLedToolStripMenuItem.Click += new System.EventHandler(this.toggleLedToolStripMenuItem_Click);
			// 
			// logToolStripMenuItem
			// 
			this.logToolStripMenuItem.Name = "logToolStripMenuItem";
			this.logToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.logToolStripMenuItem.Text = "Log";
			this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
			// 
			// simulatorToolStripMenuItem
			// 
			this.simulatorToolStripMenuItem.Name = "simulatorToolStripMenuItem";
			this.simulatorToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
			this.simulatorToolStripMenuItem.Text = "Simulator";
			this.simulatorToolStripMenuItem.Click += new System.EventHandler(this.simulatorToolStripMenuItem_Click);
			// 
			// KeyboardBtn
			// 
			this.KeyboardBtn.AutoSize = true;
			this.KeyboardBtn.Location = new System.Drawing.Point(486, 31);
			this.KeyboardBtn.Name = "KeyboardBtn";
			this.KeyboardBtn.Size = new System.Drawing.Size(90, 21);
			this.KeyboardBtn.TabIndex = 3;
			this.KeyboardBtn.Text = "Keyboard";
			this.KeyboardBtn.UseVisualStyleBackColor = true;
			this.KeyboardBtn.CheckedChanged += new System.EventHandler(this.ControllerTypeButton_CheckedChanged);
			// 
			// PowerMeter
			// 
			this.PowerMeter.BackColor = System.Drawing.Color.White;
			this.PowerMeter.BorderColor = System.Drawing.Color.Black;
			this.PowerMeter.Horizontal = false;
			this.PowerMeter.Inverse = false;
			this.PowerMeter.Location = new System.Drawing.Point(680, 59);
			this.PowerMeter.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.PowerMeter.MeterColor = System.Drawing.Color.Red;
			this.PowerMeter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.PowerMeter.Name = "PowerMeter";
			this.PowerMeter.Size = new System.Drawing.Size(20, 200);
			this.PowerMeter.TabIndex = 4;
			this.PowerMeter.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.PowerMeter.ZeroValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// InputDataTimer
			// 
			this.InputDataTimer.Interval = 67;
			this.InputDataTimer.Tick += new System.EventHandler(this.InputDataTimer_Tick);
			// 
			// JoystickBtn
			// 
			this.JoystickBtn.AutoSize = true;
			this.JoystickBtn.Location = new System.Drawing.Point(486, 58);
			this.JoystickBtn.Name = "JoystickBtn";
			this.JoystickBtn.Size = new System.Drawing.Size(79, 21);
			this.JoystickBtn.TabIndex = 5;
			this.JoystickBtn.Text = "Joystick";
			this.JoystickBtn.UseVisualStyleBackColor = true;
			this.JoystickBtn.CheckedChanged += new System.EventHandler(this.ControllerTypeButton_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(851, 84);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Warn";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(851, 113);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Info";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(851, 142);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "Debug";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// TestBtnMeter
			// 
			this.TestBtnMeter.BorderColor = System.Drawing.Color.Black;
			this.TestBtnMeter.Location = new System.Drawing.Point(12, 265);
			this.TestBtnMeter.Name = "TestBtnMeter";
			this.TestBtnMeter.OffColor = System.Drawing.Color.Firebrick;
			this.TestBtnMeter.OnColor = System.Drawing.Color.Red;
			this.TestBtnMeter.Size = new System.Drawing.Size(35, 35);
			this.TestBtnMeter.Style = Meters.ButtonStyle.Round;
			this.TestBtnMeter.TabIndex = 9;
			this.TestBtnMeter.Text = "Test";
			this.TestBtnMeter.UseVisualStyleBackColor = true;
			this.TestBtnMeter.Value = false;
			// 
			// TempLabel
			// 
			this.TempLabel.AutoSize = true;
			this.TempLabel.Location = new System.Drawing.Point(12, 313);
			this.TempLabel.Name = "TempLabel";
			this.TempLabel.Size = new System.Drawing.Size(133, 17);
			this.TempLabel.TabIndex = 10;
			this.TempLabel.Text = "Temperature: -99*C";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 330);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 17);
			this.label1.TabIndex = 11;
			this.label1.Text = "Euler";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(223, 330);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 17);
			this.label2.TabIndex = 12;
			this.label2.Text = "Accel";
			// 
			// EulerX
			// 
			this.EulerX.AutoSize = true;
			this.EulerX.Location = new System.Drawing.Point(12, 347);
			this.EulerX.Name = "EulerX";
			this.EulerX.Size = new System.Drawing.Size(41, 17);
			this.EulerX.TabIndex = 13;
			this.EulerX.Text = "Euler";
			// 
			// EulerY
			// 
			this.EulerY.AutoSize = true;
			this.EulerY.Location = new System.Drawing.Point(12, 364);
			this.EulerY.Name = "EulerY";
			this.EulerY.Size = new System.Drawing.Size(41, 17);
			this.EulerY.TabIndex = 14;
			this.EulerY.Text = "Euler";
			// 
			// EulerZ
			// 
			this.EulerZ.AutoSize = true;
			this.EulerZ.Location = new System.Drawing.Point(12, 381);
			this.EulerZ.Name = "EulerZ";
			this.EulerZ.Size = new System.Drawing.Size(41, 17);
			this.EulerZ.TabIndex = 15;
			this.EulerZ.Text = "Euler";
			// 
			// AccelX
			// 
			this.AccelX.AutoSize = true;
			this.AccelX.Location = new System.Drawing.Point(223, 347);
			this.AccelX.Name = "AccelX";
			this.AccelX.Size = new System.Drawing.Size(42, 17);
			this.AccelX.TabIndex = 16;
			this.AccelX.Text = "Accel";
			// 
			// AccelY
			// 
			this.AccelY.AutoSize = true;
			this.AccelY.Location = new System.Drawing.Point(223, 364);
			this.AccelY.Name = "AccelY";
			this.AccelY.Size = new System.Drawing.Size(42, 17);
			this.AccelY.TabIndex = 17;
			this.AccelY.Text = "Accel";
			// 
			// AccelZ
			// 
			this.AccelZ.AutoSize = true;
			this.AccelZ.Location = new System.Drawing.Point(223, 381);
			this.AccelZ.Name = "AccelZ";
			this.AccelZ.Size = new System.Drawing.Size(42, 17);
			this.AccelZ.TabIndex = 18;
			this.AccelZ.Text = "Accel";
			// 
			// WaterTempLabel
			// 
			this.WaterTempLabel.AutoSize = true;
			this.WaterTempLabel.Location = new System.Drawing.Point(461, 274);
			this.WaterTempLabel.Name = "WaterTempLabel";
			this.WaterTempLabel.Size = new System.Drawing.Size(129, 17);
			this.WaterTempLabel.TabIndex = 19;
			this.WaterTempLabel.Text = "Water Temp: -99*C";
			// 
			// PressureLabel
			// 
			this.PressureLabel.AutoSize = true;
			this.PressureLabel.Location = new System.Drawing.Point(461, 291);
			this.PressureLabel.Name = "PressureLabel";
			this.PressureLabel.Size = new System.Drawing.Size(69, 17);
			this.PressureLabel.TabIndex = 20;
			this.PressureLabel.Text = "Pressure:";
			// 
			// AltitudeLabel
			// 
			this.AltitudeLabel.AutoSize = true;
			this.AltitudeLabel.Location = new System.Drawing.Point(461, 308);
			this.AltitudeLabel.Name = "AltitudeLabel";
			this.AltitudeLabel.Size = new System.Drawing.Size(63, 17);
			this.AltitudeLabel.TabIndex = 21;
			this.AltitudeLabel.Text = "Altitude: ";
			// 
			// DepthLabel
			// 
			this.DepthLabel.AutoSize = true;
			this.DepthLabel.Location = new System.Drawing.Point(461, 325);
			this.DepthLabel.Name = "DepthLabel";
			this.DepthLabel.Size = new System.Drawing.Size(54, 17);
			this.DepthLabel.TabIndex = 22;
			this.DepthLabel.Text = "Depth: ";
			// 
			// PosTrackBar
			// 
			this.PosTrackBar.Location = new System.Drawing.Point(461, 347);
			this.PosTrackBar.Maximum = 255;
			this.PosTrackBar.Name = "PosTrackBar";
			this.PosTrackBar.Size = new System.Drawing.Size(442, 56);
			this.PosTrackBar.TabIndex = 23;
			this.PosTrackBar.Scroll += new System.EventHandler(this.PosTrackBar_Scroll);
			// 
			// MinTrackBar
			// 
			this.MinTrackBar.Location = new System.Drawing.Point(461, 409);
			this.MinTrackBar.Maximum = 1499;
			this.MinTrackBar.Minimum = 500;
			this.MinTrackBar.Name = "MinTrackBar";
			this.MinTrackBar.Size = new System.Drawing.Size(442, 56);
			this.MinTrackBar.TabIndex = 24;
			this.MinTrackBar.Value = 500;
			this.MinTrackBar.Scroll += new System.EventHandler(this.MinTrackBar_Scroll);
			// 
			// PosLabel
			// 
			this.PosLabel.AutoSize = true;
			this.PosLabel.Location = new System.Drawing.Point(423, 364);
			this.PosLabel.Name = "PosLabel";
			this.PosLabel.Size = new System.Drawing.Size(32, 17);
			this.PosLabel.TabIndex = 25;
			this.PosLabel.Text = "255";
			// 
			// MaxTrackBar
			// 
			this.MaxTrackBar.Location = new System.Drawing.Point(461, 471);
			this.MaxTrackBar.Maximum = 2500;
			this.MaxTrackBar.Minimum = 1501;
			this.MaxTrackBar.Name = "MaxTrackBar";
			this.MaxTrackBar.Size = new System.Drawing.Size(442, 56);
			this.MaxTrackBar.TabIndex = 26;
			this.MaxTrackBar.Value = 1501;
			this.MaxTrackBar.Scroll += new System.EventHandler(this.MaxTrackBar_Scroll);
			// 
			// MinNum
			// 
			this.MinNum.Location = new System.Drawing.Point(375, 418);
			this.MinNum.Maximum = new decimal(new int[] {
            1499,
            0,
            0,
            0});
			this.MinNum.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.MinNum.Name = "MinNum";
			this.MinNum.Size = new System.Drawing.Size(80, 22);
			this.MinNum.TabIndex = 27;
			this.MinNum.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.MinNum.ValueChanged += new System.EventHandler(this.MinNum_ValueChanged);
			// 
			// MaxNum
			// 
			this.MaxNum.Location = new System.Drawing.Point(375, 471);
			this.MaxNum.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
			this.MaxNum.Minimum = new decimal(new int[] {
            1501,
            0,
            0,
            0});
			this.MaxNum.Name = "MaxNum";
			this.MaxNum.Size = new System.Drawing.Size(80, 22);
			this.MaxNum.TabIndex = 28;
			this.MaxNum.Value = new decimal(new int[] {
            1501,
            0,
            0,
            0});
			this.MaxNum.ValueChanged += new System.EventHandler(this.MaxNum_ValueChanged);
			// 
			// EnableServo
			// 
			this.EnableServo.AutoSize = true;
			this.EnableServo.Location = new System.Drawing.Point(748, 325);
			this.EnableServo.Name = "EnableServo";
			this.EnableServo.Size = new System.Drawing.Size(74, 21);
			this.EnableServo.TabIndex = 29;
			this.EnableServo.Text = "Enable";
			this.EnableServo.UseVisualStyleBackColor = true;
			this.EnableServo.CheckedChanged += new System.EventHandler(this.EnableServo_CheckedChanged);
			// 
			// MainInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 532);
			this.Controls.Add(this.EnableServo);
			this.Controls.Add(this.MaxNum);
			this.Controls.Add(this.MinNum);
			this.Controls.Add(this.MaxTrackBar);
			this.Controls.Add(this.PosLabel);
			this.Controls.Add(this.MinTrackBar);
			this.Controls.Add(this.PosTrackBar);
			this.Controls.Add(this.DepthLabel);
			this.Controls.Add(this.AltitudeLabel);
			this.Controls.Add(this.PressureLabel);
			this.Controls.Add(this.WaterTempLabel);
			this.Controls.Add(this.AccelZ);
			this.Controls.Add(this.AccelY);
			this.Controls.Add(this.AccelX);
			this.Controls.Add(this.EulerZ);
			this.Controls.Add(this.EulerY);
			this.Controls.Add(this.EulerX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TempLabel);
			this.Controls.Add(this.TestBtnMeter);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.JoystickBtn);
			this.Controls.Add(this.PowerMeter);
			this.Controls.Add(this.KeyboardBtn);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.MenuStrip);
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "MainInterface";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainInterface_FormClosing);
			this.Load += new System.EventHandler(this.MainInterface_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PosTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MinTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MaxTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MinNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MaxNum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem ControlsMenu;
		private System.Windows.Forms.RadioButton KeyboardBtn;
		private System.Windows.Forms.ToolStripMenuItem JoystickMenu;
		private System.Windows.Forms.ToolStripMenuItem KeyboardMenu;
		private Meters.LinearMeter PowerMeter;
		private System.Windows.Forms.Timer InputDataTimer;
		private System.Windows.Forms.RadioButton JoystickBtn;
		private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveExcelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveCSVToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ethernetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem speedTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toggleLedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private Meters.IOMeter TestBtnMeter;
		private System.Windows.Forms.ToolStripMenuItem hardwarePingToolStripMenuItem;
		private System.Windows.Forms.Label TempLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label EulerX;
		private System.Windows.Forms.Label EulerY;
		private System.Windows.Forms.Label EulerZ;
		private System.Windows.Forms.Label AccelX;
		private System.Windows.Forms.Label AccelY;
		private System.Windows.Forms.Label AccelZ;
		private System.Windows.Forms.ToolStripMenuItem simulatorToolStripMenuItem;
		private System.Windows.Forms.Label WaterTempLabel;
		private System.Windows.Forms.Label PressureLabel;
		private System.Windows.Forms.Label AltitudeLabel;
		private System.Windows.Forms.Label DepthLabel;
		private System.Windows.Forms.TrackBar PosTrackBar;
		private System.Windows.Forms.TrackBar MinTrackBar;
		private System.Windows.Forms.Label PosLabel;
		private System.Windows.Forms.TrackBar MaxTrackBar;
		private System.Windows.Forms.NumericUpDown MinNum;
		private System.Windows.Forms.NumericUpDown MaxNum;
		private System.Windows.Forms.CheckBox EnableServo;
	}
}

