using Microsoft.EntityFrameworkCore;

namespace Interfaces.UI.Data
{
    public class InterfacesUIContext : DbContext
    {
        public InterfacesUIContext(DbContextOptions<InterfacesUIContext> options)
            : base(options)
        {
        }

        public DbSet<Almacen.Data.VModels.VMRutaEntrega> VMRutaEntrega { get; set; }
    }
}
