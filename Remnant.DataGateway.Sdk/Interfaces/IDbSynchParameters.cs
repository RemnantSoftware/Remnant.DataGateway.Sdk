using System.Collections.Generic;

namespace Remnant.DataGateway.Interfaces
{
  public interface IDbSynchParameters
  {
    string DbName { get; set; }
    bool DropUnknownTables { get; set; }
    List<string> IgnoreTables { get; set; }
    string Owner { get; set; }
    string ScanInNamespace { get; set; }
  }
}