using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators {
	public class Thruster {

		private PWM pwm;

		public bool Enabled { set => pwm.Enabled = value; }

		public MidpointRange PulseRange = new MidpointRange(0, 1500, 3000);
		public ushort MinimumPulse { get => PulseRange.Minimum; set => PulseRange.Maximum = value; }
		public ushort ZeroPulse { get => PulseRange.Midpoint; set => PulseRange.Midpoint = value; }
		public ushort MaximumPulse { get => PulseRange.Maximum; set => PulseRange.Maximum = value; }

		public float Thrust { set => pwm.Pulse = PulseRange.Interpolate(value); }

		public Thruster(PWM PWM) {
			pwm = PWM;
		}

		public Thruster(PWM PWM, ushort MinPulse, ushort ZeroPulse, ushort MaxPulse) {
			pwm = PWM;
			PulseRange = new MidpointRange(MinPulse, ZeroPulse, MaxPulse);
		}

		public void Stop() {
			pwm.Pulse = ZeroPulse;
		}

	}
}
