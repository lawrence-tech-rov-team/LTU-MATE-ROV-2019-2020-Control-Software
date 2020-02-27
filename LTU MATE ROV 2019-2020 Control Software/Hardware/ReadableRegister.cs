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
	/*
	public class IReadableRegister<T1, T2> : IRegister<T1, T2>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
	{


	}*/
}
