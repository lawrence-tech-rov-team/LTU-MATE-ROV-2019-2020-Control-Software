using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
		public SerializableDictionary<MidpointRange> ThrusterRanges = new SerializableDictionary<MidpointRange>();
		
		public GripperPosition SpongeGripper = new GripperPosition("Sponge");
		public GripperPosition MediumGripper = new GripperPosition("Medium");
		public GripperPosition SmallGripper = new GripperPosition("Small");
		public GripperPosition TinyGripper = new GripperPosition("Tiny");
		public GripperPosition NetGripper = new GripperPosition("Net");

		public IPAddress RobotIP = IPAddress.Parse("192.168.0.130");
		public int RobotPort = 9933;

		public AppSettings(RobotThread robot) {
			robot.OnConnected += Robot_OnConnected;
		}

		private void Robot_OnConnected(Robot.Hardware.Robot sender) {
			if((sender != null) && (sender is ROV rov)) {
				foreach(KeyValuePair<string, Servo> pair in rov.Servos) {
					Servo servo = pair.Value;
					if (ServoRanges.ContainsKey(pair.Key)) {
						servo.PWM.PulseRange = ServoRanges[pair.Key];
					}
				}

				foreach(KeyValuePair<string, Thruster> pair in rov.Thrusters) {
					Thruster thruster = pair.Value;
					if (ThrusterRanges.ContainsKey(pair.Key)) {
						thruster.PulseRange = ThrusterRanges[pair.Key];
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
				if (!ThrusterRanges.LoadFromJson(obj["Thruster Ranges"])) successful = false;
				if (!LoadGripperPositions(obj["Gripper Positions"])) successful = false;

				if(obj["Robot IP"] is JsonString jsonRobotIp && jsonRobotIp != null) {
					IPAddress parsedIp;
					if (IPAddress.TryParse(jsonRobotIp.Value, out parsedIp)) {
						RobotIP = parsedIp;
					}
				}
				if(obj["Robot Port"] is JsonInteger jsonRobotPort && jsonRobotPort != null) {
					if(jsonRobotPort.Value >= IPEndPoint.MinPort && jsonRobotPort.Value <= IPEndPoint.MaxPort) {
						RobotPort = (int)jsonRobotPort.Value;
					}
				}

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
			obj["Thruster Ranges"] = ThrusterRanges.SaveToJson();
			{
				JsonObject grippers = new JsonObject();
				grippers["Sponge"] = SpongeGripper.SaveToJson();
				grippers["Medium"] = MediumGripper.SaveToJson();
				grippers["Small"] = SmallGripper.SaveToJson();
				grippers["Tiny"] = TinyGripper.SaveToJson();
				grippers["Net"] = NetGripper.SaveToJson();

				obj["Gripper Positions"] = grippers;
			}
			obj["Robot IP"] = new JsonString(RobotIP.ToString());
			obj["Robot Port"] = new JsonInteger(RobotPort);

			return obj;
		}
	}
}
