namespace Remnant.DataGateway.Interfaces
{
  public interface IJoinOn : IJoinEntities, IJoinTables
  {
    /// <summary>
    /// Specify join on additional columns using 'And'
    /// </summary>
    /// <param name="fromColumn">Join from column name</param>
    /// <param name="operand">The operand</param>
    /// <param name="toColumn">Join to column name or bind parameter (values are not allowed!)</param>
    /// <returns></returns>
    IFromTable And(string fromColumn, SqlOperand operand, string toColumn);

    /// <summary>
    /// Specify join on additional columns using 'Or'
    /// </summary>
    /// <param name="fromColumn">Join from column name</param>
    /// <param name="operand">The operand</param>
    /// <param name="toColumn">Join to column name or bind parameter (values are not allowed!)</param>
    /// <returns></returns>
    IFromTable Or(string fromColumn, SqlOperand operand, string toColumn);
  }

}