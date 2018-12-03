using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Air.Currency.Library;

namespace Air.CodeGeneration.Common
{

    public class ReflectHandler
    {
        /// <summary>
        /// 获取类型
        /// </summary>
        /// <param name="assemblyPath"></param>
        /// <returns></returns>
        public static List<Type> GetTypeList(string assemblyPath)
        {

            var assembly = Assembly.LoadFrom(assemblyPath);
            var models = assembly.GetTypes().Where(t =>
                      t.IsClass
                      && t.IsPublic
                      && (!t.IsAbstract)).ToList();
            return models;
        }

 
    }
}
