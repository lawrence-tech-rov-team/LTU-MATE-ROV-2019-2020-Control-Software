using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators {
	public class Servo : PWM {

		public float MinimumAngle { get; set; }
		public float MaximumAngle { get; set; }

		public float Angle {
			set {
				if (MinimumAngle == MaximumAngle) DutyCycle = 0f;
				else DutyCycle = (value - MinimumAngle) / (MaximumAngle - MinimumAngle);
			}
		}

		public Servo(byte posId, byte enableId, float MinAngle = 0f, float MaxAngle = 0f, float refreshRate = 25) : base(posId, enableId, refreshRate) {
			MinimumAngle = MinAngle;
			MaximumAngle = MaxAngle;
		}

	}
}
