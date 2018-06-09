
using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
  public interface ISelect
  {	
   	/// <summary>
   	/// Select column
   	/// </summary>
   	/// <param name="name">The name of the column</param>
   	/// <param name="alias">Optional, an alias name</param>
   	/// <returns></returns>
    ISelect Column(string name, string alias = null);

		/// <summary>
		/// Select column expression
		/// </summary>
		/// <param name="expression">The expression</param>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
		ISelect ColumnExpression(string expression, string alias = null);

		/// <summary>
		/// Select the count
		/// </summary>
		/// <param name="name">The column name or '*'</param>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
	  ISelect Count(string name, string alias = null);

		/// <summary>
		/// Select the maximum
		/// </summary>
		/// <param name="name">The name of the column</param>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
		ISelect Max(string name, string alias = null);

		/// <summary>
		/// Select minimum
		/// </summary>
		/// <param name="name">The name of the column</param>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
		ISelect Min(string name, string alias = null);

		/// <summary>
		/// Select average
		/// </summary>
		/// <param name="name">The name of the column</param>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
		ISelect Average(string name, string alias = null);

		/// <summary>
		/// Select sum
		/// </summary>
		/// <param name="name">The name of the column</param>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
		ISelect Sum(string name, string alias = null);

		/// <summary>
		///  Specify to return only distinct (different) value
		/// </summary>
		/// <returns></returns>
		ISelect Distinct { get; }

		/// <summary>
		/// Specify the number of records to return
		/// </summary>
		/// <param name="rowCount">The amount of rows that must be returned</param>
		/// <returns></returns>
		ISelect Top(int rowCount);

		/// <summary>
		/// Select the first top record from the result
		/// </summary>
		/// <returns></returns>
		ISelect First { get; }

		/// <summary>
		/// Select concatenated columns
		/// </summary>
		/// <param name="columns">A string array of column names</param>
		/// <param name="alias">An alias name</param>
		/// <param name="delimiter">Optional, specify a delimter between columns</param>
		/// <returns></returns>
		ISelect ConcatColumns(string[] columns,  string alias, string delimiter = null);

		/// <summary>
		/// Select all columns 
		/// </summary>
		/// <param name="tableName">Optional, specify table name to column selection</param>
		/// <returns></returns>
    ISelect AllColumns(string tableName = null);

	  /// <summary>
	  /// Select all columns 
	  /// </summary>
	  /// <param name="alias">An alias name</param>
	  /// <param name="ignoreColumns">Select all columns but filter out certain columns</param>
	  /// <returns></returns>
		ISelect AllColumns<TDbEntity>(string alias, params string[] ignoreColumns) where TDbEntity : IDbTableEntity;

		/// <summary>
		/// Select all columns using entity type
		/// </summary>
		/// <typeparam name="TDbEntity">The type of entity</typeparam>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
		ISelect AllColumns<TDbEntity>(string alias = null) where TDbEntity : IDbTableEntity;

		/// <summary>
		/// Specify which tables to select from
		/// </summary>
    IFrom From { get; }

		/// <summary>
		/// Select locking the selection for update
		/// </summary>
		ISelect ForUpdate { get; }
  }
}
