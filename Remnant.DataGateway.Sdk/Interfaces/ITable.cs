using System;

namespace Remnant.DataGateway.Interfaces
{
  public interface ITable
  {
    string Alias { get; set; }
    Type EntityType { get; set; }
    string PrimaryKeyColumnName { get; set; }
    string TableName { get; set; }
  }
}