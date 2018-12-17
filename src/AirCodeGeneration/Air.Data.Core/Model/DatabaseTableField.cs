using System;
using System.Collections.Generic;
using System.Text;

namespace Air.Data.Core.Model
{
    /// <summary>
    /// 数据库表字段信息
    /// </summary>
    [Serializable]
    public class DatabaseTableField
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 字段类型
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// 数据约束
        /// </summary>
        public string Constraint { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public string DefaultValue { get; set; }


        /// <summary>
        /// 字段备注
        /// </summary>
        public string Remark { get; set; }
    }



}
