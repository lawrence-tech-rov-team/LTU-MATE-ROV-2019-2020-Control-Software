using JsonSerializable;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Controls {
	public class GripperPosition : IJsonSerializable {

		private ushort openPos = 270;
		private ushort closePos = 0;

		public ushort OpenAngle {
			get => openPos;
			set => openPos = (value <= 270) ? value : (ushort)270;
		}

		public ushort ClosedAngle {
			get => closePos;
			set => closePos = (value <= 270) ? value : (ushort)270;
		}

		private readonly string Name;

		public GripperPosition(string name) {
			Name = name;
		}

		public void Open(Servo servo) {
			servo.Angle = OpenAngle;
		}

		public void Close(Servo servo) {
			servo.Angle = ClosedAngle;
		}

		public bool LoadFromJson(JsonData Data) {
			if((Data != null) && (Data is JsonObject obj)) {
				object openObj = obj["Open"];
				object closedObj = obj["Closed"];
				if((openObj != null) && (closedObj != null) && (openObj is JsonInteger open) && (closedObj is JsonInteger closed)) {
					if((open.Value >= 0) && (closed.Value >= 0) && (open.Value <= 270) && (closed.Value <= 270)) {
						OpenAngle = (ushort)open.Value;
						ClosedAngle = (ushort)closed.Value;
						return true;
					}
				}
			}

			return false;
		}

		public JsonData SaveToJson() {
			JsonObject obj = new JsonObject();
			obj["Open"] = new JsonInteger(OpenAngle);
			obj["Closed"] = new JsonInteger(ClosedAngle);
			return obj;
		}

		public override string ToString() {
			return Name;
		}
	}
}
