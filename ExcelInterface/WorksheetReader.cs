using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelInterface.Reader {
	public class WorksheetReader {

		public string Name { get; private set; }
		public int Columns { get; private set; }
		public int Rows { get; private set; }
		private string[,] data;

		public WorksheetReader(string name, string[,] data, int cols, int rows) {
			this.Name = name;
			this.data = data;
			this.Columns = cols;
			this.Rows = rows;
		}

		public string GetCellData(int row, int col) {
			if ((row < 0) || (col < 0) || (row >= Rows) || (col >= Columns)) return null;
			return data[row, col];
		}

		public static WorksheetReader ParseFromFile(IExcelDataReader reader) {
			List<List<string>> data = new List<List<string>>();

			int maxCol = -1;
			for (uint rowIndex = 1; rowIndex <= reader.RowCount; rowIndex++) {
				reader.Read();

				List<string> rowData = new List<string>();
				for (int colIndex = 0; colIndex < reader.FieldCount; colIndex++) {
					//double subProgress = (double)(1 / reader.RowCount) * ((double)colIndex / reader.FieldCount);
					//worker.ReportProgress((int)(100 * (progress + subProgress)));
					try {
						object obj = reader.GetValue(colIndex);
						string cellData;
						if (obj == null) cellData = null;
						else {
							cellData = obj.ToString();
							maxCol = Math.Max(maxCol, colIndex);
						}
						rowData.Add(cellData);
					} catch (Exception) {
						rowData.Add(null);
					}
				}

				data.Add(rowData);
			}

			//rows, columns
			int numCols = maxCol + 1;
			string[,] arr = new string[data.Count, numCols];
			int y = 0;
			int x = 0;
			foreach (List<string> row in data) {
				if (y >= data.Count) break;
				x = 0;
				foreach (string item in row) {
					if (x >= numCols) break;
					arr[y, x] = item;
					x++;
				}
				for (; x < numCols; x++) {
					arr[y, x] = null;
				}
				y++;
			}

			return new WorksheetReader(reader.Name, arr, numCols, data.Count);
		}

		public override string ToString() {
			return Name;
		}
	}
}