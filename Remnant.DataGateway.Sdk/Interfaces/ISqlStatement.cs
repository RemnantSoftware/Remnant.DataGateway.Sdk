using Remnant.DataGateway.Core;
using System.Collections.Generic;

namespace Remnant.DataGateway.Interfaces
{
	public interface ISqlStatement : IDbStatement
	{
		List<IBindParameter> BindParameters { get; }	
		List<ITable> From { get; }
		List<ICriteria> WhereCriteria { get; }
		List<ITable> AllTables { get; }
	}
}
