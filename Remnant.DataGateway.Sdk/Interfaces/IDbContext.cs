using System;
using System.Data;

namespace Remnant.DataGateway.Interfaces
{
  public interface IDbContext : IDisposable
  {
    bool AutoDispose { get; }
    int CommandTimeout { get; set; }
    IDbConnection Connection { get; }
    bool InExplicitTransaction { get; }
    IDbRegistration Registration { get; }
    IDbSchema Schema { get; }

    event Action OnDispose;

    void Commit();
    IDbCommand CreateCommand();
    void EnlistCommand(IDbCommand command);
    void NewTransaction();
    void Rollback();
  }
}