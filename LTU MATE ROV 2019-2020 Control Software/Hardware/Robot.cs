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

		public delegate void GenericEvent();
		public event GenericEvent IdCollisionDetected; //TODO make use of event
		public event GenericEvent RobotStarted;
		public event GenericEvent RobotStopped;
		public event GenericEvent TimeoutWarning; //Called when a message is received at greater than 50% of the timeout time.
		public event GenericEvent RobotTimeout;

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

		public bool IsSimulator => ether.IsSimulator;

		private IEthernetLayer ether;
		private Thread thread;
		private volatile int BytesSent = 0;

		/// <summary>
		/// Devices
		/// </summary>
		private IRegister[] registers = new IRegister[MaxNumDevices];

		/// <summary>
		/// Timer that activates at the refresh rate of the sensor
		/// </summary>
		private Stopwatch[] refreshTimers = new Stopwatch[MaxNumDevices];

		/// <summary>
		/// Timer that checks for timeouts
		/// </summary>
		private Stopwatch[] timeoutTimers = new Stopwatch[MaxNumDevices];

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
			foreach(IRegister register in device) {
				if (registers[register.Id] != null) {
					IdCollisionDetected?.Invoke();
				} else {
					//updateAttempts[device.Id] = 0;
					timeoutTimers[register.Id] = new Stopwatch();
					refreshTimers[register.Id] = new Stopwatch();
					refreshTimers[register.Id].Start();
					registers[register.Id] = register;
				}
			}
		}

		protected Robot(ThreadPriority priority, IEthernetLayer commInterface) {
			thread = ThreadHelper.StartNewThread("Robot Sender", true, RobotLoop, priority);
			Volatile.Write<IEthernetLayer>(ref ether, commInterface);
		}

		public bool Connect() {
			return ether?.Connect() ?? false;
		}

		public void Disconnect() {
			ether?.Disconnect();
		}

		public void StopAsync() {
			running = false;
		}

		public void Stop() {
			StopAsync();
			thread.Join();
		}

		private bool SendMessage(int id, byte[] msg) {
			//byte[] bytes = new byte[msg.Length + 1];
			//bytes[0] = (byte)id;
			//Array.Copy(msg, 0, bytes, 1, msg.Length); //TODO ugh, memcopy
			UdpPacket packet = new UdpPacket((byte)id, msg);
			int len = packet.Length;
			//while (true) {
			lock (this) {
				if ((BufferSize - BytesSent) >= len) {
					BytesSent += len;
					updateSize[id] = len;
					//break;
				} else {
					return false;
				}
			}
				//Thread.Sleep(1); //TODO this doesn't work. Need a better solution to waiting. 
			//}

			if (ether?.Send(packet) ?? false) return true;
			else {
				lock (this) {
					BytesSent -= len;
				}
				return false;
			}
		} 
		
		private void CheckForTimeout(int id) {
			lock (registers[id]) {
				if (messageReceived[id]) {
					timeoutTimers[id].Reset();
					return;
				}
			}

			if (timeoutTimers[id].ElapsedMilliseconds >= MessageTimemout) {
				int n;
				lock (this) {
					//BytesSent -= updateSize[id];
					n = ++numTimeouts;
					if(numTimeouts >= TimeoutAttempts) {
						StopAsync();
						Console.Error.WriteLine("Robot Timeout!!");
					}
					BytesSent -= updateSize[id];
				}
				if (SendMessage(id, registers[id].ResendUpdate)) {
					timeoutTimers[id].Restart();
				}
				RobotTimeout?.Invoke();
				Console.Error.WriteLine("Message timeout! #{0}", n);
			}
		}
		
		private void UpdateDevice(int id) {
			refreshTimers[id].Restart(); //Absolute timing. Keeps refresh rate as close to the requested rate as possible.
			byte[] update = registers[id].SendUpdate; 
			if (update != null) {
				//UdpPacket packet = new UdpPacket(Command.UpdateDevice, update);
				//if (SendUpdateRequest(id, update)) {
				if (SendMessage(id, update)) {
					//updateSize[id] = update.Length + 4; 
					timeoutTimers[id].Restart();
				}
			}
		}

		private void RobotLoop() {
			RobotStarted?.Invoke();
			if(ether != null) ether.OnPacketReceived += Ether_OnPacketReceived;
			while (running) {
				for(int i = 0; i < MaxNumDevices; i++) {
					if(registers[i] != null) {
						if(timeoutTimers[i].IsRunning) {
							//Message was sent, check for a timeout
							CheckForTimeout(i);
						}else if(/*updateAttempts[i] == 0 &&*/refreshTimers[i].ElapsedMilliseconds > (1000 / registers[i].RefreshRate)) {
							//Sensor is due for an update, send the message
							UpdateDevice(i);
						}
					}
				}
			}
			if (ether != null) ether.OnPacketReceived -= Ether_OnPacketReceived;
			ether?.Disconnect();
			RobotStopped?.Invoke();
		}

		//NOTE: OnReceived may be invoked on a secondary thread.
		private void Ether_OnPacketReceived(UdpPacket packet) {
			int id = packet.Id;//packet[0];
			if (registers[id] != null) {
				bool timeoutWarning = false;
				lock (registers[id]) {
					if (registers[id].Update(packet.Data/* + 1*/)) {
						//updateTimers[id].Reset();
						messageReceived[id] = true;

						lock (this) {
							BytesSent -= updateSize[id];
						}

						if (timeoutTimers[id].ElapsedMilliseconds > (MessageTimemout / 2)) {
							timeoutWarning = true;
						}
					}
				}
				if(timeoutWarning) TimeoutWarning?.Invoke();
			}
		}

		public long? Ping(int timeoutMS = 3000) {
			return ether.Ping(timeoutMS);
		}

	}
}

