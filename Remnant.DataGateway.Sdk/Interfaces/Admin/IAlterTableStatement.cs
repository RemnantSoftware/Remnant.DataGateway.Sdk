using System.Collections.Generic;

namespace Remnant.DataGateway.Interfaces
{
	public interface IAlterTableStatement<TDataTypeEnum> : IAdminStatement<TDataTypeEnum>
		where TDataTypeEnum : struct 
	{
		string TableName { get; }
		string RenameTo { get; }
		List<ITableColumn<TDataTypeEnum>> AddColumns { get; }
		List<ITableColumn<TDataTypeEnum>> DropColumns { get; }
		Dictionary<string, string> RenameColumns { get; }
	}
}
