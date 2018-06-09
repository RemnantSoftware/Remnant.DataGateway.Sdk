using System;

namespace Remnant.DataGateway.Attributes
{
	[AttributeUsageAttribute(AttributeTargets.Property)]
	public class DbFieldAttribute : DbAttribute
	{

		public DbFieldAttribute()
		{
		}

		public DbFieldAttribute(string name) : base(name)
		{
		}
	}
}
