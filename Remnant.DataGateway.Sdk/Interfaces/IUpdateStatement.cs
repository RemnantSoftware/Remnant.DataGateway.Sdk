using Remnant.DataGateway.Core;
using System.Collections.Generic;

namespace Remnant.DataGateway.Interfaces
{
	public interface IUpdateStatement : ISqlStatement
	{
		List<IUpdInsColumn> Columns { get; }
	}
}
