using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonSerializable;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Settings {
	public class AppSettings : IJsonSerializable {

		private const string SettingsSavePath = "Settings.json";

		public SerializableDictionary<Range> ServoRanges = new SerializableDictionary<Range>();

		public AppSettings(RobotThread robot) {
			robot.OnConnected += Robot_OnConnected;
		}

		private void Robot_OnConnected(Robot.Hardware.Robot sender) {
			if((sender != null) && (sender is ROV rov)) {
				foreach(KeyValuePair<char, Servo[]> pair in rov.Servos) {
					Servo[] servos = pair.Value;
					for(int i = 0; i < servos.Length; i++) {
						string name = pair.Key + (i + 1).ToString();
						if (ServoRanges.ContainsKey(name)) {
							servos[i].PulseRange = ServoRanges[name];
						}
					}
				}
			}
		}

		public bool Save() {
			return Json.WriteToFile(this, SettingsSavePath);
		}

		public bool Load() {
			return Json.ParseFromFile(SettingsSavePath, this);
		}

		public bool LoadFromJson(JsonData Data) {
			if ((Data != null) && (Data is JsonObject obj)) {
				bool successful = true;

				if (!ServoRanges.LoadFromJson(obj["Servo Ranges"])) successful = false;

				return successful;
			} else {
				return false;
			}
		}

		public JsonData SaveToJson() {
			JsonObject obj = new JsonObject();
			obj["Servo Ranges"] = ServoRanges.SaveToJson();
			return obj;
		}
	}
}
