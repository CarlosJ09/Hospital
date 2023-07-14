using Microsoft.EntityFrameworkCore;

namespace hospital.integracion.Data
{
    public class CoreAPIDbContext : DbContext
    {
        public CoreAPIDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
