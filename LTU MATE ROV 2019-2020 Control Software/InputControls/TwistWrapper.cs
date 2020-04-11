using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls {
	public class TwistWrapper {

		public Twist Value { get; }

		public TwistWrapper() {
			Value = new Twist();
		}

		public TwistWrapper(Twist twist) {
			twist.Linear.X = Constrain(twist.Linear.X);
			twist.Linear.Y = Constrain(twist.Linear.Y);
			twist.Linear.Z = Constrain(twist.Linear.Z);
			twist.Angular.X = Constrain(twist.Angular.X);
			twist.Angular.Y = Constrain(twist.Angular.Y);
			twist.Angular.Z = Constrain(twist.Angular.Z);
			Value = twist;
		}

		private float Constrain(float value) {
			return Math.Max(-1f, Math.Min(1f, value));
		}

	}
}
