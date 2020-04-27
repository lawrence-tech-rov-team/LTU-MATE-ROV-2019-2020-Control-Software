using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes {
	public class BoolData : IDataType {

		public bool Value { get; private set; }

		public override int NumberOfBytes => 1;

		public override byte[] Bytes {
			get {
				byte[] bytes = new byte[NumberOfBytes];
				bytes[0] = (Value ? (byte)0x01 : (byte)0x00);
				return bytes;
			}
		}

		public BoolData() {

		}

		public BoolData(bool value) {
			Value = value;
		}

		public override bool Parse(ByteArray bytes) {
			bool result;
			if(bytes.ParseBool(out result)) {
				Value = result;
				return true;
			} else {
				return false;
			}
		}

		public override bool IsSameValue(IDataType obj) {
			if(obj is BoolData) {
				return ((BoolData)obj).Value == Value;
			} else {
				return false;
			}
		}
	}
}
