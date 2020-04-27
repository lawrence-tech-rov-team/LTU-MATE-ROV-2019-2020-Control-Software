using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware {
	public class ReadableRegister<T> : IRegister<T>
		where T : IDataType, new() 
	{
		public new T Data { get => base.Data; }

		public override byte[] SendUpdate => new byte[0];
		public override byte[] ResendUpdate => SendUpdate;

		public ReadableRegister(byte id, float refreshRate) : base(id, refreshRate) {
		}

		public override bool Update(ByteArray data) {
			T data1 = new T();

			if (data.Length == data1.NumberOfBytes) {
				if (data1.Parse(data)) {
					base.Data = data1;
					return true;
				} else return false;
			} else {
				return false;
			}
		}
	}
	/*
	public class ReadableRegister<T1, T2> : IRegister<T1, T2>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
	{
		public new T1 Data1 { get => base.Data1; }
		public new T2 Data2 { get => base.Data2; }

		public override byte[] SendUpdate => new byte[0];
		public override byte[] ResendUpdate => SendUpdate;

		public ReadableRegister(byte id, float refreshRate) : base(id, refreshRate) {
		}

		public override bool Update(ByteArray data) {
			T1 data1 = new T1();
			T2 data2 = new T2();

			if (data.Length == (data1.NumberOfBytes + data2.NumberOfBytes)) {
				if (data1.Parse(data.Sub(0, data1.NumberOfBytes))) {
					base.Data1 = data1;
					//return true;
				} else return false;
				if (data2.Parse(data.Sub(data1.NumberOfBytes, data2.NumberOfBytes))) {
					base.Data2 = data2;
				} else return false;

				return true;
			} else {
				return false;
			}
		}
	}*/

}
