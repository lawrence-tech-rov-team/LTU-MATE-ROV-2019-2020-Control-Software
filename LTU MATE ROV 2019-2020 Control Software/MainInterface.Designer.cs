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
			this.PosNum = new System.Windows.Forms.NumericUpDown();
			this.EnableServo = new System.Windows.Forms.CheckBox();
			this.TestBtn2 = new Meters.IOMeter();
			this.LedBtn = new System.Windows.Forms.Button();
			this.LetterBox = new System.Windows.Forms.ComboBox();
			this.NumberBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.MenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PosTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PosNum)).BeginInit();
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
			this.KeyboardMenu.Size = new System.Drawing.Size(216, 26);
			this.KeyboardMenu.Text = "Keyboard";
			this.KeyboardMenu.Click += new System.EventHandler(this.KeyboardMenu_Click);
			// 
			// JoystickMenu
			// 
			this.JoystickMenu.Name = "JoystickMenu";
			this.JoystickMenu.Size = new System.Drawing.Size(216, 26);
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
            this.hardwarePingToolStripMenuItem});
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
			this.PosTrackBar.Maximum = 3000;
			this.PosTrackBar.Name = "PosTrackBar";
			this.PosTrackBar.Size = new System.Drawing.Size(442, 56);
			this.PosTrackBar.TabIndex = 23;
			this.PosTrackBar.Value = 1500;
			this.PosTrackBar.Scroll += new System.EventHandler(this.PosTrackBar_Scroll);
			// 
			// PosNum
			// 
			this.PosNum.Location = new System.Drawing.Point(375, 364);
			this.PosNum.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
			this.PosNum.Name = "PosNum";
			this.PosNum.Size = new System.Drawing.Size(80, 22);
			this.PosNum.TabIndex = 27;
			this.PosNum.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
			this.PosNum.ValueChanged += new System.EventHandler(this.PosNum_ValueChanged);
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
			// TestBtn2
			// 
			this.TestBtn2.BorderColor = System.Drawing.Color.Black;
			this.TestBtn2.Location = new System.Drawing.Point(53, 265);
			this.TestBtn2.Name = "TestBtn2";
			this.TestBtn2.OffColor = System.Drawing.Color.Firebrick;
			this.TestBtn2.OnColor = System.Drawing.Color.Red;
			this.TestBtn2.Size = new System.Drawing.Size(35, 35);
			this.TestBtn2.Style = Meters.ButtonStyle.Round;
			this.TestBtn2.TabIndex = 32;
			this.TestBtn2.Text = "Test";
			this.TestBtn2.UseVisualStyleBackColor = true;
			this.TestBtn2.Value = false;
			// 
			// LedBtn
			// 
			this.LedBtn.Location = new System.Drawing.Point(15, 469);
			this.LedBtn.Name = "LedBtn";
			this.LedBtn.Size = new System.Drawing.Size(83, 32);
			this.LedBtn.TabIndex = 33;
			this.LedBtn.Text = "LED";
			this.LedBtn.UseVisualStyleBackColor = true;
			this.LedBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LedBtn_MouseDown);
			this.LedBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LedBtn_MouseUp);
			// 
			// LetterBox
			// 
			this.LetterBox.FormattingEnabled = true;
			this.LetterBox.Location = new System.Drawing.Point(469, 420);
			this.LetterBox.Name = "LetterBox";
			this.LetterBox.Size = new System.Drawing.Size(121, 24);
			this.LetterBox.TabIndex = 35;
			this.LetterBox.SelectedIndexChanged += new System.EventHandler(this.LetterBox_SelectedIndexChanged);
			// 
			// NumberBox
			// 
			this.NumberBox.FormattingEnabled = true;
			this.NumberBox.Location = new System.Drawing.Point(596, 420);
			this.NumberBox.Name = "NumberBox";
			this.NumberBox.Size = new System.Drawing.Size(121, 24);
			this.NumberBox.TabIndex = 36;
			this.NumberBox.SelectedIndexChanged += new System.EventHandler(this.NumberBox_SelectedIndexChanged);
			// 
			// MainInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 532);
			this.Controls.Add(this.NumberBox);
			this.Controls.Add(this.LetterBox);
			this.Controls.Add(this.LedBtn);
			this.Controls.Add(this.TestBtn2);
			this.Controls.Add(this.EnableServo);
			this.Controls.Add(this.PosNum);
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
			((System.ComponentModel.ISupportInitialize)(this.PosNum)).EndInit();
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
		private System.Windows.Forms.NumericUpDown PosNum;
		private System.Windows.Forms.CheckBox EnableServo;
		private Meters.IOMeter TestBtn2;
		private System.Windows.Forms.Button LedBtn;
		private System.Windows.Forms.ComboBox LetterBox;
		private System.Windows.Forms.ComboBox NumberBox;
	}
}

