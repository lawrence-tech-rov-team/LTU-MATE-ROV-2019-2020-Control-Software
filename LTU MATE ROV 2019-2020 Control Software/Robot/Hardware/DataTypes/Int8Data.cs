using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes {
	public class Int8Data : IDataType {
		public override int NumberOfBytes => 1;

		public override byte[] Bytes => new byte[] { (byte)Value };

		public sbyte Value { get; private set; }

		public Int8Data() {

		}

		public Int8Data(sbyte value) {
			Value = value;
		}

		public override bool IsSameValue(IDataType obj) {
			if(obj is Int8Data) {
				return ((Int8Data)obj).Value == Value;
			} else {
				return false;
			}
		}

		public override bool Parse(ByteArray bytes) {
			if(bytes.Length == NumberOfBytes) {
				Value = (sbyte)bytes[0];
				return true;
			} else {
				return false;
			}
		}
	}
}
