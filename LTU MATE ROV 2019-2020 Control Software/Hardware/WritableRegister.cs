using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {

	public class WritableRegister<T> : IRegister<T>
		where T : IDataType, new() 
	{

		private T LastSent1;
		public new T Data { set => base.Data = value; }

		public WritableRegister(byte id, float refreshrate) : base(id, refreshrate) {
		}

		public override byte[] SendUpdate {
			get {
				T data1 = base.Data;
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

	public class WritableRegister<T1, T2> : IRegister<T1, T2>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
	{

		private T1 LastSent1;
		public new T1 Data1 { set => base.Data1 = value; }

		private T2 LastSent2;
		public new T2 Data2 { set => base.Data2 = value; }

		public void SetValues(T1 value1, T2 value2) {
			lock (this) {
				Data1 = value1;
				Data2 = value2;
			}
		}

		public WritableRegister(byte id, float refreshrate) : base(id, refreshrate) {
		}

		public override byte[] SendUpdate {
			get {
				bool update = false;
				List<byte> bytes = new List<byte>();

				lock (this) {
					T1 data1 = base.Data1;
					if ((data1 != null) && !data1.IsSameValue(LastSent1)) {
						LastSent1 = data1;
						update = true;
						bytes.AddRange(data1.Bytes);
					}

					T2 data2 = base.Data2;
					if ((data2 != null) && !data2.IsSameValue(LastSent2)) {
						LastSent2 = data2;
						update = true;
						bytes.AddRange(data2.Bytes);
					}
				}

				if (update) return bytes.ToArray();
				else return null;
			}
		}

		public override byte[] ResendUpdate {
			get {
				List<byte> bytes = new List<byte>();
				bool update = false;
				if (LastSent1 != null) {
					bytes.AddRange(LastSent1.Bytes);
					update = true;
				}
				if (LastSent2 != null) {
					bytes.AddRange(LastSent2.Bytes);
					update = true;
				}
				return update ? bytes.ToArray() : null;
			}
		}

		public override bool Update(ByteArray data) {
			return (data.Length == 0);
		}
	}

}
