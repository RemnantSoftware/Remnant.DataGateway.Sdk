
namespace Remnant.DataGateway.Interfaces
{
	public interface IDropTableStatement : ISqlStatement
	{
		string TableName { get; }
	}
}
