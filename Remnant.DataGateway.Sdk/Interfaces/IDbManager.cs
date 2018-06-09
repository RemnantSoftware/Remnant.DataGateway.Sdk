using System;
using System.Data;
using Remnant.Core.Common;
using Remnant.DataGateway.Core;

namespace Remnant.DataGateway.Interfaces
{
  public interface IDbManager
  {
    void DeRegister(string dbName);
    void DeRegisterAll();
    void DisableLogging();
    void EnableLogging(Action<DbLogEntry> onBeforeSqlExecute, Action<DbLogEntry> onAfterSqlExecute, bool useStopWatch = false);
    IDbRegistration GetRegistration(string dbName);
    bool IsRegistered(string dbName);
    IDbContext NewContext(bool autoDispose);

    IDbContext NewContext(string dbName = null, bool autoDispose = true);

    IDbManager Register(IDbRegistration registration);

    void Synchronize(IDbSynchParameters parameters);

    /// <summary>
    /// Test a registered database connection
    /// </summary>
    /// <param name="dbName">The name of the registered database</param>
    /// <param name="raiseException">Default is true</param>
    /// <returns>Returns a bool/string value pair (bool indicates success or not, string contains message</returns>
    BoolValuePair<string> TestConnection(string dbName, bool raiseException = true);

    /// <summary>
    /// Test database connection with out registering first
    /// </summary>
    /// <param type="TDbConnection">The type of connection to used</param>
    /// <param name="connectionString">The connection string</param>
    /// <param name="raiseException">Default is true</param>
    /// <returns>Returns a bool/string value pair (bool indicates success or not, string contains message</returns>
    BoolValuePair<string> TestConnection<TDbConnection>(string connectionString, bool raiseException = true) 
      where TDbConnection : System.Data.Common.DbConnection;

    void UseDb(string dbName);
    ISql Sql(IDbContext dbContext = null);
    DbType MapTypeToDb(Type type);
  }
}