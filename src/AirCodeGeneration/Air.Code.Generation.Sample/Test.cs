using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Air.Data.Attribute;

namespace Air.Code.Generation.Sample
{
    [DataBaseTableRule(IsCreateGnore = false)]
    public class Test
    {

        [DataBaseFieldRule(DataType = "Int", IsPramaryKey = true)]
        public Guid Id { get; set; }

        [DataBaseFieldRule(DataType = "Int", IdentityValue = "Identity(1,1)", Constraint = "Not Null")]
        public int Code { get; set; }

        [DataBaseFieldRule(DataType = "Varchar(20)", Constraint = "Not Null")]
        public string Name { get; set; }

        [DataBaseFieldRule(DataType = "Int", Constraint = "Not Null", DefaultValue = "0")]
        public bool IsDelete { get; set; }

        [DataBaseFieldRule(DataType = "DateTime", Constraint = "Not Null", DefaultValue = "GetDate()")]
        public DateTime CreateTime { get; set; }
    }
}
