

namespace Remnant.DataGateway.Interfaces
{
	public interface IDbStatement
	{
		IDbContext Context { get; }
		DbStatementType Type { get; }
	}
}
