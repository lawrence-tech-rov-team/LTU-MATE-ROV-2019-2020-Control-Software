namespace LTU_MATE_ROV_2019_2020_Control_Software.Settings {
	partial class SettingsForm {
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
			this.PwmSelector = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.DisableBtn = new System.Windows.Forms.Button();
			this.EnableBtn = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.MaxPulseUpDown = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.MinPulseUpDown = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SpongeOpenPos = new System.Windows.Forms.NumericUpDown();
			this.MediumOpenPos = new System.Windows.Forms.NumericUpDown();
			this.SmallOpenPos = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.NetClosedPos = new System.Windows.Forms.NumericUpDown();
			this.label17 = new System.Windows.Forms.Label();
			this.NetOpenPos = new System.Windows.Forms.NumericUpDown();
			this.TinyClosedPos = new System.Windows.Forms.NumericUpDown();
			this.label16 = new System.Windows.Forms.Label();
			this.TinyOpenPos = new System.Windows.Forms.NumericUpDown();
			this.SmallClosedPos = new System.Windows.Forms.NumericUpDown();
			this.MediumClosedPos = new System.Windows.Forms.NumericUpDown();
			this.SpongeClosedPos = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxPulseUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MinPulseUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SpongeOpenPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MediumOpenPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SmallOpenPos)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NetClosedPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NetOpenPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TinyClosedPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TinyOpenPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SmallClosedPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MediumClosedPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SpongeClosedPos)).BeginInit();
			this.SuspendLayout();
			// 
			// ServoSelector
			// 
			this.PwmSelector.FormattingEnabled = true;
			this.PwmSelector.Location = new System.Drawing.Point(62, 19);
			this.PwmSelector.Name = "ServoSelector";
			this.PwmSelector.Size = new System.Drawing.Size(79, 21);
			this.PwmSelector.TabIndex = 0;
			this.PwmSelector.DropDown += new System.EventHandler(this.ServoSelector_DropDown);
			this.PwmSelector.SelectedIndexChanged += new System.EventHandler(this.PwmSelector_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "PWM:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.DisableBtn);
			this.groupBox1.Controls.Add(this.EnableBtn);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.MaxPulseUpDown);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.MinPulseUpDown);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.PwmSelector);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(244, 110);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "PWM Calibration";
			// 
			// DisableBtn
			// 
			this.DisableBtn.Location = new System.Drawing.Point(172, 69);
			this.DisableBtn.Name = "DisableBtn";
			this.DisableBtn.Size = new System.Drawing.Size(66, 23);
			this.DisableBtn.TabIndex = 10;
			this.DisableBtn.Text = "Disable";
			this.DisableBtn.UseVisualStyleBackColor = true;
			this.DisableBtn.Click += new System.EventHandler(this.DisableBtn_Click);
			// 
			// EnableBtn
			// 
			this.EnableBtn.Location = new System.Drawing.Point(172, 43);
			this.EnableBtn.Name = "EnableBtn";
			this.EnableBtn.Size = new System.Drawing.Size(66, 23);
			this.EnableBtn.TabIndex = 9;
			this.EnableBtn.Text = "Enable";
			this.EnableBtn.UseVisualStyleBackColor = true;
			this.EnableBtn.Click += new System.EventHandler(this.EnableBtn_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(147, 74);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(18, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "us";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(147, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(18, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "us";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Maximum:";
			// 
			// MaxPulseUpDown
			// 
			this.MaxPulseUpDown.Location = new System.Drawing.Point(63, 72);
			this.MaxPulseUpDown.Name = "MaxPulseUpDown";
			this.MaxPulseUpDown.Size = new System.Drawing.Size(78, 20);
			this.MaxPulseUpDown.TabIndex = 5;
			this.MaxPulseUpDown.ValueChanged += new System.EventHandler(this.MaxPulseUpDown_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Minimum:";
			// 
			// MinPulseUpDown
			// 
			this.MinPulseUpDown.Location = new System.Drawing.Point(63, 46);
			this.MinPulseUpDown.Name = "MinPulseUpDown";
			this.MinPulseUpDown.Size = new System.Drawing.Size(78, 20);
			this.MinPulseUpDown.TabIndex = 3;
			this.MinPulseUpDown.ValueChanged += new System.EventHandler(this.MinPulseUpDown_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Sponge:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Medium:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(5, 86);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Small:";
			// 
			// SpongeOpenPos
			// 
			this.SpongeOpenPos.Location = new System.Drawing.Point(62, 32);
			this.SpongeOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.SpongeOpenPos.Name = "SpongeOpenPos";
			this.SpongeOpenPos.Size = new System.Drawing.Size(79, 20);
			this.SpongeOpenPos.TabIndex = 6;
			this.SpongeOpenPos.ValueChanged += new System.EventHandler(this.SpongeOpenPos_ValueChanged);
			// 
			// MediumOpenPos
			// 
			this.MediumOpenPos.Location = new System.Drawing.Point(62, 58);
			this.MediumOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.MediumOpenPos.Name = "MediumOpenPos";
			this.MediumOpenPos.Size = new System.Drawing.Size(79, 20);
			this.MediumOpenPos.TabIndex = 7;
			this.MediumOpenPos.ValueChanged += new System.EventHandler(this.MediumOpenPos_ValueChanged);
			// 
			// SmallOpenPos
			// 
			this.SmallOpenPos.Location = new System.Drawing.Point(62, 84);
			this.SmallOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.SmallOpenPos.Name = "SmallOpenPos";
			this.SmallOpenPos.Size = new System.Drawing.Size(79, 20);
			this.SmallOpenPos.TabIndex = 8;
			this.SmallOpenPos.ValueChanged += new System.EventHandler(this.SmallOpenPos_ValueChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(233, 86);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Degrees";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(233, 34);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 13);
			this.label10.TabIndex = 10;
			this.label10.Text = "Degrees";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(233, 60);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(47, 13);
			this.label11.TabIndex = 11;
			this.label11.Text = "Degrees";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.NetClosedPos);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.NetOpenPos);
			this.groupBox2.Controls.Add(this.TinyClosedPos);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.TinyOpenPos);
			this.groupBox2.Controls.Add(this.SmallClosedPos);
			this.groupBox2.Controls.Add(this.MediumClosedPos);
			this.groupBox2.Controls.Add(this.SpongeClosedPos);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.SpongeOpenPos);
			this.groupBox2.Controls.Add(this.SmallOpenPos);
			this.groupBox2.Controls.Add(this.MediumOpenPos);
			this.groupBox2.Location = new System.Drawing.Point(12, 128);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(290, 162);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Gripper Positions";
			// 
			// NetClosedPos
			// 
			this.NetClosedPos.Location = new System.Drawing.Point(148, 133);
			this.NetClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.NetClosedPos.Name = "NetClosedPos";
			this.NetClosedPos.Size = new System.Drawing.Size(79, 20);
			this.NetClosedPos.TabIndex = 24;
			this.NetClosedPos.ValueChanged += new System.EventHandler(this.NetClosedPos_ValueChanged);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(233, 135);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(47, 13);
			this.label17.TabIndex = 23;
			this.label17.Text = "Degrees";
			// 
			// NetOpenPos
			// 
			this.NetOpenPos.Location = new System.Drawing.Point(62, 133);
			this.NetOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.NetOpenPos.Name = "NetOpenPos";
			this.NetOpenPos.Size = new System.Drawing.Size(79, 20);
			this.NetOpenPos.TabIndex = 22;
			this.NetOpenPos.ValueChanged += new System.EventHandler(this.NetOpenPos_ValueChanged);
			// 
			// TinyClosedPos
			// 
			this.TinyClosedPos.Location = new System.Drawing.Point(148, 109);
			this.TinyClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.TinyClosedPos.Name = "TinyClosedPos";
			this.TinyClosedPos.Size = new System.Drawing.Size(79, 20);
			this.TinyClosedPos.TabIndex = 21;
			this.TinyClosedPos.ValueChanged += new System.EventHandler(this.TinyClosedPos_ValueChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(233, 110);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(47, 13);
			this.label16.TabIndex = 20;
			this.label16.Text = "Degrees";
			// 
			// TinyOpenPos
			// 
			this.TinyOpenPos.Location = new System.Drawing.Point(62, 109);
			this.TinyOpenPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.TinyOpenPos.Name = "TinyOpenPos";
			this.TinyOpenPos.Size = new System.Drawing.Size(79, 20);
			this.TinyOpenPos.TabIndex = 19;
			this.TinyOpenPos.ValueChanged += new System.EventHandler(this.TinyOpenPos_ValueChanged);
			// 
			// SmallClosedPos
			// 
			this.SmallClosedPos.Location = new System.Drawing.Point(148, 84);
			this.SmallClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.SmallClosedPos.Name = "SmallClosedPos";
			this.SmallClosedPos.Size = new System.Drawing.Size(79, 20);
			this.SmallClosedPos.TabIndex = 18;
			this.SmallClosedPos.ValueChanged += new System.EventHandler(this.SmallClosedPos_ValueChanged);
			// 
			// MediumClosedPos
			// 
			this.MediumClosedPos.Location = new System.Drawing.Point(148, 58);
			this.MediumClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.MediumClosedPos.Name = "MediumClosedPos";
			this.MediumClosedPos.Size = new System.Drawing.Size(79, 20);
			this.MediumClosedPos.TabIndex = 17;
			this.MediumClosedPos.ValueChanged += new System.EventHandler(this.MediumClosedPos_ValueChanged);
			// 
			// SpongeClosedPos
			// 
			this.SpongeClosedPos.Location = new System.Drawing.Point(148, 32);
			this.SpongeClosedPos.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
			this.SpongeClosedPos.Name = "SpongeClosedPos";
			this.SpongeClosedPos.Size = new System.Drawing.Size(79, 20);
			this.SpongeClosedPos.TabIndex = 16;
			this.SpongeClosedPos.ValueChanged += new System.EventHandler(this.SpongeClosedPos_ValueChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(170, 15);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(39, 13);
			this.label15.TabIndex = 15;
			this.label15.Text = "Closed";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(85, 15);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(33, 13);
			this.label14.TabIndex = 14;
			this.label14.Text = "Open";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 135);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(27, 13);
			this.label13.TabIndex = 13;
			this.label13.Text = "Net:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 110);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(30, 13);
			this.label12.TabIndex = 12;
			this.label12.Text = "Tiny:";
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 315);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "SettingsForm";
			this.Text = "SettingsForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxPulseUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MinPulseUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SpongeOpenPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MediumOpenPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SmallOpenPos)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NetClosedPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NetOpenPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TinyClosedPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TinyOpenPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SmallClosedPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MediumClosedPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SpongeClosedPos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox PwmSelector;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown MaxPulseUpDown;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown MinPulseUpDown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown SpongeOpenPos;
		private System.Windows.Forms.NumericUpDown MediumOpenPos;
		private System.Windows.Forms.NumericUpDown SmallOpenPos;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button DisableBtn;
		private System.Windows.Forms.Button EnableBtn;
		private System.Windows.Forms.NumericUpDown NetClosedPos;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.NumericUpDown NetOpenPos;
		private System.Windows.Forms.NumericUpDown TinyClosedPos;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.NumericUpDown TinyOpenPos;
		private System.Windows.Forms.NumericUpDown SmallClosedPos;
		private System.Windows.Forms.NumericUpDown MediumClosedPos;
		private System.Windows.Forms.NumericUpDown SpongeClosedPos;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
	}
}