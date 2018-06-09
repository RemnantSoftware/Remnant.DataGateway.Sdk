
namespace Remnant.DataGateway.Interfaces
{
  public interface IJoin : IExecuteList, IExecuteScalar
  {
		/// <summary>
		/// Specify the join on clause
		/// </summary>
		/// <param name="fromColumn">Join from column name</param>
		/// <param name="operand">The operand</param>
		/// <param name="toColumn">Join to column name or bind parameter name (values are not allowed)</param>
		/// <returns></returns>
    IJoinOn On(string fromColumn, SqlOperand operand, string toColumn);

		/// <summary>
		/// Specify criteria for the select statement
		/// </summary>
    IWhere Where { get; }
  }
}
