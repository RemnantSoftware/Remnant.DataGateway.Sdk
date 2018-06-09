
namespace Remnant.DataGateway.Interfaces
{
	public interface ISelectWithStatement : ISelectStatement
	{
		string ExpressionName { get; set; }
	}
}
