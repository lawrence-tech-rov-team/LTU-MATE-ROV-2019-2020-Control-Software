using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {
	public abstract class IReadableDevice<T1> : IDevice<T1> 
		where T1 : IDataType, new() 
	{

		protected IReadableDevice(byte id, float refreshRate) : base(id, refreshRate) {

		}

		public override byte[] SendUpdate => new byte[0];

		public override bool Update(ByteArray data) {
			T1 data1 = new T1();

			if(data.Length == data1.NumberOfBytes) {
				if (data1.Parse(data)) {
					Data1 = data1;
					return true;
				} else return false;
			} else {
				return false;
			}
		}

	}

	public abstract class IReadableDevice<T1, T2> : IDevice<T1, T2> 
		where T1 : IDataType, new() 
		where T2 : IDataType, new() 
	{

		protected IReadableDevice(byte id, float refreshRate) : base(id, refreshRate) {

		}

		public override byte[] SendUpdate => null;

		public override bool Update(ByteArray data) {
			if (data.Length > 0) {
				T1 data1 = null;
				T2 data2 = null;

				byte mask = data[0];
				data++;
				if ((mask & 0x01) > 0) {
					data1 = new T1();
					if (!data1.Parse(data.Resize(data1.NumberOfBytes))) return false;
					data += data1.NumberOfBytes;
				}
				if((mask & 0x02) > 0) {
					data2 = new T2();
					if (!data2.Parse(data.Resize(data2.NumberOfBytes))) return false;
					data += data2.NumberOfBytes;
				}

				if(data1 != null) Data1 = data1;
				if(data2 != null) Data2 = data2;

				return true;
			} else {
				return false;
			}
		}

	}

	public abstract class IReadableDevice<T1, T2, T3> : IDevice<T1, T2, T3>
		where T1 : IDataType, new() 
		where T2 : IDataType, new() 
		where T3 : IDataType, new() 
	{

		protected IReadableDevice(byte id, float refreshRate) : base(id, refreshRate) {

		}

		public override byte[] SendUpdate => null;

		public override bool Update(ByteArray data) {
			if (data.Length > 0) {
				T1 data1 = null;
				T2 data2 = null;
				T3 data3 = null;

				byte mask = data[0];
				data++;
				if ((mask & 0x01) > 0) {
					data1 = new T1();
					if (!data1.Parse(data.Resize(data1.NumberOfBytes))) return false;
					data += data1.NumberOfBytes;
				}
				if ((mask & 0x02) > 0) {
					data2 = new T2();
					if (!data2.Parse(data.Resize(data2.NumberOfBytes))) return false;
					data += data2.NumberOfBytes;
				}
				if((mask & 0x04) > 0) {
					data3 = new T3();
					if (!data3.Parse(data.Resize(data3.NumberOfBytes))) return false;
					data += data3.NumberOfBytes;
				}

				if (data1 != null) Data1 = data1;
				if (data2 != null) Data2 = data2;
				if (data3 != null) Data3 = data3;

				return true;
			} else {
				return false;
			}
		}

	}

	public abstract class IReadableDevice<T1, T2, T3, T4> : IDevice<T1, T2, T3, T4>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
		where T3 : IDataType, new()
		where T4 : IDataType, new()
	{

		protected IReadableDevice(byte id, float refreshRate) : base(id, refreshRate) {

		}

		public override byte[] SendUpdate => null;

		public override bool Update(ByteArray data) {
			if (data.Length > 0) {
				T1 data1 = null;
				T2 data2 = null;
				T3 data3 = null;
				T4 data4 = null;

				byte mask = data[0];
				data++;
				if ((mask & 0x01) > 0) {
					data1 = new T1();
					if (!data1.Parse(data.Resize(data1.NumberOfBytes))) return false;
					data += data1.NumberOfBytes;
				}
				if ((mask & 0x02) > 0) {
					data2 = new T2();
					if (!data2.Parse(data.Resize(data2.NumberOfBytes))) return false;
					data += data2.NumberOfBytes;
				}
				if ((mask & 0x04) > 0) {
					data3 = new T3();
					if (!data3.Parse(data.Resize(data3.NumberOfBytes))) return false;
					data += data3.NumberOfBytes;
				}
				if((mask & 0x08) > 0) {
					data4 = new T4();
					if (!data4.Parse(data.Resize(data4.NumberOfBytes))) return false;
					data += data4.NumberOfBytes;
				}

				if (data1 != null) Data1 = data1;
				if (data2 != null) Data2 = data2;
				if (data3 != null) Data3 = data3;
				if (data4 != null) Data4 = data4;

				return true;
			} else {
				return false;
			}
		}

	}

	public abstract class IReadableDevice<T1, T2, T3, T4, T5> : IDevice<T1, T2, T3, T4, T5>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
		where T3 : IDataType, new()
		where T4 : IDataType, new()
		where T5 : IDataType, new()
	{

		protected IReadableDevice(byte id, float refreshRate) : base(id, refreshRate) {

		}

		public override byte[] SendUpdate => null;

		public override bool Update(ByteArray data) {
			if (data.Length > 0) {
				T1 data1 = null;
				T2 data2 = null;
				T3 data3 = null;
				T4 data4 = null;
				T5 data5 = null;

				byte mask = data[0];
				data++;
				if ((mask & 0x01) > 0) {
					data1 = new T1();
					if (!data1.Parse(data.Resize(data1.NumberOfBytes))) return false;
					data += data1.NumberOfBytes;
				}
				if ((mask & 0x02) > 0) {
					data2 = new T2();
					if (!data2.Parse(data.Resize(data2.NumberOfBytes))) return false;
					data += data2.NumberOfBytes;
				}
				if ((mask & 0x04) > 0) {
					data3 = new T3();
					if (!data3.Parse(data.Resize(data3.NumberOfBytes))) return false;
					data += data3.NumberOfBytes;
				}
				if ((mask & 0x08) > 0) {
					data4 = new T4();
					if (!data4.Parse(data.Resize(data4.NumberOfBytes))) return false;
					data += data4.NumberOfBytes;
				}
				if((mask & 0x10) > 0) {
					data5 = new T5();
					if (!data5.Parse(data.Resize(data5.NumberOfBytes))) return false;
					data += data5.NumberOfBytes;
				}

				if (data1 != null) Data1 = data1;
				if (data2 != null) Data2 = data2;
				if (data3 != null) Data3 = data3;
				if (data4 != null) Data4 = data4;
				if (data5 != null) Data5 = data5;

				return true;
			} else {
				return false;
			}
		}

	}

	public abstract class IReadableDevice<T1, T2, T3, T4, T5, T6> : IDevice<T1, T2, T3, T4, T5, T6>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
		where T3 : IDataType, new()
		where T4 : IDataType, new()
		where T5 : IDataType, new()
		where T6 : IDataType, new()
	{

		protected IReadableDevice(byte id, float refreshRate) : base(id, refreshRate) {

		}

		public override byte[] SendUpdate => null;

		public override bool Update(ByteArray data) {
			if (data.Length > 0) {
				T1 data1 = null;
				T2 data2 = null;
				T3 data3 = null;
				T4 data4 = null;
				T5 data5 = null;
				T6 data6 = null;

				byte mask = data[0];
				data++;
				if ((mask & 0x01) > 0) {
					data1 = new T1();
					if (!data1.Parse(data.Resize(data1.NumberOfBytes))) return false;
					data += data1.NumberOfBytes;
				}
				if ((mask & 0x02) > 0) {
					data2 = new T2();
					if (!data2.Parse(data.Resize(data2.NumberOfBytes))) return false;
					data += data2.NumberOfBytes;
				}
				if ((mask & 0x04) > 0) {
					data3 = new T3();
					if (!data3.Parse(data.Resize(data3.NumberOfBytes))) return false;
					data += data3.NumberOfBytes;
				}
				if ((mask & 0x08) > 0) {
					data4 = new T4();
					if (!data4.Parse(data.Resize(data4.NumberOfBytes))) return false;
					data += data4.NumberOfBytes;
				}
				if ((mask & 0x10) > 0) {
					data5 = new T5();
					if (!data5.Parse(data.Resize(data5.NumberOfBytes))) return false;
					data += data5.NumberOfBytes;
				}
				if((mask & 0x20) > 0) {
					data6 = new T6();
					if (!data6.Parse(data.Resize(data6.NumberOfBytes))) return false;
					data += data6.NumberOfBytes;
				}

				if (data1 != null) Data1 = data1;
				if (data2 != null) Data2 = data2;
				if (data3 != null) Data3 = data3;
				if (data4 != null) Data4 = data4;
				if (data5 != null) Data5 = data5;
				if (data6 != null) Data6 = data6;

				return true;
			} else {
				return false;
			}
		}

	}

	public abstract class IReadableDevice<T1, T2, T3, T4, T5, T6, T7> : IDevice<T1, T2, T3, T4, T5, T6, T7>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
		where T3 : IDataType, new()
		where T4 : IDataType, new()
		where T5 : IDataType, new()
		where T6 : IDataType, new()
		where T7 : IDataType, new()
	{

		protected IReadableDevice(byte id, float refreshRate) : base(id, refreshRate) {

		}

		public override byte[] SendUpdate => null;

		public override bool Update(ByteArray data) {
			if (data.Length > 0) {
				T1 data1 = null;
				T2 data2 = null;
				T3 data3 = null;
				T4 data4 = null;
				T5 data5 = null;
				T6 data6 = null;
				T7 data7 = null;

				byte mask = data[0];
				data++;
				if ((mask & 0x01) > 0) {
					data1 = new T1();
					if (!data1.Parse(data.Resize(data1.NumberOfBytes))) return false;
					data += data1.NumberOfBytes;
				}
				if ((mask & 0x02) > 0) {
					data2 = new T2();
					if (!data2.Parse(data.Resize(data2.NumberOfBytes))) return false;
					data += data2.NumberOfBytes;
				}
				if ((mask & 0x04) > 0) {
					data3 = new T3();
					if (!data3.Parse(data.Resize(data3.NumberOfBytes))) return false;
					data += data3.NumberOfBytes;
				}
				if ((mask & 0x08) > 0) {
					data4 = new T4();
					if (!data4.Parse(data.Resize(data4.NumberOfBytes))) return false;
					data += data4.NumberOfBytes;
				}
				if ((mask & 0x10) > 0) {
					data5 = new T5();
					if (!data5.Parse(data.Resize(data5.NumberOfBytes))) return false;
					data += data5.NumberOfBytes;
				}
				if ((mask & 0x20) > 0) {
					data6 = new T6();
					if (!data6.Parse(data.Resize(data6.NumberOfBytes))) return false;
					data += data6.NumberOfBytes;
				}
				if((mask & 0x40) > 0) {
					data7 = new T7();
					if (!data7.Parse(data.Resize(data7.NumberOfBytes))) return false;
					data += data7.NumberOfBytes;
				}

				if (data1 != null) Data1 = data1;
				if (data2 != null) Data2 = data2;
				if (data3 != null) Data3 = data3;
				if (data4 != null) Data4 = data4;
				if (data5 != null) Data5 = data5;
				if (data6 != null) Data6 = data6;
				if (data7 != null) Data7 = data7;

				return true;
			} else {
				return false;
			}
		}

	}

	public abstract class IReadableDevice<T1, T2, T3, T4, T5, T6, T7, T8> : IDevice<T1, T2, T3, T4, T5, T6, T7, T8>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
		where T3 : IDataType, new()
		where T4 : IDataType, new()
		where T5 : IDataType, new()
		where T6 : IDataType, new()
		where T7 : IDataType, new()
		where T8 : IDataType, new()
	{

		protected IReadableDevice(byte id, float refreshRate) : base(id, refreshRate) {

		}

		public override byte[] SendUpdate => null;

		public override bool Update(ByteArray data) {
			if (data.Length > 0) {
				T1 data1 = null;
				T2 data2 = null;
				T3 data3 = null;
				T4 data4 = null;
				T5 data5 = null;
				T6 data6 = null;
				T7 data7 = null;
				T8 data8 = null;

				byte mask = data[0];
				data++;
				if ((mask & 0x01) > 0) {
					data1 = new T1();
					if (!data1.Parse(data.Resize(data1.NumberOfBytes))) return false;
					data += data1.NumberOfBytes;
				}
				if ((mask & 0x02) > 0) {
					data2 = new T2();
					if (!data2.Parse(data.Resize(data2.NumberOfBytes))) return false;
					data += data2.NumberOfBytes;
				}
				if ((mask & 0x04) > 0) {
					data3 = new T3();
					if (!data3.Parse(data.Resize(data3.NumberOfBytes))) return false;
					data += data3.NumberOfBytes;
				}
				if ((mask & 0x08) > 0) {
					data4 = new T4();
					if (!data4.Parse(data.Resize(data4.NumberOfBytes))) return false;
					data += data4.NumberOfBytes;
				}
				if ((mask & 0x10) > 0) {
					data5 = new T5();
					if (!data5.Parse(data.Resize(data5.NumberOfBytes))) return false;
					data += data5.NumberOfBytes;
				}
				if ((mask & 0x20) > 0) {
					data6 = new T6();
					if (!data6.Parse(data.Resize(data6.NumberOfBytes))) return false;
					data += data6.NumberOfBytes;
				}
				if ((mask & 0x40) > 0) {
					data7 = new T7();
					if (!data7.Parse(data.Resize(data7.NumberOfBytes))) return false;
					data += data7.NumberOfBytes;
				}
				if((mask & 0x80) > 0) {
					data8 = new T8();
					if (!data8.Parse(data.Resize(data8.NumberOfBytes))) return false;
					data += data8.NumberOfBytes;
				}

				if (data1 != null) Data1 = data1;
				if (data2 != null) Data2 = data2;
				if (data3 != null) Data3 = data3;
				if (data4 != null) Data4 = data4;
				if (data5 != null) Data5 = data5;
				if (data6 != null) Data6 = data6;
				if (data7 != null) Data7 = data7;
				if (data8 != null) Data8 = data8;

				return true;
			} else {
				return false;
			}
		}

	}

}
