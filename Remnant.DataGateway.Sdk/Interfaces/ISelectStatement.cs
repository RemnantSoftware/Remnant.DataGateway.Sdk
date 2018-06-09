using Remnant.DataGateway.Core;
using System.Collections.Generic;

namespace Remnant.DataGateway.Interfaces
{
	public interface ISelectStatement : ISqlStatement
	{
		List<ISqlExpression> Expressions { get; }
		List<ISelectColumn> Columns { get; }
		List<IJoinTable> Joins { get; }
		List<IOrderByColumn> OrderBy { get; }
		List<ISelectColumn> GroupBy { get; }
		List<ICriteria> Having { get; }
		ISql InnerSql { get; }
		bool ForUpdate { get; }
	}
}
