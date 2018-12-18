using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Air.CodeGeneration.Data.Core.Attribute
{
    /// <summary>
    /// 数据库字段模型规则特性
    /// </summary>
    [Serializable]
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class DataBaseFieldRuleAttribute : System.Attribute
    {
        /// <summary>
        /// 字段名(这里默认写属性名称)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 进行数据库创建时候是否自动屏蔽
        /// </summary>
        public bool IsCreateGnore { get; set; }
 
        /// <summary>
        /// 是否为主键
        /// </summary>
        public bool IsPramaryKey { get; set; }

        /// <summary>
        /// 自增值 
        /// 如:identity(1,1)
        /// </summary>
        public string IdentityValue { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// 约束
        /// 如:Unique、NotNull
        /// </summary>
        public string Constraint { get; set; }


        /// <summary>
        /// 数据库备注信息
        /// </summary>
        public string Remark { get; set; }
    }


}
