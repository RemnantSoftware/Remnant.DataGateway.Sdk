
using System;
using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
  public interface IInsertUsing
  {
		/// <summary>
		/// ORACLE specific, specify the primary key column if you defined the table name as a literal string
		/// Note: Since you are not using an entity the DataGateway has no idea what the pk column is to return the key
		/// <param name="primaryKeyColumnName">ORACLE specific, specify the primary key column name</param>
		/// </summary>
		IInsertValues Using(string primaryKeyColumnName);
		
	  /// <summary>
	  /// Specify column and values for insert statement
	  /// </summary>
	  IInsertValues Using();

		/// <summary>
		/// Specify entity instance for insert statement
		/// </summary>
		/// <typeparam name="TDbEntity">The type of entity</typeparam>
		/// <param name="entity">The entity instance</param>
		/// <returns></returns>
		IExecute Using<TDbEntity>(TDbEntity entity) where TDbEntity : IDbTableEntity;	
  }
}
