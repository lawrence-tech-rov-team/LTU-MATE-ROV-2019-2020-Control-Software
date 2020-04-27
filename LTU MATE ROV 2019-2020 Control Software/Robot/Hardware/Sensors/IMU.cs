using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Sensors {
	public class IMU : IDevice {

		public override IRegister[] Registers => new IRegister[]{
			TemperatureRegister,
			MagnetometerRegister,
			GyroscopeRegister,
			EulerRegister,
			AccelerometerRegister,
			LinearAccelRegister,
			GravityRegister,
			QuaternionRegister
		};

		private ReadableRegister<Int8Data> TemperatureRegister;
		public sbyte Temperature => TemperatureRegister.Data?.Value ?? default(sbyte);

		private ReadableRegister<Imu16Vector3Data> MagnetometerRegister;
		public Vector3 Magnetometer => MagnetometerRegister.Data?.Vector ?? new Vector3();

		private ReadableRegister<Imu16Vector3Data> GyroscopeRegister;
		public Vector3 Gyroscope => GyroscopeRegister.Data?.Vector ?? new Vector3();

		private ReadableRegister<Imu16Vector3Data> EulerRegister;
		public Vector3 Euler => EulerRegister.Data?.Vector ?? new Vector3();

		private ReadableRegister<Imu100Vector3Data> AccelerometerRegister;
		public Vector3 Accelerometer => AccelerometerRegister.Data?.Vector ?? new Vector3();

		private ReadableRegister<Imu100Vector3Data> LinearAccelRegister;
		public Vector3 LinearAccel => LinearAccelRegister.Data?.Vector ?? new Vector3();

		private ReadableRegister<Imu100Vector3Data> GravityRegister;
		public Vector3 Gravity => GravityRegister.Data?.Vector ?? new Vector3();

		private ReadableRegister<ImuQuaternionData> QuaternionRegister;
		public Quaternion Quaternion => QuaternionRegister.Data?.Quaternion ?? new Quaternion();

		public IMU(
			byte TemperatureId, float TemperatureRefreshRate,
			byte AccelerometerId, float AccelerometerRefreshRate,
			byte MagnetometerId, float MagnetometerRefreshRate,
			byte GyroscopeId, float GyroscopeRefreshRate,
			byte EulerId, float EulerRefreshRate,
			byte LinearAccelId, float LinearAccelRefreshRate,
			byte GravityId, float GravityRefreshRate,
			byte QuaternionId, float QuaternionRefreshRate
		) {
			TemperatureRegister = new ReadableRegister<Int8Data>(TemperatureId, TemperatureRefreshRate);
			MagnetometerRegister = new ReadableRegister<Imu16Vector3Data>(MagnetometerId, MagnetometerRefreshRate);
			GyroscopeRegister = new ReadableRegister<Imu16Vector3Data>(GyroscopeId, GyroscopeRefreshRate);
			EulerRegister = new ReadableRegister<Imu16Vector3Data>(EulerId, EulerRefreshRate);
			AccelerometerRegister = new ReadableRegister<Imu100Vector3Data>(AccelerometerId, AccelerometerRefreshRate);
			LinearAccelRegister = new ReadableRegister<Imu100Vector3Data>(LinearAccelId, LinearAccelRefreshRate);
			GravityRegister = new ReadableRegister<Imu100Vector3Data>(GravityId, GravityRefreshRate);
			QuaternionRegister = new ReadableRegister<ImuQuaternionData>(QuaternionId, QuaternionRefreshRate);
		}

	}

}
