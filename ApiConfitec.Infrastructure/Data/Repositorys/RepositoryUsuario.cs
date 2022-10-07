using ApiConfitec.Domain.Core.Interfaces.Repositorys;
using ApiConfitec.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiConfitec.Infrastructure.Data.Repositorys
{
    public class RepositoryUsuario : RepositoryBase<Usuario>, IRepositoryUsuario
    {
        private readonly SqlContext sqlContext;
        public RepositoryUsuario(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
