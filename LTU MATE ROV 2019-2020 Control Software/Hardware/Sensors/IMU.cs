using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Ethernet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Sensors {
	public class IMU : IDevice {

		public override IRegister[] Registers => new IRegister[]{
			TemperatureRegister,
			AccelerometerRegister
		};

		private ReadableRegister<Int8Data> TemperatureRegister;
		public sbyte Temperature => TemperatureRegister.Value?.Value ?? default(sbyte); //TODO rename register ".Value" to ".Data"

		private ReadableRegister<Vector3Data> AccelerometerRegister;
		public Vector3Data Accelerometer => AccelerometerRegister.Value;

		//public Vector3Data Magnetometer { get => Data2; } //TODO return vector3 data
		//public Vector3Data Gyroscope { get => Data3; }
		//public Vector3Data Euler { get => Data4; }
		//public Vector3Data Accelerometer { get => Data5; }
		//public Vector3Data LinearAccelerometer { get => Data6; }
		//public Vector3Data Gravity { get => Data7; }
		//public Vector4Data Quaternion { get => Data8; }

		public IMU(byte TemperatureId, float TemperatureRefreshRate, byte AccelerometerId, float AccelerometerRefreshRate) {
			TemperatureRegister = new ReadableRegister<Int8Data>(TemperatureId, TemperatureRefreshRate);
			AccelerometerRegister = new ReadableRegister<Vector3Data>(AccelerometerId, AccelerometerRefreshRate);
		}

	}

}
