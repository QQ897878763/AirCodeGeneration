using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air.T4.Common.Model.Database
{
    /// <summary>
    /// 数据库表字段信息
    /// </summary>
    [Serializable]
    public class HostDatabaseTableField
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
