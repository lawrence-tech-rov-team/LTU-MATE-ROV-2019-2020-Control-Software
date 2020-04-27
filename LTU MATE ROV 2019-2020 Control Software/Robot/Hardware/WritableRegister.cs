using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware {

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

}
