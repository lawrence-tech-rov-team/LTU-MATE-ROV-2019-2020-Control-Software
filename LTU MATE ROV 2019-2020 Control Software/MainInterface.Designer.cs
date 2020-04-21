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
			this.robotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.disconnectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ControlsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sensorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.TestBtn2 = new Meters.IOMeter();
			this.LedBtn = new System.Windows.Forms.Button();
			this.InputComboBox = new System.Windows.Forms.ComboBox();
			this.CameraView1 = new Emgu.CV.UI.ImageBox();
			this.ImageUpdateTimer = new System.Windows.Forms.Timer(this.components);
			this.CameraView2 = new Emgu.CV.UI.ImageBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.MenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CameraView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CameraView2)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MenuStrip
			// 
			this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robotToolStripMenuItem,
            this.ControlsMenu,
            this.developerToolStripMenuItem,
            this.simulatorToolStripMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.MenuStrip.Size = new System.Drawing.Size(959, 24);
			this.MenuStrip.TabIndex = 1;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// robotToolStripMenuItem
			// 
			this.robotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem1,
            this.disconnectToolStripMenuItem1});
			this.robotToolStripMenuItem.Name = "robotToolStripMenuItem";
			this.robotToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.robotToolStripMenuItem.Text = "Robot";
			// 
			// connectToolStripMenuItem1
			// 
			this.connectToolStripMenuItem1.Name = "connectToolStripMenuItem1";
			this.connectToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
			this.connectToolStripMenuItem1.Text = "Connect";
			this.connectToolStripMenuItem1.Click += new System.EventHandler(this.ConnectRobot_MenuClick);
			// 
			// disconnectToolStripMenuItem1
			// 
			this.disconnectToolStripMenuItem1.Name = "disconnectToolStripMenuItem1";
			this.disconnectToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
			this.disconnectToolStripMenuItem1.Text = "Disconnect";
			this.disconnectToolStripMenuItem1.Click += new System.EventHandler(this.DisconnectRobot_MenuClick);
			// 
			// ControlsMenu
			// 
			this.ControlsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.sensorsToolStripMenuItem});
			this.ControlsMenu.Name = "ControlsMenu";
			this.ControlsMenu.Size = new System.Drawing.Size(54, 20);
			this.ControlsMenu.Text = "Debug";
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
            this.ethernetToolStripMenuItem,
            this.logToolStripMenuItem});
			this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
			this.developerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.developerToolStripMenuItem.Text = "Developer";
			// 
			// ethernetToolStripMenuItem
			// 
			this.ethernetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.hardwarePingToolStripMenuItem});
			this.ethernetToolStripMenuItem.Name = "ethernetToolStripMenuItem";
			this.ethernetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ethernetToolStripMenuItem.Text = "Ethernet";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.connectToolStripMenuItem.Text = "Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectRobot_MenuClick);
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.disconnectToolStripMenuItem.Text = "Disconnect";
			this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectRobot_MenuClick);
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
			this.logToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
			this.InputDataTimer.Interval = 20;
			this.InputDataTimer.Tick += new System.EventHandler(this.InputDataTimer_Tick);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(662, 501);
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
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(722, 503);
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
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Location = new System.Drawing.Point(782, 503);
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
			this.TestBtnMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.TestBtnMeter.BorderColor = System.Drawing.Color.Black;
			this.TestBtnMeter.Location = new System.Drawing.Point(78, 492);
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
			// TestBtn2
			// 
			this.TestBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.TestBtn2.BorderColor = System.Drawing.Color.Black;
			this.TestBtn2.Location = new System.Drawing.Point(108, 492);
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
			this.LedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LedBtn.Location = new System.Drawing.Point(12, 496);
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
			this.InputComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.InputComboBox.FormattingEnabled = true;
			this.InputComboBox.Location = new System.Drawing.Point(842, 501);
			this.InputComboBox.Margin = new System.Windows.Forms.Padding(2);
			this.InputComboBox.Name = "InputComboBox";
			this.InputComboBox.Size = new System.Drawing.Size(106, 21);
			this.InputComboBox.TabIndex = 37;
			this.InputComboBox.DropDown += new System.EventHandler(this.InputComboBox_DropDown);
			this.InputComboBox.SelectedIndexChanged += new System.EventHandler(this.InputComboBox_SelectedIndexChanged);
			// 
			// CameraView1
			// 
			this.CameraView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CameraView1.Location = new System.Drawing.Point(3, 3);
			this.CameraView1.Name = "CameraView1";
			this.CameraView1.Size = new System.Drawing.Size(463, 454);
			this.CameraView1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CameraView1.TabIndex = 2;
			this.CameraView1.TabStop = false;
			// 
			// ImageUpdateTimer
			// 
			this.ImageUpdateTimer.Interval = 67;
			this.ImageUpdateTimer.Tick += new System.EventHandler(this.ImageUpdateTimer_Tick);
			// 
			// CameraView2
			// 
			this.CameraView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CameraView2.Location = new System.Drawing.Point(472, 3);
			this.CameraView2.Name = "CameraView2";
			this.CameraView2.Size = new System.Drawing.Size(463, 454);
			this.CameraView2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CameraView2.TabIndex = 38;
			this.CameraView2.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.CameraView1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.CameraView2, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 27);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(938, 460);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// MainInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 533);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.InputComboBox);
			this.Controls.Add(this.LedBtn);
			this.Controls.Add(this.TestBtn2);
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
			((System.ComponentModel.ISupportInitialize)(this.CameraView2)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem ControlsMenu;
		private System.Windows.Forms.Timer InputDataTimer;
		private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ethernetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private Meters.IOMeter TestBtnMeter;
		private System.Windows.Forms.ToolStripMenuItem hardwarePingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem simulatorToolStripMenuItem;
		private Meters.IOMeter TestBtn2;
		private System.Windows.Forms.Button LedBtn;
		private System.Windows.Forms.ComboBox InputComboBox;
		private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sensorsToolStripMenuItem;
		private Emgu.CV.UI.ImageBox CameraView1;
		private System.Windows.Forms.Timer ImageUpdateTimer;
		private Emgu.CV.UI.ImageBox CameraView2;
		private System.Windows.Forms.ToolStripMenuItem robotToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

