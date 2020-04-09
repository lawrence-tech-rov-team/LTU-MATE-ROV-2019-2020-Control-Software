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
			// InputVisualizer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 277);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LinearZ);
			this.Controls.Add(this.LinearX);
			this.Controls.Add(this.LinearY);
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
	}
}