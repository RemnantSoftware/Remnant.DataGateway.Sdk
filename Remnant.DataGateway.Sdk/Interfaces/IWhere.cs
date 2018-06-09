
namespace Remnant.DataGateway.Interfaces
{
	public interface IWhere : IExecuteList, IExecuteScalar, IUnion
	{
		/// <summary>
		/// Specify column criteria for the statement
		/// </summary>
		/// <param name="column">The name of the column</param>
		/// <param name="operand">The operand</param>
		/// <param name="value">The value or bind parameter name</param>
		/// <param name="bind">Optional, if binding must be performed which is set as default</param>
		/// <param name="useValueAsColumn">Optional, Set to true if the value is a column name</param>
		/// <returns></returns>
		IWhere Criteria(string column, SqlOperand operand, object value, bool bind = true, bool useValueAsColumn = false);


		//todo: subselect IWhere Criteria(string column, SqlOperand operand, ISelectStatement subSelect);

		/// <summary>
		/// Add additional logical 'and' criteria
		/// </summary>
		IWhere And { get; }

		/// <summary>
		/// Add additional logical 'or' criteria
		/// </summary>
		IWhere Or { get; }

		/// <summary>
		/// Specify criteria if column is null
		/// </summary>
		/// <param name="column">The name of the column</param>
		/// <returns></returns>
		IWhere ColumnIsNull(string column);

		/// <summary>
		/// Specify criteria if column is not null
		/// </summary>
		/// <param name="column">The name of the column</param>
		/// <returns></returns>
		IWhere ColumnIsNotNull(string column);

		/// <summary>
		/// Specify group by for select statement
		/// </summary>
		IGroupBy GroupBy { get; }

		/// <summary>
		/// Specify order by for select statement
		/// </summary>
		IOrderBy OrderBy { get; }

		/// <summary>
		/// Specify free text criteria
		/// </summary>
		/// <param name="criteria"></param>
		/// <returns></returns>
		IWhere CustomCriteria(string criteria);

		//ISelect Select(SqlMultiOperand multiOperand);
	}
}
