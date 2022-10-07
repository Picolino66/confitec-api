using ApiConfitec.Domain.Core.Interfaces.Repositorys;
using ApiConfitec.Domain.Core.Interfaces.Services;
using ApiConfitec.Domain.Entitys;

namespace ApiConfitec.Domain.Services
{
    public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
    {
        private readonly IRepositoryUsuario repositoryUsuario;
        public ServiceUsuario(IRepositoryUsuario repositoryUsuario) : base(repositoryUsuario)
        {
            this.repositoryUsuario = repositoryUsuario;
        }
    }
}
