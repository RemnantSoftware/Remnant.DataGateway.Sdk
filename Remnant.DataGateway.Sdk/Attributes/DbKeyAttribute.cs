using System;

namespace Remnant.DataGateway.Attributes
{
	[AttributeUsage(AttributeTargets.Property)]
	public class DbKeyAttribute : DbAttribute
	{
		public DbKeyAttribute()
		{
		}

		public DbKeyAttribute(string name) : base(name)
		{
		}

		public string AutoSequence { get; set; }
	}
}
