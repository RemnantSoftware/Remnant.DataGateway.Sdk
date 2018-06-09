
using System;
using System.Data;

namespace Remnant.DataGateway.Core
{
	public class DbLogEntry
	{
		/// <summary>
		/// The thread that made the call
		/// </summary>
		public int ThreadId { get; set; }

		/// <summary>
		/// The sql command with any bind parameters
		/// </summary>
		public IDbCommand Command { get; set; }

		/// <summary>
		/// The duration the call made in milliseconds
		/// Stopwatch must be set to true when enable logging to obtain duration
		/// </summary>
		public long Duration { get; set; }
		
	}
}
