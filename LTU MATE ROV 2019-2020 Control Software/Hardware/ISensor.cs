using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Ethernet;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {
	public abstract class ISensor<T> : IUpdatable where T:class {

		/// <summary>
		/// The Id of the sensor.
		/// See <see cref="IUpdatable.Id"/>
		/// </summary>
		public byte Id { get; private set; }

		/// <summary>
		/// The type of sensor. This could be IMU, Pressure, etc.
		/// Mainy used as a check when parsing data.
		/// </summary>
		public abstract SensorType Type { get; }

		/// <summary>
		/// The refresh rate of the sensor in hertz.
		/// See <see cref="IUpdatable.RefreshRate"/>
		/// </summary>
		public float RefreshRate { get; private set; }

		/// <summary>
		/// Indicates if the sensor requires an update. Always set to true
		/// since sensor values are always changing.
		/// </summary>
		public bool RequiresUpdate => true;

		/// <summary>
		/// The data to be sent to update the sensor.
		/// By default, just send the type of sensor as a check.
		/// </summary>
		public virtual byte[] SendUpdate => new byte[] { (byte)Type };

		private volatile T data;
		public T Data { get => data; }

		public ISensor(byte Id, float RefreshRate = 1f) {
			this.Id = Id;
			this.RefreshRate = RefreshRate;
		}

		/// <summary>
		/// The first byte will always be the sensor type (which can be ignored, it is already checked),
		/// the actual data starts on the second byte.
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		protected abstract T ParseData(ByteArray data);

		public bool Update(ByteArray data) {
			if ((data.Length > 0) && (data[0] == (byte)Type)) {
				T parsed = ParseData(data++);
				if (parsed == null) return false;
				else {
					this.data = parsed;
					return true;
				}
			} else {
				return false;
			}
		}
	}
}
