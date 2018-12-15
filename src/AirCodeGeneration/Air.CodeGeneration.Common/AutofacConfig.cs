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


        public static void RegisterObj(ContainerBuilder builder, List<Assembly> assemblieLst)
        {
            var loadedProfiles = RetrieveProfiles(assemblieLst);
            builder.RegisterTypes(loadedProfiles.ToArray());
            ContainerManager.Container = builder.Build();
            RegisterAutoMapper(ContainerManager.Container, loadedProfiles);
        }

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
