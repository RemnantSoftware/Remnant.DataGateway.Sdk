namespace Remnant.DataGateway.Interfaces
{
  public interface ICriteria
  {
    bool Bind { get; set; }
    string ColumnName { get; set; }
    string Custom { get; set; }
    CriteriaLogicalOperand LogicalOperand { get; set; }
    SqlOperand Operand { get; set; }
    bool UseValueAsColumn { get; set; }
    object Value { get; set; }
  }
}