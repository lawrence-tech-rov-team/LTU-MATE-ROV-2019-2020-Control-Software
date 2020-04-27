using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Sensors {
	public class PressureSensor : IDevice {

		public override IRegister[] Registers => new IRegister[] {
			SensorRegister
		};

		private ReadableRegister<Vector2Data> SensorRegister;

		/// <summary> Returns pressure in milliBars </summary>
		public float Pressure => SensorRegister.Data?.X ?? default(float);

		/// <summary> Returns temperature in celcius. </summary>
		public float Temperature => SensorRegister.Data?.Y ?? default(float);

		/// <summary> Meters above mean sea level </summary>
		public float Altitude => (1f - (float)Math.Pow(Pressure / 1013.25f, 0.190284f)) * 145366.45f * 0.3048f;

		/// <summary> Depth in meters. </summary>
		public float Depth => (Pressure * 100f - 101300f) / (FluidDensity.Density * 9.80665f);

		public FluidDensity FluidDensity = FluidDensity.Freshwater;

		public PressureSensor(byte sensorId, float refreshRate) {
			SensorRegister = new ReadableRegister<Vector2Data>(sensorId, refreshRate);
		}

	}

	public struct FluidDensity {

		public static FluidDensity Freshwater = new FluidDensity(997f);
		public static FluidDensity Seawater = new FluidDensity(1029f);

		public float Density;

		public FluidDensity(float density) {
			Density = density;
		}

	}
}
