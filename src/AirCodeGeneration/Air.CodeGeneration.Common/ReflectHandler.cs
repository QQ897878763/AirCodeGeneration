using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Data;
using AirCodeGeneration.Data.Dto;
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
                      && (!t.IsAbstract) && t.GetAttribute<DisplayAttribute>() != null).ToList();
            return models;
        }

        /// <summary>
        /// 获取反射DLL后的类型集合DataTable
        /// </summary>
        /// <param name="assemblyPath">字符集路径</param>
        /// <returns></returns>
        public static DataTable GetTypeDataTable(string assemblyPath)
        {
            DataTable dt = new DataTable();
            List<Type> lst = GetTypeList(assemblyPath);
            List<TypeReflectDto> lstDto = new List<TypeReflectDto>();
            for (int i = 0; i < lst.Count; i++)
            {
                TypeReflectDto item = new TypeReflectDto();
                item.Sort = i + 1;
                item.Name = lst[i].Name;
                item.FieldCount = lst[i].GetFields().Where(p => p.IsPublic && !p.IsStatic).Count().ToString();
                item.IsSel = true;
                lstDto.Add(item);
            }
            if (lstDto != null && lstDto.Count > 1)
            {
                lstDto.Add(new TypeReflectDto()
                {
                    FieldCount = "",
                    IsSel = true,
                    Sort = lstDto.Count + 1,
                    Name = "全选"
                });
            }

            dt = lstDto.ToDataTable();
            return dt;
        }
    }
}
