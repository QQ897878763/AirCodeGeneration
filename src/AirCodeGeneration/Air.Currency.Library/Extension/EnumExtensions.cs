using System;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using AspectCore.Extensions.Reflection;

namespace Air.Currency.Library.Extension
{
    /// <summary>
    /// 枚举扩展方法
    /// </summary>
    public static partial class EnumExtensions
    {
        /// <summary>
        /// 获取显示名
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetEnumMemberDisplayName(this Enum value)
        {
            Type enumType = value.GetType();
            return enumType.GetEnumMemberDisplayName(value);
        }

        private static string GetEnumMemberDisplayName(this Type enumType, object value)
        {
            var enumName = Enum.GetName(enumType, value);
            var members = enumType.GetMember(enumName);
            MemberInfo member = null;
            if (members.Length > 0)
                member = members[0];
            else
                return value.ToString();

            var attrs = member.GetCustomAttributes(typeof(DisplayAttribute), true);
            if (attrs.Length == 0)
            {
                return value.ToString();
            }
            var outString = ((DisplayAttribute)attrs[0]).Name;
            if (((DisplayAttribute)attrs[0]).ResourceType != null)
            {
                outString = ((DisplayAttribute)attrs[0]).GetName();
            }

            return outString;
        }



        public static IDictionary<string, int> GetDictionary(this Enum theEnum)
        {
            Type enumType = theEnum.GetType();
            return enumType.GetEnumDictionary();
        }

        public static IDictionary<string, int> GetEnumDictionary(this Type type)
        {
            var names = Enum.GetNames(type);
            var dic = new Dictionary<string, int>();
            foreach (var name in names)
            {
                var value = (int)Enum.Parse(type, name);
                dic.Add(name, value);
            }
            return dic;
        }

        public static IDictionary<string, int> GetEnumDiplayDictionary(this Type type)
        {
            var names = Enum.GetNames(type);
            var dic = new Dictionary<string, int>();
            foreach (var name in names)
            {
                var value = (int)Enum.Parse(type, name);
                var displayName = type.GetEnumMemberDisplayName(value);
                dic.Add(displayName, value);
            }
            return dic;
        }
    }
}
