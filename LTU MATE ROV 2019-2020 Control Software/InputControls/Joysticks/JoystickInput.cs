using JoystickInput;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Joysticks {
	public class JoystickInput : InputDevice {

		private Joystick joystick;
		private JoystickDevice device;
		private GenericConfig config = new GenericConfig();
		private Dictionary<JoystickControl, int> states = new Dictionary<JoystickControl, int>();
		public override string Name => device?.Name ?? "null (Joystick)";

		private JoystickInput(JoystickDevice device) {
			this.device = device; ;
			
		}

		private void Joystick_OnInputChanged(Joystick sender, JoystickControl Type, int Value) {
			states[Type] = Value;
		}

		public override void Connect() {
			Disconnect();
			joystick = Joystick.Connect(device);
			if(joystick != null) joystick.OnInputChanged += Joystick_OnInputChanged;
		}

		public override void Disconnect() {
			if(joystick != null) {
				joystick.OnInputChanged -= Joystick_OnInputChanged;
				joystick.Disconnect();
			}
			joystick = null;
			foreach(JoystickControl control in EnumUtil.GetValues<JoystickControl>()) {
				states[control] = default(int);
			}
		}

		public override bool Update() {
			if (!(joystick?.Update() ?? false)) {
				Disconnect();
				return false;
			} else {
				Value = config.Translate(states);
				return true;
			}
		}

		private class GenericConfig {
			public virtual Twist Translate(Dictionary<JoystickControl, int> states) {
				Twist twist = new Twist();
				twist.Linear.X = 1f - ((float)states[JoystickControl.Sliders0] / (float)UInt16.MaxValue * 2f);
				return twist;
			}
		}

		public static InputDevice[] GetDevices() {
			return Joystick.GetAvailableJoysticks().Select(x => new JoystickInput(x)).ToArray();
		}

		/*
		private static readonly string[][] joystickConfigs = {
			new string[]{"044f:b10a", "Thrustmaster T.16000M"},
			new string[]{ "044f:b687", "Thrustmaster T.16000M Throttle" },
			new string[]{"044f:b678", "Thrustmaster T.Flight Rudder Car Mode"},
			new string[]{ "044f:b679", "Thrustmaster T.Flight Rudder"},
			new string[]{ "044f:b108", "Thrustmaster T.Flight HOTAS X" },
			new string[]{ "044f:0402", "Thrustmaster Warthog Joystick"},
			new string[]{ "044f:0404",  "Thrustmaster Warthog Throttle"},
			new string[]{ "044f:ffff", "Thrustmaster Warthog Combined" },
			new string[]{ "06a3:0763", "Saitek Rudder Pedals"},
			new string[]{ "06a3:0764", "Saitek Combat Rudder Pedals" },
			new string[]{ "068e:c0f2",  "CH Pro Pedals"},
			new string[]{ "068e:00f2",  "CH Pro Pedals"},
			new string[]{ "231d:011f", "VKB Gunfighter"},
			new string[]{ "046d:c215", "Logitech 3D Pro"},
			new string[]{ "16d0:0a38", "MFG Crosswind"},
			new string[]{ "06a3:075c", "Saitek X52 HOTAS"},
			new string[]{ "06a3:0762", "Saitek X52 Pro HOTAS"},
			new string[]{ "0738:a215", "Saitek X55 Throttle"},
			new string[]{ "0738:2215", "Saitek X55 Joystick"},
			new string[]{ "0738:a221", "Saitek X56 Throttle"},
			new string[]{ "0738:2221", "Saitek X56 Joystick"},
			new string[]{ "06a3:0c2d", "Saitek Pro Flight Throttle Quadrant"},
			new string[]{ "06a3:2541", "Saitek X45 HOTAS (2541)"},
			new string[]{ "06a3:053c", "Saitek X45 HOTAS (053c)"},
			new string[]{ "06a3:0464", "Saitek Cyborg Evo"},
			new string[]{ "03eb:2043", "Virpil Mongoos T-50"},
			new string[]{ "03ef:2004", "VPC-Star-Citizen-L"},
			new string[]{ "03ec:2005", "VPC-Star-Citizen-R" }
		};
		*/

	}

}
