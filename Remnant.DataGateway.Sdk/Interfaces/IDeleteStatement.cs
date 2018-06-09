using Remnant.DataGateway.Core;
using System.Collections.Generic;

namespace Remnant.DataGateway.Interfaces
{
	public interface IDeleteStatement : ISqlStatement
	{		
		List<ISelectColumn> Columns { get; }
	}
}
