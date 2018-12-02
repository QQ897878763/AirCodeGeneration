using System;

namespace AirCodeGeneration.Data.Attribute
{
    /// <summary>
    /// 数据库忽略创建
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class SqlCreateIsgnoreAttribute : System.Attribute
    {
    }
}
