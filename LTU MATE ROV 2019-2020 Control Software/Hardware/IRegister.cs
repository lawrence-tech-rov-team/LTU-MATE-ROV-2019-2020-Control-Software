using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Sensors.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {
	public abstract class IRegister : IUpdatable {

		public byte Id { get; }

		public float RefreshRate { get; }

		protected IRegister(byte id, float refreshRate = 1f) {
			Id = id;
			RefreshRate = refreshRate;
		}

		public abstract bool Update(ByteArray data);
		public abstract byte[] SendUpdate { get; }

	}

	public abstract class IRegister<T1> : IRegister where T1 : IDataType, new() {

		protected volatile T1 Data1;

		protected IRegister(byte id, float refreshRate = 1f) : base(id, refreshRate) {

		}

		public override bool Update(ByteArray data) {
			return data.Length == 0;
		}

		public override byte[] SendUpdate {
			get {
				T1 data1 = Data1;
				if(data1 != null) {
					return data1.Bytes;
				} else {
					return null;
				}
			}
		}

	}

	public abstract class IRegister<T1, T2> : IRegister where T1 : IDataType, new() where T2 : IDataType, new() {

		protected volatile T1 Data1;
		protected volatile T2 Data2;

		protected IRegister(byte id, float refreshRate = 1f) : base(id, refreshRate) {

		}

		public override bool Update(ByteArray data) {
			return data.Length == 0;
		}

		public override byte[] SendUpdate {
			get {
				T1 data1 = Data1;
				T2 data2 = Data2;

				List<byte> bytes = new List<byte>();
				bytes.Add(0);

				if (data1 != null) {
					bytes[0] |= 0x01;
					bytes.AddRange(data1.Bytes);
				}
				if (data2 != null) {
					bytes[0] |= 0x02;
					bytes.AddRange(data2.Bytes);
				}

				if (bytes[0] == 0) return null; //There is nothing to update.
				else return bytes.ToArray();
			}
		}

	}
}
