using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using AutoMapper;

namespace Air.CodeGeneration.Common
{
    public class AutofacConfig
    {

        ///// <summary>
        ///// Scan all referenced assemblies to retrieve all `Profile` types.
        ///// </summary>
        ///// <returns>A collection of <see cref="AutoMapper.Profile"/> types.</returns>
        //private static List<Type> RetrieveProfiles()
        //{
        //    var assemblyNames = Assembly.GetExecutingAssembly().GetReferencedAssemblies()
        //        .Where(a => a.Name.StartsWith("Some"));
        //    var assemblies = assemblyNames.Select(an => Assembly.Load(an));
        //    var loadedProfiles = ExtractProfiles(assemblies);
        //    return loadedProfiles;
        //}

        private static List<Type> RetrieveProfiles(List<Assembly> assemblieLst)
        {
            var loadedProfiles = ExtractProfiles(assemblieLst);
            return loadedProfiles;
        }

        private static List<Type> ExtractProfiles(IEnumerable<Assembly> assemblies)
        {
            var profiles = new List<Type>();
            foreach (var assembly in assemblies)
            {
                var assemblyProfiles = assembly.ExportedTypes.Where(type => type.IsSubclassOf(typeof(Profile)));
                profiles.AddRange(assemblyProfiles);
            }
            return profiles;
        }


        public static List<Type> RegisterObj(ContainerBuilder builder, List<Assembly> assemblieLst)
        {
            var loadedProfiles = RetrieveProfiles(assemblieLst);
            builder.RegisterTypes(loadedProfiles.ToArray());
            return loadedProfiles;
            #region 注释代码
            //var assemblies = assemblieLst.ToArray();
            //builder.RegisterAssemblyTypes(assemblies)
            //    .Where(t => typeof(Profile).IsAssignableFrom(t) && !t.IsAbstract && t.IsPublic)
            //    .As<Profile>();

            //builder.Register(c => new MapperConfiguration(cfg =>
            //{
            //    foreach (var profile in c.Resolve<IEnumerable<Profile>>())
            //    {
            //        cfg.AddProfile(profile);
            //    }
            //})).AsSelf().SingleInstance();

            //builder.Register(c => c.Resolve<MapperConfiguration>()
            //    .CreateMapper(c.Resolve))
            //    .As<IMapper>()
            //    .InstancePerLifetimeScope();

            //// AutoMapper
            //// Register all the profiles
            //builder.RegisterAssemblyTypes().AssignableTo(typeof(Profile)).As<Profile>();
            //builder.Register(c => new MapperConfiguration(cfg =>
            //{
            //    //cfg.AddProfile(new AppProfile());
            //    foreach (var profile in c.Resolve<IEnumerable<Profile>>())
            //    {
            //        cfg.AddProfile(profile);
            //    }
            //})).AsSelf().SingleInstance();
            //builder.Register(c => c.Resolve<MapperConfiguration>()
            //    .CreateMapper(c.Resolve))
            //    .As<IMapper>()
            //    .InstancePerLifetimeScope();
            #endregion
        }

        //private static void SetAutofacContainer()
        //{
        //    var builder = new ContainerBuilder();

        //    builder.RegisterControllers(Assembly.GetExecutingAssembly());
        //    builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
        //    builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

        //    // Repositories
        //    builder.RegisterAssemblyTypes(typeof(TrainingRepository).Assembly)
        //        .Where(t => t.Name.EndsWith("Repository"))
        //        .AsImplementedInterfaces().InstancePerRequest();

        //    // Services
        //    builder.RegisterAssemblyTypes(typeof(CourseService).Assembly)
        //       .Where(t => t.Name.EndsWith("Service"))
        //       .AsImplementedInterfaces().InstancePerRequest();

        //    // AutoMapper
        //    // Register all the profiles
        //    builder.RegisterAssemblyTypes().AssignableTo(typeof(Profile)).As<Profile>();
        //    builder.Register(c => new MapperConfiguration(cfg =>
        //    {
        //        //cfg.AddProfile(new AppProfile());
        //        foreach (var profile in c.Resolve<IEnumerable<Profile>>())
        //        {
        //            cfg.AddProfile(profile);
        //        }
        //    })).AsSelf().SingleInstance();
        //    builder.Register(c => c.Resolve<MapperConfiguration>()
        //        .CreateMapper(c.Resolve))
        //        .As<IMapper>()
        //        .InstancePerLifetimeScope();

        //    IContainer container = builder.Build();
        //    DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        //}


        public static void RegisterAutoMapper(IContainer container, IEnumerable<Type> loadedProfiles)
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.ConstructServicesUsing(container.Resolve);
                foreach (var profile in loadedProfiles)
                {
                    var resolvedProfile = container.Resolve(profile) as Profile;
                    cfg.AddProfile(resolvedProfile);
                }
            });
        }

    }


}
