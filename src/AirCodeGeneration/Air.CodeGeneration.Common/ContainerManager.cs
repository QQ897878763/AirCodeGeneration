using Autofac;
using Autofac.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air.CodeGeneration.Common
{
    /// <summary>
    /// 容器管理器
    /// </summary>
    [System.Runtime.InteropServices.ComVisible(true)]
    public static class ContainerManager
    {
        /// <summary>
        /// 容器
        /// </summary>
        public static Autofac.IContainer Container { get; set; }
        /// <summary>
        /// 获取实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static T Resolve<T>(IEnumerable<Parameter> parameters = null)
        {
            return parameters == null || parameters.Count() <= 0 ? Container.Resolve<T>() : Container.Resolve<T>(parameters);
        }
        public static T Resolve<T>(params Parameter[] parameters)
        {
            return parameters == null || parameters.Length <= 0 ? Container.Resolve<T>() : Container.Resolve<T>(parameters);
        }

        /// <summary>
        /// 根据接口的实现类名称，实例化对象
        /// </summary>
        /// <typeparam name="T">接口名称</typeparam>
        /// <param name="name">接口对应的实现类名称</param>
        /// <returns>实例化接口实现类的对象</returns>
        public static T ResolveNamed<T>(string name)
        {
            return Container.ResolveNamed<T>(name);
        }

    }
}
