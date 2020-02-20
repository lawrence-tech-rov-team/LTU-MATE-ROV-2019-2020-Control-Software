using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Ethernet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Sensors {
	public class IMU : ISensor<Int8Data, FloatData, FloatData, FloatData, FloatData, FloatData, FloatData> {

		public sbyte Temperature { get => Data1?.Value ?? default(sbyte); }
		
		public float EulerX { get => Data2?.Value ?? default(float); }
		public float EulerY { get => Data3?.Value ?? default(float); }
		public float EulerZ { get => Data4?.Value ?? default(float); }

		public float AccelX { get => Data5?.Value ?? default(float); }
		public float AccelY { get => Data6?.Value ?? default(float); }
		public float AccelZ { get => Data7?.Value ?? default(float); }

		public IMU(byte ID) : base(ID) {
			
		}

	}

}
