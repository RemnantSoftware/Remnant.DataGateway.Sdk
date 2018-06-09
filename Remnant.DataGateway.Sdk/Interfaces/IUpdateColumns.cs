
namespace Remnant.DataGateway.Interfaces
{
  public interface IUpdateColumns
  {    		
		/// <summary>
		/// Update column with a value type.
		/// </summary>
		/// <param name="columnName">The name of the column to be updated </param>
		/// <param name="value">The value</param>
		/// <param name="length">The length (optional)</param>
		/// <param name="bind">Specify if bind parameters must be used, default is true</param>
		/// <returns>Returns the interface</returns>
    IUpdateColumns Column(string columnName, object value, int? length = null, bool bind = true);

		/// <summary>
		/// Update column with another column's value
		/// </summary>
		/// <param name="columnName">The name of the column to be updated</param>
		/// <param name="withColumnName">The name of the column that contains the value</param>
		/// <returns>Returns interface</returns>
		IUpdateColumns ColumnWithColumn(string columnName, string withColumnName);

		/// <summary>
		/// Specify where criteria for the update statement
		/// </summary>
		IUpdateDeleteWhere Where { get; }
  }
}
