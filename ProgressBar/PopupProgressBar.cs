using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar {
	public partial class PopupProgressBar : Form {
		/*
		public double Value {
			get => ProgBar.Value / 1000d;
			set {
				ProgBar.Invoke(new Action(() => {
					ProgBar.Value = Math.Max(0, Math.Min(1000, (int)(value * 1000)));
				}));
			}
		}
		*/
		private Action<DoWorkEventArgs, BackgroundWorker> Work;
		private bool cancelled = false;

		private PopupProgressBar(string title, string text, Action<DoWorkEventArgs, BackgroundWorker> work, bool infinite, bool Cancel) {
			InitializeComponent();
			this.Text = (title == null) ? "Progress" : title;
			OptionalText.Text = (text == null) ? "" : text;
			if (infinite) ProgBar.Style = ProgressBarStyle.Marquee;
			if (Cancel) {
				CancelBtn.Visible = true;
				Worker.WorkerSupportsCancellation = true;
			}
			Work = work;
		}

		private void PopupProgressBar_Load(object sender, EventArgs e) {
			OptionalText.Text = "";
			Worker.RunWorkerAsync();
		}
		/*
		public void StartMarquee() {
			ProgBar.Invoke(new Action(() => {
				ProgBar.Style = ProgressBarStyle.Marquee;
			}));
		}

		public void StopMarquee() {
			ProgBar.Invoke(new Action(() => {
				ProgBar.Style = ProgressBarStyle.Continuous;
			}));
		}
		*/
		private void CancelBtn_Click(object sender, EventArgs e) {
			Worker.CancelAsync();
		}

		private void Worker_DoWork(object sender, DoWorkEventArgs e) {
			Work?.Invoke(e, Worker);
			if (e.Cancel) {
				cancelled = true;
			}
		}

		private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
			object state = e.UserState;
			if ((state != null) && (state is ProgressBarStyle)) {
				ProgBar.Style = (ProgressBarStyle)state;
			}

			ProgBar.Value = Math.Max(0, Math.Min(100, e.ProgressPercentage));
		}

		private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			Close();
		}

		/// <summary>
		/// Return true if operation completed successfully, otherwise false if cancelled or failed.
		/// Use ProgressBarStyle as the UserState to change that.
		/// </summary>
		/// <param name="work"></param>
		/// <param name="SupportsCancel"></param>
		public static bool Show(string Title, string Text, Action<DoWorkEventArgs, BackgroundWorker> work, bool InfiniteProgress = false, bool SupportsCancel = false) {
			PopupProgressBar bar = new PopupProgressBar(Title, Text, work, InfiniteProgress, SupportsCancel);
			bar.ShowDialog();
			bar.Close();
			return bar.cancelled;
		}

		/// <summary>
		/// Return true if operation completed successfully, otherwise false if cancelled or failed.
		/// Used for blocking operations that still want a feedback to the user
		/// or a way to cancel the operation. Runs the given action on a new thread
		/// to prevent UI from freezing.
		/// </summary>
		/// <param name="work"></param>
		/// <param name="SupportsCancel"></param>
		public static bool Show(string Title, string Text, ThreadStart work, bool SupportsCancel = false, string ThreadName = "Progress Bar") {
			PopupProgressBar bar = new PopupProgressBar(Title, Text, new Action<DoWorkEventArgs, BackgroundWorker>(
				(DoWorkEventArgs args, BackgroundWorker worker) => {
					Thread thread = new Thread(work);
					thread.Name = "Worker Thread - " + ThreadName;
					thread.IsBackground = true;
					thread.Start();

					while (thread.IsAlive) {
						if (worker.CancellationPending) {
							thread.Abort();
							thread.Join();
							args.Cancel = true;
							break;
						}
					}
				}), true, SupportsCancel);
			bar.ShowDialog();
			bar.Close();
			return bar.cancelled;
		}

	}
}
