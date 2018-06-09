
namespace Remnant.DataGateway.Interfaces
{
  public interface IFromTable : IJoinEntities, IJoinTables, IUnion
  {
		/// <summary>
		/// Specify criteria for the select statement
		/// </summary>
    new IWhere Where { get; }

		/// <summary>
		/// Specify group by for the select statement
		/// </summary>
    IGroupBy GroupBy { get; }

		/// <summary>
		/// Specify order by for the select statement
		/// </summary>
    IOrderBy OrderBy { get; }

	  /// <summary>
	  /// Creates a new Sql select statement
	  /// </summary>
	  ISelect Select();

  }
}
