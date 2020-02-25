﻿using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
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

	public abstract class ISensor<T1, T2> : IReadableDevice<T1, T2>
		where T1 : IDataType, new()
		where T2 : IDataType, new() {

		public ISensor(byte Id, float RefreshRate = 1f) : base(Id, RefreshRate) {

		}

		public override bool Update(ByteArray data) {
			//Any code to check sensor type goes here.
			return base.Update(data);
		}
	}

	public abstract class ISensor<T1, T2, T3, T4, T5, T6, T7> : IReadableDevice<T1, T2, T3, T4, T5, T6, T7>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
		where T3 : IDataType, new()
		where T4 : IDataType, new()
		where T5 : IDataType, new()
		where T6 : IDataType, new()
		where T7 : IDataType, new() { 

		public ISensor(byte Id, float RefreshRate = 1f) : base(Id, RefreshRate) {

		}

		public override bool Update(ByteArray data) {
			//Any code to check sensor type goes here.
			return base.Update(data);
		}
	}

	public abstract class ISensor<T1, T2, T3, T4, T5, T6, T7, T8> : IReadableDevice<T1, T2, T3, T4, T5, T6, T7,T8>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
		where T3 : IDataType, new()
		where T4 : IDataType, new()
		where T5 : IDataType, new()
		where T6 : IDataType, new()
		where T7 : IDataType, new()
		where T8 : IDataType, new() {

		public ISensor(byte Id, float RefreshRate = 1f) : base(Id, RefreshRate) {

		}

		public override bool Update(ByteArray data) {
			//Any code to check sensor type goes here.
			return base.Update(data);
		}
	}
}
