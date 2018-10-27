using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AirCodeGeneration.Common
{
    public static class TypeExtensions
    {
        public static List<T> GetAttribute<T>(this Type type) where T : Attribute
        {
            return type.GetCustomAttributes<T>().ToList();
        }
    }
}
