using hospital.Caja.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace hospital.integracion.Data
{
    public class CajaAPIDbContext : DbContext
    {
        public CajaAPIDbContext(DbContextOptions<CajaAPIDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENTE>().HasKey(x => x.Id_Cliente);

            modelBuilder.Entity<EMPLEADO>().HasKey(x => x.Id_Empleado);

            modelBuilder.Entity<FACTURA>().HasKey(x => x.Id_Factura);

            modelBuilder.Entity<MontoInicial>().HasKey(x => x.Id);

            modelBuilder.Entity<REPORTE>().HasKey(x => x.Id_Cliente);

            modelBuilder.Entity<SEGURO>().HasKey(x => x.Id_Seguro);

            modelBuilder.Entity<SERVICIOS>().HasKey(x => x.Id_Servicio);

        }

        public virtual DbSet<CLIENTE> CLIENTE { get; set; }

        public virtual DbSet<EMPLEADO> EMPLEADO { get; set; }

        public virtual DbSet<FACTURA> FACTURA { get; set; }

        public virtual DbSet<MontoInicial> MontoInicial { get; set; }

        public virtual DbSet<ppReporte_Result> ppReporte_Result { get; set; }

        public virtual DbSet<REPORTE> REPORTE { get; set; }

        public virtual DbSet<SEGURO> SEGURO { get; set; }

        public virtual DbSet<SERVICIOS> SERVICIOS { get; set; }

    }
}
