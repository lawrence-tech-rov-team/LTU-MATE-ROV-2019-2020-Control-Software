using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JSON {
	public static class Json {

		public static bool WriteToFile(JsonObject json, string path) {
			if (json == null) return false;
			try {
				StringBuilder sb = new StringBuilder();
				json.Serialize(sb, 0);
				File.WriteAllText(path, sb.ToString());
				return true;
			} catch (Exception e) {
				Console.WriteLine("Error writing JSON file: " + e.Message);
				Console.WriteLine(e.StackTrace);
				return false;
			}
		}

		public static JsonObject ParseFromFile(string path) {
			try {
				string file = File.ReadAllText(path); //file = Regex.Replace(File.ReadAllText(path), @"\s+", ""); //Remove whitespace
				using (StringReader reader = new StringReader(file)) {
					return JsonObject.Parse(reader);
				}
			} catch (Exception e) {
				Console.Error.WriteLine("Could not read JSON file: " + e.Message);
				return null;
			}
		}

		internal static void SerializeValue(StringBuilder writer, object value, int depth) {
			if (value == null) {
				writer.Append("null");
			} else if (value is JsonArray) {
				((JsonArray)value).Serialize(writer, depth);
			} else if (value is JsonObject) {
				((JsonObject)value).Serialize(writer, depth);
			} else if ((value is string) || (value is char)) {
				if (value is char) value = "" + value;
				SerializeString(writer, (string)value);
			} else if (IsBasicType(value)) {
				SerializeStringNoQuotes(writer, value.ToString());
			} else {
				SerializeString(writer, value.ToString());
			}
		}

		private static bool IsBasicType(this object value) {
			return value is sbyte
					|| value is byte
					|| value is short
					|| value is ushort
					|| value is int
					|| value is uint
					|| value is long
					|| value is ulong
					|| value is float
					|| value is double
					|| value is decimal
					|| value is bool;
		}

		private static void SerializeStringNoQuotes(StringBuilder writer, string str) {
			foreach (char c in str) {
				if (c == '\\' || c == '\'' || c == '\"') {
					writer.Append('\\');
				}
				writer.Append(c);
			}
		}

		internal static void SerializeString(StringBuilder writer, string str) {
			writer.Append('\"');
			SerializeStringNoQuotes(writer, str);
			writer.Append('\"');
		}

		internal static void ReadWhitespace(StringReader reader) {
			int raw;
			char c;
			while (true) {
				raw = reader.Peek();
				if (raw == -1) return;
				c = (char)raw;
				if (char.IsWhiteSpace(c)) reader.Read();
				else break;
			}
		}

		internal static string ParseString(StringReader reader) {
			string str = "";
			Json.ReadWhitespace(reader);
			if (reader.Read() != '\"') return null;
			while (reader.Peek() != '\"') {
				int raw = reader.Read();
				if (raw == -1) return null;
				char c = (char)raw;

				if (c == '\\') {
					if (reader.Peek() == -1) return null;
					char special = (char)reader.Read();
					if (special == '\'' || special == '\"' || special == '\\') {
						str += special;
					} else {
						str += c;
					}
				} else {
					str += c;
				}
				if (reader.Peek() == -1) return null;
			}
			reader.Read(); //Discard last quote
			return str;
		}

		internal static JsonValue ParseValue(StringReader reader) {
			Json.ReadWhitespace(reader);
			if (reader.Peek() == '{') return new JsonValue(false, JsonObject.Parse(reader));
			else if (reader.Peek() == '[') return new JsonValue(false, JsonArray.Parse(reader));
			else if (reader.Peek() == '\"') {
				string str = Json.ParseString(reader);
				if (str == null)
					return new JsonValue(true);
				else return new JsonValue(false, str);
			} else if (reader.Peek() == -1)
				return new JsonValue(true);
			else {
				if ((reader.Peek() == 'n') || (reader.Peek() == 'N')) {
					if (checkForNull(reader)) return new JsonValue(false, null);
					else return new JsonValue(true);
				} else if ((reader.Peek() == 't') || (reader.Peek() == 'T') || (reader.Peek() == 'f') || (reader.Peek() == 'F')) {
					string str = "";
					for (int i = 0; i < "true".Length; i++) str += (char)reader.Read();
					bool b;
					if (bool.TryParse(str, out b)) return new JsonValue(false, b);
					str += (char)reader.Read();
					if (bool.TryParse(str, out b)) return new JsonValue(false, b);
					else return new JsonValue(true);
				}

				string number = "";
				while (reader.Peek() == '-' || reader.Peek() == '.' || char.IsDigit((char)reader.Peek())) {
					number += (char)reader.Read();
				}
				double d;
				long lg;

				if (long.TryParse(number, out lg)) {
					return new JsonValue(false, lg);
				} else if (double.TryParse(number, out d)) {
					return new JsonValue(false, d);
				} else {
					return new JsonValue(true);
				}
			}
		}

		private static bool checkForNull(StringReader reader) {
			Json.ReadWhitespace(reader);
			if (reader.Peek() == 'n' || reader.Peek() == 'N') {
				reader.Read();
				if (reader.Peek() == 'u' || reader.Peek() == 'U') {
					reader.Read();
					if (reader.Peek() == 'l' || reader.Peek() == 'L') {
						reader.Read();
						if (reader.Peek() == 'l' || reader.Peek() == 'L') {
							reader.Read();
							return true;
						}
					}
				}
			}
			return false;
		}
	}

	internal struct JsonValue {
		internal bool isEmpty;
		internal object Value;

		internal JsonValue(bool isEmpty) {
			this.isEmpty = isEmpty;
			Value = null;
		}

		internal JsonValue(bool isEmpty, object value) {
			this.isEmpty = isEmpty;
			this.Value = value;
		}
	}
}