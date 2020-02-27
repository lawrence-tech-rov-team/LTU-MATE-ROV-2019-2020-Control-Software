using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.DataTypes;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {

	public abstract class IRegister {

		/// <summary>
		/// The unique Id of the device.
		/// </summary>
		public byte Id { get; }

		/// <summary>
		/// The refresh rate of the device, in hertz.
		/// </summary>
		public float RefreshRate { get; }

		/// <summary>
		/// Bytes used to request an update. Can be empty.
		/// If returns null, it is understood that an update is not required.
		/// </summary>
		public abstract byte[] SendUpdate { get; }

		public abstract byte[] ResendUpdate { get; }

		protected IRegister(byte id, float refreshrate) {
			this.Id = id;
			this.RefreshRate = refreshrate;
		}

		public abstract bool Update(ByteArray data);
	}

	public abstract class IRegister<T> : IRegister
		where T : IDataType, new()
	{
		protected volatile T Data;

		protected IRegister(byte id, float refreshRate) : base(id, refreshRate) {
			
		}
	}
	/*
	public abstract class IRegister<T1, T2>
		where T1 : IDataType, new()
		where T2 : IDataType, new()
	{
		protected volatile T1 Data1;
		protected volatile T2 Data2;
	}*/


	/*
	#region IRegisterW
	public abstract class IRegisterW<T1> : IWritableDevice<T1> where T1 : IDataType, new() {

		protected IRegisterW(byte id, float refreshRate = 1f) : base(id, refreshRate) {

		}

		public override byte[] SendUpdate {
			get {
				byte[] bytes = base.SendUpdate;
				if (bytes == null) return null;
				else {
					//Add additional bytes here
					return bytes;
				}
			}
		}

	}*/
	/*
		public abstract class IRegisterW<T1, T2> : IWritableDevice<T1, T2> where T1 : IDataType, new() where T2 : IDataType, new() {

			protected IRegisterW(byte id, float refreshRate = 1f) : base(id, refreshRate) {

			}

			public override byte[] SendUpdate {
				get {
					byte[] bytes = base.SendUpdate;
					if (bytes == null) return null;
					else {
						//Add additional bytes here
						return bytes;
					}
				}
			}

		}
	*/
	//#endregion
	/*#region IRegisterR
	public abstract class IRegisterR<T1> : IReadableDevice<T1> where T1 : IDataType, new() {
		protected IRegisterR(byte id, float refreshRate = 1f) : base(id, refreshRate) {
		}

		public override bool Update(ByteArray data) {
			//Any code to check sensor type goes here.
			return base.Update(data);
		}
	}
	*/
	/*public abstract class IRegisterR<T1, T2> : IReadableDevice<T1, T2> where T1 : IDataType, new() where T2 : IDataType, new() {
		protected IRegisterR(byte id, float refreshRate = 1f) : base(id, refreshRate) {
		}

		public override bool Update(ByteArray data) {
			//Any code to check sensor type goes here.
			return base.Update(data);
		}
	}
	*/
	//#endregion
}
