using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot {
	public class Servo {

		private PWM pwm { get; }

		public float MinimumAngle { get; set; }
		public float MaximumAngle { get; set; }
		public bool Enabled { set => pwm.Enabled = value; }
		public float Percentage { set => pwm.DutyCycle = value; }

		public float Angle {
			set {
				if(MinimumAngle == MaximumAngle) pwm.DutyCycle = 0f;
				else pwm.DutyCycle = (value - MinimumAngle) / (MaximumAngle - MinimumAngle);
			}
		}

		public Servo(PWM PWM, float MinAngle = 0f, float MaxAngle = 180f) {
			this.pwm = PWM;
			MinimumAngle = MinAngle;
			MaximumAngle = MaxAngle;
		}

	}
}
