﻿namespace LTU_MATE_ROV_2019_2020_Control_Software.Programs.StartStop {
	partial class StartStopGui {
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
			this.StartBtn = new System.Windows.Forms.Button();
			this.StopBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// StartBtn
			// 
			this.StartBtn.Location = new System.Drawing.Point(12, 12);
			this.StartBtn.Name = "StartBtn";
			this.StartBtn.Size = new System.Drawing.Size(185, 32);
			this.StartBtn.TabIndex = 0;
			this.StartBtn.Text = "Start";
			this.StartBtn.UseVisualStyleBackColor = true;
			this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
			// 
			// StopBtn
			// 
			this.StopBtn.Location = new System.Drawing.Point(12, 79);
			this.StopBtn.Name = "StopBtn";
			this.StopBtn.Size = new System.Drawing.Size(185, 32);
			this.StopBtn.TabIndex = 1;
			this.StopBtn.Text = "Stop";
			this.StopBtn.UseVisualStyleBackColor = true;
			this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
			// 
			// StartStopGui
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(209, 141);
			this.Controls.Add(this.StopBtn);
			this.Controls.Add(this.StartBtn);
			this.Name = "StartStopGui";
			this.Text = "StartStopGui";
			this.Load += new System.EventHandler(this.StartStopGui_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button StartBtn;
		private System.Windows.Forms.Button StopBtn;
	}
}