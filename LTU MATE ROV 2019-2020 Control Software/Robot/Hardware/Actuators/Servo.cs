using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators {
	public class Servo {

		public RangedPWM PWM { get; }

		public bool Enabled { set => PWM.Enabled = value; }

		public float MinimumAngle { get; set; }
		public float MaximumAngle { get; set; }

		public float Angle {
			set {
				if (MinimumAngle == MaximumAngle) PWM.DutyCycle = 0f;
				else PWM.DutyCycle = (value - MinimumAngle) / (MaximumAngle - MinimumAngle);
			}
		}

		public float Percentage { set => PWM.DutyCycle = value; }

		public Servo(RangedPWM PWM, float MinAngle, float MaxAngle) {
			this.PWM = PWM;
			MinimumAngle = MinAngle;
			MaximumAngle = MaxAngle;
		}

	}
}
