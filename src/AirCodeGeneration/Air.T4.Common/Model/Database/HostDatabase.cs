using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Air.T4.Common.Model.Database
{
    /// <summary>
    /// 数据库项目信息
    /// </summary>
    [Serializable]
    public class HostDatabase
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数据表集合
        /// </summary>
        public List<HostDatabaseTable> TableItems { get; set; }
    
    }
}
