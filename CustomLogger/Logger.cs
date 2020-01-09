using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomLogger {

	//TODO handles the multi-threaded aspect of logging.
	public class Logger {

		private ConcurrentBag<LogOutput> outputs = new ConcurrentBag<LogOutput>();
		private ConcurrentQueue<Tuple<LogLevel, string, string, int, ThreadPriority>> logQueue = new ConcurrentQueue<Tuple<LogLevel, string, string, int, ThreadPriority>>();
		private Thread logThread;

		public Logger() {
			logThread = new Thread(logLoop);
			logThread.IsBackground = true;
			logThread.Name = "Logging Thread";
			logThread.Priority = ThreadPriority.Normal;
			logThread.Start();
		}

		private void logLoop() {
			Tuple<LogLevel, string, string, int, ThreadPriority> log;
			while (true) {
				if(logQueue.TryDequeue(out log)) {
					foreach (LogOutput output in outputs) {
						output.Log(log.Item1, log.Item2, log.Item3, log.Item4, log.Item5\);
					}
				}
			}
		}

		public void AddOutput(LogOutput output) {
			if (output != null) outputs.Add(output);
		}

		public void Flush() {
			foreach (LogOutput output in outputs) output.Flush();
		}
		//TODO finish tomorrow: Not actually thread safe? Although the lists won;t break, the same file may have multiple operations trying to access it at once (i.e. writing while disposing)
		public void Close() {
			foreach (LogOutput output in outputs) {
				output.Dispose();
			}
		}

		public void Log(LogLevel level, string msg) {
			logQueue.Enqueue(new Tuple<LogLevel, string, string, int, ThreadPriority>(level, msg, Thread.CurrentThread.Name, Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.Priority));
		}

	}
}
