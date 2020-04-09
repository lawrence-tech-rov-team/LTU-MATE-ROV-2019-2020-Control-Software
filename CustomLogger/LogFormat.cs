using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomLogger {
	public class LogFormat {

		internal string GetHeader(LogLevel level, string ThreadName, int threadId, ThreadPriority threadPriority) {
			MethodBase method = new StackTrace().GetFrame(2).GetMethod();
			string className = method.ReflectedType.Name;

			string date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss \"GMT\"zzz");
			return date + " [" + className + "] " + threadPriority.ToString() + " \"" + ThreadName + "\" {" + threadId.ToString() + "} " + level.ToString() + ": ";
		}

	}
}
