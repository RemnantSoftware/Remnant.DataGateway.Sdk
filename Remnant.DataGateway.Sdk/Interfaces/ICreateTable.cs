using System;
using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
	public interface ICreateTable<in TDataTypeEnum> : IExecute
		where TDataTypeEnum : struct
	{
		/// <summary>
		/// The name of the table
		/// </summary>
		/// <param name="tableName">The table name</param>
		/// <returns></returns>
		ICreateTable<TDataTypeEnum> Name(string tableName);

		/// <summary>
		/// Using a db enitity to construct table
		/// </summary>
		/// <typeparam name="TDbEntity">The generic db entity type</typeparam>
		/// <returns></returns>
		IExecute Using<TDbEntity>() where TDbEntity : IDbTableEntity;

		/// <summary>
		/// Using a db enitity to construct table
		/// </summary>
		/// <param name="entityType">The db entity type</param>
		/// <returns></returns>
		IExecute Using(Type entityType);

		/// <summary>
		/// Specify the primary key column for the table
		/// </summary>
		/// <param name="columnName">The name of the column</param>
		/// <param name="dataType">The data type of the column</param>
		/// <param name="autoSequence">Specify if primary is auto sequence (Defalt = true)</param>
		/// <returns></returns>
		ICreateTable<TDataTypeEnum> PrimaryKey(string columnName, TDataTypeEnum dataType, bool autoSequence = true);

		/// <summary>
		/// Specify a foreign key column
		/// </summary>
		/// <param name="columnName">The name of the column</param>
		/// <param name="dataType">The data type of the column</param>
		/// <param name="foreignTableName">The name of the foreign table</param>
		/// <param name="foreignColumnName">The name of the foreign column name</param>
		/// <returns></returns>
		ICreateTable<TDataTypeEnum> ForeignKey(string columnName, TDataTypeEnum dataType, string foreignTableName, string foreignColumnName = null);

		/// <summary>
		/// Specify a column for the table
		/// </summary>
		/// <param name="columnName">The name of the column</param>
		/// <param name="dataType">The data type of the column</param>
		/// <param name="length">Optional: The length of the data type for the column</param>
		/// <param name="precision">Optional: The precision to use for the data type</param>
		/// <param name="isNullable">Optional: Specify if column can contain nulls or not. Default is false</param>
		/// <param name="defaultValue">Optional: Specify the default value if none is supplied</param>
		/// <returns></returns>
		ICreateTable<TDataTypeEnum> Column(string columnName, TDataTypeEnum dataType, int? length = null, int? precision = null, bool isNullable = false, object defaultValue = null);
	}
}
