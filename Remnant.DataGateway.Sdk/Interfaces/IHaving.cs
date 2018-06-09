
namespace Remnant.DataGateway.Interfaces
{
  public interface IHaving : IExecuteList, IExecuteScalar
  {
		/// <summary>
		/// Specify column criteria for the statement
		/// </summary>
		/// <param name="column">The name of the column</param>
		/// <param name="operand">The operand</param>
		/// <param name="value">The value or bind parameter name</param>
		/// <param name="bind">Optional, if binding must be performed which is set as default</param>
		/// <returns></returns>
		IHaving Criteria(string column, SqlOperand operand, object value, bool bind = true);

		/// <summary>
		/// Add additional logical 'and' criteria
		/// </summary>
		IHaving And { get; }

		/// <summary>
		/// Add additional logical 'or' criteria
		/// </summary>
		IHaving Or { get; }

		/// <summary>
		/// Specify criteria if column is null
		/// </summary>
		/// <param name="column">The name of the column</param>
		/// <returns></returns>
		IHaving ColumnIsNull(string column);

		/// <summary>
		/// Specify criteria if column is not null
		/// </summary>
		/// <param name="column">The name of the column</param>
		/// <returns></returns>
		IHaving ColumnIsNotNull(string column);

		/// <summary>
		/// Specify order by for select statement
		/// </summary>
		IOrderBy OrderBy { get; }
	}
}
