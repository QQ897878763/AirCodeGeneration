using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air.T4.Common.Model.Database
{
    /// <summary>
    /// 数据库表信息
    /// </summary>
    [Serializable]
    public class HostDatabaseTable
    {
        /// <summary>
        /// 数据表名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 字段集合
        /// </summary>
        public List<HostDatabaseTableField> FieldItems { get; set; }

        /// <summary>
        /// 字段规格集合
        /// </summary>
        public List<HostDataBaseFieldRuleAttribute> FieldRuleItems { get; set; }
    }
}
