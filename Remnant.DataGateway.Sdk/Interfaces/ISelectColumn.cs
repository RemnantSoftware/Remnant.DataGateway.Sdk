using System.Collections.Generic;

namespace Remnant.DataGateway.Interfaces
{
  public interface ISelectColumn
  {
    SqlAggregate? Aggregate { get; set; }
    string Alias { get; set; }
    List<string> ConcatColumns { get; set; }
    string ConcatDelimiter { get; set; }
    bool Expression { get; set; }
    string Name { get; set; }
  }
}