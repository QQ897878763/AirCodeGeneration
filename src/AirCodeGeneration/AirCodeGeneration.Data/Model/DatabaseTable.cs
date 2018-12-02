using System;
using System.Collections.Generic;
using System.Text;

namespace AirCodeGeneration.Data.Model
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
    }
     
}
