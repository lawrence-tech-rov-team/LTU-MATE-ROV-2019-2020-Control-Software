using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Actuators {
	public class RangedPWM : PWM {

		public new ushort Pulse { set => base.Pulse = PulseRange.Limit(value); }

		public Range PulseRange = new Range(0, 3000);
		public ushort MinimumPulse { get => PulseRange.Minimum; set => PulseRange.Minimum = value; }
		public ushort MaximumPulse { get => PulseRange.Maximum; set => PulseRange.Maximum = value; }
		public float DutyCycle { set => base.Pulse = PulseRange.Interpolate(value); }

		public RangedPWM(byte posId, byte enableId, float refreshRate = 25f) : base(posId, enableId, refreshRate) {
			
		}

		public RangedPWM(byte posId, byte enableId, Range pulseRange, float refreshRate = 25f) : base(posId, enableId, refreshRate) {
			this.PulseRange = pulseRange;
		}

	}
}
