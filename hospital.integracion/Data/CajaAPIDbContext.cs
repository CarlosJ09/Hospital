using Microsoft.EntityFrameworkCore;
using System.Data;

namespace hospital.integracion.Data
{
    public class CajaAPIDbContext : DbContext
    {
        public class CLIENTES
        {
            public int Id_Cliente { get; set; }
            public string Nombre_Cliente { get; set; }
            public string Cedula_Cliente { get; set; }
            public int? Id_Seguro { get; set; }
            public string Poliza { get; set; }
            public string Telefono { get; set; }
        }
        public CajaAPIDbContext(DbContextOptions<CajaAPIDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENTES>().HasKey(x => x.Id_Cliente);
        }

        public virtual DbSet<CLIENTES> CLIENTE { get; set; }

    }
}
