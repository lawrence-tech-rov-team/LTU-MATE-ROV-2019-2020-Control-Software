using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLogger {
	public enum LogLevel {
		
		/// <summary>
		/// Nothing is logged. No messages should be logged to this level.
		/// </summary>
		None,

		/// <summary>
		/// Only the ost extreme of errors should be considered fatal.
		/// If a fatal message is logged, that means the program is about to
		/// crash because it can not continue with the exception that was thrown.
		/// </summary>
		Fatal,

		/// <summary>
		/// Used for errors occur that don't cause the program to fail. This could be anything from
		/// not having access to a file, losing connection, or maybe just a bad programming but
		/// the exception was caught.
		/// </summary>
		Error,

		/// <summary>
		/// Marks unusual behavior in a program, such as parts of code that *should* be unreachable, but
		/// was somehow reached. These aren't actually errors and don't harm the program at all, but repeated
		/// warnings should definitely be looked in to.
		/// </summary>
		Warn,

		/// <summary>
		/// Normal program operation messages. This can include things like made connections, disconnections,
		/// spawned threads, or just general information about the progress of the system. These should be the
		/// most generic messages possible.
		/// </summary>
		Info,

		/// <summary>
		/// Extra information that can be used to help debug systems later, like periodical parsed (sensor) data from the robot,
		/// input controls, mostly just data that may be helpful if a problem arises.
		/// </summary>
		Debug,

		/// <summary>
		/// Every message imaginable. Raw packet data sent/received, raw controller values,
		/// bytes sent over ethernet, everything. Logging this will probably overload the computer
		/// to the point will the program will be noticably slower, but hey, you will have all the
		/// debugging information you will need!
		/// </summary>
		All

	}
}
