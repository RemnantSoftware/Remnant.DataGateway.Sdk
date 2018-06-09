using System;

namespace Remnant.DataGateway.Attributes
{	
	[AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
	public class DbAttribute : Attribute
	{
		public DbAttribute()
		{
		}

		public DbAttribute(string name)
		{
			Name = null;
		}

		/// <summary>
		/// Optional, if not set the property name is used
		/// </summary>
		public string Name { get; set; }

	}
}
