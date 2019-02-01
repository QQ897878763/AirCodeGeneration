using Air.CodeGeneration.Common;
using Air.T4;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirCodeGeneration
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RegisterIOC();
            Application.Run(new FrmMain());
        }


        static void RegisterIOC()
        {
            //实例化Autofac容器
            var builder = new ContainerBuilder();
            //Autofac注册对象
            List<Assembly> assemblies = new List<Assembly>();
            //获取程序依赖的程序集名称集合
            var assemblyNameLst = Assembly.GetEntryAssembly().GetReferencedAssemblies();
            //循环程序集名称集合，加载这些程序集
            foreach (var assName in assemblyNameLst)
            {
                if (assName.Name.StartsWith("Air"))
                    assemblies.Add(Assembly.Load(assName));
            }
            AutofacConfig.RegisterObj(builder, assemblies);
        }

    }
}
