

namespace Remnant.DataGateway.Interfaces
{
  public interface IUpdateDeleteWhere : IExecute
  {
		/// <summary>
		/// Specify column criteria for the statement
		/// </summary>
		/// <param name="column">The name of the column</param>
		/// <param name="operand">The operand</param>
		/// <param name="value">The value or bind parameter name</param>
		/// <param name="bind">Optional, if binding must be performed which is set as default</param>
		/// <returns></returns>
		IUpdateDeleteWhere Criteria(string column, SqlOperand operand, object value, bool bind = true);

		/// <summary>
		/// Add additional logical 'and' criteria
		/// </summary>
		IUpdateDeleteWhere And { get; }

		/// <summary>
		/// Add additional logical 'or' criteria
		/// </summary>
		IUpdateDeleteWhere Or { get; }

		/// <summary>
		/// Specify criteria if column is null
		/// </summary>
		/// <param name="column">The name of the column</param>
		/// <returns></returns>
		IUpdateDeleteWhere ColumnIsNull(string column);

		/// <summary>
		/// Specify criteria if column is not null
		/// </summary>
		/// <param name="column">The name of the column</param>
		/// <returns></returns>
		IUpdateDeleteWhere ColumnIsNotNull(string column);
		
  }
}
