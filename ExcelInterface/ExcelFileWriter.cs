using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelInterface.Writer {
	public class ExcelFileWriter : IDisposable {

		private Application App;
		private List<WorkbookWriter> books = new List<WorkbookWriter>();

		public bool IsOpen { get => App != null; }

		private ExcelFileWriter(Application app) {
			this.App = app;
		}

		public static ExcelFileWriter OpenExcelApplication() {
			try {
				Application app = new Application();
				app.Visible = false;
				app.ScreenUpdating = false;
				app.DisplayAlerts = false;
				return new ExcelFileWriter(app);
			} catch (Exception ex) {
				Console.Error.WriteLine("Error when opening a new excel application: \"" + ex.Message + "\"");
				Console.Error.WriteLine(ex.StackTrace);
			}

			return null;
		}

		public WorkbookWriter CreateNewWorkbook() {
			if (App == null) {
				Console.Error.WriteLine("Could not create new workbook: Excel application is already closed.");
				return null;
			}
			try {
				Workbook wb = App.Workbooks.Add();
				if (wb == null) throw new NullReferenceException("New workbook returned null.");
				WorkbookWriter wbWriter = new WorkbookWriter(this, wb);
				books.Add(wbWriter);
				return wbWriter;
			} catch (Exception ex) {
				Console.Error.WriteLine("Error creating a new WorkbookWriter: \'" + ex.Message + "\"");
				Console.Error.WriteLine(ex.StackTrace);
			}

			return null;
		}

		internal void BookClosed(WorkbookWriter book) {
			books.Remove(book);
		}

		public void Close() {
			if (App == null) Console.Error.WriteLine("Could not close Excel: Excel application is already closed.");
			else {
				try {
					foreach (WorkbookWriter book in books) {
						book.Close();
					}

					App.Quit();
					App = null;
				} catch (Exception ex) {
					Console.Error.WriteLine("Error when trying to quit excel: \"" + ex.Message + "\"");
					Console.Error.WriteLine(ex.StackTrace);
				}
			}
		}

		public void Close() {
			Close();
			App = null; //We tried our best
		}

		~ExcelFileWriter() {
			Close();
		}

	}
}