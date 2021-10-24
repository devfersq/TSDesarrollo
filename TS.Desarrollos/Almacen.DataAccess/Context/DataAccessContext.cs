using Microsoft.EntityFrameworkCore;

namespace Almacen.DataAccess.Context
{
    public class DataAccessContext : DbContext//, IDataAccessContext
    {
        public DataAccessContext(DbContextOptions<DataAccessContext> options) : base(options)
        {
        }

        //public async Task<OrdenMovimientoDTO> GetOrdenMovimientoInfo(int orden, string tipo, int sucursal)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
