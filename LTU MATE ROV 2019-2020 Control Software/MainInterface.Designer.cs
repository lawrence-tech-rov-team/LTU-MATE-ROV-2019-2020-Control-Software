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
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.ControlsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sensorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ethernetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hardwarePingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.simulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.InputDataTimer = new System.Windows.Forms.Timer(this.components);
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
			this.TestBtn2 = new Meters.IOMeter();
			this.LedBtn = new System.Windows.Forms.Button();
			this.InputComboBox = new System.Windows.Forms.ComboBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.CameraView1 = new Emgu.CV.UI.ImageBox();
			this.ImageUpdateTimer = new System.Windows.Forms.Timer(this.components);
			this.MenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CameraView1)).BeginInit();
			this.SuspendLayout();
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
			this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.MenuStrip.Size = new System.Drawing.Size(704, 24);
			this.MenuStrip.TabIndex = 1;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// ControlsMenu
			// 
			this.ControlsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.sensorsToolStripMenuItem});
			this.ControlsMenu.Name = "ControlsMenu";
			this.ControlsMenu.Size = new System.Drawing.Size(54, 20);
			this.ControlsMenu.Text = "Debug";
			this.ControlsMenu.Click += new System.EventHandler(this.ControlsMenu_Click);
			// 
			// inputToolStripMenuItem
			// 
			this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
			this.inputToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.inputToolStripMenuItem.Text = "Input";
			this.inputToolStripMenuItem.Click += new System.EventHandler(this.InputToolStripMenuItem_Click);
			// 
			// sensorsToolStripMenuItem
			// 
			this.sensorsToolStripMenuItem.Name = "sensorsToolStripMenuItem";
			this.sensorsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.sensorsToolStripMenuItem.Text = "Sensors";
			this.sensorsToolStripMenuItem.Click += new System.EventHandler(this.SensorsToolStripMenuItem_Click);
			// 
			// developerToolStripMenuItem
			// 
			this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveExcelToolStripMenuItem,
            this.saveCSVToolStripMenuItem,
            this.ethernetToolStripMenuItem,
            this.logToolStripMenuItem});
			this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
			this.developerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.developerToolStripMenuItem.Text = "Developer";
			// 
			// saveExcelToolStripMenuItem
			// 
			this.saveExcelToolStripMenuItem.Name = "saveExcelToolStripMenuItem";
			this.saveExcelToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.saveExcelToolStripMenuItem.Text = "Save Excel";
			this.saveExcelToolStripMenuItem.Click += new System.EventHandler(this.SaveExcelToolStripMenuItem_Click);
			// 
			// saveCSVToolStripMenuItem
			// 
			this.saveCSVToolStripMenuItem.Name = "saveCSVToolStripMenuItem";
			this.saveCSVToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.saveCSVToolStripMenuItem.Text = "Save CSV";
			this.saveCSVToolStripMenuItem.Click += new System.EventHandler(this.SaveCSVToolStripMenuItem_Click);
			// 
			// ethernetToolStripMenuItem
			// 
			this.ethernetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.hardwarePingToolStripMenuItem});
			this.ethernetToolStripMenuItem.Name = "ethernetToolStripMenuItem";
			this.ethernetToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.ethernetToolStripMenuItem.Text = "Ethernet";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.connectToolStripMenuItem.Text = "Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.disconnectToolStripMenuItem.Text = "Disconnect";
			this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
			// 
			// hardwarePingToolStripMenuItem
			// 
			this.hardwarePingToolStripMenuItem.Name = "hardwarePingToolStripMenuItem";
			this.hardwarePingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.hardwarePingToolStripMenuItem.Text = "Hardware Ping";
			this.hardwarePingToolStripMenuItem.Click += new System.EventHandler(this.HardwarePingToolStripMenuItem_Click);
			// 
			// logToolStripMenuItem
			// 
			this.logToolStripMenuItem.Name = "logToolStripMenuItem";
			this.logToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.logToolStripMenuItem.Text = "Log";
			this.logToolStripMenuItem.Click += new System.EventHandler(this.LogToolStripMenuItem_Click);
			// 
			// simulatorToolStripMenuItem
			// 
			this.simulatorToolStripMenuItem.Name = "simulatorToolStripMenuItem";
			this.simulatorToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.simulatorToolStripMenuItem.Text = "Simulator";
			this.simulatorToolStripMenuItem.Click += new System.EventHandler(this.SimulatorToolStripMenuItem_Click);
			// 
			// InputDataTimer
			// 
			this.InputDataTimer.Interval = 67;
			this.InputDataTimer.Tick += new System.EventHandler(this.InputDataTimer_Tick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(638, 68);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 19);
			this.button1.TabIndex = 6;
			this.button1.Text = "Warn";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(638, 92);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 19);
			this.button2.TabIndex = 7;
			this.button2.Text = "Info";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(638, 115);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(56, 19);
			this.button3.TabIndex = 8;
			this.button3.Text = "Debug";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// TestBtnMeter
			// 
			this.TestBtnMeter.BorderColor = System.Drawing.Color.Black;
			this.TestBtnMeter.Location = new System.Drawing.Point(9, 215);
			this.TestBtnMeter.Margin = new System.Windows.Forms.Padding(2);
			this.TestBtnMeter.Name = "TestBtnMeter";
			this.TestBtnMeter.OffColor = System.Drawing.Color.Firebrick;
			this.TestBtnMeter.OnColor = System.Drawing.Color.Red;
			this.TestBtnMeter.Size = new System.Drawing.Size(26, 28);
			this.TestBtnMeter.Style = Meters.ButtonStyle.Round;
			this.TestBtnMeter.TabIndex = 9;
			this.TestBtnMeter.Text = "Test";
			this.TestBtnMeter.UseVisualStyleBackColor = true;
			this.TestBtnMeter.Value = false;
			// 
			// TempLabel
			// 
			this.TempLabel.AutoSize = true;
			this.TempLabel.Location = new System.Drawing.Point(9, 254);
			this.TempLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TempLabel.Name = "TempLabel";
			this.TempLabel.Size = new System.Drawing.Size(99, 13);
			this.TempLabel.TabIndex = 10;
			this.TempLabel.Text = "Temperature: -99*C";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 268);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Euler";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(167, 268);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Accel";
			// 
			// EulerX
			// 
			this.EulerX.AutoSize = true;
			this.EulerX.Location = new System.Drawing.Point(9, 282);
			this.EulerX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.EulerX.Name = "EulerX";
			this.EulerX.Size = new System.Drawing.Size(31, 13);
			this.EulerX.TabIndex = 13;
			this.EulerX.Text = "Euler";
			// 
			// EulerY
			// 
			this.EulerY.AutoSize = true;
			this.EulerY.Location = new System.Drawing.Point(9, 296);
			this.EulerY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.EulerY.Name = "EulerY";
			this.EulerY.Size = new System.Drawing.Size(31, 13);
			this.EulerY.TabIndex = 14;
			this.EulerY.Text = "Euler";
			// 
			// EulerZ
			// 
			this.EulerZ.AutoSize = true;
			this.EulerZ.Location = new System.Drawing.Point(9, 310);
			this.EulerZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.EulerZ.Name = "EulerZ";
			this.EulerZ.Size = new System.Drawing.Size(31, 13);
			this.EulerZ.TabIndex = 15;
			this.EulerZ.Text = "Euler";
			// 
			// AccelX
			// 
			this.AccelX.AutoSize = true;
			this.AccelX.Location = new System.Drawing.Point(167, 282);
			this.AccelX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.AccelX.Name = "AccelX";
			this.AccelX.Size = new System.Drawing.Size(34, 13);
			this.AccelX.TabIndex = 16;
			this.AccelX.Text = "Accel";
			// 
			// AccelY
			// 
			this.AccelY.AutoSize = true;
			this.AccelY.Location = new System.Drawing.Point(167, 296);
			this.AccelY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.AccelY.Name = "AccelY";
			this.AccelY.Size = new System.Drawing.Size(34, 13);
			this.AccelY.TabIndex = 17;
			this.AccelY.Text = "Accel";
			// 
			// AccelZ
			// 
			this.AccelZ.AutoSize = true;
			this.AccelZ.Location = new System.Drawing.Point(167, 310);
			this.AccelZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.AccelZ.Name = "AccelZ";
			this.AccelZ.Size = new System.Drawing.Size(34, 13);
			this.AccelZ.TabIndex = 18;
			this.AccelZ.Text = "Accel";
			// 
			// WaterTempLabel
			// 
			this.WaterTempLabel.AutoSize = true;
			this.WaterTempLabel.Location = new System.Drawing.Point(346, 223);
			this.WaterTempLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.WaterTempLabel.Name = "WaterTempLabel";
			this.WaterTempLabel.Size = new System.Drawing.Size(98, 13);
			this.WaterTempLabel.TabIndex = 19;
			this.WaterTempLabel.Text = "Water Temp: -99*C";
			// 
			// PressureLabel
			// 
			this.PressureLabel.AutoSize = true;
			this.PressureLabel.Location = new System.Drawing.Point(346, 236);
			this.PressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.PressureLabel.Name = "PressureLabel";
			this.PressureLabel.Size = new System.Drawing.Size(51, 13);
			this.PressureLabel.TabIndex = 20;
			this.PressureLabel.Text = "Pressure:";
			// 
			// AltitudeLabel
			// 
			this.AltitudeLabel.AutoSize = true;
			this.AltitudeLabel.Location = new System.Drawing.Point(346, 250);
			this.AltitudeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.AltitudeLabel.Name = "AltitudeLabel";
			this.AltitudeLabel.Size = new System.Drawing.Size(48, 13);
			this.AltitudeLabel.TabIndex = 21;
			this.AltitudeLabel.Text = "Altitude: ";
			// 
			// DepthLabel
			// 
			this.DepthLabel.AutoSize = true;
			this.DepthLabel.Location = new System.Drawing.Point(346, 264);
			this.DepthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DepthLabel.Name = "DepthLabel";
			this.DepthLabel.Size = new System.Drawing.Size(42, 13);
			this.DepthLabel.TabIndex = 22;
			this.DepthLabel.Text = "Depth: ";
			// 
			// TestBtn2
			// 
			this.TestBtn2.BorderColor = System.Drawing.Color.Black;
			this.TestBtn2.Location = new System.Drawing.Point(40, 215);
			this.TestBtn2.Margin = new System.Windows.Forms.Padding(2);
			this.TestBtn2.Name = "TestBtn2";
			this.TestBtn2.OffColor = System.Drawing.Color.Firebrick;
			this.TestBtn2.OnColor = System.Drawing.Color.Red;
			this.TestBtn2.Size = new System.Drawing.Size(26, 28);
			this.TestBtn2.Style = Meters.ButtonStyle.Round;
			this.TestBtn2.TabIndex = 32;
			this.TestBtn2.Text = "Test";
			this.TestBtn2.UseVisualStyleBackColor = true;
			this.TestBtn2.Value = false;
			// 
			// LedBtn
			// 
			this.LedBtn.Location = new System.Drawing.Point(11, 381);
			this.LedBtn.Margin = new System.Windows.Forms.Padding(2);
			this.LedBtn.Name = "LedBtn";
			this.LedBtn.Size = new System.Drawing.Size(62, 26);
			this.LedBtn.TabIndex = 33;
			this.LedBtn.Text = "LED";
			this.LedBtn.UseVisualStyleBackColor = true;
			this.LedBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LedBtn_MouseDown);
			this.LedBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LedBtn_MouseUp);
			// 
			// InputComboBox
			// 
			this.InputComboBox.FormattingEnabled = true;
			this.InputComboBox.Location = new System.Drawing.Point(364, 25);
			this.InputComboBox.Margin = new System.Windows.Forms.Padding(2);
			this.InputComboBox.Name = "InputComboBox";
			this.InputComboBox.Size = new System.Drawing.Size(106, 21);
			this.InputComboBox.TabIndex = 37;
			this.InputComboBox.DropDown += new System.EventHandler(this.InputComboBox_DropDown);
			this.InputComboBox.SelectedIndexChanged += new System.EventHandler(this.InputComboBox_SelectedIndexChanged);
			// 
			// CameraView1
			// 
			this.CameraView1.Location = new System.Drawing.Point(12, 27);
			this.CameraView1.Name = "CameraView1";
			this.CameraView1.Size = new System.Drawing.Size(347, 183);
			this.CameraView1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CameraView1.TabIndex = 2;
			this.CameraView1.TabStop = false;
			// 
			// ImageUpdateTimer
			// 
			this.ImageUpdateTimer.Interval = 67;
			this.ImageUpdateTimer.Tick += new System.EventHandler(this.ImageUpdateTimer_Tick);
			// 
			// MainInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 432);
			this.Controls.Add(this.CameraView1);
			this.Controls.Add(this.InputComboBox);
			this.Controls.Add(this.LedBtn);
			this.Controls.Add(this.TestBtn2);
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
			this.Controls.Add(this.MenuStrip);
			this.MainMenuStrip = this.MenuStrip;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainInterface";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainInterface_FormClosing);
			this.Load += new System.EventHandler(this.MainInterface_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainInterface_Paint);
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CameraView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem ControlsMenu;
		private System.Windows.Forms.Timer InputDataTimer;
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
		private Meters.IOMeter TestBtn2;
		private System.Windows.Forms.Button LedBtn;
		private System.Windows.Forms.ComboBox InputComboBox;
		private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sensorsToolStripMenuItem;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Emgu.CV.UI.ImageBox CameraView1;
		private System.Windows.Forms.Timer ImageUpdateTimer;
	}
}

