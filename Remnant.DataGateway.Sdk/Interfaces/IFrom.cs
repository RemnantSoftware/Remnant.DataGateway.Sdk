
using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
  public interface IFrom
  {
		/// <summary>
		/// Select from table using entity type
		/// </summary>
		/// <typeparam name="TDbEntity">The type of entity</typeparam>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
		IFromTable Table<TDbEntity>(string alias = null) where TDbEntity : IDbTableEntity;

		/// <summary>
		/// Select from table specifying table name
		/// </summary>
		/// <param name="name">The name of the table</param>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
	  IFromTable Table(string name, string alias = null);

		/// <summary>
		/// Specify criteria for select statement
		/// </summary>
    IWhere Where { get; }
  }
}
