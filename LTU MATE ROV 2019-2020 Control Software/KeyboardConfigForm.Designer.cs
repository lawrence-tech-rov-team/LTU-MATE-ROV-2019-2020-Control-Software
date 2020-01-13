namespace LTU_MATE_ROV_2019_2020_Control_Software {
	partial class KeyboardConfigForm {
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
				components.Close();
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
			this.label1 = new System.Windows.Forms.Label();
			this.ThrottleFBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ThrottleBBox = new System.Windows.Forms.TextBox();
			this.SteerLBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ThrustMeter = new Meters.LinearMeter();
			this.SteerMeter = new Meters.LinearMeter();
			this.InputTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Throttle Forward: ";
			// 
			// ThrottleFBox
			// 
			this.ThrottleFBox.Location = new System.Drawing.Point(138, 12);
			this.ThrottleFBox.MaxLength = 1;
			this.ThrottleFBox.Name = "ThrottleFBox";
			this.ThrottleFBox.Size = new System.Drawing.Size(90, 22);
			this.ThrottleFBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Throttle Backward: ";
			// 
			// ThrottleBBox
			// 
			this.ThrottleBBox.Location = new System.Drawing.Point(138, 40);
			this.ThrottleBBox.MaxLength = 1;
			this.ThrottleBBox.Name = "ThrottleBBox";
			this.ThrottleBBox.Size = new System.Drawing.Size(90, 22);
			this.ThrottleBBox.TabIndex = 3;
			// 
			// SteerLBox
			// 
			this.SteerLBox.Location = new System.Drawing.Point(138, 68);
			this.SteerLBox.MaxLength = 1;
			this.SteerLBox.Name = "SteerLBox";
			this.SteerLBox.Size = new System.Drawing.Size(90, 22);
			this.SteerLBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Steer Left:";
			// 
			// ThrustMeter
			// 
			this.ThrustMeter.BackColor = System.Drawing.Color.White;
			this.ThrustMeter.BorderColor = System.Drawing.Color.Black;
			this.ThrustMeter.Horizontal = false;
			this.ThrustMeter.Inverse = false;
			this.ThrustMeter.Location = new System.Drawing.Point(650, 40);
			this.ThrustMeter.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.ThrustMeter.MeterColor = System.Drawing.Color.Red;
			this.ThrustMeter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.ThrustMeter.Name = "ThrustMeter";
			this.ThrustMeter.Size = new System.Drawing.Size(20, 200);
			this.ThrustMeter.TabIndex = 6;
			this.ThrustMeter.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.ThrustMeter.ZeroValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// SteerMeter
			// 
			this.SteerMeter.BackColor = System.Drawing.Color.White;
			this.SteerMeter.BorderColor = System.Drawing.Color.Black;
			this.SteerMeter.Horizontal = true;
			this.SteerMeter.Inverse = false;
			this.SteerMeter.Location = new System.Drawing.Point(569, 246);
			this.SteerMeter.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.SteerMeter.MeterColor = System.Drawing.Color.Red;
			this.SteerMeter.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.SteerMeter.Name = "SteerMeter";
			this.SteerMeter.Size = new System.Drawing.Size(200, 20);
			this.SteerMeter.TabIndex = 7;
			this.SteerMeter.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.SteerMeter.ZeroValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// InputTimer
			// 
			this.InputTimer.Interval = 34;
			this.InputTimer.Tick += new System.EventHandler(this.InputTimer_Tick);
			// 
			// KeyboardConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SteerMeter);
			this.Controls.Add(this.ThrustMeter);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.SteerLBox);
			this.Controls.Add(this.ThrottleBBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ThrottleFBox);
			this.Controls.Add(this.label1);
			this.KeyPreview = true;
			this.Name = "KeyboardConfigForm";
			this.Text = "KeyboardConfigForm";
			this.Load += new System.EventHandler(this.KeyboardConfigForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyboardConfigForm_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyboardConfigForm_KeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ThrottleFBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ThrottleBBox;
		private System.Windows.Forms.TextBox SteerLBox;
		private System.Windows.Forms.Label label3;
		private Meters.LinearMeter ThrustMeter;
		private Meters.LinearMeter SteerMeter;
		private System.Windows.Forms.Timer InputTimer;
	}
}