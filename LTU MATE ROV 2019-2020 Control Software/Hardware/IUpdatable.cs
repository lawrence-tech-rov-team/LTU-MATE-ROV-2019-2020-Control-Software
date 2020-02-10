using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Ethernet;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {
	public interface IUpdatable { //TODO rename to IDevice?

		/// <summary>
		/// The unique Id of the device.
		/// </summary>
		byte Id { get; }

		/// <summary>
		/// The refresh rate of the device, in hertz.
		/// </summary>
		float RefreshRate { get; } 

		/// <summary>
		/// The command used to update the device.
		/// </summary>
		//Command Command { get; }

		/// <summary>
		/// If true, a request will be sent to update the status of the device.
		/// If false, the device will be flagged as updated and no update will be sent.
		/// </summary>
		//bool RequiresUpdate { get; }

		/// <summary>
		/// Bytes used to request an update. Can be empty.
		/// If returns null, it is understood that an update is not required.
		/// </summary>
		byte[] SendUpdate { get; }

		/// <summary>
		/// Update the device with the returned data.
		/// Returns true if updated, false if the data couldn't be parsed.
		/// </summary>
		/// <param name="data">The data received from the ethernet packet.</param>
		/// <returns></returns>
		bool Update(ByteArray data);

	}
}
