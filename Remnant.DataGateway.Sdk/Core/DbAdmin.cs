
//using Remnant.DataGateway.Interfaces;

//namespace Remnant.DataGateway.Core
//{

//	public class DbAdmin<TDataTypeEnum> : Sql, IDbAdmin<TDataTypeEnum>
//		where TDataTypeEnum : struct
//	{

//		public DbAdmin(IDbManager dbManager, IDbContext context = null)
//			: base(dbManager, context)
//		{
//		}	

//		public ICreateTable<TDataTypeEnum> CreateTable()
//		{
//			var statement = new CreateTableStatement<TDataTypeEnum>(this, Context);
//			Type = DbStatementType.CreateTable;
//			_statements.Add(statement);
//			return statement;
//		}

//		public IAlterTable<TDataTypeEnum> AlterTable()
//		{
//			var statement = new AlterTableStatement<TDataTypeEnum>(_dbManager, this, Context);
//			Type = DbStatementType.AlterTable;
//			_statements.Add(statement);
//			return statement;
//		}

//		public IDropTable DropTable()
//		{
//			var statement = new DropTableStatement(this, Context);
//			Type = DbStatementType.DropTable;
//			_statements.Add(statement);
//			return statement;
//		}


//		public IDbAdmin<TDataTypeEnum> And
//		{
//			get { return this; }
//		}

//		#region Synchronize database

		
//		#endregion
//	}

//}
