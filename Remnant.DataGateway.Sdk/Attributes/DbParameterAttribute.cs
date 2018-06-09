using System;
using System.Data;

namespace Remnant.DataGateway.Attributes
{
	[AttributeUsageAttribute(AttributeTargets.Property)]
	public class DbParameterAttribute : DbAttribute
	{
		public const int Size32K = 32768;

		public DbParameterAttribute()
		{
			Direction = ParameterDirection.Input;
		}

		/// <summary>
		/// Direction of the parameter, default is set as input
		/// </summary>
		public ParameterDirection Direction { get; set; }

		/// <summary>
		/// Should be set for output parameters, explicitly when using oracle
		/// </summary>
		public int Size { get; set; }
	}
}
