using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {
	public abstract class IDevice {
		public byte Id { get; }

		public float RefreshRate { get; }

		public IDevice(byte id, float refreshRate) {
			Id = id;
			RefreshRate = refreshRate;
		}

		public abstract byte[] SendUpdate { get; }

		public abstract bool Update(ByteArray data);
	}
}
