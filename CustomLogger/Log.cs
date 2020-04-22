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
	public static class Log {

		private static LogFormat DefaultFormat = new LogFormat();

		private static ConcurrentBag<LogOutput> outputs = new ConcurrentBag<LogOutput>();
		private static ConcurrentQueue<Tuple<LogLevel, string, string, int, ThreadPriority>> logQueue = new ConcurrentQueue<Tuple<LogLevel, string, string, int, ThreadPriority>>();
		private static volatile Thread logThread;
		private static readonly object threadLock = new object();
		private static volatile bool isLogging = false;

		/// <summary>
		/// Creates a new logger with the given thread priority for the logging thread. 
		/// </summary>
		/// <param name="priority"></param>
		public static void StartLogger(ThreadPriority priority = ThreadPriority.Normal) {
			lock (threadLock) {
				if (logThread != null) return;
				isLogging = true;
				logThread = new Thread(logLoop);
				logThread.IsBackground = true;
				logThread.Name = "Logging Thread";
				logThread.Priority = priority;
				logThread.Start();
			}
		}

		/// <summary>
		/// Non-blocking, tells the logger to close without waiting for it to finish closing.
		/// </summary>
		public static void StopAsync() {
			isLogging = false;
		}

		/// <summary>
		/// Blocking call that closes the logger and waits for it to finish closing.
		/// If the logger is already closed the operation will appear as if it is non-blocking.
		/// </summary>
		public static void Stop() {
			isLogging = false;
			logThread.Join();
		}

		private static void broadcast(Tuple<LogLevel, string, string, int, ThreadPriority> log) {
			foreach (LogOutput output in outputs) {
				if (log.Item1 <= output.LogLevel) {
					try {
						LogFormat format = output.LogFormat;
						if (format == null) format = DefaultFormat;
						string header = format.GetHeader(log.Item1, log.Item3, log.Item4, log.Item5);
						output.Log(header + log.Item2);
					} catch (Exception) { } //If your logger throws an error, you have some serious issues.
				}
			}
		}

		private static void logLoop() {
			Tuple<LogLevel, string, string, int, ThreadPriority> log;
			while (isLogging) {
				while(logQueue.TryDequeue(out log)) {
					broadcast(log);
				}
				/*if (shouldFlush) {
					shouldFlush = false;
					foreach (LogOutput output in outputs) output.Flush();
				}*/
			}
			
			//Ensure log is empty
			while(logQueue.TryDequeue(out log)) {
				broadcast(log);
			}

			foreach(LogOutput output in outputs) {
				output.Close();
			}

			lock (threadLock) {
				logThread = null;
			}
		}

		/// <summary>
		/// Adds a new output to log to. Can't be removed due to some limitations.
		/// </summary>
		/// <param name="output"></param>
		public static void AddOutput(LogOutput output) {
			if (output != null) outputs.Add(output);
		}

		/// <summary>
		/// Adds a new output to log to. Can't be removed due to some limitations.
		/// </summary>
		/// <param name="output"></param>
		public static void AddOutput(LogOutput output, LogLevel Level) {
			if (output != null) {
				outputs.Add(output);
				output.LogLevel = Level;
			}
		}

		/// <summary>
		/// Asynchronous operation that adds a log to the queue to be later serviced by the logging thread.
		/// </summary>
		public static void All(string msg) { Record(LogLevel.All, msg); }

		/// <summary>
		/// Asynchronous operation that adds a log to the queue to be later serviced by the logging thread.
		/// </summary>
		public static void Debug(string msg) { Record(LogLevel.Debug, msg); }

		/// <summary>
		/// Asynchronous operation that adds a log to the queue to be later serviced by the logging thread.
		/// </summary>
		public static void Info(string msg) { Record(LogLevel.Info, msg); }

		/// <summary>
		/// Asynchronous operation that adds a log to the queue to be later serviced by the logging thread.
		/// </summary>
		public static void Warn(string msg) { Record(LogLevel.Warn, msg); }

		/// <summary>
		/// Asynchronous operation that adds a log to the queue to be later serviced by the logging thread.
		/// </summary>
		public static void Error(string msg) { Record(LogLevel.Error, msg); }

		/// <summary>
		/// Asynchronous operation that adds a log to the queue to be later serviced by the logging thread.
		/// </summary>
		public static void Fatal(string msg) { Record(LogLevel.Fatal, msg); }

		/// <summary>
		/// Asynchronous operation that adds a log to the queue to be later serviced by the logging thread.
		/// </summary>
		public static void Record(LogLevel level, string msg) {
			logQueue.Enqueue(new Tuple<LogLevel, string, string, int, ThreadPriority>(level, msg, Thread.CurrentThread.Name, Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.Priority));
		}

	}
}
