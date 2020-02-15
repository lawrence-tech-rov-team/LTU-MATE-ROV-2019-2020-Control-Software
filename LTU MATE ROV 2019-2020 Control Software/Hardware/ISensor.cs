using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Ethernet;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {
	public abstract class ISensor<T1> : IReadableDevice<T1> 
		where T1 : IDataType, new()
	{

		public ISensor(byte Id, float RefreshRate = 1f) : base(Id, RefreshRate){
			
		}

		public override bool Update(ByteArray data) {
			//Any code to check sensor type goes here.
			return base.Update(data);
		}
	}
/*
	public abstract class ISensor<T1, T2> : IReadableDevice<T1, T2>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
	{
		public ISensor(byte Id, float RefreshRate = 1f) : base(Id, RefreshRate) {

		}

		public override bool Update(ByteArray data) {
			//Any code to check sensor type goes here.
			return base.Update(data);
		}
	}

	public abstract class ISensor<T1, T2, T3> : IReadableDevice<T1, T2, T3>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
		where T3 : IDataType, new()
	{
		public ISensor(byte Id, float RefreshRate = 1f) : base(Id, RefreshRate) {

		}

		public override bool Update(ByteArray data) {
			//Any code to check sensor type goes here.
			return base.Update(data);
		}
	}*/
}
