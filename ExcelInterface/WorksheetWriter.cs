using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelInterface.Writer {
	public class WorksheetWriter {

		private WorkbookWriter book;
		private Worksheet sheet;

		public bool IsOpen { get => book.IsOpen; }

		public const int MinColumn = 1;
		public const int MinRow = 1;

		public const int MaxColumn = 16384;
		public const int MaxRow = 1048576;

		public string Name {
			get => sheet.Name;
			set => sheet.Name = value;
		}

		internal WorksheetWriter(WorkbookWriter wb, Worksheet ws) {
			this.book = wb;
			sheet = ws;
		}

		#region Formatting
		public void SetColumnWidth(int col, float width) {
			if (IsValidColumn(col) && (width > 0f)) {
				sheet.Columns[col].ColumnWidth = width;
			}
		}

		public void AutoFitAllColumns() {
			sheet.Columns.AutoFit();
		}

		public void Bold(int row, int col) {
			if (IsValidRow(row) && IsValidColumn(col))
				sheet.Cells[row, col].Font.Bold = true;
		}

		public void SetFormatText(int row, int col) {
			if (IsValidRow(row) && IsValidColumn(col))
				sheet.Cells[row, col].NumberFormat = "@";
		}
		#endregion

		#region Cell data getter/setters
		public string this[int Row, int Col] {
			//get => GetValue(key);
			set {
				if (IsValidColumn(Col) && IsValidRow(Row)) {
					sheet.Cells[Row, Col] = value;
				}
			}
		}
		public string this[int Row, string Col] {
			set => this[Row, ColumnToInt(Col)] = value;
		}
		public string this[string Row, int Col] {
			set => this[RowToInt(Row), Col] = value;
		}
		public string this[string Row, string Col] {
			set => this[RowToInt(Row), ColumnToInt(Col)] = value;
		}
		#endregion

		#region Row/Column Parsers
		public static int ColumnToInt(string str) {
			if (str == null) return -1;

			int num = 0;
			foreach (char c in str) {
				if (num > (MaxColumn / 26)) return -1;
				num *= 26;

				char digit = char.ToUpper(c);
				if ((digit < 'A') || (digit > 'Z')) return -1;
				int n = digit - 'A' + 1;

				if (num > (MaxColumn - n)) return -1;
				num += n;
			}

			return num;
		}

		public static int RowToInt(string str) {
			int n;
			if (int.TryParse(str, out n)) {
				if ((n >= MinRow) && (n <= MaxRow)) return n;
			}
			return -1;
		}
		#endregion

		#region Row/Col Checkers
		#region Columns
		public static bool IsValidColumn(int col) {
			return (col >= MinColumn) && (col <= MaxColumn);
		}

		public static bool IsValidColumn(string col) {
			return IsValidColumn(ColumnToInt(col));
		}
		#endregion

		#region Rows
		public static bool IsValidRow(int row) {
			return (row >= MinRow) && (row <= MaxRow);
		}

		public static bool IsValidRow(string row) {
			return IsValidRow(RowToInt(row));
		}
		#endregion
		#endregion
	}
}