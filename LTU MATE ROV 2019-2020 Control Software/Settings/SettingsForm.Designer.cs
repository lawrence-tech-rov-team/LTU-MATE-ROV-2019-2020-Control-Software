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
			this.ServoSelector = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.MaxPulseUpDown = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.MinPulseUpDown = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.EnableBtn = new System.Windows.Forms.Button();
			this.DisableBtn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxPulseUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MinPulseUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ServoSelector
			// 
			this.ServoSelector.FormattingEnabled = true;
			this.ServoSelector.Location = new System.Drawing.Point(62, 19);
			this.ServoSelector.Name = "ServoSelector";
			this.ServoSelector.Size = new System.Drawing.Size(79, 21);
			this.ServoSelector.TabIndex = 0;
			this.ServoSelector.DropDown += new System.EventHandler(this.ServoSelector_DropDown);
			this.ServoSelector.SelectedIndexChanged += new System.EventHandler(this.ServoSelector_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Servo:";
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
			this.groupBox1.Controls.Add(this.ServoSelector);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(244, 110);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Servo Calibration";
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
			this.label4.Location = new System.Drawing.Point(6, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "PVC: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Sample:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Battery:";
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(62, 20);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(79, 20);
			this.numericUpDown3.TabIndex = 6;
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.Location = new System.Drawing.Point(62, 46);
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(79, 20);
			this.numericUpDown4.TabIndex = 7;
			// 
			// numericUpDown5
			// 
			this.numericUpDown5.Location = new System.Drawing.Point(62, 72);
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new System.Drawing.Size(79, 20);
			this.numericUpDown5.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(147, 22);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Degrees";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(147, 48);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 13);
			this.label10.TabIndex = 10;
			this.label10.Text = "Degrees";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(147, 74);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(47, 13);
			this.label11.TabIndex = 11;
			this.label11.Text = "Degrees";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.numericUpDown3);
			this.groupBox2.Controls.Add(this.numericUpDown5);
			this.groupBox2.Controls.Add(this.numericUpDown4);
			this.groupBox2.Location = new System.Drawing.Point(12, 128);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(216, 101);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Gripper Positions";
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
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 268);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "SettingsForm";
			this.Text = "SettingsForm";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MaxPulseUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MinPulseUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox ServoSelector;
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
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
		private System.Windows.Forms.NumericUpDown numericUpDown5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button DisableBtn;
		private System.Windows.Forms.Button EnableBtn;
	}
}