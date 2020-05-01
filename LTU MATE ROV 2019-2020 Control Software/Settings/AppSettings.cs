﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonSerializable;
using LTU_MATE_ROV_2019_2020_Control_Software.Controls;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot;
using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Settings {
	public class AppSettings : IJsonSerializable {

		private const string SettingsSavePath = "Settings.json";

		public SerializableDictionary<Range> ServoRanges = new SerializableDictionary<Range>();
		//TODO Gripper class that contains these definitions? Allows input to simply say open/close?
		public GripperPosition SpongeGripper = new GripperPosition("Sponge");
		public GripperPosition MediumGripper = new GripperPosition("Medium");
		public GripperPosition SmallGripper = new GripperPosition("Small");
		public GripperPosition TinyGripper = new GripperPosition("Tiny");
		public GripperPosition NetGripper = new GripperPosition("Net");

		public AppSettings(RobotThread robot) {
			robot.OnConnected += Robot_OnConnected;
		}

		private void Robot_OnConnected(Robot.Hardware.Robot sender) {
			if((sender != null) && (sender is ROV rov)) {
				foreach(KeyValuePair<char, PWM[]> pair in rov.PWM) {
					PWM[] servos = pair.Value;
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
				if (!LoadGripperPositions(obj["Gripper Positions"])) successful = false;

				return successful;
			} else {
				return false;
			}
		}

		private bool LoadGripperPositions(JsonData Data) {
			if((Data != null) && (Data is JsonObject obj)) {
				bool successful = true;

				if (!SpongeGripper.LoadFromJson(obj["Sponge"])) successful = false;
				if (!MediumGripper.LoadFromJson(obj["Medium"])) successful = false;
				if (!SmallGripper.LoadFromJson(obj["Small"])) successful = false;
				if (!TinyGripper.LoadFromJson(obj["Tiny"])) successful = false;
				if (!NetGripper.LoadFromJson(obj["Net"])) successful = false;

				return successful;
			}

			return false;
		}

		public JsonData SaveToJson() {
			JsonObject obj = new JsonObject();
			obj["Servo Ranges"] = ServoRanges.SaveToJson();
			{
				JsonObject grippers = new JsonObject();
				grippers["Sponge"] = SpongeGripper.SaveToJson();
				grippers["Medium"] = MediumGripper.SaveToJson();
				grippers["Small"] = SmallGripper.SaveToJson();
				grippers["Tiny"] = TinyGripper.SaveToJson();
				grippers["Net"] = NetGripper.SaveToJson();

				obj["Gripper Positions"] = grippers;
			}
			return obj;
		}
	}
}
