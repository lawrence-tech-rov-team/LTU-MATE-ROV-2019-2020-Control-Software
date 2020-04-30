using JsonSerializable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Controls {
	public class GripperPosition : IJsonSerializable {

		private ushort openPos = 270;
		private ushort closePos = 0;

		public ushort Open {
			get => openPos;
			set => openPos = (value <= 270) ? value : (ushort)270;
		}

		public ushort Closed {
			get => closePos;
			set => closePos = (value <= 270) ? value : (ushort)270;
		}

		private string Name;

		public GripperPosition(string name) {
			Name = name;
		}

		public bool LoadFromJson(JsonData Data) {
			if((Data != null) && (Data is JsonObject obj)) {
				object openObj = obj["Open"];
				object closedObj = obj["Closed"];
				if((openObj != null) && (closedObj != null) && (openObj is JsonInteger open) && (closedObj is JsonInteger closed)) {
					if((open.Value >= 0) && (closed.Value >= 0) && (open.Value <= 270) && (closed.Value <= 270)) {
						Open = (ushort)open.Value;
						Closed = (ushort)closed.Value;
						return true;
					}
				}
			}

			return false;
		}

		public JsonData SaveToJson() {
			JsonObject obj = new JsonObject();
			obj["Open"] = new JsonInteger(Open);
			obj["Closed"] = new JsonInteger(Closed);
			return obj;
		}

		public override string ToString() {
			return Name;
		}
	}
}
