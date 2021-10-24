using Almacen.Data.ModelReporting;
using System.Threading.Tasks;

namespace Interfaces.UI
{
    public interface IDataAccessContext
    {
        #region Reporting Data Sources
        Task<OrdenMovimientoDTO> GetOrdenMovimientoInfo(int orden, string tipo, int sucursal);
        #endregion
    }
}
