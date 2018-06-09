
using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
  public interface IDelete
  {    
		/// <summary>
		/// Delete from a table using entity
		/// </summary>
		/// <typeparam name="TDbEntity">The entity type that represents a table</typeparam>
		/// <returns></returns>
		IDeleteUsing Table<TDbEntity>() where TDbEntity : IDbTableEntity;

		/// <summary>
		/// Delete from a table specifying the table name
		/// </summary>
		/// <param name="tableName">The name of the table</param>
		/// <returns></returns>
		IDeleteUsing Table(string tableName);
  }
}
