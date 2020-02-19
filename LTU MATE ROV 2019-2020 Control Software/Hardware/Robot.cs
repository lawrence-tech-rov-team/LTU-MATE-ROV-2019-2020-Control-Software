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

		private IEthernetLayer ether;
		private Thread thread;
		private volatile int BytesSent = 0;

		/// <summary>
		/// Devices
		/// </summary>
		private IDevice[] devices = new IDevice[MaxNumDevices];

		/// <summary>
		/// Timer that activates at the refresh rate of the sensor
		/// </summary>
		private Stopwatch[] refreshTimers = new Stopwatch[MaxNumDevices];

		/// <summary>
		/// Timer that checks for timeouts
		/// </summary>
		private Stopwatch[] updateTimers = new Stopwatch[MaxNumDevices]; //TODO rename to "timeouttimer"

		private bool[] messageReceived = new bool[MaxNumDevices];

		/// <summary>
		/// The size of the message that was sent
		/// </summary>
		private int[] updateSize = new int[MaxNumDevices];

		/// <summary>
		/// Number of timeouts that have occured in a row.
		/// </summary>
		private volatile int numTimeouts = 0;

		private volatile bool running = true;

		protected void RegisterDevice(IDevice device) {
			if(devices[device.Id] != null) {
				throw new IndexOutOfRangeException(); //TODO id collisions
			} else {
				//updateAttempts[device.Id] = 0;
				updateTimers[device.Id] = new Stopwatch();
				refreshTimers[device.Id] = new Stopwatch();
				refreshTimers[device.Id].Start();
				devices[device.Id] = device;
			}
		}

		protected Robot(ThreadPriority priority, IEthernetLayer commInterface) {
			thread = ThreadHelper.StartNewThread("Robot Sender", true, RobotLoop, priority);
			Volatile.Write<IEthernetLayer>(ref ether, commInterface);
		}

		public bool Connect() {
			return ether.Connect();
		}

		public void Disconnect() {
			ether.Disconnect();
		}

		public void StopAsync() {
			running = false;
		}

		public void Stop() {
			StopAsync();
			thread.Join();
		}


		private bool SendMessage(int id, byte[] msg) {
			byte[] bytes = new byte[msg.Length + 1];
			bytes[0] = (byte)id;
			Array.Copy(msg, 0, bytes, 1, msg.Length); //TODO ugh, memcopy
			UdpPacket packet = new UdpPacket(Command.UpdateDevice, bytes);
			int len = packet.AllBytes.Length; //TODO make a simple length function
			while (true) {
				lock (this) {
					if ((BufferSize - BytesSent) >= len) {
						BytesSent += len;
						updateSize[id] = len;
						break;
					}
				}
				Thread.Sleep(1);
			}

			if (ether?.Send(packet) ?? false) return true;
			else {
				lock (this) {
					BytesSent -= len;
				}
				return false;
			}
		} 
		
		private void CheckForTimeout(int id) {
			lock (devices[id]) {
				if (messageReceived[id]) {
					updateTimers[id].Reset();
					return;
				}
			}

			if (updateTimers[id].ElapsedMilliseconds >= MessageTimemout) {
				/*if (updateAttempts[id] == TimeoutAttempts) {
					Console.Error.WriteLine("Timeout!!!");
					//throw new NotImplementedException(); //TODO timeout occured, disconnect.
					updateAttempts[id] = 0;
				} else {*/
				//lock (this) {
				//	BytesSent -= updateSize[id]; //Just in case the update packets are different sizes.
				//if (updateBytes[id] == null) return;
				//BytesSent -= updateBytes[id].Length + 1;
				//}
				//SendUpdateRequest(id, updateBytes[id]);
				//updateAttempts[id] = 0;//++;
				//updateTimers[id].Restart();
				//}
				int n;
				lock (this) {
					//BytesSent -= updateSize[id];
					n = ++numTimeouts;
					if(numTimeouts >= TimeoutAttempts) {
						//TODO maybe trigger an event
						StopAsync();
						Console.Error.WriteLine("Robot Timeout!!");
					}
					BytesSent -= updateSize[id];
				}
				if (SendMessage(id, devices[id].ResendUpdate)) {
					updateTimers[id].Restart();
				}
				Console.Error.WriteLine("Message timeout! #{0}", n);
			}
		}
		/*
		private bool SendUpdateRequest(int id, byte[] updateBytes) {
			//Get the required bytes to send an update
			//byte[] updateBytes = devices[id].SendUpdate;
			byte[] bytes = new byte[updateBytes.Length + 1];
			bytes[0] = (byte)id;
			updateBytes.CopyTo(bytes, 1);
			updateSize[id] = bytes.Length;

			//Wait until there is enough space in the receive buffer to send the packet
			while (true) {
				lock (this) {
					if ((BufferSize - BytesSent) >= bytes.Length) {
						BytesSent += bytes.Length;
						break;
					}
				}
				Thread.Sleep(1);
			}

			if(!ether.Send(Command.UpdateDevice, bytes)) {
				lock (this) {
					BytesSent -= bytes.Length;
				}
				return false;
			} else {
				return true;
			}
		}//TODO check refresh rate is > 0
		*/
		private void UpdateDevice(int id) {
			refreshTimers[id].Restart(); //Absolute timing. Keeps refresh rate as close to the requested rate as possible.
			byte[] update = devices[id].SendUpdate; //TODO check if messageReceived is true. if so, we have a problem
			if (update != null) {
				//UdpPacket packet = new UdpPacket(Command.UpdateDevice, update);
				//if (SendUpdateRequest(id, update)) {
				if (SendMessage(id, update)) { //TODO better way to pass the size around
					//updateSize[id] = update.Length + 4; //TODO make a simple length function
					updateTimers[id].Restart();
				}
			}
		}

		private void RobotLoop() {
			if(ether != null) ether.OnPacketReceived += Ether_OnPacketReceived;
			while (running) {
				for(int i = 0; i < MaxNumDevices; i++) {
					if(devices[i] != null) {
						if(updateTimers[i].IsRunning) {
							//Message was sent, check for a timeout
							CheckForTimeout(i);
						}else if(/*updateAttempts[i] == 0 &&*/refreshTimers[i].ElapsedMilliseconds > (1000 / devices[i].RefreshRate)) {
							//Sensor is due for an update, send the message
							UpdateDevice(i);
						}
					}
				}
			}
			if (ether != null) ether.OnPacketReceived -= Ether_OnPacketReceived;
			ether?.Disconnect();
		}

		private void PingReceived(ByteArray packet) {
			//TODO ping
			Console.WriteLine("Ping Received: {0}", packet[0]);
		}

		private void EchoReceived(ByteArray packet) {
			//TODO echo
			Console.WriteLine("Echo Received: Length = {0}", packet.Length);
		}
		//TODO add warning if a message was received over 50% of the timeout time.
		private void UpdateDeviceReceived(ByteArray packet) {
			if (packet.Length >= 1) {
				int id = packet[0];
				if (devices[id] != null) {
					lock (devices[id]) {
						if (devices[id].Update(++packet)) {
							//updateTimers[id].Reset();
							messageReceived[id] = true;

							lock (this) {
								BytesSent -= updateSize[id];
							}
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

		public long? Ping(int timeoutMS = 3000) {
			return ether.Ping(timeoutMS);
		}
	}
}

