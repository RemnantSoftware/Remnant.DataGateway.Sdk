using System;
using System.Data;

namespace Remnant.DataGateway.Interfaces
{
  public interface IBindParameter
  {
    Type DataType { get; set; }
    ParameterDirection Direction { get; set; }
    string Name { get; set; }
    int? Size { get; set; }
    object Value { get; set; }
  }
}