using System;
using System.Collections.Generic;
using AutoMapper;
using Autofac;

namespace Air.CodeGeneration.Common
{
    //public class MapperInstaller : Module
    //{
    //    protected override void Load(ContainerBuilder builder)
    //    {
    //        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
    //        builder.RegisterAssemblyTypes(assemblies)
    //            .Where(t => typeof(Profile).IsAssignableFrom(t) && !t.IsAbstract && t.IsPublic)
    //            .As<Profile>();

    //        builder.Register(c => new MapperConfiguration(cfg =>
    //        {
    //            foreach (var profile in c.Resolve<IEnumerable<Profile>>())
    //            {
    //                cfg.AddProfile(profile);
    //            }
    //        })).AsSelf().SingleInstance();

    //        builder.Register(c => c.Resolve<MapperConfiguration>()
    //            .CreateMapper(c.Resolve))
    //            .As<IMapper>()
    //            .InstancePerLifetimeScope();
    //    }
    //}
}
