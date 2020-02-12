using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO Limit PWM values
/*
T-200:
1180 - 1814 PMW input Value
T-100:
1140 - 1855 PWM input Value
*/

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {

	public abstract class IActuator<T1> : IWritableDevice<T1> where T1 : IDataType, new() {

		protected IActuator(byte id, float refreshRate = 1f) : base(id, refreshRate) {
			
		}

		public override byte[] SendUpdate {
			get {
				byte[] bytes = base.SendUpdate;
				if (bytes == null) return null;
				else {
					//Add additional bytes here
					return bytes;
				}
			}
		}

	}

	public abstract class IActuator<T1, T2> : IWritableDevice<T1, T2> where T1 : IDataType, new() where T2 : IDataType, new() {

		protected IActuator(byte id, float refreshRate = 1f) : base(id, refreshRate) {

		}

		public override byte[] SendUpdate {
			get {
				byte[] bytes = base.SendUpdate;
				if (bytes == null) return null;
				else {
					//Add additional bytes here
					return bytes;
				}
			}
		}

	}
}
