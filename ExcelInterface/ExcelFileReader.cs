using ExcelDataReader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelInterface.Reader {
	public class ExcelFileReader : IEnumerable<WorksheetReader> {

		public string FilePath { get; private set; }
		private WorksheetReader[] worksheets;
		public WorksheetReader[] Worksheets {
			get {
				if (worksheets == null) return null;
				WorksheetReader[] ws = new WorksheetReader[worksheets.Length];
				worksheets.CopyTo(ws, 0);
				return ws;
			}
		}

		private ExcelFileReader(string path, WorksheetReader[] ws) {
			this.FilePath = path;
			this.worksheets = ws;
		}

		public static ExcelFileReader LoadFromFile(string path) {
			string fullPath = Path.GetFullPath(path);
			if (File.Exists(fullPath)) {
				//ExcelFile file = null;
				//PopupProgressBar.Show("Opening File", "Opening file...", new Action<DoWorkEventArgs, BackgroundWorker>(
				//	(DoWorkEventArgs e, BackgroundWorker worker) => {
				//file = new ExcelFile(path);
				//	}), true); 
				//return file;
				return ReadDataFromFile(path);
			} else {
				Console.WriteLine("Could not load excel data from file: file does not exist. \"" + path + "\"");
			}

			return null;
		}

		private static ExcelFileReader ReadDataFromFile(string path) {
			try {
				using (Stream stream = File.Open(path, FileMode.Open, FileAccess.Read)) {
					using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream)) {
						List<WorksheetReader> worksheets = new List<WorksheetReader>();
						do {
							WorksheetReader ws = WorksheetReader.ParseFromFile(reader);
							if (ws != null) worksheets.Add(ws);
						} while (reader.NextResult());

						return new ExcelFileReader(path, worksheets.ToArray());
					}
				}
			} catch (Exception e) {
				Console.Error.WriteLine(e.Message);
				Console.Error.WriteLine(e.StackTrace);
				return null;
			}
		}

		public IEnumerator<WorksheetReader> GetEnumerator() {
			return worksheets.AsEnumerable().GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return worksheets.GetEnumerator();
		}

	}
}