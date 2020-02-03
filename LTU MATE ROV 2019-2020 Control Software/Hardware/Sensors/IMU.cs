using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Ethernet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Sensors {
	public class IMU : ISensor<ImuData> {

		public override SensorType Type => SensorType.IMU;

		public IMU(byte ID) : base(ID) {
			
		}

		protected override ImuData ParseData(byte[] data) {
			if((data.Length == 4) && (data[0] == (byte)Type)) {
				return new ImuData(
					(byte)data[1],
					(byte)data[2],
					(byte)data[3]
				);
			}

			return null;
		}
	}

	public class ImuData {

		public float x { get; }
		public float y { get; }
		public float z { get; }

		public ImuData(float x, float y, float z) {
			this.x = x;
			this.y = y;
			this.z = z;
		}
	}
}
