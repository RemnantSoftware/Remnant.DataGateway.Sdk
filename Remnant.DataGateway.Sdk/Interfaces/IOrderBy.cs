
namespace Remnant.DataGateway.Interfaces
{
  public interface IOrderBy : IExecuteList, IExecuteScalar
  {
		/// <summary>
		/// Specify the order by column
		/// </summary>
		/// <param name="columnName">The name of the column or expression</param>
		/// <param name="orderBy">Optional, acsending (default) or descending</param>
		/// <param name="expression">Optional, set true if expression is used</param>
		/// <returns></returns>
    IOrderBy Column(string columnName, SqlOrderBy orderBy = SqlOrderBy.Acsending, bool expression = false);

	  /// <summary>
	  /// Creates a new Sql select statement
	  /// </summary>
	  ISelect Select();
  }
}
