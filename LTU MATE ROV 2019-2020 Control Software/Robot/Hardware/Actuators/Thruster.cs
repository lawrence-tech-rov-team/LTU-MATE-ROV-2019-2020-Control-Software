using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators {
	public class Thruster : PWM {

		public

		public Thruster(byte posId, byte enableId, float refreshRate = 25) : base(posId, enableId, refreshRate) {
		}

	}
}
