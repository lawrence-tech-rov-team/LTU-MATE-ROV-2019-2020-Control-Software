using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Ethernet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Simulator {
	public class RobotSimulator : IEthernetLayer {

		private int Latency;
		private RobotSimulatorUI UI;
		private List<ISimulatorDevice> devices = new List<ISimulatorDevice>();
		private IRegister[] registers = new IRegister[256];
		private System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();

		public override bool IsSimulator => true;

		public RobotSimulator(int latency = 5) {
			Latency = latency;
			updateTimer.Interval = 10;
			updateTimer.Tick += UpdateTimer_Tick;
			updateTimer.Start();
		}

		private void UpdateTimer_Tick(object sender, EventArgs e) {
			lock (devices) {
				foreach (ISimulatorDevice device in devices) {
					device.Update();
				}
			}
		}

		public void RegisterDevice(ISimulatorDevice simDevice) {
			foreach(IRegister register in simDevice) {
				if (registers[register.Id] == null) {
					registers[register.Id] = register;
				} else {
					//TODO warn of collision
				}
			}
			lock (devices) {
				devices.Add(simDevice);
			}
		}

		public override long? Ping(int timeoutMs = 3000) {
			lock (this) {
				if (UI != null) {
					Thread.Sleep(Latency);
					return 5;
				} else {
					return null;
				}
			}
		}

		protected override bool TryConnect() {
			lock (this) {
				if (UI == null) {
					UI = new RobotSimulatorUI(this);
					UI.Show();
					return true;
				} else {
					return false;
				}
			}
		}

		protected override void Close() {
			lock (this) {
				if (UI != null) UI.Close();
				UI = null;
			}
		}

		protected override bool SendBytes(byte[] bytes) {
			lock (this) {
				if (UI != null) {
					UdpPacket response = GetResponse(bytes);
					if (response != null) {
						ThreadPool.QueueUserWorkItem((state) => {
							Thread.Sleep(Latency);
							InvokePacketReceived(response);
						});
						return true;
					}
				}

				return false;
			}
		}

		private UdpPacket GetResponse(byte[] bytes) {
			UdpPacket packet = UdpPacket.ParseData(bytes);
			if ((packet != null) && (packet.Command == Command.UpdateDevice)) {
				if (packet.Data.Length > 0) {
					byte id = packet.Data[0];
					if (registers[id] != null) {
						byte[] data = registers[id].SendUpdate;
						if (data == null) data = registers[id].ResendUpdate;
						if (data == null) return null;
						byte[] responseBytes = new byte[data.Length + 1];
						Array.Copy(data, 0, responseBytes, 1, data.Length);
						responseBytes[0] = id;
						return new UdpPacket(Command.UpdateDevice, responseBytes);
					}
				}
			}

			return null;
		}

	}
}
