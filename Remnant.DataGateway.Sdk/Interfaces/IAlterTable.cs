
namespace Remnant.DataGateway.Interfaces
{
	public interface IAlterTable<in TDataTypeEnum> : IExecute
		where TDataTypeEnum : struct
	{
		IAlterTable<TDataTypeEnum> Name(string tableName);

		IExecute Rename(string newTableName);


		IAlterTable<TDataTypeEnum> AddColumn(string columnName, TDataTypeEnum dataType, int? length = null, bool isNullable = false, object defaultValue = null);
		IAlterTable<TDataTypeEnum> DropColumn(string columnName);
		IAlterTable<TDataTypeEnum> AlterColumn(string columnName, TDataTypeEnum dataType, int? length = null, bool isNullable = false, object defaultValue = null);
		IAlterTable<TDataTypeEnum> RenameColumn(string columnName, string newColumnName);
	}
}
