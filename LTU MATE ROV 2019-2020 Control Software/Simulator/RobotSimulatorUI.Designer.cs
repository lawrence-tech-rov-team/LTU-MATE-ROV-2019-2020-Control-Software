namespace LTU_MATE_ROV_2019_2020_Control_Software.Simulator {
	partial class RobotSimulatorUI {
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
			this.TestBtn0 = new System.Windows.Forms.Button();
			this.Led = new Meters.IOMeter();
			this.TempTrackBar = new System.Windows.Forms.TrackBar();
			this.TempLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.TempTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// TestBtn0
			// 
			this.TestBtn0.Location = new System.Drawing.Point(12, 12);
			this.TestBtn0.Name = "TestBtn0";
			this.TestBtn0.Size = new System.Drawing.Size(97, 32);
			this.TestBtn0.TabIndex = 0;
			this.TestBtn0.Text = "Test Button";
			this.TestBtn0.UseVisualStyleBackColor = true;
			// 
			// Led
			// 
			this.Led.BorderColor = System.Drawing.Color.Black;
			this.Led.Location = new System.Drawing.Point(314, 9);
			this.Led.Name = "Led";
			this.Led.OffColor = System.Drawing.Color.Firebrick;
			this.Led.OnColor = System.Drawing.Color.Red;
			this.Led.Size = new System.Drawing.Size(35, 35);
			this.Led.Style = Meters.ButtonStyle.Round;
			this.Led.TabIndex = 1;
			this.Led.Text = "LED";
			this.Led.UseVisualStyleBackColor = true;
			this.Led.Value = false;
			// 
			// TempTrackBar
			// 
			this.TempTrackBar.Location = new System.Drawing.Point(12, 90);
			this.TempTrackBar.Maximum = 127;
			this.TempTrackBar.Minimum = -128;
			this.TempTrackBar.Name = "TempTrackBar";
			this.TempTrackBar.Size = new System.Drawing.Size(583, 56);
			this.TempTrackBar.TabIndex = 2;
			this.TempTrackBar.Value = 25;
			// 
			// TempLabel
			// 
			this.TempLabel.AutoSize = true;
			this.TempLabel.Location = new System.Drawing.Point(12, 70);
			this.TempLabel.Name = "TempLabel";
			this.TempLabel.Size = new System.Drawing.Size(94, 17);
			this.TempLabel.TabIndex = 3;
			this.TempLabel.Text = "Temperature:";
			// 
			// RobotSimulatorUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(607, 321);
			this.Controls.Add(this.TempLabel);
			this.Controls.Add(this.TempTrackBar);
			this.Controls.Add(this.Led);
			this.Controls.Add(this.TestBtn0);
			this.Name = "RobotSimulatorUI";
			this.Text = "RobotSimulatorUI";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RobotSimulatorUI_FormClosing);
			this.Load += new System.EventHandler(this.RobotSimulatorUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.TempTrackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button TestBtn0;
		private Meters.IOMeter Led;
		private System.Windows.Forms.TrackBar TempTrackBar;
		private System.Windows.Forms.Label TempLabel;
	}
}