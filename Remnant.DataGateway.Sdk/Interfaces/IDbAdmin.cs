
namespace Remnant.DataGateway.Interfaces
{
	public interface IDbAdmin<in TDataTypeEnum>
		where TDataTypeEnum : struct
	{
		/// <summary>
		/// Drop an object from the database
		/// </summary>
		/// <returns></returns>
		IDropTable DropTable();

		/// <summary>
		/// Create a new table
		/// </summary>
		/// <returns></returns>
		ICreateTable<TDataTypeEnum> CreateTable();


		/// <summary>
		/// Alter an existing table
		/// </summary>
		/// <returns></returns>
		IAlterTable<TDataTypeEnum> AlterTable();
		
	}
}
