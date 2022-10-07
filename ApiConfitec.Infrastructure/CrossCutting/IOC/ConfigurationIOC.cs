using ApiConfitec.Application;
using ApiConfitec.Application.Interfaces;
using ApiConfitec.Application.Interfaces.Mappers;
using ApiConfitec.Application.Mapper;
using ApiConfitec.Domain.Core.Interfaces.Repositorys;
using ApiConfitec.Domain.Core.Interfaces.Services;
using ApiConfitec.Domain.Services;
using ApiConfitec.Infrastructure.Data.Repositorys;
using Autofac;

namespace ApiConfitec.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
            builder.RegisterType<ApplicationServiceUsuario>().As<IApplicationServiceUsuario>();
            builder.RegisterType<ServiceUsuario>().As<IServiceUsuario>();
            builder.RegisterType<RepositoryUsuario>().As<IRepositoryUsuario>();
            builder.RegisterType<MapperUsuario>().As<IMapperUsuario>();
            #endregion
        }
    }
}
