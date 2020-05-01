using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot {
	public class Thruster {

		private PWM pwm { get; }

		public ushort ZeroThrust { get; set; }

		public bool Enabled { set => pwm.Enabled = value; }
		public float Thrust {
			set {
				if(value >= 0) {
					if(pwm.MaximumPulse >= pwm.MinimumPulse) {
						pwm.Pulse = new Range(ZeroThrust, pwm.MaximumPulse).Interpolate(value);
					} else {
						pwm.Pulse = new Range(ZeroThrust, pwm.MinimumPulse).Interpolate(value);
					}
				} else {
					if(pwm.MinimumPulse <= pwm.MaximumPulse) {
						pwm.Pulse = new Range(ZeroThrust, pwm.MinimumPulse).Interpolate(-value);
					} else {
						pwm.Pulse = new Range(ZeroThrust, pwm.MaximumPulse).Interpolate(-value);
					}
				}
			}
		}

		public Thruster(PWM PWM) {
			pwm = PWM;
			ZeroThrust = (ushort)(((int)pwm.MaximumPulse + (int)pwm.MinimumPulse) / 2);
		}

	}
}
