
namespace Remnant.DataGateway.Interfaces
{
  public interface IJoinTables
  {
		/// <summary>
		/// Left join by specifying the table name
		/// </summary>
		/// <param name="tableName">The name of the table</param>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
		IJoin LeftJoin(string tableName, string alias = null);

		/// <summary>
		/// Right join by specifying the table name
		/// </summary>
		/// <param name="tableName">The name of the table</param>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
		IJoin RightJoin(string tableName, string alias = null);

		/// <summary>
		/// Inner join by specifying the table name
		/// </summary>
		/// <param name="tableName">The name of the table</param>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
		IJoin InnerJoin(string tableName, string alias = null);

		/// <summary>
		/// Left Outer join by specifying the table name
		/// </summary>
		/// <param name="tableName">The name of the table</param>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
		IJoin LeftOuterJoin(string tableName, string alias = null);

		/// <summary>
		/// Right Outer join by specifying the table name
		/// </summary>
		/// <param name="tableName">The name of the table</param>
		/// <param name="alias">Optional, an alias name</param>
		/// <returns></returns>
		IJoin RightOuterJoin(string tableName, string alias = null);
  }
}
