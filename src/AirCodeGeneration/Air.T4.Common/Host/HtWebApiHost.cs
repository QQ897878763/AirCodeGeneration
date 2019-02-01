using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Air.T4.Common.Host
{
    /// <summary>
    /// 后台WebAPI T4模板服务Host
    /// </summary>
    [Serializable]
    public class HtWebApiHost : BaseHost
    {
        /// <summary>
        /// 实体
        /// </summary>
        public readonly Type Entity;

        /// <summary>
        /// 命名空间
        /// </summary>
        public readonly string NameSpace;

        /// <summary>
        /// 类名
        /// </summary>
        public readonly string ClassName;
        public HtWebApiHost(Type entity, string nameSpace, string className)
        {
            NameSpace = nameSpace;
            Entity = entity;
            ClassName = className;
            var items = entity.GetProperties();

            for (int i = 0; i < items.Length; i++)
            {
                var item = items[i];
                string name = item.Name; //字段名称
                string type = item.PropertyType.Name;
                if (item.PropertyType.FullName.Contains("Nullable"))
                    type = string.Concat(item.PropertyType.GenericTypeArguments[0].Name, "?");
                if (item.PropertyType.FullName.Contains("Boolean"))
                    type = type.Replace("Boolean", "bool");
                if (!item.PropertyType.FullName.Contains("DateTime"))
                    type = type.Replace("Int64", "long").ToLower();
            }
        }

        //private void SetCreateInputItems(string assemPath)
        //{
        //    if (!instance.IsClass) return;
        //    PropertyInfo[] lstPropertys = instance.GetProperties();
        //    foreach (var item in lstPropertys)
        //    {
        //        string typeName = item.PropertyType.GetTypeInfo().FullName;
        //        string name = item.PropertyType.FullName;
        //    }
        //}


        public override object GetHostOption(string optionName)
        {
            object returnObject = null;
            //根据选项名称来获取数据
            switch (optionName)
            {
                case "CacheAssemblies":
                    returnObject = true;
                    break;
                default:
                    break;
            }
            return returnObject;
        }


        /// <summary>
        /// Gets the StandardImports
        /// 获取命名空间的列表。
        /// </summary>
        public override IList<string> StandardImports
        {
            get
            {
                return new string[]
                {
                    "System",
                    "System.IO",
                    "System.Linq",
                    "System.Text",
                    "System.Collections.Generic",
                    "System.Collections",
                    "Air.T4.Common",
                    "Air.T4.Common.Host",
                    "Air.T4.Common.Model.Database",

                };
            }
        }

        public override IList<string> StandardAssemblyReferences
        {
            get
            {
                return new string[]
                {
                    typeof(Uri).Assembly.Location,
                    typeof(BaseHost).Assembly.Location,
                    typeof(DataBaseCoreHost).Assembly.Location,
                    typeof(ParallelExecutionMode).Assembly.Location,
                    typeof(List<>).Assembly.Location,
                };
            }
        }
    }
}
