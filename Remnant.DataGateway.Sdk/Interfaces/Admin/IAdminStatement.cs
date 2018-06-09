namespace Remnant.DataGateway.Interfaces
{
	public interface IAdminStatement<TDataTypeEnum> : ISqlStatement
		where TDataTypeEnum : struct 
	{
	}
}
