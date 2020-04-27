using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes {
	public class Vector4Data : IDataType {

		public Vector4 Vector;
		public float X { get => Vector.X; set => Vector.X = value; }
		public float Y { get => Vector.Y; set => Vector.Y = value; }
		public float Z { get => Vector.Z; set => Vector.Z = value; }
		public float W { get => Vector.W; set => Vector.W = value; }

		public override int NumberOfBytes => 16;

		public override byte[] Bytes {
			get {
				List<byte> bytes = new List<byte>(NumberOfBytes);
				bytes.AddRange(BitConverter.GetBytes(X));
				bytes.AddRange(BitConverter.GetBytes(Y));
				bytes.AddRange(BitConverter.GetBytes(Z));
				bytes.AddRange(BitConverter.GetBytes(W));
				return bytes.ToArray();
			}
		}

		public Vector4Data() {

		}

		public Vector4Data(Vector4 vector) {
			this.Vector = vector;
		}

		public Vector4Data(float x, float y, float z, float w) {
			this.Vector = new Vector4(x, y, z, w);
		}

		public override bool IsSameValue(IDataType obj) {
			if (obj is Vector4Data) {
				Vector4 vec = ((Vector4Data)obj).Vector;
				return vec == Vector;
			} else {
				return false;
			}
		}

		public override bool Parse(ByteArray bytes) {
			if (bytes.Length == NumberOfBytes) {
				return (bytes.ParseSingle(0, out Vector.X)
					&& bytes.ParseSingle(4, out Vector.Y)
					&& bytes.ParseSingle(8, out Vector.Z)
					&& bytes.ParseSingle(12, out Vector.W)
				);
			} else {
				return false;
			}
		}

	}
}
