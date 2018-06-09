namespace Remnant.DataGateway.Interfaces
{
  public interface IUpdInsColumn
  {
    bool Bind { get; set; }
    int? Length { get; set; }
    string Name { get; set; }
    object Value { get; set; }
  }
}