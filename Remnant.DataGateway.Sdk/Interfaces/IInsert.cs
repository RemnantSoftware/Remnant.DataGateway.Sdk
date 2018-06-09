
using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
  public interface IInsert
  {	
		/// <summary>
		/// Insert into by using entity type that represents a table
		/// </summary>
		/// <typeparam name="TDbEntity">The entity type</typeparam>
		/// <returns></returns>
		IInsertUsing Table<TDbEntity>() where TDbEntity : IDbTableEntity;

		/// <summary>
		/// Insert into table by specifying table name
		/// </summary>
		/// <param name="tableName">The name of the table</param>
		/// <returns></returns>
		IInsertUsing Table(string tableName);
  }
}
