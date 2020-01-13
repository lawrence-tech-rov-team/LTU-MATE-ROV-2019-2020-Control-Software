using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JSON {
	public class JsonArray : IEnumerable<object> {

		private List<object> Values;

		public JsonArray() {
			Values = new List<object>();
		}

		public JsonArray(List<object> values) {
			Values = values;
		}

		public JsonArray(object[] values) {
			Values = new List<object>(values);
		}

		public static JsonArray FromArray<T>(List<T> arr) {
			JsonArray json = new JsonArray();
			foreach (T t in arr) json.Add(t.ToString());
			return json;
		}

		public static JsonArray FromArray<T>(T[] arr) {
			JsonArray json = new JsonArray();
			foreach (T t in arr) json.Add(t.ToString());
			return json;
		}

		/// <summary>
		/// Every value must be of the given type, or else returns null;
		/// </summary>
		public T[] ToArray<T>() {
			T[] arr = new T[Values.Count];
			for (int i = 0; i < arr.Length; i++) {
				if (!(Values[i] is T)) return null;
				else arr[i] = (T)Values[i];
			}
			return arr;
		}

		public List<T> ToList<T>() {
			List<T> arr = new List<T>();
			foreach (object obj in Values) {
				if (!(obj is T)) return null;
				else arr.Add((T)obj);
			}
			return arr;
		}

		public void Add(object obj) {
			Values.Add(obj);
		}

		public IEnumerator<object> GetEnumerator() {
			return Values.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return Values.GetEnumerator();
		}

		internal void Serialize(StringBuilder writer, int depth) {
			writer.Append('[');
			if (Values.Count > 0) {
				depth++;
				bool isFirst = true;
				foreach (object obj in Values) {
					if (!isFirst) writer.Append(',');
					else isFirst = false;
					writer.AppendLine();
					writer.Append('\t', depth);
					Json.SerializeValue(writer, obj, depth);
				}
				depth--;
				writer.AppendLine();
				writer.Append('\t', depth);
				writer.Append(']');
			} else {
				writer.Append(']');
			}
		}

		internal static JsonArray Parse(StringReader reader) {
			Json.ReadWhitespace(reader);
			if (reader.Read() != '[') return null;

			JsonArray array = new JsonArray();
			Json.ReadWhitespace(reader);
			while ((reader.Peek() != ']') && (reader.Peek() != -1)) {
				JsonValue value = Json.ParseValue(reader);
				if (value.isEmpty) return null;
				array.Values.Add(value.Value);
				Json.ReadWhitespace(reader);
				if (reader.Peek() == ',') {
					reader.Read(); //Discard separator
					Json.ReadWhitespace(reader);
					if (reader.Peek() == ']' || reader.Peek() == -1) return null;
				}
				Json.ReadWhitespace(reader); //Prepare for next loop
			}
			Json.ReadWhitespace(reader);
			if (reader.Read() != ']') return null;
			else return array;
		}

	}
}