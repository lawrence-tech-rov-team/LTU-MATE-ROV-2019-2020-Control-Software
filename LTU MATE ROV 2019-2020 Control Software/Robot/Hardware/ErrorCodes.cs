using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Ethernet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware {
	public class ErrorCodes {

		[Flags]
		private enum Error {
			None = 0x00,
			IdCollision = 0x01,
			Initialization = 0x02,
			RegisterNotFound = 0x04
		}

		private const int ERROR_INIT_BTN0 = 0x01;
		private const int ERROR_INIT_BTN1 = 0x02;
		private const int ERROR_INIT_LED = 0x03;
		private const int ERROR_INIT_IMU = 0x04;
		private const int ERROR_INIT_PRESSURE = 0x05;
		private const int ERROR_INIT_TWI = 0x06;

		private string IdCollision;
		private string Init;
		private string Reg;

		private ErrorCodes(string collision, string init, string reg) {
			IdCollision = collision;
			Init = init;
			Reg = reg;
		}

		public override string ToString() {
			StringBuilder str = new StringBuilder();
			if(IdCollision != null) {
				str.Append("Id Collision: Id = ");
				str.AppendLine(IdCollision);
			}
			if(Init != null) {
				str.Append("Initialization Incomplete: ");
				str.AppendLine(Init);
			}
			if(Reg != null) {
				str.Append("Register not found: Id = ");
				str.AppendLine(Reg);
			}

			if(str.Length == 0) {
				str.AppendLine("No Errors");
			}

			return str.ToString();
		}

		public static ErrorCodes Decode(UdpPacket packet) {
			if(packet.Id == 0xFF) {
				string collision = null;
				string init = null;
				string reg = null;

				if((packet[0] & (int)Error.IdCollision) > 0) {
					collision = packet[1].ToString();
				}
				if((packet[0] & (int)Error.Initialization) > 0) {
					init = GetInitError(packet[2]);
					if (init == null) return null;
				}
				if((packet[0] & (int)Error.RegisterNotFound) > 0) {
					reg = packet[3].ToString();
				}

				return new ErrorCodes(collision, init, reg);
			}

			return null;
		}

		private static string GetInitError(int id) {
			if (id == ERROR_INIT_BTN0) return "Button 0";
			else if (id == ERROR_INIT_BTN1) return "Button 1";
			else if (id == ERROR_INIT_LED) return "LED";
			else if (id == ERROR_INIT_IMU) return "IMU";
			else if (id == ERROR_INIT_PRESSURE) return "Pressure Sensor";
			else if (id == ERROR_INIT_TWI) return "Twi Settings";
			else {
				if (id == 0x10) return "Twi Servo Controller";

				int num = id & 0x0F;
				if (num == 0) return null;

				switch(id >> 4) {
					case 1:
						if (num > 5) return null;
						else return "A" + num;
					case 2:
						if (num > 6) return null;
						else return "B" + num;
					case 3:
						if (num > 8) return null;
						else return "C" + num;
					case 4:
						if (num > 8) return null;
						else return "D" + num;
					default:
						return null;
				}
			}
		}

	}
}
