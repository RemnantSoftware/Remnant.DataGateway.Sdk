namespace Remnant.DataGateway.Interfaces
{
  public interface IOrderByColumn
  {
    string Name { get; set; }
    SqlOrderBy OrderBy { get; set; }
  }
}