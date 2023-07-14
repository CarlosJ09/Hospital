using hospital.webApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;



namespace hospital.integracion.Data
{
    public class WebAPIDbContext : DbContext
    {
        public WebAPIDbContext(DbContextOptions<WebAPIDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasKey(x => x.IdCliente);
            modelBuilder.Entity<Cita>().HasKey(x => x.IdCita);
            modelBuilder.Entity<Transaccion>().HasKey(x => x.IdFactura);
        }

        public virtual DbSet<Cita> Cita { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Transaccion> Transaccion { get; set; }

    }
}
