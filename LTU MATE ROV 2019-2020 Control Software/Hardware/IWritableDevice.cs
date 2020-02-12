using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {
	public abstract class IWritableDevice<T1> : IDevice<T1> where T1 : IDataType, new() {

		protected IWritableDevice(byte id, float refreshrate) : base(id, refreshrate) {
		}

		public override byte[] SendUpdate {
			get {
				T1 data1 = Data1;
				if (data1 != null) return data1.Bytes;
				else return null;
			}
		}

		public override bool Update(ByteArray data) {
			return (data.Length == 0);
		}
	}

	public abstract class IWritableDevice<T1, T2> : IDevice<T1, T2> where T1 : IDataType, new() where T2 : IDataType, new() {

		protected IWritableDevice(byte id, float refreshrate) : base(id, refreshrate) {
		}

		public override byte[] SendUpdate {
			get {
				T1 data1 = Data1;
				T2 data2 = Data2;

				List<byte> bytes = new List<byte>();
				bytes.Add(0);

				if (data1 != null) {
					bytes[0] |= 0x01;
					bytes.AddRange(data1.Bytes);
				}
				if(data2 != null) {
					bytes[0] |= 0x02;
					bytes.AddRange(data2.Bytes);
				}

				if (bytes[0] == 0) return null;
				else return bytes.ToArray();
			}
		}

		public override bool Update(ByteArray data) {
			return (data.Length == 0);
		}
	}

	public abstract class IWritableDevice<T1, T2, T3> : IDevice<T1, T2, T3> where T1 : IDataType, new() where T2 : IDataType, new() where T3 : IDataType, new() {

		protected IWritableDevice(byte id, float refreshrate) : base(id, refreshrate) {
		}

		public override byte[] SendUpdate {
			get {
				T1 data1 = Data1;
				T2 data2 = Data2;
				T3 data3 = Data3;

				List<byte> bytes = new List<byte>();
				bytes.Add(0);

				if (data1 != null) {
					bytes[0] |= 0x01;
					bytes.AddRange(data1.Bytes);
				}
				if (data2 != null) {
					bytes[0] |= 0x02;
					bytes.AddRange(data2.Bytes);
				}
				if(data3 != null) {
					bytes[0] |= 0x04;
					bytes.AddRange(data3.Bytes);
				}

				if (bytes[0] == 0) return null;
				else return bytes.ToArray();
			}
		}

		public override bool Update(ByteArray data) {
			return (data.Length == 0);
		}
	}

}
