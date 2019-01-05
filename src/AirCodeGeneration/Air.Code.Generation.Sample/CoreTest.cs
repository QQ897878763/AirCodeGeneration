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
        [DataBaseFieldRule(DataType = "Varchar(20)", Constraint = "Not Null", Sort = 3)]
        public string Name { get; set; }

        [DataBaseFieldRule(DataType = "Int", Constraint = "Not Null", DefaultValue = "0", Sort = 4)]
        public bool IsDelete { get; set; }

        [DataBaseFieldRule(DataType = "DateTime", Constraint = "Not Null", DefaultValue = "GetDate()", Sort = 5)]
        public DateTime CreateTime { get; set; }

        [DataBaseFieldRule(DataType = "Int", IdentityValue = "Identity(1,1)", IsPramaryKey = true, Remark = "主键", Sort = 1)]
        public int Id { get; set; }

        [DataBaseFieldRule(DataType = "Int", Constraint = "Not Null", Remark = "编码", Sort = 2)]
        public int Code { get; set; }

    }
}
