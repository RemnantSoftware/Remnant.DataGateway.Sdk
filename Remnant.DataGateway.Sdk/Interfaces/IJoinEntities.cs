using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
  public interface IJoinEntities :  IExecuteList, IExecuteScalar
	{
		/// <summary>
		/// Specify criteria for the select statement
		/// </summary>
		IWhere Where { get; }

		#region Auto Join On

		/// <summary>
		/// Left join on table using entity types
		/// </summary>
		/// <typeparam name="TPrimaryEntity">Join from primary entity type (using db key)</typeparam>
		/// <typeparam name="TForeignEntity">Join to foreign entity type (a property must match the primary)</typeparam>
		/// <param name="alias">Optional, an alias name for the join to entity</param>
		/// <returns></returns>
		IJoinEntities LeftJoin<TPrimaryEntity, TForeignEntity>(string alias = null)
			where TPrimaryEntity : IDbTableEntity
			where TForeignEntity : IDbTableEntity;		

		/// <summary>
		/// Right join on table using entity types
		/// </summary>
		/// <typeparam name="TPrimaryEntity">Join from primary entity type (using db key)</typeparam>
		/// <typeparam name="TForeignEntity">Join to foreign entity type (a property must match the primary)</typeparam>
		/// <param name="alias">Optional, an alias name for the join to entity</param>
		/// <returns></returns>
		IJoinEntities RightJoin<TPrimaryEntity, TForeignEntity>(string alias = null)
			where TPrimaryEntity : IDbTableEntity
			where TForeignEntity : IDbTableEntity;


		/// <summary>
		/// Inner join on table using entity types
		/// </summary>
		/// <typeparam name="TPrimaryEntity">Join from primary entity type (using db key)</typeparam>
		/// <typeparam name="TForeignEntity">Join to foreign entity type (a property must match the primary)</typeparam>
		/// <param name="alias">Optional, an alias name for the join to entity</param>
		/// <returns></returns>
		IJoinEntities InnerJoin<TPrimaryEntity, TForeignEntity>(string alias = null)
			where TPrimaryEntity : IDbTableEntity
      where TForeignEntity : IDbTableEntity;

		/// <summary>
		/// Left Outer join on table using entity types
		/// </summary>
		/// <typeparam name="TPrimaryEntity">Join from primary entity type (using db key)</typeparam>
		/// <typeparam name="TForeignEntity">Join to foreign entity type (a property must match the primary)</typeparam>
		/// <param name="alias">Optional, an alias name for the join to entity</param>
		/// <returns></returns>
		IJoinEntities LeftOuterJoin<TPrimaryEntity, TForeignEntity>(string alias = null)
			where TPrimaryEntity : IDbTableEntity
      where TForeignEntity : IDbTableEntity;

		/// <summary>
		/// Right Outer join on table using entity types
		/// </summary>
		/// <typeparam name="TPrimaryEntity">Join from primary entity type (using db key)</typeparam>
		/// <typeparam name="TForeignEntity">Join to foreign entity type (a property must match the primary)</typeparam>
		/// <param name="alias">Optional, an alias name for the join to entity</param>
		/// <returns></returns>
		IJoinEntities RightOuterJoin<TPrimaryEntity, TForeignEntity>(string alias = null)
			where TPrimaryEntity : IDbTableEntity
      where TForeignEntity : IDbTableEntity;	

		#endregion

		#region Manual Join on

		/// <summary>
		/// Left join on table using entity types
		/// </summary>
		/// <typeparam name="TToEntity">Join to entity type</typeparam>
		/// <param name="alias">Optional, an alias name for the join to entity</param>
		/// <returns></returns>
		IJoin LeftJoin<TToEntity>(string alias = null)
			where TToEntity : IDbTableEntity;

		/// <summary>
		/// Right join on table using entity types
		/// </summary>
		/// <typeparam name="TToEntity">Join to entity type</typeparam>
		/// <param name="alias">Optional, an alias name for the join to entity</param>
		/// <returns></returns>
		IJoin RightJoin<TToEntity>(string alias = null)
			where TToEntity : IDbTableEntity;

		/// <summary>
		/// Inner join on table using entity types
		/// </summary>
		/// <typeparam name="TToEntity">Join to entity type</typeparam>
		/// <param name="alias">Optional, an alias name for the join to entity</param>
		/// <returns></returns>
		IJoin InnerJoin<TToEntity>(string alias = null)
			where TToEntity : IDbTableEntity;

		/// <summary>
		/// Left Outer join on table using entity types
		/// </summary>
		/// <typeparam name="TToEntity">Join to entity type</typeparam>
		/// <param name="alias">Optional, an alias name for the join to entity</param>
		/// <returns></returns>
		IJoin LeftOuterJoin<TToEntity>(string alias = null)
			where TToEntity : IDbTableEntity;

		/// <summary>
		/// Right Outer join on table using entity types
		/// </summary>
		/// <typeparam name="TToEntity">Join to entity type</typeparam>
		/// <param name="alias">Optional, an alias name for the join to entity</param>
		/// <returns></returns>
		IJoin RightOuterJoin<TToEntity>(string alias = null)
			where TToEntity : IDbTableEntity;

		#endregion

	}
}
