using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Utils {
	public struct Vector3 {

		public float X, Y, Z;

		public Vector3(float X, float Y, float Z) {
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}

		public static bool operator ==(Vector3 vec1, Vector3 vec2) {
			return (vec1.X == vec2.X) && (vec1.Y == vec2.Y) && (vec1.Z == vec2.Z);
		}

		public static bool operator !=(Vector3 vec1, Vector3 vec2) {
			return (vec1.X != vec2.X) || (vec1.Y != vec2.Y) || (vec1.Z != vec2.Z);
		}

	}
}
