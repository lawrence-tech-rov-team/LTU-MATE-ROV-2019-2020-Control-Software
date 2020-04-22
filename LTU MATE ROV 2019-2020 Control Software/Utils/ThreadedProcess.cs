using CustomLogger;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {
	public abstract class ThreadedProcess {

		private readonly Thread thread;
		private volatile bool running = false;
		protected bool ShouldExit { get => !running; }
		private Stopwatch timer = new Stopwatch();

		public ThreadPriority Priority {
			get {
				try {
					return thread.Priority;
				} catch (Exception ex) {
					Log.Warn("Failed to get thread priority.", ex);
					return ThreadPriority.Normal;
				}
			}

			set {
				try {
					thread.Priority = value;
					Log.Info("Thread \"" + (thread?.Name ?? "(null)") + "\" priority changed: " + value.ToString());
				} catch (Exception ex) {
					Log.Warn("Failed to set thread priority.", ex);
				}
			}
		}

		public ThreadedProcess(string Name, ThreadPriority Priority = ThreadPriority.Normal) {
			thread = new Thread(ThreadLoop);
			thread.IsBackground = true;
			thread.Name = Name;
			this.Priority = Priority;
		}

		public bool Start() {
			try {
				running = true;
				thread.Start();
				return true;
			} catch (Exception ex) {
				Log.Error("Unable to start thread! Name = " + (thread?.Name ?? "null"), ex);
				return false;
			}
		}

		public void Start(ThreadPriority Priority) {
			this.Priority = Priority;
			Start();
		}

		private void ThreadLoop() {
			Log.Info("Thread started."); 
			try {
				Initialize();
				Log.Info("Thread initialized.");
				try {
					while (running) {
						if (!Loop()) running = false;
					}
				} catch (Exception ex) {
					Log.Error("Unexpected error in thread loop.", ex);
					running = false;
				}
				Cleanup();
				Log.Info("Thread cleaned up.");
			} catch (Exception ex) {
				Log.Error("Unexpected error in thread.", ex);
			}
			Log.Info("Thread finished.");
		}

		protected abstract void Initialize();

		/// <summary>
		/// Return true if the thread should continue. Return false to exit the thread.
		/// </summary>
		/// <returns></returns>
		protected abstract bool Loop();

		protected abstract void Cleanup();

		/// <summary>
		/// Returns true if successful, false if was interrupted by an exit request.
		/// </summary>
		protected bool Sleep(long millis) {
			timer.Restart();
			while (timer.ElapsedMilliseconds < millis) {
				if (!running) return false;
				Thread.Sleep(1);
			}
			return true;
		}

		public void StopAsync() {
			running = false;
		}

		public void Stop() {
			try {
				StopAsync();
				thread.Join();
			} catch (Exception ex) {
				Log.Info("Error stopping thread: \"" + (thread?.Name ?? "(null)") + "\"", ex);
			}
		}

	}
}
