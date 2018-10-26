using System;
using System.Collections.Generic;
using System.Text;

namespace Air.DataBaseManage.Dto
{
    /// <summary>
    /// 数据库
    /// </summary>
    public class DbConnectInput
    {
        /// <summary>
        /// 认证方式
        /// </summary>
        public DbAuthenticationTypeEnums AuthenticationType { get; set; }

        /// <summary>
        /// 数据库用户名
        /// </summary>
        public string DbUserName { get; set; }

        /// <summary>
        /// 数据库密码
        /// </summary>
        public string DbPassword { get; set; }

        /// <summary>
        /// 数据库连接地址
        /// </summary>
        public string IpAddress { get; set; }
    }

    /// <summary>
    /// 数据库认证方式
    /// </summary>
    public enum DbAuthenticationTypeEnums : int
    {
        /// <summary>
        /// windows用户方式
        /// </summary>
        WindowsUser = 1,
        /// <summary>
        /// 数据库用户方式
        /// </summary>
        DatabaseUser = 2
    }
}
