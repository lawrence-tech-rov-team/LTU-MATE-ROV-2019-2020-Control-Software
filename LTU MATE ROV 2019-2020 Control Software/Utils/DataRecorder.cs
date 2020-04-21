using ExcelInterface.Writer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {
	public class DataRecorder {

		private Dictionary<string, List<object>> allData = new Dictionary<string, List<object>>();
		private List<string> orderedCategories = new List<string>();

		public void Log(string category, object data) {
			if (!allData.ContainsKey(category)) {
				allData[category] = new List<object>();
				orderedCategories.Add(category);
			}

			allData[category].Add(data);
		}

		public bool SaveToExcel(string FileName) {
			try {
				using(ExcelFileWriter file = ExcelFileWriter.OpenExcelApplication()) {
					if (file == null) throw new NullReferenceException("Failed to open the Excel application.");
					using(WorkbookWriter book = file.CreateNewWorkbook()) {
						if (book == null) throw new NullReferenceException("Failed to create a new Excel workbook.");
						WorksheetWriter sheet = book.GetActiveWorksheet();
						if (sheet == null) throw new NullReferenceException("Failed to find the active worksheet.");
						sheet.Name = "Data Acquisition";

						int col = WorksheetWriter.MinColumn;
						int row;
						foreach(string cat in orderedCategories) {
							row = WorksheetWriter.MinRow;
							sheet[row, col] = cat;
							sheet.Bold(row, col);

							foreach(object data in allData[cat]) {
								sheet[++row, col] = data.ToString();
							}

							col++;
						}

						sheet.AutoFitAllColumns();
						return book.Save(FileName + WorkbookWriter.DEFAULT_FILE_EXTENSION);
					}
				}
			} catch (Exception) {
				Console.WriteLine("Unable to save data.");
				return false;
			}
		}

		public bool SaveToCSV(string FileName) {
			try {
				using (StreamWriter writer = new StreamWriter(File.OpenWrite(FileName + ".csv"))) {
					bool writeComma = false;

					foreach(string cat in orderedCategories) {
						if (writeComma) writer.Write(',');
						if (cat.Contains(',')) {
							writer.Write('\"');
							writer.Write(cat);
							writer.Write('\"');
						} else {
							writer.Write(cat);
						}
						writeComma = true;
					}

					int i = -1;
					bool dataRemaining = true;
					while (dataRemaining) {
						i++;
						dataRemaining = false;
						writeComma = false;
						writer.Write('\n');

						foreach (string cat in orderedCategories) {
							List<object> data = allData[cat];
							if (writeComma) writer.Write(',');
							if(i < data.Count) {
								writer.Write(data[i]);
								if ((i + 1) < data.Count) dataRemaining = true;
							}
							writeComma = true;
						}
					}

					writer.Flush();
					return true;
				}
			} catch (Exception) {
				Console.WriteLine("Unable to save data.");
				return false;
			}
		}

	}
}
