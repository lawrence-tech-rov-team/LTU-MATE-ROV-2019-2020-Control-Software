using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes {
	public class ImuQuaternionData : IDataType {

		public Quaternion Quaternion;
		public float X { get => Quaternion.X; set => Quaternion.X = value; }
		public float Y { get => Quaternion.Y; set => Quaternion.Y = value; }
		public float Z { get => Quaternion.Z; set => Quaternion.Z = value; }
		public float W { get => Quaternion.W; set => Quaternion.W = value; }

		public override int NumberOfBytes => 8;
		private const float Scale = (1f / (1 << 14));

		public override byte[] Bytes {
			get {
				List<byte> bytes = new List<byte>(NumberOfBytes);
				bytes.AddRange(BitConverter.GetBytes(GetInt16(X / Scale)));
				bytes.AddRange(BitConverter.GetBytes(GetInt16(Y / Scale)));
				bytes.AddRange(BitConverter.GetBytes(GetInt16(Z / Scale)));
				bytes.AddRange(BitConverter.GetBytes(GetInt16(W / Scale)));
				return bytes.ToArray();
			}
		}

		private short GetInt16(float val) {
			if (val <= short.MinValue) return short.MinValue;
			else if (val >= short.MaxValue) return short.MaxValue;
			else return (short)Math.Round(val);
		}

		public ImuQuaternionData() {

		}

		public ImuQuaternionData(float x, float y, float z, float w) {
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		public override bool IsSameValue(IDataType obj) {
			if(obj is ImuQuaternionData) {
				Quaternion quat = ((ImuQuaternionData)obj).Quaternion;
				return Quaternion == quat;
			} else {
				return false;
			}
		}

		public override bool Parse(ByteArray bytes) {
			if(bytes.Length == NumberOfBytes) {
				return ParseFloat(bytes, 0, out Quaternion.X)
					&& ParseFloat(bytes, 2, out Quaternion.Y)
					&& ParseFloat(bytes, 4, out Quaternion.Z)
					&& ParseFloat(bytes, 6, out Quaternion.W);
			} else {
				return false;
			}
		}

		private bool ParseFloat(ByteArray bytes, int index, out float val) {
			short result;
			if(bytes.ParseInt16(index, out result)) {
				val = result * Scale;
				return true;
			} else {
				val = default(float);
				return false;
			}
		}

	}
}
