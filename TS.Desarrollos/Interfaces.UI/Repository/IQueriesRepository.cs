using Almacen.Data.ModelReporting;
using System;
using System.Threading.Tasks;

namespace Interfaces.UI.Repository
{
    public interface IQueriesRepository
    {
        #region Reporting Queries
        Task<RelacionChoferDTO> GetRelacionChoferInfo(int folio);
        Task<DiarioBodegaDTO> GetDiarioBodegaInfo(DateTime desde, DateTime hasta);
        Task<CobranzaBodegaDTO> GetCobranzaBodegaInfo(DateTime desde, DateTime hasta);
        Task<OrdenEntregaDTO> GetOrdenEntregaInfo(int folio, string tipo, int sucursal);
        Task<OrdenMovimientoDTO> GetOrdenMovimientoInfo(int folio, string tipo, int sucursal);
        Task<OrdenDevolucionDTO> GetOrdenDevolucionInfo(int folio, string tipo, int sucursal);
        #endregion
    }
}
