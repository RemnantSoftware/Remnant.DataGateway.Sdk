using System.Collections.Generic;
using Remnant.DataGateway.Core;
using System.Data;
using System;

namespace Remnant.DataGateway.Interfaces
{
	public interface ISql : IExecute, IExecuteList, IExecuteScalar
	{
		List<IDbStatement> Statements { get; }
		IDbContext Context { get; }
		DbStatementType Type { get; }
		List<IBindParameter> BindParameters { get; }
    ISql DefineBindParameter(IBindParameter bindParameter);
    ISql DefineBindParameter(string name, object value, ParameterDirection direction = ParameterDirection.Input, Type dataType = null, int? size = null);
    ISelect Select();
		IUpdate Update();
		IDelete Delete();
		IInsert Insert();
    IDbManager DbManager { get; }
	}
}
