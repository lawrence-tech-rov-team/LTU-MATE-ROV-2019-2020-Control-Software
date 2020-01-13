using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JSON {
	public class JsonObject {

		private Dictionary<string, object> items;
		public IEnumerable<KeyValuePair<string, object>> Items { get => items.AsEnumerable(); }


		public JsonObject() {
			items = new Dictionary<string, object>();
		}

		public JsonObject(Dictionary<string, object> items) {
			this.items = items;
		}

		public static JsonObject FromDictionary<T>(Dictionary<string, T> dict) {
			JsonObject obj = new JsonObject();
			foreach (KeyValuePair<string, T> pair in dict) obj.items[pair.Key] = pair.Value.ToString();
			return obj;
		}

		public void Add(string key, object value) {
			items[key] = value;
		}

		public object this[string key] {
			get {
				if (items.ContainsKey(key)) return items[key];
				else return null;
			}
			set => items[key] = value;
		}

		public T ReadAs<T>(string key) where T : class {
			object obj = this[key];
			if ((obj == null) || !(obj is T)) return null;
			else return (T)obj;
		}

		internal void Serialize(StringBuilder writer, int depth) {
			writer.Append('{');
			if (items.Count > 0) {
				depth++;
				bool isFirst = true;
				foreach (KeyValuePair<string, object> pair in items) {
					if (!isFirst) writer.Append(',');
					else isFirst = false;
					writer.AppendLine();
					writer.Append('\t', depth);
					Json.SerializeString(writer, pair.Key);
					writer.Append(": ");
					Json.SerializeValue(writer, pair.Value, depth);
				}
				depth--;
				writer.AppendLine();
				writer.Append('\t', depth);
				writer.Append('}');
			} else {
				writer.Append('}');
			}
		}

		internal static JsonObject Parse(StringReader reader) {
			Json.ReadWhitespace(reader);
			if (reader.Read() != '{') return null;
			Json.ReadWhitespace(reader);

			JsonObject obj = new JsonObject();
			while ((reader.Peek() != '}') && (reader.Peek() != -1)) {
				//Read key
				string key = Json.ParseString(reader);
				if (key == null) return null;
				Json.ReadWhitespace(reader);
				if (reader.Read() != ':') return null;

				//Determine value;
				JsonValue value = Json.ParseValue(reader);
				if (value.isEmpty) return null;
				else {
					if (obj.items.ContainsKey(key)) return null;
					obj.items.Add(key, value.Value);
				}
				Json.ReadWhitespace(reader);
				if (reader.Peek() == ',') {
					reader.Read(); //We are going to look, we can ignore the comma.
					Json.ReadWhitespace(reader);
					if (reader.Peek() == '}' || reader.Peek() == -1) return null;
				}
				Json.ReadWhitespace(reader); //Prepare for the next loop
			}
			Json.ReadWhitespace(reader);
			if (reader.Read() != '}') return null;
			return obj;
		}
	}
}