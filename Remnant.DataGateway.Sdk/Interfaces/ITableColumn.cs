namespace Remnant.DataGateway.Interfaces
{
  public interface ITableColumn<TDataTypeEnum> where TDataTypeEnum : struct
  {
    bool AutoSequence { get; set; }
    TDataTypeEnum DataType { get; set; }
    object DefaultValue { get; set; }
    bool IsNullable { get; set; }
    int? Length { get; set; }
    string Name { get; set; }
    int? Precision { get; set; }
    ColumnType Type { get; set; }
  }
}