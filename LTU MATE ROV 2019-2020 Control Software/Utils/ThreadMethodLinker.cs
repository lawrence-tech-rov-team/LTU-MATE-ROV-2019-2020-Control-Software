using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {

	/// <summary>
	/// The idea of this class to provide an easy (and ros-like) way to call functions in another thread.
	/// Ideally the object sits in the thread that is being called.
	/// Unidirectional, one thread calls the other, but not the other way around.
	/// 
	/// If every click is important (i.e. a few missed clicks will affect system functionality) then consider setting Blocking to true,
	/// which will cause the caller to block if the previous call has not been processed yet.
	/// </summary>
	public class ThreadMethodLinker {

		private volatile bool Invoked = false;
		private volatile object Args;

		public bool Blocking { get; }
		private Func<object, object> callbackFunc;

		public ThreadMethodLinker(Action callback, bool blocking = false) {
			this.callbackFunc = (object args) => {
				callback();
				return null;
			};
			this.Blocking = blocking;
		}

		public ThreadMethodLinker(Action<object> callback, bool blocking = false) {
			this.callbackFunc = (object args) => {
				callback(args);
				return null;
			};
			this.Blocking = blocking;
		}

		public ThreadMethodLinker(Func<object> callback, bool blocking = false) {
			this.callbackFunc = (object args) => { return callback(); };
			this.Blocking = blocking;
		}

		public ThreadMethodLinker(Func<object, object> callback, bool blocking = false) {
			this.callbackFunc = callback;
			this.Blocking = blocking;
		}

		/// <summary>
		/// Called from the sending thread
		/// </summary>
		public void Invoke() {
			Invoke(null);
		}

		/// <summary>
		/// Called from the sending thread
		/// </summary>
		public void Invoke(object args) {
			bool invoked = Invoked;
			if (invoked & Blocking) {
				while (Invoked) {
					Thread.Sleep(1);
				}
				invoked = false;
			}

			if (!invoked) {
				Args = args;
				Invoked = true;
			}
		}

		public void ProcessEvent() {
			if (Invoked) {
				object args = Args;
				Invoked = false;
				callbackFunc?.Invoke(args);
			}
		}
	}
}
