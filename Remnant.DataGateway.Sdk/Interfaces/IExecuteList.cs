using System;
using System.Collections.Generic;
using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
	public interface IExecuteList
	{
		/// <summary>
		/// Execute the select statement to return a list of results
		/// </summary>
		/// <typeparam name="TResult">The type that will contain the result</typeparam>
		/// <returns>Returns a list of result instances or empty list</returns>
		List<TResult> Execute<TResult>() where TResult : IDbTableEntity, new();

		/// <summary>
		/// Execute the select statement to return a list of results (not strongly typed)
		/// </summary>
		/// <param name="resultType">The type that will contain the result</param>
		/// <returns>Returns a list of result instances or empty list</returns>
		//List<object> Execute(Type resultType);

		/// <summary>
		/// Execute the select statement asynchronously to return a list of results
		/// </summary>
		/// <typeparam name="TResult">The type that will contain the result</typeparam>
		/// <param name="callBackOnCompletion">Optional, provide a call back which will be called on async completion with a list of results or empty list</param>
		void ExecuteAsync<TResult>(Action<List<TResult>> callBackOnCompletion = null) where TResult : IDbTableEntity, new();
	}
}
