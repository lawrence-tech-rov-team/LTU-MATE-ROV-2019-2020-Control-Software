using LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware.Ethernet;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LTU_MATE_ROV_2019_2020_Control_Software.Robot.Hardware {
	public abstract class Robot : ThreadedProcess {

		public delegate void IdCollisionEvent(byte IdConflict);
		public event IdCollisionEvent OnIdCollisionDetected; //TODO make use of event

		public delegate void RobotEvent(Robot sender);
		public event RobotEvent OnConnected;

		public delegate void GenericEvent();
		public event GenericEvent OnConnectFailed;
		public event GenericEvent OnDisconnected;
		public event GenericEvent OnTimeoutWarning; //Called when a message is received at greater than 50% of the timeout time.
		public event GenericEvent OnTimeout;

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
		private volatile int BytesSent = 0;

		/// <summary>
		/// Devices
		/// </summary>
		private readonly IRegister[] registers = new IRegister[MaxNumDevices];

		/// <summary>
		/// Timer that activates at the refresh rate of the sensor
		/// </summary>
		private readonly Stopwatch[] refreshTimers = new Stopwatch[MaxNumDevices];

		/// <summary>
		/// Timer that checks for timeouts
		/// </summary>
		private readonly Stopwatch[] timeoutTimers = new Stopwatch[MaxNumDevices];

		private readonly bool[] messageReceived = new bool[MaxNumDevices];

		/// <summary>
		/// The size of the message that was sent
		/// </summary>
		private readonly int[] updateSize = new int[MaxNumDevices];

		/// <summary>
		/// Number of timeouts that have occured in a row.
		/// </summary>
		private volatile int numTimeouts = 0;

		protected void RegisterDevice(IDevice device) {
			foreach(IRegister register in device) {
				if (registers[register.Id] != null) {
					OnIdCollisionDetected?.Invoke(register.Id);
				} else {
					//updateAttempts[device.Id] = 0;
					timeoutTimers[register.Id] = new Stopwatch();
					refreshTimers[register.Id] = new Stopwatch();
					refreshTimers[register.Id].Start();
					registers[register.Id] = register;
				}
			}
		}

		protected Robot(IEthernetLayer commInterface) : base("Robot Thread") {
			Volatile.Write<IEthernetLayer>(ref ether, commInterface);
		}

		private bool SendMessage(int id, byte[] msg) {
			UdpPacket packet = new UdpPacket((byte)id, msg);
			int len = packet.Length;
			lock (this) {
				if ((BufferSize - BytesSent) >= len) {
					BytesSent += len;
					updateSize[id] = len;
				} else {
					return false;
				}
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
				OnTimeout?.Invoke();
				Console.Error.WriteLine("Message timeout! #{0}", n);
			}
		}
		
		private void UpdateDevice(int id) {
			refreshTimers[id].Restart(); //Absolute timing. Keeps refresh rate as close to the requested rate as possible.
			byte[] update = registers[id].SendUpdate; 
			if (update != null) {
				if (SendMessage(id, update)) {
					timeoutTimers[id].Restart();
				}
			}
		}

		protected override void Initialize() {
			if (ether?.Connect() ?? false) {
				OnConnected?.Invoke(this);
				ether.OnPacketReceived += Ether_OnPacketReceived;
			} else OnConnectFailed?.Invoke();
		}

		protected override bool Loop() {
			if (!(ether?.Connected ?? false)) return false;
			for (int i = 0; i < MaxNumDevices; i++) {
				if (registers[i] != null) {
					if (timeoutTimers[i].IsRunning) {
						//Message was sent, check for a timeout
						CheckForTimeout(i);
					} else if (/*updateAttempts[i] == 0 &&*/refreshTimers[i].ElapsedMilliseconds > (1000 / registers[i].RefreshRate)) {
						//Sensor is due for an update, send the message
						UpdateDevice(i);
					}
				}
			}
			return Sleep(1);
		}

		protected override void Cleanup() {
			if(ether != null) {
				ether.Disconnect();
				ether.OnPacketReceived -= Ether_OnPacketReceived;
			}
			OnDisconnected?.Invoke();
		}

		//NOTE: OnReceived may be invoked on a secondary thread.
		private void Ether_OnPacketReceived(UdpPacket packet) {
			int id = packet.Id;
			if (registers[id] != null) {
				bool timeoutWarning = false;
				lock (registers[id]) {
					if (registers[id].Update(packet.Data)) {
						messageReceived[id] = true;

						lock (this) {
							BytesSent -= updateSize[id];
						}

						if (timeoutTimers[id].ElapsedMilliseconds > (MessageTimemout / 2)) {
							timeoutWarning = true;
						}
					}
				}
				if(timeoutWarning) OnTimeoutWarning?.Invoke();
			}
		}

		public long? Ping(int timeoutMS = 3000) {
			return ether.Ping(timeoutMS);
		}

	}
}

