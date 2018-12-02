using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air.Test
{
    public class Test
    {

        [Display(Description = "ID", GroupName = "Primary key")]
        public Guid Id { get; set; }

        [Display(GroupName = "identity(1,1)")]
        public int Code { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Name", Description = "名称", ShortName = "Varchar(20)")]
        public string Name_1 { get; set; }

        [Required]
        [Display(Name = "IsDelete", Description = "是否删除", ShortName = "int")]
        public bool IsDelete_1 { get; set; }


        [Display(Description = "创建时间", ShortName = "DateTime", GroupName = "getdate()")]
        public DateTime CreateTime { get; set; }

    }
}
