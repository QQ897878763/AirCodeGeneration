using System;
using System.Collections.Generic;
using System.Text;

namespace Air.CodeGeneration.Data.Attribute
{
    /// <summary>
    /// 数据库数据表模型规则特性
    /// </summary>
    [Serializable]
    [AttributeUsage(AttributeTargets.Class)]
    public class DataBaseTableRuleAttribute : System.Attribute
    {
        /// <summary>
        /// 进行数据库创建时候是否自动屏蔽
        /// </summary>
        public bool IsCreateGnore { get; set; }
    }
}
