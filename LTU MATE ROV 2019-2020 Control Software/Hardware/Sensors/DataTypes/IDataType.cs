using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Sensors.DataTypes {
	public abstract class IDataType {

		public IDataType() {

		}

		public abstract int NumberOfBytes { get; }

		public abstract byte[] Bytes { get; }

		public abstract bool Parse(ByteArray bytes);

	}
}
