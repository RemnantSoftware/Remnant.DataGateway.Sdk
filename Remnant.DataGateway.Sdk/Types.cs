using System;
using System.ComponentModel;

namespace Remnant.DataGateway
{
  public enum DatabaseType
  {
    Undefined = 0,
    SqlServer,
    MySql,
    Db2,
    Firebird,
    PostgreSqL,
    Sybase,
    Oracle,
    MsAccess
  }

  public enum SqlAggregate
  {
    [Description("Min")]
    Minimum = 0,
    [Description("Max")]
    Maxmimum,
    [Description("Avg")]
    Average,
    [Description("Sum")]
    Sum,
    [Description("Count")]
    Count,
    [Description("Concatenate")]
    Concatenate
  }

  public enum SqlSelectExpression
  {
    [Description("Distinct ")]
    Distinct = 0,
    Top
  }

  public enum SqlSelectExpressionParse
  {
    None = 0,
    BeforeColumns,
    AfterStatement
  }

  public enum SqlMultiOperand
  {
    /// <summary>
    ///  Union results. Duplicate rows are removed.
    /// </summary>
    [Description(" Union ")]
    Union = 0,

    /// <summary>
    /// Union result. Incorporates all rows into the results, which includes duplicates.
    /// </summary>
    [Description("Union all ")]
    UnionAll,

    [Description("with {0} as ")]
    With,

    [Description("select")]
    Select
  }

  public enum DbStatementType
  {
    [Description(" Select ")]
    Select = 0,
    [Description("Insert ")]
    Insert,
    [Description("Delete ")]
    Delete,
    [Description("Update ")]
    Update,
    [Description("StoredProcedure")]
    StoredProcedure,
    [Description("Create Table")]
    CreateTable,
    [Description("Alter Table")]
    AlterTable,
    [Description("Drop Table")]
    DropTable
  }

  public enum SqlKeywords
  {
    [Description(" Where ")]
    Where = 0,
    [Description(" Set ")]
    Set,
    [Description(" From ")]
    From,
    [Description(" Order by ")]
    OrderBy,
    [Description(" Group by ")]
    GroupBy,
    [Description(" Into ")]
    Into,
    [Description(" Values ")]
    Values,
    [Description(" Having ")]
    Having
  }

  public enum SqlOrderBy
  {
    None = 0,
    [Description("Asc")]
    Acsending,
    [Description("Desc")]
    Descending
  }

  public enum CriteriaLogicalOperand
  {
    [Description("and")]
    And,
    [Description("or")]
    Or
  }

  public enum SqlLogicialOperand
  {
    [Description("all")]
    All = 0,
    [Description("and")]
    And,
    [Description("any")]
    Any,
    [Description("between")]
    Between,
    [Description("exists")]
    Exists,
    [Description("in")]
    In,
    [Description("like")]
    Like,
    [Description("not")]
    Not,
    [Description("on")]
    On,
    [Description("or")]
    Or,
    [Description("some")]
    Some
  }

  public enum SqlOperand
  {
    [Description("=")]
    Equal = 0,
    [Description("<>")]
    NotEqual,
    [Description("<")]
    LessThan,
    [Description(">")]
    GreaterThan,
    [Description("<=")]
    LessThanEqual,
    [Description(">=")]
    GreaterThanEqual,
    [Description("in")]
    In,
    [Description("not in")]
    NotIn,
    [Description("between")]
    Between,
    [Description("is null")]
    IsNull,
    [Description("is not null")]
    IsNotNull,
    [Description("like")]
    Like,
    [Description("not like")]
    NotLike
  }


  public enum SqlJoin
  {
    /// <summary>
    ///  Return rows when there is at least one match in both tables
    /// </summary>
    [Description("Inner Join")]
    Inner = 0,

    /// <summary>
    /// Return all rows from the left table, even if there are no matches in the right table
    /// </summary>
    [Description("Left Join")]
    Left,

    /// <summary>
    /// Return all rows from the right table, even if there are no matches in the left table
    /// </summary>
    [Description("Right Join")]
    Right,

    /// <summary>
    /// Return rows when there is a match in one of the tables
    /// </summary>
    [Description("Left Outer Join")]
    LeftOuter,

    /// <summary>
    /// Return rows when there is a match in one of the tables
    /// </summary>
    [Description("Right Outer Join")]
    RightOuter
  }

  public enum DbThreadType
  {
    NonQuery = 0,
    ScalarQuery,
    ListQuery
  }

  [Obsolete]
  public enum ColumnType
  {
    Standard = 0,
    PrimaryKey,
    ForeignKey
  }

  public enum ConstraintType
  {
    [Description("Unknown constraint type")]
    Unknown = 0,
    [Description("CHECK")]
    Check,
    [Description("UNIQUE")]
    Unique,
    [Description("PRIMARY KEY")]
    PrimaryKey,
    [Description("FOREIGN KEY")]
    ForeignKey
}

  public enum DbSynchOperation
  {
    DropTable = 0,
    CreateTable,
    SynchTable
  }

}
