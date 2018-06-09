using System;

namespace Remnant.DataGateway.Attributes
{
	[AttributeUsageAttribute(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
	public class DbNameAttribute : DbAttribute
	{
		public DbNameAttribute()
		{
		}

		public DbNameAttribute(string name) : base(name)
		{
		}
	}
}
