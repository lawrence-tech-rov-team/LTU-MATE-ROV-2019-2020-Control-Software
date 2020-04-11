namespace LTU_MATE_ROV_2019_2020_Control_Software {
	partial class SensorsForm {
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.AccelZ = new System.Windows.Forms.Label();
			this.AccelY = new System.Windows.Forms.Label();
			this.AccelX = new System.Windows.Forms.Label();
			this.EulerZ = new System.Windows.Forms.Label();
			this.EulerY = new System.Windows.Forms.Label();
			this.EulerX = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TempLabel = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.DepthLabel = new System.Windows.Forms.Label();
			this.AltitudeLabel = new System.Windows.Forms.Label();
			this.PressureLabel = new System.Windows.Forms.Label();
			this.WaterTempLabel = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.TestBtn2 = new Meters.IOMeter();
			this.TestBtnMeter = new Meters.IOMeter();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.AccelZ);
			this.groupBox1.Controls.Add(this.AccelY);
			this.groupBox1.Controls.Add(this.AccelX);
			this.groupBox1.Controls.Add(this.EulerZ);
			this.groupBox1.Controls.Add(this.EulerY);
			this.groupBox1.Controls.Add(this.EulerX);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.TempLabel);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(658, 162);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "IMU";
			// 
			// AccelZ
			// 
			this.AccelZ.AutoSize = true;
			this.AccelZ.Location = new System.Drawing.Point(217, 86);
			this.AccelZ.Name = "AccelZ";
			this.AccelZ.Size = new System.Drawing.Size(42, 17);
			this.AccelZ.TabIndex = 27;
			this.AccelZ.Text = "Accel";
			// 
			// AccelY
			// 
			this.AccelY.AutoSize = true;
			this.AccelY.Location = new System.Drawing.Point(217, 69);
			this.AccelY.Name = "AccelY";
			this.AccelY.Size = new System.Drawing.Size(42, 17);
			this.AccelY.TabIndex = 26;
			this.AccelY.Text = "Accel";
			// 
			// AccelX
			// 
			this.AccelX.AutoSize = true;
			this.AccelX.Location = new System.Drawing.Point(217, 52);
			this.AccelX.Name = "AccelX";
			this.AccelX.Size = new System.Drawing.Size(42, 17);
			this.AccelX.TabIndex = 25;
			this.AccelX.Text = "Accel";
			// 
			// EulerZ
			// 
			this.EulerZ.AutoSize = true;
			this.EulerZ.Location = new System.Drawing.Point(6, 86);
			this.EulerZ.Name = "EulerZ";
			this.EulerZ.Size = new System.Drawing.Size(41, 17);
			this.EulerZ.TabIndex = 24;
			this.EulerZ.Text = "Euler";
			// 
			// EulerY
			// 
			this.EulerY.AutoSize = true;
			this.EulerY.Location = new System.Drawing.Point(6, 69);
			this.EulerY.Name = "EulerY";
			this.EulerY.Size = new System.Drawing.Size(41, 17);
			this.EulerY.TabIndex = 23;
			this.EulerY.Text = "Euler";
			// 
			// EulerX
			// 
			this.EulerX.AutoSize = true;
			this.EulerX.Location = new System.Drawing.Point(6, 52);
			this.EulerX.Name = "EulerX";
			this.EulerX.Size = new System.Drawing.Size(41, 17);
			this.EulerX.TabIndex = 22;
			this.EulerX.Text = "Euler";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(217, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 17);
			this.label2.TabIndex = 21;
			this.label2.Text = "Accel";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 17);
			this.label1.TabIndex = 20;
			this.label1.Text = "Euler";
			// 
			// TempLabel
			// 
			this.TempLabel.AutoSize = true;
			this.TempLabel.Location = new System.Drawing.Point(6, 18);
			this.TempLabel.Name = "TempLabel";
			this.TempLabel.Size = new System.Drawing.Size(133, 17);
			this.TempLabel.TabIndex = 19;
			this.TempLabel.Text = "Temperature: -99*C";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.DepthLabel);
			this.groupBox2.Controls.Add(this.AltitudeLabel);
			this.groupBox2.Controls.Add(this.PressureLabel);
			this.groupBox2.Controls.Add(this.WaterTempLabel);
			this.groupBox2.Location = new System.Drawing.Point(12, 180);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(658, 162);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Pressure";
			// 
			// DepthLabel
			// 
			this.DepthLabel.AutoSize = true;
			this.DepthLabel.Location = new System.Drawing.Point(10, 69);
			this.DepthLabel.Name = "DepthLabel";
			this.DepthLabel.Size = new System.Drawing.Size(54, 17);
			this.DepthLabel.TabIndex = 26;
			this.DepthLabel.Text = "Depth: ";
			// 
			// AltitudeLabel
			// 
			this.AltitudeLabel.AutoSize = true;
			this.AltitudeLabel.Location = new System.Drawing.Point(10, 52);
			this.AltitudeLabel.Name = "AltitudeLabel";
			this.AltitudeLabel.Size = new System.Drawing.Size(63, 17);
			this.AltitudeLabel.TabIndex = 25;
			this.AltitudeLabel.Text = "Altitude: ";
			// 
			// PressureLabel
			// 
			this.PressureLabel.AutoSize = true;
			this.PressureLabel.Location = new System.Drawing.Point(10, 35);
			this.PressureLabel.Name = "PressureLabel";
			this.PressureLabel.Size = new System.Drawing.Size(69, 17);
			this.PressureLabel.TabIndex = 24;
			this.PressureLabel.Text = "Pressure:";
			// 
			// WaterTempLabel
			// 
			this.WaterTempLabel.AutoSize = true;
			this.WaterTempLabel.Location = new System.Drawing.Point(10, 18);
			this.WaterTempLabel.Name = "WaterTempLabel";
			this.WaterTempLabel.Size = new System.Drawing.Size(129, 17);
			this.WaterTempLabel.TabIndex = 23;
			this.WaterTempLabel.Text = "Water Temp: -99*C";
			// 
			// timer1
			// 
			this.timer1.Interval = 33;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// TestBtn2
			// 
			this.TestBtn2.BorderColor = System.Drawing.Color.Black;
			this.TestBtn2.Location = new System.Drawing.Point(53, 365);
			this.TestBtn2.Name = "TestBtn2";
			this.TestBtn2.OffColor = System.Drawing.Color.Firebrick;
			this.TestBtn2.OnColor = System.Drawing.Color.Red;
			this.TestBtn2.Size = new System.Drawing.Size(35, 35);
			this.TestBtn2.Style = Meters.ButtonStyle.Round;
			this.TestBtn2.TabIndex = 34;
			this.TestBtn2.Text = "Test";
			this.TestBtn2.UseVisualStyleBackColor = true;
			this.TestBtn2.Value = false;
			// 
			// TestBtnMeter
			// 
			this.TestBtnMeter.BorderColor = System.Drawing.Color.Black;
			this.TestBtnMeter.Location = new System.Drawing.Point(12, 365);
			this.TestBtnMeter.Name = "TestBtnMeter";
			this.TestBtnMeter.OffColor = System.Drawing.Color.Firebrick;
			this.TestBtnMeter.OnColor = System.Drawing.Color.Red;
			this.TestBtnMeter.Size = new System.Drawing.Size(35, 35);
			this.TestBtnMeter.Style = Meters.ButtonStyle.Round;
			this.TestBtnMeter.TabIndex = 33;
			this.TestBtnMeter.Text = "Test";
			this.TestBtnMeter.UseVisualStyleBackColor = true;
			this.TestBtnMeter.Value = false;
			// 
			// SensorsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TestBtn2);
			this.Controls.Add(this.TestBtnMeter);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "SensorsForm";
			this.Text = "SensorsForm";
			this.Load += new System.EventHandler(this.SensorsForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label AccelZ;
		private System.Windows.Forms.Label AccelY;
		private System.Windows.Forms.Label AccelX;
		private System.Windows.Forms.Label EulerZ;
		private System.Windows.Forms.Label EulerY;
		private System.Windows.Forms.Label EulerX;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label TempLabel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label DepthLabel;
		private System.Windows.Forms.Label AltitudeLabel;
		private System.Windows.Forms.Label PressureLabel;
		private System.Windows.Forms.Label WaterTempLabel;
		private System.Windows.Forms.Timer timer1;
		private Meters.IOMeter TestBtn2;
		private Meters.IOMeter TestBtnMeter;
	}
}