
namespace Remnant.DataGateway.Interfaces
{
  public interface IUpdateWhere
  {    			
		/// <summary>
		/// Specify where criteria for the update statement
		/// </summary>
		IUpdateDeleteWhere Where { get; }
  }
}
