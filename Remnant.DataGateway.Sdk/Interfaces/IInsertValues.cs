
namespace Remnant.DataGateway.Interfaces
{
  public interface IInsertValues : IExecute
  {
		/// <summary>
		/// Insert values for column
		/// </summary>
		/// <param name="column">The name of the column</param>
		/// <param name="value">The value that will be inserted or the name of a bind parameter that contains the value</param>
		/// <param name="length">Optional, the length of the value for a bind parameter</param>
		/// <param name="bind">Optional, binding is set to true by default</param>
		/// <returns></returns>
		IInsertValues Column(string column, object value, int? length = null, bool bind = true);	
  }
}
