﻿namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Simulator {
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
			// RobotSimulatorUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(607, 321);
			this.Controls.Add(this.TestBtn0);
			this.Name = "RobotSimulatorUI";
			this.Text = "RobotSimulatorUI";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RobotSimulatorUI_FormClosing);
			this.Load += new System.EventHandler(this.RobotSimulatorUI_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button TestBtn0;
	}
}