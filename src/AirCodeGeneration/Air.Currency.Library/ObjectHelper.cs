using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Runtime.Serialization;
namespace Air.Currency.Library
{
    /// <summary>
    /// 对象工具
    /// </summary>
    public static class ObjectHelper
    {
        /// <summary>
        /// 获取属性的Display
        ///  //获取指定属性的特性值，如：  var displayAttr = property.GetAttribute<DisplayAttribute>(false);
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="provider"></param>
        /// <param name="inherit"></param>
        /// <returns></returns>
        public static T GetAttribute<T>(this ICustomAttributeProvider provider, bool inherit = false)
where T : Attribute
        {
            return provider
                .GetCustomAttributes(typeof(T), inherit)
                .OfType<T>()
                .FirstOrDefault();
        }
        /// <summary>
        /// 返回DbDataReader读取的对象集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dbDataReader"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private static List<T> CreateObject<T>(DbDataReader dbDataReader, Type type)
        {
            List<T> result = new List<T>();
            PropertyInfo[] properties = type.GetProperties();
            while (dbDataReader.Read())
            {
                T item = default(T);
                try
                {
                    item = Activator.CreateInstance<T>();
                }
                catch
                {
                    item = (T)FormatterServices.GetUninitializedObject(type);
                }

                for (int i = 0; i < dbDataReader.FieldCount; i++)
                {
                    string name = dbDataReader.GetName(i);

                    foreach (PropertyInfo propertyInfo in properties)
                    {
                        if (name.Equals(propertyInfo.Name) && dbDataReader[propertyInfo.Name] != null && dbDataReader[propertyInfo.Name].GetType() != typeof(DBNull))
                        {
                            propertyInfo.SetValue(item, Convert.ChangeType(dbDataReader[propertyInfo.Name], propertyInfo.PropertyType), null);
                            break;
                        }
                    }
                }
                result.Add(item);
            }
            return result;
        }
        /// <summary>
        /// 返回dbDataReader读取的对象集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dbDataReader"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private static List<T> CreateValue<T>(DbDataReader dbDataReader, Type type)
        {
            List<T> result = new List<T>();
            while (dbDataReader.Read())
            {
                T item = (T)Convert.ChangeType(dbDataReader[0], type, null);
                result.Add(item);
            }
            return result;
        }
        /// <summary>
        /// 返回dbDataReader读取的对象集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dbDataReader"></param>
        /// <returns></returns>
        public static List<T> ToList<T>(DbDataReader dbDataReader)
        {
            if (dbDataReader == null)
            {
                throw new ArgumentNullException("dbDataReader");
            }

            if (!dbDataReader.HasRows)
            {
                return null;
            }

            Type type = typeof(T);
            List<T> result = null;
            if (type.IsValueType || type == typeof(string))
            {
                result = CreateValue<T>(dbDataReader, type);
            }
            else
            {
                result = CreateObject<T>(dbDataReader, type);
            }
            return result;
        }

        /// <summary>
        /// 实体深拷贝扩展函数（重新创建一份独立的实体）
        /// </summary>
        /// <typeparam name="T">实体的类型</typeparam>
        /// <param name="entity">被拷贝的实体</param>
        /// <returns></returns>
        public static T DeepClone<T>(this T entity) where T : new()
        {
            var newEntity = default(T);
            var entityType = typeof(T);

            //得到新的对象对象
            newEntity = (T)Activator.CreateInstance(entityType);

            //给新的对象复制
            var lstProperties = entityType.GetProperties();
            foreach (var item in lstProperties)
            {
                //从旧对象里面取值
                var newValue = item.GetValue(entity, null);
                //复制给新的对象
                item.SetValue(newEntity, newValue, null);
            }

            return newEntity;
        }
    }
}
