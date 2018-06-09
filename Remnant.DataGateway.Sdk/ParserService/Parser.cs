using System.Text;
using Remnant.Core.Extensions;
using Remnant.DataGateway.Interfaces;

namespace Remnant.DataGateway.Core
{
	public abstract class Parser<TDbStatement> : IParser
    where TDbStatement : IDbStatement
	{
		#region Fields

		protected readonly StringBuilder _parser;
    protected TDbStatement _statement;

    #endregion

    #region Constructors & Finalizors

    protected Parser()
    {
    }

    protected Parser(TDbStatement statement)
		{
      Shield.AgainstNull(statement, "statement").Raise();

      _statement = statement;
			_parser = new StringBuilder();
		}		 

		#endregion

    public TDbStatement Statement { get;  }

		protected void RemoveEolComma()
		{
			if (_parser[_parser.Length - 3] == ',')
				_parser.Remove(_parser.Length - 3, 1);
		}

		protected string FormatField(IDbContext context, string name, bool useDatabinding = false)
		{
			if (!string.IsNullOrEmpty(name))
			{
				if (useDatabinding)
					return context.Schema.BindVariableSymbol + name.ToCase(context.Schema.IdentifierCase);

				if (name.Contains("."))
					return context.Schema.IdentifierPreEscapeChar +
							 name.Replace(".", context.Schema.IdentifierPostEscapeChar + "." +
														 context.Schema.IdentifierPreEscapeChar).ToCase(context.Schema.IdentifierCase) +
															context.Schema.IdentifierPostEscapeChar;

				// if escaped <> for keywords
				if (name.StartsWith("<") && name.EndsWith(">"))
					name = name.Substring(1, name.Length - 2);
				else
					return context.Schema.IdentifierPreEscapeChar + name.ToCase(context.Schema.IdentifierCase) +
					       context.Schema.IdentifierPostEscapeChar;
			}
			return name.ToCase(context.Schema.IdentifierCase);
		}

		public abstract string Parse();
	}
}
