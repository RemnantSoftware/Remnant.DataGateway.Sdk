
namespace Remnant.DataGateway.Interfaces
{
	public interface IUnion
	{
		/// <summary>
		/// Define a union select statement (distinct values, duplicates are excluded)
		/// </summary>
		ISelect Union();

		/// <summary>
		/// Define a union all select statement (duplicates are included)
		/// /// </summary>
		ISelect UnionAll();
	}
}
