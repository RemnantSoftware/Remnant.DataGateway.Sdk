
using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
  public interface IUpdate
  {    
		/// <summary>
		/// Update table using entity type
		/// </summary>
		/// <typeparam name="TDbEntity">The entity type</typeparam>
		/// <returns></returns>
		IUpdateUsing Table<TDbEntity>() where TDbEntity : IDbTableEntity;

		/// <summary>
		/// Update table by specifying table name
		/// </summary>
		/// <param name="tableName">The name of the table</param>
		/// <returns></returns>
		IUpdateUsing Table(string tableName);

  }
}
