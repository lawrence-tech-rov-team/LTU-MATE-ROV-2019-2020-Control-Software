using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes {
	public class UInt16Data : IDataType {
		public override int NumberOfBytes => 2;

		public override byte[] Bytes => BitConverter.GetBytes(Value);

		public ushort Value { get; private set; }
		public byte MSB {
			get => (byte)((Value >> 8) & 0xFF);
			set {
				Value = (ushort)((value << 8) | (Value & 0xFF));
			}
		}
		public byte LSB {
			get => (byte)(Value & 0xFF);
			set {
				Value = (ushort)((Value & 0xFF00) | value);
			}
		}

		public UInt16Data() {

		}

		/*public UInt16Data(byte value) {
			Value = value;
		}*/

		public UInt16Data(ushort value) {
			Value = value;
		}

		public override bool IsSameValue(IDataType obj) {
			if (obj is UInt16Data) {
				return ((UInt16Data)obj).Value == Value;
			} else {
				return false;
			}
		}

		public override bool Parse(ByteArray bytes) {
			ushort result;
			if(bytes.ParseUInt16(out result)) {
				Value = result;
				return true;
			} else {
				return false;
			}
		}
	}
}
