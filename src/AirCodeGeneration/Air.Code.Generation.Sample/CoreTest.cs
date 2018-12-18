using Air.CodeGeneration.Data.Core.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Air.Code.Generation.Sample
{
    /// <summary>
    /// Air.Data.Core.Attribute特性方式测试(.NET Standard 2.0平台)
    /// </summary>
    [DataBaseTableRule(IsCreateGnore = false)]
    public class CoreTest
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
