using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*TODO
 I'm thinking in IDevice, add a method called "Resend last". 
 IReadable will just return the same update message.

	IWritable will have an additional data field called "LastSent1" which stores the last sent value
	if "Resent Last" is called, that value will be sent.
	Otherwise, when an update is requested is used to check against the current value.
	If the values are the same, an update isn't needed. Otherwise, update LastSent with the new value.
*/

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {
	public abstract class IWritableDevice<T1> : IDevice<T1> where T1 : IDataType, new() {

		//TODO only send the value if it is different.
		private T1 LastSent1;

		protected IWritableDevice(byte id, float refreshrate) : base(id, refreshrate) {
		}

		public override byte[] SendUpdate {
			get {
				T1 data1 = Data1;
				if ((data1 != null) && !data1.IsSameValue(LastSent1)) {
					LastSent1 = data1;
					return data1.Bytes;
				} else return null;
			}
		}

		public override byte[] ResendUpdate {
			get {
				if (LastSent1 != null) return LastSent1.Bytes;
				else return null;
			}
		}

		public override bool Update(ByteArray data) {
			return (data.Length == 0);
		}
	}
	/*
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
	*/
}
