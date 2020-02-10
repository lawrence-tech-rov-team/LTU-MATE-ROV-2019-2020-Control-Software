using LTU_MATE_ROV_2019_2020_Control_Software.Hardware.Ethernet;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Hardware {
	public abstract class Robot {
		//TODO detect congestion. Something along the lines of if 3 messages in a row don't get a quick enough response. Maybe instead of disconnecting when a timeout is found, just inform the user of congestion.
		/// <summary>
		/// The maximum number of devices that can be attached.
		/// </summary>
		private const int MaxNumDevices = 256;

		/// <summary>
		/// The max # of bytes the robot can buffer at once.
		/// </summary>
		protected abstract int BufferSize { get; }

		/// <summary>
		/// Number of update attempts before a timeout occurs.
		/// </summary>
		protected virtual int TimeoutAttempts { get; } = 3;

		/// <summary>
		/// Number of milliseconds before a message is considered lost.
		/// </summary>
		protected virtual int MessageTimemout { get; } = 100;

		public volatile EthernetInterface ether; //TODO make private and not volatile, temporary testing
		private Thread thread;
		private volatile int BytesSent = 0;

		private IUpdatable[] devices = new IUpdatable[MaxNumDevices];
		private Stopwatch[] refreshTimers = new Stopwatch[MaxNumDevices];
		private byte[] updateAttempts = new byte[MaxNumDevices];
		private Stopwatch[] updateTimers = new Stopwatch[MaxNumDevices];
		private int[] updateSize = new int[MaxNumDevices];

		private volatile bool running = true;

		protected void RegisterDevice(IUpdatable device) {
			if(devices[device.Id] != null) {
				throw new IndexOutOfRangeException(); //TODO id collisions
			} else {
				updateAttempts[device.Id] = 0;
				updateTimers[device.Id] = new Stopwatch();
				refreshTimers[device.Id] = new Stopwatch();
				refreshTimers[device.Id].Start();
				devices[device.Id] = device;
			}
		}

		protected Robot(ThreadPriority priority) {
			thread = ThreadHelper.StartNewThread("Robot Sender", true, RobotLoop, priority);
		}

		public void StopAsync() {
			running = false;
		}

		public void Stop() {
			StopAsync();
			thread.Join();
		}

		private void SendUpdateRequest(int id) {
			//Get the required bytes to send an update
			byte[] updateBytes = devices[id].SendUpdate;
			byte[] bytes = new byte[updateBytes.Length + 1];
			bytes[0] = (byte)id;
			updateBytes.CopyTo(bytes, 1);
			updateSize[id] = updateBytes.Length;

			//Wait until there is enough space in the receive buffer to send the packet
			while (true) {
				lock (this) {
					if ((BufferSize - BytesSent) >= updateBytes.Length) {
						BytesSent += updateBytes.Length;
						break;
					}
				}
			}

			ether.Send(Command.UpdateDevice, bytes);
			updateTimers[id].Restart();
		}//TODO check refresh rate is > 0

		private void CheckForTimeout(int id) {
			if (updateTimers[id].ElapsedMilliseconds >= MessageTimemout) {
				if (updateAttempts[id] == TimeoutAttempts) {
					//throw new NotImplementedException(); //TODO timeout occured, disconnect.
					updateAttempts[id] = 0;
				} else {
					lock (this) {
						BytesSent -= updateSize[id]; //Just in case the update packets are different sizes.
					}
					SendUpdateRequest(id);
					updateAttempts[id]++;
					updateTimers[id].Restart();
				}
			}
		}

		private void UpdateDevice(int id) {
			refreshTimers[id].Restart(); //Absolute timing. Keeps refresh rate as close to the requested rate as possible.
			if (devices[id].RequiresUpdate) {
				SendUpdateRequest(id);
			}
			updateAttempts[id] = 1; //Indicates that an update message was sent.
			updateTimers[id].Restart();
		}

		private void RobotLoop() {
			ether = new EthernetInterface();
			ether.OnPacketReceived += Ether_OnPacketReceived;
			while (running) {
				for(int i = 0; i < MaxNumDevices; i++) {
					if(devices[i] != null) {
						if(updateAttempts[i] > 0) {
							//Message was sent, check for a timeout
							CheckForTimeout(i);
						}else if(/*updateAttempts[i] == 0 &&*/refreshTimers[i].ElapsedMilliseconds > (1000 / devices[i].RefreshRate)) {
							//Sensor is due for an update, send the message
							UpdateDevice(i);
						}
					}
				}
			}
			ether.Disconnect();
		}

		private void PingReceived(ByteArray packet) {
			//TODO ping
			Console.WriteLine("Ping Received: {0}", packet[0]);
		}

		private void EchoReceived(ByteArray packet) {
			//TODO echo
			Console.WriteLine("Echo Received: Length = {0}", packet.Length);
		}

		private void UpdateDeviceReceived(ByteArray packet) {
			if (packet.Length >= 1) {
				int id = packet[0];
				if (devices[id] != null) {
					if (devices[id].Update(packet++)) {
						int size = updateSize[id];
						updateAttempts[id] = 0;
						lock (this) { //TODO take a good look at atomicity
							BytesSent -= size;
						}
					}
				}
			}
		}

		//NOTE: OnReceived may be invoked on a secondary thread.
		private void Ether_OnPacketReceived(UdpPacket packet) { 
			switch (packet.Command) {
				case Command.Ping:
					PingReceived(packet.Data);
					break;
				case Command.Echo:
					EchoReceived(packet.Data);
					break;
				case Command.UpdateDevice:
					UpdateDeviceReceived(packet.Data);
					break;
				default:
					//TODO other commands
					throw new NotImplementedException();
			}
		}
	}
}

