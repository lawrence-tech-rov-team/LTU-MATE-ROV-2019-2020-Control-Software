using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {
	public abstract class IDevice {

		/// <summary>
		/// The unique Id of the device.
		/// </summary>
		public byte Id { get; }

		/// <summary>
		/// The refresh rate of the device, in hertz.
		/// </summary>
		public float RefreshRate { get; }

		public IDevice(byte id, float refreshRate) {
			Id = id;
			RefreshRate = refreshRate;
		}

		/// <summary>
		/// Bytes used to request an update. Can be empty.
		/// If returns null, it is understood that an update is not required.
		/// </summary>
		public abstract byte[] SendUpdate { get; }

		/// <summary>
		/// Update the device with the returned data.
		/// Returns true if updated, false if the data couldn't be parsed.
		/// </summary>
		/// <param name="data">The data received from the ethernet packet.</param>
		/// <returns></returns>
		public abstract bool Update(ByteArray data);
	}

	public abstract class IDevice<T1> : IDevice where T1 : IDataType, new() {

		protected volatile T1 Data1;

		protected IDevice(byte id, float refreshrate) : base(id, refreshrate) {

		}

	}

	public abstract class IDevice<T1, T2> : IDevice where T1 : IDataType, new() where T2 : IDataType, new() {

		protected volatile T1 Data1;
		protected volatile T2 Data2;

		protected IDevice(byte id, float refreshrate) : base(id, refreshrate) {

		}

	}

	public abstract class IDevice<T1, T2, T3> : IDevice where T1 : IDataType, new() where T2 : IDataType, new() where T3 : IDataType, new() {

		protected volatile T1 Data1;
		protected volatile T2 Data2;
		protected volatile T3 Data3;

		protected IDevice(byte id, float refreshrate) : base(id, refreshrate) {

		}

	}
}
