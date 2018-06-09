using Remnant.DataGateway.Core;
using System.Collections.Generic;

namespace Remnant.DataGateway.Interfaces
{
	public interface IInsertStatement : ISqlStatement
	{
		List<IUpdInsColumn> Columns { get; }
    string AutoSequence { get; set; }
	}
}
