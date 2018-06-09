using System;
using System.Reflection;

namespace Remnant.DataGateway.Attributes
{
	public class Decoration<TAttribute>
		where TAttribute : Attribute
	{
		public PropertyInfo Property { get; set; }
		public TAttribute Attribute { get; set; }
	}
}
