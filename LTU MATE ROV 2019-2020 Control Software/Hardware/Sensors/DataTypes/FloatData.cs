using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Sensors.DataTypes {
	public class FloatData : IDataType {

		public float Value { get; private set; }

		public override int NumberOfBytes => 4;

		public override byte[] Bytes {
			get {
				return BitConverter.GetBytes(Value);
			}
		}

		public override bool Parse(ByteArray bytes) {
			if (bytes.Length == NumberOfBytes) {
				try {
					Value = BitConverter.ToSingle(bytes.ToArray(), 0);
					return true;
				}catch(Exception) {
					return false;
				}
			} else {
				return false;
			}
		}
	}
}
