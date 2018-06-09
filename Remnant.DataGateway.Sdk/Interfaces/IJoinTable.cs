using System.Collections.Generic;

namespace Remnant.DataGateway.Interfaces
{
  public interface IJoinTable
  {
    ITable FromTable { get; set; }
    IJoinTable Join { get; set; }
    SqlJoin JoinType { get; set; }
    List<IJoinOnExt> On { get; set; }
    ITable ToTable { get; set; }
  }
}