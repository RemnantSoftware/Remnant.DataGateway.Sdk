using System;

namespace Remnant.DataGateway.Attributes
{
	[AttributeUsageAttribute(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	public class RuntimeDbFieldAttribute : Attribute
	{
	}
}
