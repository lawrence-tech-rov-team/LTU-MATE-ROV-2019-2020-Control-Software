using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {
	public abstract class IReadableDevice<T1> : IDevice<T1> where T1 : IDataType, new() {

		protected IReadableDevice(byte id, float refreshRate) : base(id, refreshRate) {

		}

		public override byte[] SendUpdate => new byte[0];

		public override bool Update(ByteArray data) {
			T1 data1 = new T1();

			if(data.Length == data1.NumberOfBytes) {
				if (data1.Parse(data)) {
					Data1 = data1;
					return true;
				} else return false;
			} else {
				return false;
			}
		}

	}

	public abstract class IReadableDevice<T1, T2> : IDevice<T1, T2> where T1 : IDataType, new() where T2 : IDataType, new() {

		protected IReadableDevice(byte id, float refreshRate) : base(id, refreshRate) {

		}

		public override byte[] SendUpdate => null;

		public override bool Update(ByteArray data) {
			if (data.Length > 0) {
				T1 data1 = new T1();
				T2 data2 = new T2();

				byte mask = data[0];
				data++;
				if ((mask & 0x01) > 0) {
					if (!data1.Parse(data.Resize(data1.NumberOfBytes))) return false;
					data += data1.NumberOfBytes;
				}
				if((mask & 0x02) > 0) {
					if (!data2.Parse(data.Resize(data2.NumberOfBytes))) return false;
					data += data2.NumberOfBytes;
				}

				Data1 = data1;
				Data2 = data2;

				return true;
			} else {
				return false;
			}
		}

	}

	public abstract class IReadableDevice<T1, T2, T3> : IDevice<T1, T2, T3> where T1 : IDataType, new() where T2 : IDataType, new() where T3 : IDataType, new() {

		protected IReadableDevice(byte id, float refreshRate) : base(id, refreshRate) {

		}

		public override byte[] SendUpdate => null;

		public override bool Update(ByteArray data) {
			if (data.Length > 0) {
				T1 data1 = new T1();
				T2 data2 = new T2();
				T3 data3 = new T3();

				byte mask = data[0];
				data++;
				if ((mask & 0x01) > 0) {
					if (!data1.Parse(data.Resize(data1.NumberOfBytes))) return false;
					data += data1.NumberOfBytes;
				}
				if ((mask & 0x02) > 0) {
					if (!data2.Parse(data.Resize(data2.NumberOfBytes))) return false;
					data += data2.NumberOfBytes;
				}
				if((mask & 0x04) > 0) {
					if (!data3.Parse(data.Resize(data3.NumberOfBytes))) return false;
					data += data3.NumberOfBytes;
				}

				Data1 = data1;
				Data2 = data2;
				Data3 = data3;

				return true;
			} else {
				return false;
			}
		}

	}
}
