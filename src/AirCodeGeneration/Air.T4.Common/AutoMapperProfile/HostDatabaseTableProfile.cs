using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Air.T4.Common.AutoMapperProfile
{
    public class HostDatabaseTableProfile : Profile
    {
        public HostDatabaseTableProfile()
        {
            CreateMap<Air.Data.Core.Model.DatabaseTable, Air.T4.Common.Model.Database.HostDatabaseTable>();
            CreateMap<Air.Data.Model.DatabaseTable, Air.T4.Common.Model.Database.HostDatabaseTable>();
        }
    }

    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new HostDatabaseTableProfile());
            });
        }
    }

}
