
namespace Remnant.DataGateway.Interfaces
{
	public interface IObjectExists
	{
		/// <summary>
		/// The name of the object to check if it exists 
		/// Note: Expecting object name to be unique across object types
		/// </summary>
		/// <param name="objectName">Name of the object</param>
		/// <returns></returns>
		IExecute Name(string objectName);
	}
}
