
namespace Remnant.DataGateway.Interfaces
{
  public interface IGroupBy : IExecuteList, IExecuteScalar
  {
		/// <summary>
		/// Specify the colum to group by
		/// </summary>
		/// <param name="columnName">The name of the column or an expression</param>
		/// <param name="expression">Optional, set to true if using an expression</param>
		/// <returns></returns>
    IGroupBy Column(string columnName, bool expression = false);

		/// <summary>
		/// Specifies that the statement should only return rows where aggregate values meet the specified conditions
		/// Note: 
		/// </summary>
		IHaving Having { get; }

		/// <summary>
		/// Specify order by for select statement
		/// </summary>
    IOrderBy OrderBy { get; }

	  /// <summary>
	  /// Creates a new Sql select statement
	  /// </summary>
	  ISelect Select();
  }
}
