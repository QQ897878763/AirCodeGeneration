using System;
using System.Collections.Generic;
using System.Linq;

/**
如果要在 .NET Framework 4.5 和 .NET Core 1.0 上运行，可以使用的最高 .NET Standard 版本是 .NET Standard 1.1。 
*/
namespace Air.Currency.Library.Extension
{
    /// <summary>
    /// 集合通用扩展
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// 遍历处理指定的action函数
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="instance">当前枚举对象</param>
        /// <param name="action">处理函数</param>
        /// <returns>当前集合</returns>
        public static IEnumerable<T> Each<T>(this IEnumerable<T> instance, Action<T> action)
        {
            foreach (T item in instance)
            {
                action(item);
            }
            return instance;
        }

        /// <summary>
        /// 验证集合是否为空或长度为0
        /// </summary>
        /// <typeparam name="T">集合中的数据类型</typeparam>
        /// <param name="instance">当前枚举对象</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> instance)
        {
            if (instance == null) return true;
            if (instance.Count() <= 0) return true;
            return false;
        }

        /// <summary>
        /// 合并两个List数据交集
        /// </summary>
        /// <typeparam name="T">集合对象</typeparam>
        /// <param name="source">源集合</param>
        /// <param name="target">目标集合</param>
        /// <returns>返回源集合和目标集合共同存在的交集数据</returns>
        public static List<T> Merge<T>(this List<T> source, List<T> target)
        {
            List<T> mergedList = new List<T>(source);
            mergedList.AddRange(target.Except(source));
            return mergedList;
        }
    }
}
