using System;
using System.Collections.Generic;
using System.Text;

namespace Air.CodeGeneration.Data.Model
{
    /// <summary>
    /// 数据库项目信息
    /// </summary>
    [Serializable]
    public class Database
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数据表集合
        /// </summary>
        public List<DatabaseTable> TableItems { get; set; }
    }
}
