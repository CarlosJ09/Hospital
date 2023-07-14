using Microsoft.EntityFrameworkCore;
using CapaEntidad_CORE_USER.Models;
using System.Data;
using System.Net;

namespace hospital.integracion.Data
{
    public class CoreAPIDbContext : DbContext
    {
        public CoreAPIDbContext(DbContextOptions<CoreAPIDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autorizacion>().HasKey(x => x.ID_Autorizacion);

            modelBuilder.Entity<Cuentas>().HasKey(x => x.ID_Cuenta);

            modelBuilder.Entity<DeAlta>().HasKey(x => x.ID_Alta);

            modelBuilder.Entity<Ingreso>().HasKey(x => x.ID_ingreso);
        }

        public virtual DbSet<Autorizacion> Autorizacion { get; set; }

        public virtual DbSet<Cuentas> Cuentas { get; set; }

        public virtual DbSet<DeAlta> DeAlta { get; set; }

        public virtual DbSet<Ingreso> Ingreso { get; set; }
    }
}
