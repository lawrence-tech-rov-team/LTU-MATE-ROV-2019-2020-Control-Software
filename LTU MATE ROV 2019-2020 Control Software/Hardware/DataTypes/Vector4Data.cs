using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes {
	public class Vector4Data : IDataType {

		public float w;
		public float x;
		public float y;
		public float z;

		public override int NumberOfBytes => 16;

		public override byte[] Bytes {
			get {
				List<byte> bytes = new List<byte>(NumberOfBytes);
				bytes.AddRange(BitConverter.GetBytes(w));
				bytes.AddRange(BitConverter.GetBytes(x));
				bytes.AddRange(BitConverter.GetBytes(y));
				bytes.AddRange(BitConverter.GetBytes(z));
				return bytes.ToArray();
			}
		}

		public Vector4Data() {

		}

		public Vector4Data(float w, float x, float y, float z) {
			this.w = w;
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public override bool IsSameValue(IDataType obj) {
			if (obj is Vector4Data) {
				Vector4Data vec = (Vector4Data)obj;
				return (vec.w == w) && (vec.x == x) && (vec.y == y) && (vec.z == z);
			} else {
				return false;
			}
		}

		public override bool Parse(ByteArray bytes) {
			if (bytes.Length == NumberOfBytes) {
				return ParseFloat(bytes.Sub(0, 4), out w) && ParseFloat(bytes.Sub(4, 4), out x) && ParseFloat(bytes.Sub(8, 4), out y) && ParseFloat(bytes.Sub(12, 4), out z);
			} else {
				return false;
			}
		}

		private bool ParseFloat(ByteArray bytes, out float val) {
			if (bytes.Length == 4) {
				try {
					val = BitConverter.ToSingle(bytes.ToArray(), 0);
					return true;
				} catch (Exception) {
					val = default(float);
					return false;
				}
			} else {
				val = default(float);
				return false;
			}
		}

	}
}
