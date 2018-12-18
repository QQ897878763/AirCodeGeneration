using Air.CodeGeneration.Data.Attribute;
using System;
using System.Collections.Generic;
using System.Text;

namespace Air.CodeGeneration.Data.Model
{
    /// <summary>
    /// 数据库表信息
    /// </summary>
    [Serializable]
    public class DatabaseTable
    {
        /// <summary>
        /// 数据表名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 字段集合
        /// </summary>
        public List<DatabaseTableField> FieldItems { get; set; }

        /// <summary>
        /// 字段规格集合
        /// </summary>
        public List<DataBaseFieldRuleAttribute> FieldRuleItems { get; set; }
    }
     
}
