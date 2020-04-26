using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {
	public struct Twist {

		public Vector3 Linear, Angular;

		public Twist(Vector3 Linear, Vector3 Angular) {
			this.Linear = Linear;
			this.Angular = Angular;
		}

		public Twist(float x, float y, float z, float ax, float ay, float az) {
			Linear.X = x;
			Linear.Y = y;
			Linear.Z = z;
			Angular.X = ax;
			Angular.Y = ay;
			Angular.Z = az;
		}

	}
}
