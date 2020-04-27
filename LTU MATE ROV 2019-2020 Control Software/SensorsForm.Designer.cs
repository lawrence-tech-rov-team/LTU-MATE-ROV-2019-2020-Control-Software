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
			this.TempLabel = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.DepthLabel = new System.Windows.Forms.Label();
			this.AltitudeLabel = new System.Windows.Forms.Label();
			this.PressureLabel = new System.Windows.Forms.Label();
			this.WaterTempLabel = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.TestBtn2 = new Meters.IOMeter();
			this.TestBtnMeter = new Meters.IOMeter();
			this.AccelVectorPanel = new LTU_MATE_ROV_2019_2020_Control_Software.Utils.Vector3Panel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.AccelVectorPanel);
			this.groupBox1.Controls.Add(this.TempLabel);
			this.groupBox1.Location = new System.Drawing.Point(9, 10);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(494, 184);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "IMU";
			// 
			// TempLabel
			// 
			this.TempLabel.AutoSize = true;
			this.TempLabel.Location = new System.Drawing.Point(4, 15);
			this.TempLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TempLabel.Name = "TempLabel";
			this.TempLabel.Size = new System.Drawing.Size(99, 13);
			this.TempLabel.TabIndex = 19;
			this.TempLabel.Text = "Temperature: -99*C";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.DepthLabel);
			this.groupBox2.Controls.Add(this.AltitudeLabel);
			this.groupBox2.Controls.Add(this.PressureLabel);
			this.groupBox2.Controls.Add(this.WaterTempLabel);
			this.groupBox2.Location = new System.Drawing.Point(9, 210);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(494, 132);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Pressure";
			// 
			// DepthLabel
			// 
			this.DepthLabel.AutoSize = true;
			this.DepthLabel.Location = new System.Drawing.Point(8, 56);
			this.DepthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DepthLabel.Name = "DepthLabel";
			this.DepthLabel.Size = new System.Drawing.Size(42, 13);
			this.DepthLabel.TabIndex = 26;
			this.DepthLabel.Text = "Depth: ";
			// 
			// AltitudeLabel
			// 
			this.AltitudeLabel.AutoSize = true;
			this.AltitudeLabel.Location = new System.Drawing.Point(8, 42);
			this.AltitudeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.AltitudeLabel.Name = "AltitudeLabel";
			this.AltitudeLabel.Size = new System.Drawing.Size(48, 13);
			this.AltitudeLabel.TabIndex = 25;
			this.AltitudeLabel.Text = "Altitude: ";
			// 
			// PressureLabel
			// 
			this.PressureLabel.AutoSize = true;
			this.PressureLabel.Location = new System.Drawing.Point(8, 28);
			this.PressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.PressureLabel.Name = "PressureLabel";
			this.PressureLabel.Size = new System.Drawing.Size(51, 13);
			this.PressureLabel.TabIndex = 24;
			this.PressureLabel.Text = "Pressure:";
			// 
			// WaterTempLabel
			// 
			this.WaterTempLabel.AutoSize = true;
			this.WaterTempLabel.Location = new System.Drawing.Point(8, 15);
			this.WaterTempLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.WaterTempLabel.Name = "WaterTempLabel";
			this.WaterTempLabel.Size = new System.Drawing.Size(98, 13);
			this.WaterTempLabel.TabIndex = 23;
			this.WaterTempLabel.Text = "Water Temp: -99*C";
			// 
			// timer1
			// 
			this.timer1.Interval = 33;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// TestBtn2
			// 
			this.TestBtn2.BorderColor = System.Drawing.Color.Black;
			this.TestBtn2.Location = new System.Drawing.Point(40, 361);
			this.TestBtn2.Margin = new System.Windows.Forms.Padding(2);
			this.TestBtn2.Name = "TestBtn2";
			this.TestBtn2.OffColor = System.Drawing.Color.Firebrick;
			this.TestBtn2.OnColor = System.Drawing.Color.Red;
			this.TestBtn2.Size = new System.Drawing.Size(26, 28);
			this.TestBtn2.Style = Meters.ButtonStyle.Round;
			this.TestBtn2.TabIndex = 34;
			this.TestBtn2.Text = "Test";
			this.TestBtn2.UseVisualStyleBackColor = true;
			this.TestBtn2.Value = false;
			// 
			// TestBtnMeter
			// 
			this.TestBtnMeter.BorderColor = System.Drawing.Color.Black;
			this.TestBtnMeter.Location = new System.Drawing.Point(9, 361);
			this.TestBtnMeter.Margin = new System.Windows.Forms.Padding(2);
			this.TestBtnMeter.Name = "TestBtnMeter";
			this.TestBtnMeter.OffColor = System.Drawing.Color.Firebrick;
			this.TestBtnMeter.OnColor = System.Drawing.Color.Red;
			this.TestBtnMeter.Size = new System.Drawing.Size(26, 28);
			this.TestBtnMeter.Style = Meters.ButtonStyle.Round;
			this.TestBtnMeter.TabIndex = 33;
			this.TestBtnMeter.Text = "Test";
			this.TestBtnMeter.UseVisualStyleBackColor = true;
			this.TestBtnMeter.Value = false;
			// 
			// AccelVectorPanel
			// 
			this.AccelVectorPanel.Location = new System.Drawing.Point(7, 31);
			this.AccelVectorPanel.MaximumSize = new System.Drawing.Size(100, 60);
			this.AccelVectorPanel.MinimumSize = new System.Drawing.Size(100, 60);
			this.AccelVectorPanel.Name = "AccelVectorPanel";
			this.AccelVectorPanel.Size = new System.Drawing.Size(100, 60);
			this.AccelVectorPanel.TabIndex = 35;
			this.AccelVectorPanel.TabStop = false;
			this.AccelVectorPanel.Text = "Acceleration";
			this.AccelVectorPanel.X = 0F;
			this.AccelVectorPanel.Y = 0F;
			this.AccelVectorPanel.Z = 0F;
			// 
			// SensorsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 467);
			this.Controls.Add(this.TestBtn2);
			this.Controls.Add(this.TestBtnMeter);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
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
		private System.Windows.Forms.Label TempLabel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label DepthLabel;
		private System.Windows.Forms.Label AltitudeLabel;
		private System.Windows.Forms.Label PressureLabel;
		private System.Windows.Forms.Label WaterTempLabel;
		private System.Windows.Forms.Timer timer1;
		private Meters.IOMeter TestBtn2;
		private Meters.IOMeter TestBtnMeter;
		private Utils.Vector3Panel AccelVectorPanel;
	}
}