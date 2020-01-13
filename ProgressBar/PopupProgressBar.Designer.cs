namespace ProgressBar {
	partial class PopupProgressBar {
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
			this.ProgBar = new System.Windows.Forms.ProgressBar();
			this.OptionalText = new System.Windows.Forms.Label();
			this.Worker = new System.ComponentModel.BackgroundWorker();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ProgBar
			// 
			this.ProgBar.Location = new System.Drawing.Point(12, 12);
			this.ProgBar.MarqueeAnimationSpeed = 35;
			this.ProgBar.Name = "ProgBar";
			this.ProgBar.Size = new System.Drawing.Size(433, 48);
			this.ProgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.ProgBar.TabIndex = 0;
			// 
			// OptionalText
			// 
			this.OptionalText.AutoSize = true;
			this.OptionalText.Location = new System.Drawing.Point(12, 63);
			this.OptionalText.Name = "OptionalText";
			this.OptionalText.Size = new System.Drawing.Size(102, 20);
			this.OptionalText.TabIndex = 1;
			this.OptionalText.Text = "Optional Text";
			// 
			// Worker
			// 
			this.Worker.WorkerReportsProgress = true;
			this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
			this.Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Worker_ProgressChanged);
			this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Location = new System.Drawing.Point(363, 66);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(80, 31);
			this.CancelBtn.TabIndex = 2;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Visible = false;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// PopupProgressBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 105);
			this.ControlBox = false;
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.OptionalText);
			this.Controls.Add(this.ProgBar);
			this.Name = "PopupProgressBar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PopupProgressBar";
			this.Load += new System.EventHandler(this.PopupProgressBar_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar ProgBar;
		private System.Windows.Forms.Label OptionalText;
		private System.ComponentModel.BackgroundWorker Worker;
		private System.Windows.Forms.Button CancelBtn;
	}
}