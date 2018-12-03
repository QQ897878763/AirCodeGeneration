﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Air.Data.Model;
using Air.T4.Common.Host;

namespace Air.T4.Common.Host
{
    /// <summary>
    /// 数据库T4模板服务Host
    /// </summary>
    [Serializable]
    public class DataBaseHost : BaseHost
    {
        /// <summary>
        /// 数据库信息
        /// </summary>
        public readonly Database Database;

        public DataBaseHost(Database database)
        {
            Database = database;

        }


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
                    "Air.T4.Common",
                    "Air.T4.Common.Host",
                    "Air.Data",
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
                    typeof(ParallelExecutionMode).Assembly.Location,
                    typeof(DataBaseHost).Assembly.Location,
                    typeof(Database).Assembly.Location,
                    typeof(List<>).Assembly.Location,
                };
            }
        }
    }
}
