
namespace Remnant.DataGateway.Interfaces
{
  public interface IDeleteWhere : IExecute
  {    			
		/// <summary>
		/// Specify where criteria for the update statement
		/// </summary>
		IUpdateDeleteWhere Where { get; }	
  }
}
