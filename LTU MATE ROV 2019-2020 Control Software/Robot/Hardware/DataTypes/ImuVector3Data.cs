using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes {
	public abstract class ImuVector3Data : IDataType {

		public Vector3 Vector;
		public float X { get => Vector.X; set => Vector.X = value; }
		public float Y { get => Vector.Y; set => Vector.Y = value; }
		public float Z { get => Vector.Z; set => Vector.Z = value; }

		public override int NumberOfBytes => 6;

		public override byte[] Bytes {
			get {
				List<byte> bytes = new List<byte>(NumberOfBytes);
				bytes.AddRange(BitConverter.GetBytes(GetInt16(X * Ratio)));
				bytes.AddRange(BitConverter.GetBytes(GetInt16(Y * Ratio)));
				bytes.AddRange(BitConverter.GetBytes(GetInt16(Z * Ratio)));
				return bytes.ToArray();
			}
		}

		private short GetInt16(float val) {
			if (val <= short.MinValue) return short.MinValue;
			else if (val >= short.MaxValue) return short.MaxValue;
			else return (short)Math.Round(val);
		}

		protected abstract float Ratio { get; }

		public ImuVector3Data() {

		}

		public ImuVector3Data(float x, float y, float z) {
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public override bool IsSameValue(IDataType obj) {
			if (obj is ImuVector3Data) {
				Vector3 vec = ((ImuVector3Data)obj).Vector;
				return Vector == vec;
			} else {
				return false;
			}
		}

		public override bool Parse(ByteArray bytes) {
			if (bytes.Length == NumberOfBytes) {
				return ParseFloat(bytes.Sub(0, 2), out Vector.X) && ParseFloat(bytes.Sub(2, 2), out Vector.Y) && ParseFloat(bytes.Sub(4, 2), out Vector.Z);
			} else {
				return false;
			}
		}

		private bool ParseFloat(ByteArray bytes, out float val) {
			if (bytes.Length == 2) {
				try {
					val = BitConverter.ToInt16(bytes.ToArray(), 0) / Ratio;
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

	public class Imu16Vector3Data : ImuVector3Data {
		protected override float Ratio => 16f;
		public Imu16Vector3Data() { }
		public Imu16Vector3Data(float x, float y, float z) : base(x, y, z) { }
	}

	public class Imu100Vector3Data : ImuVector3Data {
		protected override float Ratio => 100f;
		public Imu100Vector3Data() { }
		public Imu100Vector3Data(float x, float y, float z) : base(x, y, z) { }
	}
}
