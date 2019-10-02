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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.ControlsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.JoystickMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.KeyboardMenu = new System.Windows.Forms.ToolStripMenuItem();
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
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(486, 31);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(90, 21);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Keyboard";
			this.radioButton1.UseVisualStyleBackColor = true;
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
			// MainInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 450);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.MenuStrip);
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "MainInterface";
			this.Text = "Form1";
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
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.ToolStripMenuItem JoystickMenu;
		private System.Windows.Forms.ToolStripMenuItem KeyboardMenu;
	}
}

