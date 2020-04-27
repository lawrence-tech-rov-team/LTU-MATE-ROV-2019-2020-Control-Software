using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes {
	public class UInt32Data : IDataType {
		public override int NumberOfBytes => 4;

		public override byte[] Bytes => BitConverter.GetBytes(Value);

		public uint Value { get; private set; }
		/*public byte MSB {
			get => (byte)((Value >> 8) & 0xFF);
			set {
				Value = (uint)((value << 8) | (Value & 0xFF));
			}
		}
		public byte LSB {
			get => (byte)(Value & 0xFF);
			set {
				Value = (uint)((Value & 0xFF00) | value);
			}
		}*/

		public UInt32Data() {

		}

		public UInt32Data(uint value) {
			Value = value;
		}

		public override bool IsSameValue(IDataType obj) {
			if(obj is UInt32Data) {
				return ((UInt32Data)obj).Value == Value;
			} else {
				return false;
			}
		}

		public override bool Parse(ByteArray bytes) {
			uint result;
			if(bytes.ParseUInt32(out result)) {
				Value = result;
				return true;
			} else {
				return false;
			}
		}

	}
}
