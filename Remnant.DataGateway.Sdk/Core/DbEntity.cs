using System;
using Remnant.DataGateway.Attributes;

namespace Remnant.DataGateway.Core
{	
	/// <summary>
	/// Class that represents somekind of database entity
	/// </summary>
	[Serializable]
	public class DbEntity
	{
		public DbEntity()
		{			
			
		}

		//public static MetaAttribute GetMetaDataForProperty<TDbEntity>(string propertyName)
		//where TDbEntity : DbEntity
		//{
		//	return GetMetaDataForProperty(typeof(TDbEntity), propertyName);
		//}

		//public static MetaAttribute GetMetaDataForProperty(Type entityType, string propertyName)
		//{
		//	return (from prop in entityType.GetProperties()
		//					from attribute in prop.GetCustomAttributes(true)
		//					where prop.Name.Equals(propertyName, StringComparison.CurrentCultureIgnoreCase) &&
		//								attribute.GetType() == typeof(MetaAttribute)
		//					select (MetaAttribute)attribute).SingleOrDefault();
		//}

		/// <summary>
		/// Get the decorated DbName attribute name for the class
		/// Note: If attribute name is not specified, the class name is used as the table name
		/// </summary>
		/// <returns></returns>
		//public static string GetDbName<TDbEntity>()
		//	where TDbEntity : DbEntity
		//{
		//	var dbTableAttr = ReflectionService.GetClassAttribute<DbNameAttribute>(typeof(TDbEntity));
		//	return (dbTableAttr != null && !string.IsNullOrEmpty(dbTableAttr.Name))
		//						? dbTableAttr.Name
		//						: typeof(TDbEntity).Name;
		//}

	}
}
