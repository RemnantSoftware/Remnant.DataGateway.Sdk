using System.Data;

namespace Remnant.DataGateway.Interfaces
{
	public interface IMapData
	{
		void Map(IDataReader reader);
	}
}