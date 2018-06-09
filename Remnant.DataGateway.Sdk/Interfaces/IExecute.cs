using System;

namespace Remnant.DataGateway.Interfaces
{
	public interface IExecute
	{
		/// <summary>
		/// Execute statement
		/// </summary>
		/// <returns>Returns the amount of rows effected or primary key if insert statement was called</returns>
		string Execute();

		/// <summary>
		/// Execute statement asynchronously
		/// </summary>
		/// <param name="callBackOnCompletion">Optional, provide call back which will be called on async completion with the amount of rows effected</param>
		void ExecuteAsync(Action<int> callBackOnCompletion = null);
	}
}
