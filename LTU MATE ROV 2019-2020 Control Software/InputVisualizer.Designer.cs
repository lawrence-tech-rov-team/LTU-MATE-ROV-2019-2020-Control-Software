namespace LTU_MATE_ROV_2019_2020_Control_Software {
	partial class InputVisualizer {
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
			this.LinearY = new Meters.LinearMeter();
			this.LinearX = new Meters.LinearMeter();
			this.LinearZ = new Meters.LinearMeter();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.AngularZ = new Meters.LinearMeter();
			this.AngularX = new Meters.LinearMeter();
			this.AngularY = new Meters.LinearMeter();
			this.SuspendLayout();
			// 
			// LinearY
			// 
			this.LinearY.BackColor = System.Drawing.Color.White;
			this.LinearY.BorderColor = System.Drawing.Color.Black;
			this.LinearY.Horizontal = false;
			this.LinearY.Inverse = false;
			this.LinearY.Location = new System.Drawing.Point(38, 12);
			this.LinearY.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.LinearY.MeterColor = System.Drawing.Color.Red;
			this.LinearY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.LinearY.Name = "LinearY";
			this.LinearY.Size = new System.Drawing.Size(20, 200);
			this.LinearY.TabIndex = 0;
			this.LinearY.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.LinearY.ZeroValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// LinearX
			// 
			this.LinearX.BackColor = System.Drawing.Color.White;
			this.LinearX.BorderColor = System.Drawing.Color.Black;
			this.LinearX.Horizontal = true;
			this.LinearX.Inverse = false;
			this.LinearX.Location = new System.Drawing.Point(64, 212);
			this.LinearX.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.LinearX.MeterColor = System.Drawing.Color.Red;
			this.LinearX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.LinearX.Name = "LinearX";
			this.LinearX.Size = new System.Drawing.Size(200, 20);
			this.LinearX.TabIndex = 1;
			this.LinearX.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.LinearX.ZeroValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// LinearZ
			// 
			this.LinearZ.BackColor = System.Drawing.Color.White;
			this.LinearZ.BorderColor = System.Drawing.Color.Black;
			this.LinearZ.Horizontal = false;
			this.LinearZ.Inverse = false;
			this.LinearZ.Location = new System.Drawing.Point(12, 12);
			this.LinearZ.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.LinearZ.MeterColor = System.Drawing.Color.Red;
			this.LinearZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.LinearZ.Name = "LinearZ";
			this.LinearZ.Size = new System.Drawing.Size(20, 200);
			this.LinearZ.TabIndex = 1;
			this.LinearZ.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.LinearZ.ZeroValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(159, 189);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "X";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(64, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Y";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 215);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Z";
			// 
			// timer1
			// 
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(136, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "Linear";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(456, 103);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "Angular";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(335, 215);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Z";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(384, 103);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 17);
			this.label7.TabIndex = 10;
			this.label7.Text = "Y";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(479, 189);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(17, 17);
			this.label8.TabIndex = 9;
			this.label8.Text = "X";
			// 
			// AngularZ
			// 
			this.AngularZ.BackColor = System.Drawing.Color.White;
			this.AngularZ.BorderColor = System.Drawing.Color.Black;
			this.AngularZ.Horizontal = false;
			this.AngularZ.Inverse = false;
			this.AngularZ.Location = new System.Drawing.Point(332, 12);
			this.AngularZ.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.AngularZ.MeterColor = System.Drawing.Color.Red;
			this.AngularZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.AngularZ.Name = "AngularZ";
			this.AngularZ.Size = new System.Drawing.Size(20, 200);
			this.AngularZ.TabIndex = 7;
			this.AngularZ.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.AngularZ.ZeroValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// AngularX
			// 
			this.AngularX.BackColor = System.Drawing.Color.White;
			this.AngularX.BorderColor = System.Drawing.Color.Black;
			this.AngularX.Horizontal = true;
			this.AngularX.Inverse = false;
			this.AngularX.Location = new System.Drawing.Point(384, 212);
			this.AngularX.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.AngularX.MeterColor = System.Drawing.Color.Red;
			this.AngularX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.AngularX.Name = "AngularX";
			this.AngularX.Size = new System.Drawing.Size(200, 20);
			this.AngularX.TabIndex = 8;
			this.AngularX.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.AngularX.ZeroValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// AngularY
			// 
			this.AngularY.BackColor = System.Drawing.Color.White;
			this.AngularY.BorderColor = System.Drawing.Color.Black;
			this.AngularY.Horizontal = false;
			this.AngularY.Inverse = false;
			this.AngularY.Location = new System.Drawing.Point(358, 12);
			this.AngularY.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.AngularY.MeterColor = System.Drawing.Color.Red;
			this.AngularY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.AngularY.Name = "AngularY";
			this.AngularY.Size = new System.Drawing.Size(20, 200);
			this.AngularY.TabIndex = 6;
			this.AngularY.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.AngularY.ZeroValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// InputVisualizer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 277);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.AngularZ);
			this.Controls.Add(this.AngularX);
			this.Controls.Add(this.AngularY);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LinearZ);
			this.Controls.Add(this.LinearX);
			this.Controls.Add(this.LinearY);
			this.KeyPreview = true;
			this.Name = "InputVisualizer";
			this.Text = "InputVisualizer";
			this.Load += new System.EventHandler(this.InputVisualizer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Meters.LinearMeter LinearY;
		private Meters.LinearMeter LinearX;
		private Meters.LinearMeter LinearZ;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private Meters.LinearMeter AngularZ;
		private Meters.LinearMeter AngularX;
		private Meters.LinearMeter AngularY;
	}
}