namespace LTU_MATE_ROV_2019_2020_Control_Software {
	partial class LogWindowForm {
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
			this.LogTextBox = new System.Windows.Forms.TextBox();
			this.LogLevelsGroup = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// LogTextBox
			// 
			this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LogTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
			this.LogTextBox.Location = new System.Drawing.Point(9, 10);
			this.LogTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.LogTextBox.Multiline = true;
			this.LogTextBox.Name = "LogTextBox";
			this.LogTextBox.ReadOnly = true;
			this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.LogTextBox.Size = new System.Drawing.Size(438, 315);
			this.LogTextBox.TabIndex = 0;
			// 
			// LogLevelsGroup
			// 
			this.LogLevelsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LogLevelsGroup.Location = new System.Drawing.Point(450, 10);
			this.LogLevelsGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.LogLevelsGroup.Name = "LogLevelsGroup";
			this.LogLevelsGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.LogLevelsGroup.Size = new System.Drawing.Size(141, 314);
			this.LogLevelsGroup.TabIndex = 1;
			this.LogLevelsGroup.TabStop = false;
			this.LogLevelsGroup.Text = "Log Levels";
			// 
			// LogWindowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 332);
			this.Controls.Add(this.LogLevelsGroup);
			this.Controls.Add(this.LogTextBox);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "LogWindowForm";
			this.Text = "LogWindow";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogWindowForm_FormClosing);
			this.Load += new System.EventHandler(this.LogWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox LogTextBox;
		private System.Windows.Forms.GroupBox LogLevelsGroup;
	}
}