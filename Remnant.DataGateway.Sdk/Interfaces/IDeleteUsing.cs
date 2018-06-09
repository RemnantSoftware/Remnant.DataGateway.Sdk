
using System;
using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
  public interface IDeleteUsing
  {
		/// <summary>
		/// Specify criteria for delete statement
		/// </summary>
		IUpdateDeleteWhere Where { get; }

		/// <summary>
		/// Specify an entity instance for deletion.
		/// Noet that the property marked as DbKey must be set
		/// </summary>
		/// <typeparam name="TDbEntity">The type of entity</typeparam>
		/// <param name="entity">The entity instance</param>
		/// <returns></returns>
		IDeleteWhere Using<TDbEntity>(TDbEntity entity) where TDbEntity : IDbTableEntity;

		/// <summary>
		/// Execute delete statement
		/// </summary>
		/// <returns>Returns the amount of rows effected</returns>
	  int Execute();

		/// <summary>
		/// Execute delete statement asynchronously
		/// </summary>
		/// <param name="callBackOnCompletion">Optional, provide call back which will be called on async completion with the amount of rows effected</param>
		void ExecuteAsync(Action<int> callBackOnCompletion = null);
  }
}
