using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Ethernet {
	public class UdpPacket {
		//public static readonly byte START_BYTE = 0xFF;
		public static readonly byte CHECKSUM_MASK = 0xFF;
		public static readonly int MAX_LENGTH = 255;

		//public byte StartByte;
		public byte Id;
		//public byte Length;
		public ByteArray Data;
		public byte Checksum;
		public int Length { get => Data.Length; }

		public byte[] AllBytes {
			get {
				byte[] bytes = new byte[Data.Length + 2];
				//bytes[0] = START_BYTE;
				bytes[0] = Id;
				Data.CopyTo(bytes, 1);
				bytes[bytes.Length - 1] = Checksum;
				return bytes;
			}
		}

		private UdpPacket() {
		}

		public UdpPacket(byte id, ByteArray data) {
			this.Id = id;
			if (data == null) this.Data = new ByteArray();
			else if (data.Length <= MAX_LENGTH) this.Data = data;
			else this.Data = data.Resize(MAX_LENGTH);
			Checksum = /*(byte)(START_BYTE +*/ id;//);
			foreach (byte b in Data) Checksum += b;
			Checksum &= CHECKSUM_MASK;
		}

		public UdpPacket(byte id, params byte[] data) : this(id, new ByteArray(data)){
			
		}

		public byte this[int i] {
			get { return Data[i]; }
			//set { InnerList[i] = value; }
		}

		public static UdpPacket ParseData(byte[] data) {
			if (data.Length < 2) return null;

			UdpPacket packet = new UdpPacket();
			//packet.StartByte = data[0];
			packet.Id = data[0];
			//packet.Length = data[2];
			packet.Checksum = data[data.Length - 1];

			//if ((data[0] != START_BYTE)
				//|| (packet.Command == START_BYTE)
				//|| (packet.Length == START_BYTE)
				/*|| (packet.Checksum == START_BYTE)*///) return null;

			//Check both for invalid bytes and the checksum.
			byte checksum = 0;
			for (int i = 0; i < (data.Length - 1); i++) {
				//				if (data[i] == START_BYTE) return null;
				checksum += data[i];
			}

			if ((checksum & CHECKSUM_MASK) != data[data.Length - 1]) return null;

			packet.Data = new ByteArray(data, 1, data.Length - 2);

			return packet;
		}

	}
}
