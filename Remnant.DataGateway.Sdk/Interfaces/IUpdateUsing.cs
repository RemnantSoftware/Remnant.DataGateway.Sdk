
using System;
using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
  public interface IUpdateUsing
  {
	  /// <summary>
	  /// Specify column and values for update statement
	  /// </summary>
	  IUpdateColumns Using();

		/// <summary>
		/// Specify entity instance for update statement
		/// </summary>
		/// <typeparam name="TDbEntity">The type of entity</typeparam>
		/// <param name="entity">The entity instance</param>
		/// <returns></returns>
		IUpdateWhere Using<TDbEntity>(TDbEntity entity) where TDbEntity : IDbTableEntity;	
  }
}
