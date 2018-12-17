using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Air.Data.Attribute;


namespace Air.Code.Generation.Sample
{
    /// <summary>
    /// Air.Data.Attribute特性方式测试(.NET Framework平台)
    /// </summary>
    [DataBaseTableRule(IsCreateGnore = false)]
    public class FrameworkTest
    {
        [DataBaseFieldRule(DataType = "Int", IdentityValue = "Identity(1,1)", IsPramaryKey = true, Remark = "主键")]
        public int Id { get; set; }

        [DataBaseFieldRule(DataType = "Int", Constraint = "Not Null", Remark = "编码")]
        public int Code { get; set; }

        [DataBaseFieldRule(DataType = "Varchar(20)", Constraint = "Not Null")]
        public string Name { get; set; }

        [DataBaseFieldRule(DataType = "Int", Constraint = "Not Null", DefaultValue = "0")]
        public bool IsDelete { get; set; }

        [DataBaseFieldRule(DataType = "DateTime", Constraint = "Not Null", DefaultValue = "GetDate()")]
        public DateTime CreateTime { get; set; }
    }
}
