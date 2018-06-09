
using System;
using System.Collections.Generic;
using System.Data;
using Remnant.Core;

namespace Remnant.DataGateway.Interfaces
{
	public interface IDbSchema
	{
		/// <summary>
		/// Get the .Net data type for database type
		/// </summary>
		/// <param name="netDataType">The .net data type</param>
		/// <returns>Returns the equivelent data base type</returns>
		string GetDatabaseDataType(Type netDataType);

		/// <summary>
		/// Get the .Net data type for database type
		/// </summary>
		/// <param name="dataType">The database data type</param>
		/// <param name="isNullable">If the type is nullable or not</param>
		/// <returns>Returns the equivelent .Net data type</returns>
		Type GetNetDataType(string dataType, bool isNullable);

		/// <summary>
		/// Get the .Net data type for database type as string
		/// </summary>
		/// <param name="dataType">The database data type</param>
		/// <param name="isNullable">If the type is nullable or not</param>
		/// <returns>Returns the equivelent .Net data type as string</returns>
		string GetNetDataTypeString(string dataType, bool isNullable);

		/// <summary>
		/// Get the represented database type
		/// </summary>
		DatabaseType DatabaseType { get; }

		/// <summary>
		/// Get if single or double quotes must be used for sql string values
		/// Note: The default is set to single quotes which are more widely accepted by all RDBMS
		/// </summary>
		string QuoteForStringValues { get; }

		/// <summary>
		/// Oracle bind variables names are preceeded by an :
		/// Sybase and MS SQL Server, bind variables names are preceeded by an @ 
		/// PostgreSQL bind variables names are preceeded by an $
		/// In MySQL, DB2 and Firebird, bind variables are represented by an ?
		/// </summary>
		string BindVariableSymbol { get;  }

		/// <summary>
		/// Escape sequence for identifiers that match keywords
		/// </summary>
		char IdentifierPreEscapeChar { get; }

		/// <summary>
		/// Escape sequence for identifiers that match keywords
		/// </summary>
		char IdentifierPostEscapeChar { get; }

		/// <summary>
		/// Get the case must be used for identifiers
		/// </summary>
		Case IdentifierCase { get; }

		/// <summary>
		/// Get the format to be used for table and column aliases
		/// </summary>
		string AliasFormat { get; }

		/// <summary>
		/// Auto sequence/increment format for creating table columns using numbers
		/// </summary>
		string AutoSequenceNumberFormat { get; }

    /// <summary>
    /// Auto sequence format for creating table columns using unique identifiers
    /// </summary>
    string AutoSequenceUniqueIdFormat { get; }

    /// <summary>
    /// Null format for creating table columns
    /// </summary>
    string NullFormat { get; }

		/// <summary>
		/// Not Null format for creating table columns
		/// </summary>
		string NotNullFormat { get; }

		/// <summary>
		/// Format to add a primary key constraint for creating a table
		/// </summary>
		string FormatPrimaryKeyConstraint(string tableName, string columnName);

		/// <summary>
		/// Format to add a foreign key constraint for creating a table
		/// </summary>
		string FormatForeignKeyConstraint(string tableName, string columnName, string foreignTableName, string foreignColumnName);

    /// <summary>
    /// Registers parsers for Sql statements
    /// </summary>
    /// <typeparam name="TParser"></typeparam>
    /// <typeparam name="TParserInterface"></typeparam>
    void RegisterParser<TParser, TDbStatement>()
      where TParser : IParser
      where TDbStatement : IDbStatement;

    /// <summary>
    /// Get the SqlParser implementation to be used for sql parsing	
    /// </summary>
    IParser SqlParser(IDbStatement statement);

		/// <summary>
		/// Handle the concatenation of columns with an optional delimiter
		/// </summary>
		/// <param name="columns">List of columns to concatenate</param>
		/// <param name="delimiter">Optional delimiter between columns</param>
		/// <returns>Returns the formatted concatenated columns</returns>
		string ConcatFormat(List<string> columns, string delimiter = null);

		/// <summary>
		/// Format the expression
		/// </summary>
		/// <param name="statement">The select statement</param>	
		/// <param name="expression">The sql expression</param>	
		/// <returns>The result will be added to parser based on the expression's 'ParseWhere'</returns>
		void ExpressionFormat(ISelectStatement statement, ISqlExpression expression);

		/// <summary>
		/// Handle the syntax to return the primary key on an insert statement
		/// Note: Use the passed bind parameter list to add a new bind parameter if the key is returned as a parameter.
		///				Also ensure the parameter direction is ParameterDirection.ReturnValue.
		/// </summary>
		/// <param name="autoSequence">The auto sequence as specified on the DbKey attribute</param>
		/// <param name="statement">The insert statement</param>
		/// <param name="primaryKeyColumnName">Optional, If entity type is not used specify the primary key colum name</param>
		/// <returns>Return the formatted string or null if bind parameter is used</returns>
		string InsertReturnKeySyntax(string autoSequence, string statement, string primaryKeyColumnName = null);

    /// <summary>
    /// Handle the return key on an insert statement using a call to the database
    /// </summary>
    /// <param name="statement"></param>
    /// <returns></returns>
    IDbCommand InsertReturnKeyCommand(IInsertStatement statement);

		/// <summary>
		/// Get or set the default datbase date and time format
		/// </summary>
		string DefaultDateTimeFormat { get; set; }

    /// <summary>
    /// Ask the schema to construct a command using the connection to
    /// allow behaviour settings for a specific database command
    /// </summary>
    /// <param name="connection">The connection to the database</param>
    /// <returns>Returns an instance of the command</returns>
    IDbCommand CreateCommand(IDbConnection connection);

		/// <summary>
		/// Format the 'With' statement for common table expressions (cte)
		/// </summary>
		/// <param name="statement"></param>
		/// <returns></returns>
		string CteWithFormat(ISelectWithStatement statement);

		/// <summary>
		/// Minimum date value for database
		/// </summary>
		DateTime MinDateTime { get; set; }

		/// <summary>
		/// Maximum date value for database
		/// </summary>
		DateTime MaxDateTime { get; set; }
		
		/// <summary>
		/// Format to rename a table
		/// </summary>
		/// <param name="oldName">The old name</param>
		/// <param name="newName">The new name</param>
		/// <returns>Returns the formatted syntax</returns>
		string AdminRenameTable(string oldName, string newName);

		/// <summary>
		/// Format to rename a table column
		/// </summary>
		/// <param name="tableName">The name of the table</param>
		/// <param name="oldName">The old name</param>
		/// <param name="newName">The new name</param>
		/// <returns>Returns the formatted syntax</returns>
		string AdminRenameColumn(string tableName, string oldName, string newName);

		/// <summary>
		/// Get the format for select for update
		/// </summary>
		string SelectForUpdateFormat { get; }

		/// <summary>
		/// Get the format to check if object exists
		/// </summary>
		string ObjectExistsFormat { get; }
	}
}
