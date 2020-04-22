using CustomLogger;
using CustomLogger.Outputs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {
	public static class FileServices {

		public static void DeleteOldLogs() {
			try {
				DirectoryInfo directory = new DirectoryInfo(Path.GetDirectoryName("logs/"));
				FileInfo[] files = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).Reverse().ToArray();
				Log.Debug(files.Length + " log files found.");
				for (int i = 0; i < files.Length; i++) {
					Log.All("Found log file: " + files[i].FullName);
					if (i < (files.Length - 5)) {
						File.Delete(files[i].FullName);
						Log.Info("Log deleted: \"" + files[i].Name + "\"");
					}
				}
			} catch (Exception ex) {
				Log.Error("Error occured while deleting old logs.", ex);
			}
		}

		public static FileLogger GetLogFile() {
			return FileLogger.LoadFile("logs/Log [" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss \"GMT\"zzz").Replace(':', '_') + "].log");
		}

	}
}
