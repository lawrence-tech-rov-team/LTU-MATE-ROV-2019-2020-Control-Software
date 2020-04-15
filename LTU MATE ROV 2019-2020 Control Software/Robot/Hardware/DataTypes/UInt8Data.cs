using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes {
	public class UInt8Data : IDataType {
		public override int NumberOfBytes => 1;

		public override byte[] Bytes => new byte[] { Value };

		public byte Value { get; private set; }

		public UInt8Data() {

		}

		public UInt8Data(byte value) {
			Value = value;
		}

		public override bool IsSameValue(IDataType obj) {
			if(obj is UInt8Data) {
				return ((UInt8Data)obj).Value == Value;
			} else {
				return false;
			}
		}

		public override bool Parse(ByteArray bytes) {
			if(bytes.Length == NumberOfBytes) {
				Value = bytes[0];
				return true;
			} else {
				return false;
			}
		}
	}
}
