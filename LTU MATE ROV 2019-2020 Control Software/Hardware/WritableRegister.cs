using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {

	/*TODO
 I'm thinking in IDevice, add a method called "Resend last". 
 IReadable will just return the same update message.

	IWritable will have an additional data field called "LastSent1" which stores the last sent value
	if "Resent Last" is called, that value will be sent.
	Otherwise, when an update is requested is used to check against the current value.
	If the values are the same, an update isn't needed. Otherwise, update LastSent with the new value.
*/

	public class WritableRegister<T> : IRegister<T>
		where T : IDataType, new() {

		//TODO only send the value if it is different.
		private T LastSent1;
		public T Value { set => Data = value; }

		public WritableRegister(byte id, float refreshrate) : base(id, refreshrate) {
		}

		public override byte[] SendUpdate {
			get {
				T data1 = Data;
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
	public class IWritableRegister<T1, T2> : IRegister<T1, T2>
		where T1 : IDataType, new()
		where T2 : IDataType, new() {


	}*/
}
