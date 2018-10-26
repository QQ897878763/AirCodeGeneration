using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Air.Currency.Library
{
    /// <summary>
    /// 转换工具
    /// </summary>
    public static class Convertor
    {
        /// <summary>
        /// 传入对象，返回一个对象
        /// </summary>
        /// <param name="ToStringStr">参考的Object对象</param>
        /// <param name="Str">需要返回的对象，如果第一个参数不为空设置为NUll则返回该对象原有值，否则返回""</param>
        /// <returns>返回一个string类型的值</returns>
        public static string IsNull(Object ToStringStr, string Str)
        {
            try
            {
                if (ToStringStr != null && !string.IsNullOrWhiteSpace(ToStringStr.ToString())) //如果对象不为空
                {
                    if (Str != null)//如果设置了为空返回值
                    {
                        return ToStringStr.ToString();
                    }
                }
                else//对象为空
                {
                    if (Str == null)
                    {
                        return "";
                    }
                    else if (Str != null)
                    {
                        return Str;
                    }
                }
            }
            catch (Exception ea)
            {
                throw new Exception("Convertor.IsNull出现错误!原因:" + ea.ToString());
            }
            return ToStringStr.ToString();
        }
        /// <summary>
        /// 字符串为空时转换的值
        /// </summary>
        /// <param name="ToStr">原字符串</param>
        /// <param name="str">原字符串为空时转成指定字符串</param>
        /// <returns></returns>
        public static string IsEmpty(string ToStr, string str)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ToStr))
                    return str;
                else
                    return ToStr;
            }
            catch (Exception ea)
            {
                throw new Exception("Convertor.IsEmpty出现错误!原因:" + ea.ToString());
            }
        }

        /// <summary>  
        /// 泛型数据类型转换  
        /// </summary>  
        /// <typeparam name="T">自定义数据类型</typeparam>  
        /// <param name="value">传入需要转换的值</param>  
        /// <param name="defaultValue">默认值</param>  
        /// <returns></returns>  
        public static T ConvertType<T>(object value, T defaultValue)
        {
            try
            {
                return (T)ConvertToT<T>(value, defaultValue);
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>  
        /// 转换数据类型  
        /// </summary>  
        /// <typeparam name="T">自定义数据类型</typeparam>  
        /// <param name="myvalue">传入需要转换的值</param>  
        /// <param name="defaultValue">默认值</param>  
        /// <returns></returns>  
        private static object ConvertToT<T>(object myvalue, T defaultValue)
        {
            TypeCode typeCode = Type.GetTypeCode(typeof(T));
            if (myvalue != null)
            {
                string value = Convert.ToString(myvalue);
                switch (typeCode)
                {
                    case TypeCode.Boolean:
                        bool flag = false;
                        if (bool.TryParse(value, out flag))
                        {
                            return flag;
                        }
                        break;
                    case TypeCode.Char:
                        char c;
                        if (Char.TryParse(value, out c))
                        {
                            return c;
                        }
                        break;
                    case TypeCode.SByte:
                        sbyte s = 0;
                        if (SByte.TryParse(value, out s))
                        {
                            return s;
                        }
                        break;
                    case TypeCode.Byte:
                        byte b = 0;
                        if (Byte.TryParse(value, out b))
                        {
                            return b;
                        }
                        break;
                    case TypeCode.Int16:
                        Int16 i16 = 0;
                        if (Int16.TryParse(value, out i16))
                        {
                            return i16;
                        }
                        break;
                    case TypeCode.UInt16:
                        UInt16 ui16 = 0;
                        if (UInt16.TryParse(value, out ui16))
                            return ui16;
                        break;
                    case TypeCode.Int32:
                        int i = 0;
                        if (Int32.TryParse(value, out i))
                        {
                            return i;
                        }
                        break;
                    case TypeCode.UInt32:
                        UInt32 ui32 = 0;
                        if (UInt32.TryParse(value, out ui32))
                        {
                            return ui32;
                        }
                        break;
                    case TypeCode.Int64:
                        Int64 i64 = 0;
                        if (Int64.TryParse(value, out i64))
                        {
                            return i64;
                        }
                        break;
                    case TypeCode.UInt64:
                        UInt64 ui64 = 0;
                        if (UInt64.TryParse(value, out ui64))
                            return ui64;
                        break;
                    case TypeCode.Single:
                        Single single = 0;
                        if (Single.TryParse(value, out single))
                        {
                            return single;
                        }
                        break;
                    case TypeCode.Double:
                        double d = 0;
                        if (Double.TryParse(value, out d))
                        {
                            return d;
                        }
                        break;
                    case TypeCode.Decimal:
                        decimal de = 0;
                        if (Decimal.TryParse(value, out de))
                        {
                            return de;
                        }
                        break;
                    case TypeCode.DateTime:
                        DateTime dt;
                        if (DateTime.TryParse(value, out dt))
                        {
                            return dt;
                        }
                        break;
                    case TypeCode.String:
                        if (!string.IsNullOrEmpty(value))
                        {
                            return value.ToString();
                        }
                        break;
                }
            }

            return defaultValue;
        }
    }

    /// <summary>
    /// 转换类型工具
    /// </summary>
    /// <typeparam name="T">需转换成的对象类型</typeparam>
    public static class ConvertGeneric<T> where T : new()
    {

        /// <summary>  
        /// 利用反射和泛型  
        /// </summary>  
        /// <param name="dt"></param>  
        /// <returns></returns>
        public static List<T> ConvertDtToList(DataTable dt)
        {
            try
            {
                // 定义集合  
                List<T> ts = new List<T>();

                // 获得此模型的类型  
                Type type = typeof(T);
                //定义一个临时变量  
                string tempName = string.Empty;
                //遍历DataTable中所有的数据行  
                foreach (DataRow dr in dt.Rows)
                {
                    T t = new T();
                    // 获得此模型的公共属性  
                    PropertyInfo[] propertys = t.GetType().GetProperties();
                    //遍历该对象的所有属性  
                    foreach (PropertyInfo pi in propertys)
                    {
                        tempName = pi.Name;//将属性名称赋值给临时变量  
                        //检查DataTable是否包含此列（列名==对象的属性名）    
                        if (dt.Columns.Contains(tempName))
                        {
                            // 判断此属性是否有Setter  
                            if (!pi.CanWrite) continue;//该属性不可写，直接跳出  
                            //取值  
                            object value = dr[tempName];
                            //如果非空，则赋给对象的属性  
                            if (value != DBNull.Value)
                                pi.SetValue(t, value, null);
                        }
                    }
                    //对象添加到泛型集合中  
                    ts.Add(t);
                }

                return ts;
            }
            catch (Exception ea)
            {
                throw new Exception("ConvertDtToList函数异常!原因:" + ea.Message);
            }

        }

        /// <summary>
        /// 将集合类转换成DataTable
        /// </summary>
        /// <param name="list">集合</param>
        /// <returns></returns>
        public static DataTable ConvertToDataTable(IList<T> list)
        {
            try
            {
                DataTable result = new DataTable();
                if (list.Count > 0)
                {
                    PropertyInfo[] propertys = list[0].GetType().GetProperties();
                    foreach (PropertyInfo pi in propertys)
                    {
                        result.Columns.Add(pi.Name, pi.PropertyType);
                    }

                    for (int i = 0; i < list.Count; i++)
                    {
                        ArrayList tempList = new ArrayList();
                        foreach (PropertyInfo pi in propertys)
                        {
                            object obj = pi.GetValue(list[i], null);
                            tempList.Add(obj);
                        }
                        object[] array = tempList.ToArray();
                        result.LoadDataRow(array, true);
                    }
                }
                return result;

            }
            catch (Exception ea)
            {
                throw ea;
            }
        }

    }
}
