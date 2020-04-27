using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes {
	public class Vector3Data : IDataType {

		public Vector3 Vector;
		public float X { get => Vector.X; set => Vector.X = value; }
		public float Y { get => Vector.Y; set => Vector.Y = value; }
		public float Z { get => Vector.Z; set => Vector.Z = value; }

		public override int NumberOfBytes => 12;

		public override byte[] Bytes {
			get {
				List<byte> bytes = new List<byte>(NumberOfBytes);
				bytes.AddRange(BitConverter.GetBytes(X));
				bytes.AddRange(BitConverter.GetBytes(Y));
				bytes.AddRange(BitConverter.GetBytes(Z));
				return bytes.ToArray();
			}
		}

		public Vector3Data() {

		}

		public Vector3Data(Vector3 vector) {
			this.Vector = vector;
		}

		public Vector3Data(float x, float y, float z) {
			this.Vector = new Vector3(x, y, z);
		}

		public override bool IsSameValue(IDataType obj) {
			if (obj is Vector3Data) {
				Vector3 vec = ((Vector3Data)obj).Vector;
				return vec == Vector;
			} else {
				return false;
			}
		}

		public override bool Parse(ByteArray bytes) {
			if(bytes.Length == NumberOfBytes) {
				return bytes.ParseSingle(0, out Vector.X)
					&& bytes.ParseSingle(4, out Vector.Y)
					&& bytes.ParseSingle(8, out Vector.Z);
			} else {
				return false;
			}
		}

	}
}
