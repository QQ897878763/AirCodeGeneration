using System;
using System.Collections.Generic;
using System.Text;

namespace Air.CodeGeneration.Data.Core.Dto
{
    /// <summary>
    /// 类型反射DTO
    /// </summary>
    public class TypeReflectDto
    {
        /// <summary>
        /// 类型名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 字段长度
        /// </summary>
        public string FieldCount { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 是否选中 
        /// 默认选中
        /// </summary>
        public bool IsSel { get; set; }
    }
}
