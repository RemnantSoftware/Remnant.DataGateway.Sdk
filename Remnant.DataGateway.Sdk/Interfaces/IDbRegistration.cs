
using System;
using System.Data;

namespace Remnant.DataGateway.Interfaces
{
	public interface IDbRegistration
	{
		/// <summary>
		/// The database connection type. Ex: SqlConnection
		/// </summary>
		Type ConnectionType { get; set; }

		/// <summary>
		/// The database connection type as a string. Ex: System.Data.SqlClient.SqlConnection
		/// </summary>
		string SoftConnectionType { get; }

		/// <summary>
		/// The name to be used for the registration
		/// </summary>
		string Name { get; }

		/// <summary>
		/// The connection string for the database
		/// </summary>
		string ConnectionString { get;  }

		/// <summary>
		/// Get the database schema that is associated with the registration
		/// </summary>
		IDbSchema Schema { get; }

		/// <summary>
		/// Specifies the locking behaviour for the database
		/// </summary>
		IsolationLevel IsolationLevel { get; }

    IDbManager DbManager { get; set; }

	}
}
