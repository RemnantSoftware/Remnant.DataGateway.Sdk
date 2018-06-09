using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remnant.DataGateway.Interfaces
{
  public interface IJoinOnExt
  {
    string FromColumn { get; set; }
    string ToColumn { get; set; }
    SqlOperand Operand { get; set; }
    SqlLogicialOperand LogicalOperand { get; set; }
  }
}
