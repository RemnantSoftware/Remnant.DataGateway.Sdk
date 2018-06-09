using System.Collections.Generic;

namespace Remnant.DataGateway.Interfaces
{
	public interface ICreateTableStatement<TDataTypeEnum> : IAdminStatement<TDataTypeEnum>
		where TDataTypeEnum : struct 
	{
		string TableName { get; }
		List<ITableColumn<TDataTypeEnum>> Columns { get; }
	}
}
