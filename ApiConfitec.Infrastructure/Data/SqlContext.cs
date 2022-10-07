using ApiConfitec.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace ApiConfitec.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
