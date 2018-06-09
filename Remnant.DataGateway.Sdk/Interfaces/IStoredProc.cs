using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
	public interface IStoredProc : IExecute, IExecuteList, IExecuteScalar
	{
		/// <summary>
		/// Specify the stored procedure name
		/// </summary>
		/// <param name="name">The name of the stored procedure</param>
		/// <returns></returns>
		IStoredProc Name(string name);

		/// <summary>
		/// Specify the store procedure name using entity type
		/// </summary>
		/// <typeparam name="TDbEntity">The type of entity</typeparam>
		/// <returns></returns>
		IStoredProc Name<TDbEntity>() where TDbEntity : IStoredProcedure;

		/// <summary>
		/// Specify the parameters for the stored procedure
		/// </summary>
		/// <returns></returns>
		IStoredProcParameters Using();

		/// <summary>
		/// Specify the parameters for the stored procedure using entity
		/// </summary>
		/// <typeparam name="TDbEntity">The type of entity</typeparam>
		/// <param name="entity">The entity instance</param>
		/// <returns></returns>
		IStoredProc Using<TDbEntity>(TDbEntity entity) where TDbEntity : IDbEntity;	
	}
}
