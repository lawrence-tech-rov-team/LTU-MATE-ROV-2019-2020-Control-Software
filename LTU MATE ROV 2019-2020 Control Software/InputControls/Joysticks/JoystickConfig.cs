using JoystickInput;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Joysticks {
	public abstract class JoystickConfig {

		public abstract Twist Translate(Dictionary<JoystickControl, int> states);

		public static JoystickConfig GetConfig(string name) {
			switch (name) {
				case "Thrustmaster T.16000M":
				case "Thrustmaster T.16000M Throttle":
				case "Thrustmaster T.Flight Rudder Car Mode":
				case "Thrustmaster T.Flight Rudder":
				case "Thrustmaster T.Flight HOTAS X":
				case "Thrustmaster Warthog Joystick":
				case "Thrustmaster Warthog Throttle":
				case "Thrustmaster Warthog Combined":
				case "Saitek Rudder Pedals":
				case "Saitek Combat Rudder Pedals":
				case "CH Pro Pedals":
				case "VKB Gunfighter":
				case "MFG Crosswind":
				case "Saitek X52 HOTAS":
				case "Saitek X52 Pro HOTAS":
				case "Saitek X55 Throttle":
				case "Saitek X55 Joystick":
				case "Saitek X56 Throttle":
				case "Saitek X56 Joystick":
				case "Saitek Pro Flight Throttle Quadrant":
				case "Saitek X45 HOTAS (2541)":
				case "Saitek X45 HOTAS (053c)":
				case "Saitek Cyborg Evo":
				case "Virpil Mongoos T-50":
				case "VPC-Star-Citizen-L":
				case "VPC-Star-Citizen-R":
				case "Logitech 3D Pro":
				default:
					return new Logitech3dProConfig();
			}
		}

	}

}
