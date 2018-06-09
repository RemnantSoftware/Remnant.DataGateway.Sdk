using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Remnant.DataGateway.Attributes;
using Remnant.DataGateway.Interfaces;
using FastMember;

namespace Remnant.DataGateway.Core
{
  [Serializable]
  public class DbTableEntity<TEntity> : DbEntity, IDbTableEntity
    where TEntity : DbTableEntity<TEntity>
  {
    private static List<string> _properties = typeof(TEntity).GetProperties().ToList().Select(p => p.Name).ToList();
    private static TypeAccessor _accessor = TypeAccessor.Create(typeof(TEntity));

    //		public object[] ToDataRow()
    //		{
    //			var list = ReflectionService.GetPropertiesAttribute<DbFieldAttribute>(GetType());
    //			//return list.Select(fieldAttribute => ReflectionService.GetPropertyValue(this, fieldAttribute.Key, false)).ToArray();
    //			return (from dbFieldAttribute in list
    //							where !(dbFieldAttribute.Value.Generated)
    //							select ReflectionService.GetPropertyValue(this, dbFieldAttribute.Key, false)).ToArray();
    //		}

    //		public static Dictionary<string, DbFieldAttribute> GetMetaInfo<TDbEntity>()
    //			where TDbEntity : DbEntity
    //		{
    //			return ReflectionService.GetPropertiesAttribute<DbFieldAttribute>(typeof(TDbEntity));
    //		}

    /// <summary>
    /// Retrieve all db related properties 
    /// </summary>
    /// <returns></returns>
    //public static IEnumerable<PropertyInfo> GetAllFields(Type entityType)
    //{
    //	var fieldProps = (from prop in entityType.GetProperties()
    //										from attribute in prop.GetCustomAttributes(true)
    //										where attribute.GetType() == typeof(DbKeyAttribute) ||
    //													attribute.GetType() == typeof(DbFieldAttribute) ||
    //													attribute.GetType() == typeof(RuntimeDbFieldAttribute) 
    //										select prop);
    //	return fieldProps;
    //}

    /// <summary>
    /// Retrieve all db related properties
    /// </summary>
    /// <returns></returns>
    //public static IEnumerable<PropertyInfo> GetAllFields<TDbEntity>()
    //	where TDbEntity : DbTableEntity
    //{
    //	return GetAllFields(typeof(TDbEntity));
    //}

    /// <summary>
    /// Retrieve all properties that is decorated with DbField and RumtimeDbField attribute
    /// </summary>
    /// <returns></returns>
    //public static IEnumerable<PropertyInfo> GetDbAndRuntimeFields(Type entityType)
    //{
    //	var fieldProps = (from prop in entityType.GetProperties()
    //										from attribute in prop.GetCustomAttributes(true)
    //										where attribute.GetType() == typeof(DbFieldAttribute) ||
    //													attribute.GetType() == typeof(RuntimeDbFieldAttribute)
    //										select prop);
    //	return fieldProps;
    //}

    /// <summary>
    /// Retrieve all properties that is decorated with DbField and RumtimeDbField attribute
    /// </summary>
    /// <returns></returns>
    //public static IEnumerable<PropertyInfo> GetDbAndRuntimeFields<TDbEntity>()
    //	where TDbEntity : DbTableEntity
    //{
    //	return GetDbAndRuntimeFields(typeof (TDbEntity));
    //}

    /// <summary>
    /// Retrieve all properties that is decorated with DbField attribute 
    /// </summary>
    /// <returns></returns>
    //public static List<Decoration<DbFieldAttribute>> GetDbFields<TDbEntity>()
    //	where TDbEntity : DbTableEntity
    //{
    //	return GetDbFields(typeof (TDbEntity));
    //}

    /// <summary>
    /// Retrieve all properties that is decorated with DbField attribute 
    /// </summary>
    /// <returns></returns>
    //public static List<Decoration<DbFieldAttribute>> GetDbFields(Type entityType)
    //{
    //	var fields = (from prop in entityType.GetProperties()
    //					from attribute in prop.GetCustomAttributes(true)
    //					where attribute.GetType() == typeof (DbFieldAttribute)
    //					select new Decoration<DbFieldAttribute> {Property = prop, Attribute = (DbFieldAttribute) attribute});
    //	return fields.ToList();
    //}

    /// <summary>
    /// Retrieve all properties that is decorated with DbKey and DbField attribute 
    /// </summary>
    /// <returns></returns>
    //public static List<Decoration<DbAttribute>> GetDbKeyAndFields<TDbEntity>()
    //	where TDbEntity : DbTableEntity
    //{
    //	return GetDbKeyAndFields(typeof(TDbEntity));
    //}

    /// <summary>
    /// Retrieve all properties that is decorated with DbKey and DbField attribute 
    /// </summary>
    /// <returns></returns>
    //public static List<Decoration<DbAttribute>> xGetDbKeyAndFields(Type entityType)
    //{
    //	var fields = (from prop in entityType.GetProperties()
    //								from attribute in prop.GetCustomAttributes(true)
    //								where attribute.GetType() == typeof(DbKeyAttribute) ||
    //											 attribute.GetType() == typeof(DbFieldAttribute)
    //								select new Decoration<DbAttribute> { Property = prop, Attribute = (DbAttribute)attribute });
    //	return fields.ToList();
    //}

    /// <summary>
    /// Retrieve all properties that is decorated with DbParameter attribute 
    /// </summary>
    /// <returns>Return a dictionary containing the property and its decorated attribute</returns>
    //public static Dictionary<PropertyInfo, DbParameterAttribute> GetDbParameters<TDbEntity>()
    //	where TDbEntity : DbTableEntity
    //{
    //	return GetDbParameters(typeof (TDbEntity));
    //}

    /// <summary>
    /// Retrieve all properties that is decorated with DbParameter attribute 
    /// </summary>
    /// <returns>Return a dictionary containing the property and its decorated attribute</returns>
    //public static Dictionary<PropertyInfo, DbParameterAttribute> GetDbParameters(Type entityType)
    //{
    //	var parameters = (from prop in entityType.GetProperties()
    //										from attribute in prop.GetCustomAttributes(true)
    //										where attribute.GetType() == typeof(DbParameterAttribute)
    //										select new { Field = prop, Attribute = (DbParameterAttribute)attribute });

    //	return parameters.ToDictionary(item => item.Field, item => item.Attribute);
    //}

    //public static DbFieldAttribute GetDbFieldForProperty<TDbEntity>(string propertyName)
    //	where TDbEntity : DbTableEntity
    //{
    //	return GetDbFieldForProperty(typeof(TDbEntity), propertyName);
    //}

    //public static DbFieldAttribute GetDbFieldForProperty(Type entityType, string propertyName)
    //{
    //	var attr = (from prop in entityType.GetProperties()
    //							from attribute in prop.GetCustomAttributes(true)
    //							where prop.Name.Equals(propertyName, StringComparison.InvariantCultureIgnoreCase) &&
    //										attribute.GetType() == typeof(DbFieldAttribute)
    //							select (DbFieldAttribute)attribute).SingleOrDefault();
    //	return attr;
    //}	

    /// <summary>
    /// Get the property that is decorated with DbKey attribute
    /// </summary>
    /// <returns></returns>
    //public static Decoration<DbKeyAttribute> GetDbKey<TDbEntity>()
    //	where TDbEntity : DbTableEntity
    //{
    //	return GetDbKey(typeof (TDbEntity));
    //}

    /// <summary>
    /// Get the property that is decorated with DbKey attribute
    /// </summary>
    /// <returns></returns>
    //public static Decoration<DbKeyAttribute> GetDbKey(Type entityType)
    //{
    //	var field = (from prop in entityType.GetProperties()
    //							 from attribute in prop.GetCustomAttributes(true)
    //							 where attribute.GetType() == typeof(DbKeyAttribute) 
    //							 select new { Property = prop, Attribute = (DbKeyAttribute)attribute }).SingleOrDefault();

    //	return (field == null) 
    //		? null 
    //		: new Decoration<DbKeyAttribute> {Attribute = field.Attribute, Property = field.Property};
    //}	
    public TypeAccessor _Accessor => _accessor;

    public List<string> _Properties => _properties;
 
  }
}
