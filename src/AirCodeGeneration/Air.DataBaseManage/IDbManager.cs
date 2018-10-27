using Air.DataBaseManage.Dto;
using System;

namespace Air.DataBaseManage
{
    public interface IDbManager
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        string ConnectString { get; }

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool ConnectDataBase(DbConnectInput input);


    }
}
