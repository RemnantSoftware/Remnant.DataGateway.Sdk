using Remnant.DataGateway.Interfaces;
using System;

namespace Remnant.DataGateway.Exceptions
{
	[Serializable]
  public class DbSchemaException : Exception
  {
    public DbSchemaException(IDbSchema schema, string message)
      : base(string.Format($"Schema: {schema.GetType().FullName}, failed with {message}"))
    {
    }
  }
}
