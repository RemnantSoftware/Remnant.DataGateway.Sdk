using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using Remnant.DataGateway.Interfaces;
using Remnant.DataGateway.Sdk;
using Remnant.DataGateway.Exceptions;
using Remnant.Core.Extensions;
using Remnant.Core;

namespace Remnant.DataGateway.Core
{
	public abstract class DbSchema<TDataTypeEnum> : IDbSchema
    where TDataTypeEnum : struct
  {
    #region Fields

    protected const string _primaryKeyConstraintFormat = "CONSTRAINT pk_{0} PRIMARY KEY ({1})";
    protected const string _foreignKeyConstraintFormat = "CONSTRAINT fk_{0} FOREIGN KEY ({1}) REFERENCES {2}({3})";

    protected Dictionary<Type, Type> _parsers = new Dictionary<Type, Type>();
    protected readonly Dictionary<TDataTypeEnum, Type> _mapDataTypes = new Dictionary<TDataTypeEnum, Type>();
    protected readonly IDbManager _dbManager;

    #endregion

    #region Constructors and Finalisors

    public DbSchema(IDbManager dbManager)
    {
      Shield.AgainstNull(dbManager, "dbManager").Raise();

      _dbManager = dbManager;

      DatabaseType = DatabaseType.Undefined;
      QuoteForStringValues = "'";
      AliasFormat = string.Empty;
      NullFormat = "null";
      NotNullFormat = "not null";
      IdentifierCase = Case.Default;
      DefaultDateTimeFormat = "yyyy/MM/dd HH:mm:ss";
      MinDateTime = DateTime.MinValue;
      MaxDateTime = DateTime.MaxValue;
      RegisterDataTypeMappings();
    }

    #endregion

    #region Protected Members

    protected virtual void RegisterDataTypeMappings()
    {
      throw new NotImplementedException("RegisterDataTypeMappings must be implemented in derive schema.");
    }

    #endregion

    #region Public Members

    public virtual IDbCommand CreateCommand(IDbConnection connection)
    {
      return connection.CreateCommand();
    }

    public Type GetNetDataType(string dataType, bool isNullable)
    {
      if (string.IsNullOrEmpty(dataType))
      {
        return typeof(object);
      }

      Shield.Against(_mapDataTypes.Count == 0)
        .WithMessage(ErrorMessages.NoDataTypesMapped)
        .Raise();

      var dataTypes = Enum.GetValues(typeof(TDataTypeEnum));
      var mappingFound = false;
      var enumDataType = (TDataTypeEnum)Enum.GetValues(typeof(TDataTypeEnum)).GetValue(0); // maps to unknown

      foreach (var type in dataTypes)
      {
        if (((TDataTypeEnum)type).ToDescription().Equals(dataType, StringComparison.InvariantCultureIgnoreCase))
        {
          enumDataType = (TDataTypeEnum)type;
          mappingFound = true;
          break;
        }
      }

      Shield.Against(!mappingFound)
        .WithMessage(ErrorMessages.NoMappingForDataType)
        .WithParameters(GetType().Name, dataType)
        .Raise();

      Type netDataType;
      _mapDataTypes.TryGetValue(enumDataType, out netDataType);

      Shield.AgainstNull(netDataType)
        .WithMessage(ErrorMessages.NoMappingForDataType)
        .WithParameters(GetType().Name, dataType)
        .Raise();

      // make type a generic nullable
      if (isNullable
        && netDataType != typeof(XDocument)
        && netDataType != typeof(string)
        && netDataType != typeof(byte[]))
      {
        netDataType = typeof(Nullable<>).MakeGenericType(netDataType);
      }

      return netDataType;
    }

    public string GetDatabaseDataType(Type netDataType)
    {
      Shield.Against(_mapDataTypes.Count == 0)
        .WithMessage(ErrorMessages.NoDataTypesMapped)
        .Raise();

      if (netDataType.IsGenericType && netDataType.GetGenericTypeDefinition() == typeof(Nullable<>))
        netDataType = Nullable.GetUnderlyingType(netDataType);

      Shield.Against(!_mapDataTypes.ContainsValue(netDataType))
        .WithMessage(ErrorMessages.NoMappingForDataType)
        .WithParameters(GetType().Name, netDataType)
        .Raise();

      foreach (var mapDataType in _mapDataTypes)
      {
        if (mapDataType.Value == netDataType)
          return mapDataType.Key.ToDescription().ToCase(Case.Pascal);
      }

      return null;
    }

    public string GetNetDataTypeString(string dataType, bool isNullable)
    {
      var type = GetNetDataType(dataType, isNullable);

      if (type.IsGenericType && isNullable)
        return Nullable.GetUnderlyingType(type).Name + '?'; // .Net 4.5 usage GenericTypeArguments[0].Name + '?' 

      return type.Name;
    }

    public virtual string FormatPrimaryKeyConstraint(string tableName, string columnName)
    {
      return string.Format(_primaryKeyConstraintFormat, tableName, columnName);
    }

    public virtual string FormatForeignKeyConstraint(string tableName, string columnName, string foreignTableName,
                                                     string foreignColumnName)
    {
      return string.Format(_foreignKeyConstraintFormat, tableName, columnName, foreignTableName, foreignColumnName);
    }

    public void RegisterParser<TParser, TDbStatement>()
       where TParser : IParser
      where TDbStatement : IDbStatement
    {
      var parserType = typeof(TParser);
      var statementType = typeof(TDbStatement);

      Shield.Against(_parsers.ContainsKey(statementType))
        .WithParameters(this, $"A parser is already registered for {statementType.FullName}")
        .Raise<DbSchemaException>();

      Shield.AgainstNull(parserType.GetConstructor(new[] { statementType }))
        .WithParameters(this, $"The parser {parserType.FullName} has no implementation to parse statement {statementType.FullName}")
        .Raise<DbSchemaException>();

      _parsers.Add(statementType, typeof(TParser));
    }

    public virtual IParser SqlParser(IDbStatement statement)
    {
      var statementType = statement.GetType();

      Shield.Against(!_parsers.ContainsKey(statementType))
        .WithParameters(this, $"There is no parser registered for statement of type {statementType}")
        .Raise<DbSchemaException>();

      return Activator.CreateInstance(_parsers[statementType], statement) as IParser;
    }

    public virtual IDbAdmin<TDataTypeEnum> Admin(IDbContext context = null)
    {
      throw new NotImplementedException("Admin must be implemented in derived dschema.");
    }


    public virtual string ConcatFormat(List<string> columns, string delimiter = null)
    {
      throw new NotImplementedException("ConcatFormat must be implemented in derived schema.");
    }

    public virtual string InsertReturnKeySyntax(string autoSequence, string statement, string primaryKeyColumnName = null)
    {
      return statement;
    }

    public virtual IDbCommand InsertReturnKeyCommand(IInsertStatement statement)
    {
      return null;
    }

    public virtual void ExpressionFormat(ISelectStatement statement, ISqlExpression expression)
    {
      throw new NotImplementedException("ExpressionFormat must be implemented in derived schema.");
    }

    public virtual string CteWithFormat(ISelectWithStatement statement)
    {
      throw new NotImplementedException("Common expression tables not supported by the schema.");
    }

    public virtual string SelectForUpdateFormat
    {
      get { throw new NotImplementedException("Select for update must be implemented in derive schema."); }
    }

    public virtual string ObjectExistsFormat
    {
      get { throw new NotImplementedException("Object exists format must be implemented in derive schema."); }
    }

    #endregion

    #region Properties

    public DatabaseType DatabaseType { get; protected set; }

    public string QuoteForStringValues { get; protected set; }

    public string BindVariableSymbol { get; protected set; }

    public char IdentifierPreEscapeChar { get; protected set; }

    public char IdentifierPostEscapeChar { get; protected set; }

    public Case IdentifierCase { get; protected set; }

    public string AliasFormat { get; protected set; }

    public string AutoSequenceUniqueIdFormat { get; protected set; }

    public string AutoSequenceNumberFormat { get; set; }

    public string NullFormat { get; protected set; }

    public string NotNullFormat { get; protected set; }

    public string DefaultDateTimeFormat { get; set; }

    public DateTime MinDateTime { get; set; }

    public DateTime MaxDateTime { get; set; }

    #endregion

    #region Admin

    public virtual string AdminRenameTable(string oldName, string newName)
    {
      throw new NotImplementedException("AdminRenameTable must be implemented in derive schema.");
    }

    public virtual string AdminRenameColumn(string tableName, string oldName, string newName)
    {
      throw new NotImplementedException("AdminRenameColumn must be implemented in derive schema.");
    }

    #endregion
  }
}
