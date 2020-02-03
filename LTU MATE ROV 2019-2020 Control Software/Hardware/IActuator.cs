using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {
	public abstract class IActuator : IUpdatable {
		public byte Id { get; private set; }

		public float RefreshRate { get; private set; }

		private volatile bool requiresUpdate = true;
		public bool RequiresUpdate { get => requiresUpdate; private set => requiresUpdate = value; }

		public byte[] RequestUpdate => throw new NotImplementedException();

		public bool Update(byte[] data) {
			throw new NotImplementedException();
		}
	}
}
