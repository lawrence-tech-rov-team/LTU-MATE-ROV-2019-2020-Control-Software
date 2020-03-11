using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {
	public class ReadableRegister<T> : IRegister<T>
		where T : IDataType, new() 
	{
		public T Value { get => Data; }

		public override byte[] SendUpdate => new byte[0];
		public override byte[] ResendUpdate => SendUpdate;

		public ReadableRegister(byte id, float refreshRate) : base(id, refreshRate) {
		}

		public override bool Update(ByteArray data) {
			T data1 = new T();

			if (data.Length == data1.NumberOfBytes) {
				if (data1.Parse(data)) {
					Data = data1;
					return true;
				} else return false;
			} else {
				return false;
			}
		}
	}

	public class ReadableRegister<T1, T2> : IRegister<T1, T2>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
	{
		public T1 Value1 { get => Data1; }
		public T2 Value2 { get => Data2; }

		public override byte[] SendUpdate => new byte[0];
		public override byte[] ResendUpdate => SendUpdate;

		public ReadableRegister(byte id, float refreshRate) : base(id, refreshRate) {
		}

		public override bool Update(ByteArray data) {
			T1 data1 = new T1();
			T2 data2 = new T2();

			if (data.Length == (data1.NumberOfBytes + data2.NumberOfBytes)) {
				if (data1.Parse(data.Sub(0, data1.NumberOfBytes))) {
					Data1 = data1;
					//return true;
				} else return false;
				if (data2.Parse(data.Sub(data1.NumberOfBytes, data2.NumberOfBytes))) {
					Data2 = data2;
				} else return false;

				return true;
			} else {
				return false;
			}
		}
	}

}
