
namespace Remnant.DataGateway.Interfaces
{
	public interface IStoredProcedure : ISqlStatement
	{
		string Name { get; }
	}
}
