using System;
using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
	public interface IExecuteScalar
	{
		/// <summary>
		/// Execute the select statement to return one result
		/// </summary>
		/// <typeparam name="TResult">The type that will contain the result</typeparam>
		/// <returns>Returns a result instance or null</returns>
		TResult ExecuteScalar<TResult>() where TResult : IDbTableEntity,  new();


		/// <summary>
		/// Execute the select statement asynchronously to return one result
		/// </summary>
		/// <typeparam name="TResult">The type that will contain the result</typeparam>
		/// <param name="callBackOnCompletion">Optional, provide a call back which will be called on async completion with a result or null</param>
		void ExecuteScalarAsync<TResult>(Action<TResult> callBackOnCompletion = null) where TResult : IDbTableEntity, new();
	}
}
