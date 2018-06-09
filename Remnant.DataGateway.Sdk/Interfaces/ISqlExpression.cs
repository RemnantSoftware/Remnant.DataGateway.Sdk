namespace Remnant.DataGateway.Interfaces
{
  public interface ISqlExpression
  {
    SqlSelectExpressionParse ParseWhere { get; set; }
    SqlSelectExpression Type { get; set; }
    object Value { get; set; }
  }
}