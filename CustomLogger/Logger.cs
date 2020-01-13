using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomLogger {

	/// <summary>
	/// Handles multiple threads at once to write logs to multiple different outputs.
	/// Logging messages are taken as asynchronous operations then stored in a queue to be processed by a dedicated logging thread at a later time.
	/// By calling Close(), the operation will block until the log fully closes. CloseAsync() will tell the logger to close without blocking the call.
	/// 
	/// Attempting to log after the log's closure will not result in any exceptions and will not be written to any outputs,
	/// however if logging fast enough may prevent the log from closing.
	/// </summary>
	public class Logger {

		private ConcurrentBag<LogOutput> outputs = new ConcurrentBag<LogOutput>();
		private ConcurrentQueue<Tuple<LogLevel, string, string, int, ThreadPriority>> logQueue = new ConcurrentQueue<Tuple<LogLevel, string, string, int, ThreadPriority>>();
		private Thread logThread;
		private volatile bool isLogging = true;
		//private volatile bool shouldFlush = false;

		/// <summary>
		/// Creates a new logger with the given thread priority for the logging thread. 
		/// </summary>
		/// <param name="priority"></param>
		public Logger(ThreadPriority priority = ThreadPriority.Normal) {
			logThread = new Thread(logLoop);
			logThread.IsBackground = true;
			logThread.Name = "Logging Thread";
			logThread.Priority = priority;
			logThread.Start();
		}

		private void logLoop() {
			Tuple<LogLevel, string, string, int, ThreadPriority> log;
			while (isLogging) {
				while(logQueue.TryDequeue(out log)) {
					foreach (LogOutput output in outputs) output.Log(log.Item1, log.Item2, log.Item3, log.Item4, log.Item5);
				}
				/*if (shouldFlush) {
					shouldFlush = false;
					foreach (LogOutput output in outputs) output.Flush();
				}*/
			}
			
			//Ensure log is empty
			while(logQueue.TryDequeue(out log)) {
				foreach (LogOutput output in outputs) output.Log(log.Item1, log.Item2, log.Item3, log.Item4, log.Item5);
			}

			foreach(LogOutput output in outputs) {
				output.Flush();
				output.Dispose();
			}
		}

		/// <summary>
		/// Adds a new output to log to. Can't be removed due to some limitations.
		/// </summary>
		/// <param name="output"></param>
		public void AddOutput(LogOutput output) {
			if (output != null) outputs.Add(output);
		}

		/*public void Flush() {
			shouldFlush = true;
		}*/
		
		/// <summary>
		/// Non-blocking, tells the logger to close without waiting for it to finish closing.
		/// </summary>
		public void CloseAsync() {
			isLogging = false;
		}

		/// <summary>
		/// Blocking call that closes the logger and waits for it to finish closing.
		/// If the logger is already closed the operation will appear as if it is non-blocking.
		/// </summary>
		public void Close() {
			isLogging = false;
			logThread.Join();
		}

		/// <summary>
		/// Asynchronous operation that adds a log to the queue to be later serviced by the logging thread.
		/// </summary>
		/// <param name="level"></param>
		/// <param name="msg"></param>
		public void Log(LogLevel level, string msg) {
			logQueue.Enqueue(new Tuple<LogLevel, string, string, int, ThreadPriority>(level, msg, Thread.CurrentThread.Name, Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.Priority));
		}

	}
}
