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
			this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.speedTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toggleLedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.KeyboardBtn = new System.Windows.Forms.RadioButton();
			this.PowerMeter = new Meters.LinearMeter();
			this.InputDataTimer = new System.Windows.Forms.Timer(this.components);
			this.JoystickBtn = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.TestBtnMeter = new Meters.IOMeter();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.MenuStrip.SuspendLayout();
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
            this.developerToolStripMenuItem});
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
			// MainInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 450);
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
	}
}

