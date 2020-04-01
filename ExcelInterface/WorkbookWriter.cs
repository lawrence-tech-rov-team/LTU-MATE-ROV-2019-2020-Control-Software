using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelInterface.Writer {
	public class WorkbookWriter : IDisposable {

		public static readonly string DEFAULT_FILE_EXTENSION = ".xlsx";
		private ExcelFileWriter file;
		private Workbook workbook;

		public bool IsOpen { get => workbook != null; }

		internal WorkbookWriter(ExcelFileWriter file, Workbook wb) {
			this.file = file;
			workbook = wb;
		}

		public WorksheetWriter GetActiveWorksheet() {
			dynamic sheet = workbook.ActiveSheet;
			if (sheet is Worksheet) {
				Worksheet ws = (Worksheet)sheet;
				if (ws == null) return null;
				return new WorksheetWriter(this, ws);
			} else return null;
		}

		public WorksheetWriter CreateNewWorksheet() {
			dynamic sheet = workbook.Worksheets.Add(After: workbook.Sheets[workbook.Sheets.Count]);
			if (sheet is Worksheet) {
				Worksheet ws = (Worksheet)sheet;
				if (ws == null) return null;
				return new WorksheetWriter(this, ws);
			} else return null;
		}
		// cancel button not working on popup, (for uploading), but force closing the window worked.
		public bool Save(string path) {
			if (workbook == null) Console.Error.WriteLine("Error saving workbook: Excel workbook is already closed.");
			else {
				try {
					string fullPath = Path.GetFullPath(path);
					if (!Path.HasExtension(fullPath)) fullPath += DEFAULT_FILE_EXTENSION;

					//if (File.Exists(fullPath)) File.Delete(fullPath);
					workbook.SaveAs(fullPath);
					return true;
				} catch (Exception ex) {
					Console.Error.WriteLine("Error saving workbook: \"" + ex.Message + "\"");
					Console.Error.WriteLine(ex.StackTrace);
				}
			}
			return false;
		}

		public void Close() {
			if (workbook == null) Console.Error.WriteLine("Error closing workbook: Excel workbook is already closed.");
			else {
				try {
					workbook.Close(false);
					workbook = null;
					file.BookClosed(this);
				} catch (Exception ex) {
					Console.Error.WriteLine("Error when closing workbook: \"" + ex.Message + "\"");
					Console.Error.WriteLine(ex.StackTrace);
				}
			}
		}

		public void Dispose() {
			Close();
			workbook = null; //We tried our best.
		}

		~WorkbookWriter() {
			Dispose();
		}
	}
}