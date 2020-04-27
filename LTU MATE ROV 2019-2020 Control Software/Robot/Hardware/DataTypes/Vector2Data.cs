using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes {
	public class Vector2Data : IDataType {

		public Vector2 Vector;
		public float X { get => Vector.X; set => Vector.X = value; }
		public float Y { get => Vector.Y; set => Vector.Y = value; }

		public override int NumberOfBytes => 8;

		public override byte[] Bytes {
			get {
				List<byte> bytes = new List<byte>(NumberOfBytes);
				bytes.AddRange(BitConverter.GetBytes(X));
				bytes.AddRange(BitConverter.GetBytes(Y));
				return bytes.ToArray();
			}
		}

		public Vector2Data() {

		}

		public Vector2Data(Vector2 vector) {
			this.Vector = vector;
		}

		public Vector2Data(float x, float y) {
			this.Vector = new Vector2(x, y);
		}

		public override bool IsSameValue(IDataType obj) {
			if(obj is Vector2Data) {
				Vector2 vec = ((Vector2Data)obj).Vector;
				return vec == Vector;
			} else {
				return false;
			}
		}

		public override bool Parse(ByteArray bytes) {
			if(bytes.Length == NumberOfBytes) {
				return ParseFloat(bytes.Sub(0, 4), out Vector.X)
					&& ParseFloat(bytes.Sub(4, 4), out Vector.Y);
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
