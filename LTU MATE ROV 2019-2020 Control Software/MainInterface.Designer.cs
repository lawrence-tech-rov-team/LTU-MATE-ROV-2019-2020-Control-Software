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
			this.KeyboardBtn = new System.Windows.Forms.RadioButton();
			this.JoystickMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.KeyboardMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.PowerMeter = new Meters.LinearMeter();
			this.InputDataTimer = new System.Windows.Forms.Timer(this.components);
			this.JoystickBtn = new System.Windows.Forms.RadioButton();
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
            this.ControlsMenu});
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
			// KeyboardBtn
			// 
			this.KeyboardBtn.AutoSize = true;
			this.KeyboardBtn.Checked = true;
			this.KeyboardBtn.Location = new System.Drawing.Point(486, 31);
			this.KeyboardBtn.Name = "KeyboardBtn";
			this.KeyboardBtn.Size = new System.Drawing.Size(90, 21);
			this.KeyboardBtn.TabIndex = 3;
			this.KeyboardBtn.Text = "Keyboard";
			this.KeyboardBtn.UseVisualStyleBackColor = true;
			this.KeyboardBtn.CheckedChanged += new System.EventHandler(this.ControllerTypeButton_CheckedChanged);
			// 
			// JoystickMenu
			// 
			this.JoystickMenu.Name = "JoystickMenu";
			this.JoystickMenu.Size = new System.Drawing.Size(216, 26);
			this.JoystickMenu.Text = "Joystick";
			this.JoystickMenu.Click += new System.EventHandler(this.JoystickMenu_Click);
			// 
			// KeyboardMenu
			// 
			this.KeyboardMenu.Name = "KeyboardMenu";
			this.KeyboardMenu.Size = new System.Drawing.Size(216, 26);
			this.KeyboardMenu.Text = "Keyboard";
			this.KeyboardMenu.Click += new System.EventHandler(this.KeyboardMenu_Click);
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
			// MainInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 450);
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
	}
}

