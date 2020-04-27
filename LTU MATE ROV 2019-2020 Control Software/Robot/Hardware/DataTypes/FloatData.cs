using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes {
	public class FloatData : IDataType {

		public float Value;

		public override int NumberOfBytes => 4;

		public override byte[] Bytes {
			get {
				return BitConverter.GetBytes(Value);
			}
		}

		public FloatData() {

		}

		public FloatData(float value) {
			Value = value;
		}

		public override bool IsSameValue(IDataType obj) {
			if(obj is FloatData) {
				return ((FloatData)obj).Value == Value;
			} else {
				return false;
			}
		}

		public override bool Parse(ByteArray bytes) {
			if (bytes.Length == NumberOfBytes) {
				return bytes.ParseSingle(out Value);
			}

			return false;
		}
	}
}
