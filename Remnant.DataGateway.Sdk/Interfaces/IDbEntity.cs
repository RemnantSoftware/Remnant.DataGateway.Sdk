
using FastMember;
using System.Collections.Generic;

namespace Remnant.DataGateway.Interfaces
{
  public interface IDbEntity
  {
    List<string> _Properties { get; }
    TypeAccessor _Accessor { get; }
  }
}
