using Almacen.Data.ModelReporting;
using Almacen.DataAccess;
using Almacen.DataAccess.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace Interfaces.UI.Repository
{
    public class QueriesRepository : IQueriesRepository
    {
        AlmacenContext _context = null;
        public QueriesRepository()
        {
            _context = new AlmacenContext(new Microsoft.EntityFrameworkCore.DbContextOptions<AlmacenContext>());
        }

        public async Task<RelacionChoferDTO> GetRelacionChoferInfo(int folio)
        {
            var dto = new RelacionChoferDTO();
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter() { ParameterName = "folio", SqlDbType = SqlDbType.BigInt, Value = folio }};
                var jsonDsets = _context.QueryMultipleResults(sql: "dbo.spRepRelacionChofer").ExecuteMultipleJsonResults(parameters, typeof(RelacionChoferHeader), typeof(RelacionChoferDeatils));
                dto.Header = JsonConvert.DeserializeObject<List<RelacionChoferHeader>>(jsonDsets[0]);
                dto.Details = JsonConvert.DeserializeObject<List<RelacionChoferDeatils>>(jsonDsets[1]);
            }
            catch (Exception ex)
            { }
            return await Task.FromResult(dto);
        }
        public async Task<DiarioBodegaDTO> GetDiarioBodegaInfo(DateTime desde, DateTime hasta)
        {
            var dto = new DiarioBodegaDTO();
            try
            {
                SqlParameter[] parameters = new SqlParameter[] 
                {
                    new SqlParameter() { ParameterName = "fechaInicio", SqlDbType = SqlDbType.Date, Value = desde },
                    new SqlParameter() { ParameterName = "fechaFin", SqlDbType = SqlDbType.Date, Value = hasta }
                };
                var jsonDsets = _context.QueryMultipleResults(sql: "dbo.spRepDiarioDeBodega").ExecuteMultipleJsonResults(parameters, typeof(DiarioBodegaHeader), typeof(DiarioBodegaDetail));
                dto.Header = JsonConvert.DeserializeObject<List<DiarioBodegaHeader>>(jsonDsets[0]);
                dto.Details = JsonConvert.DeserializeObject<List<DiarioBodegaDetail>>(jsonDsets[1]);
            }
            catch (Exception ex)
            { }
            return await Task.FromResult(dto);
        }
        public async Task<CobranzaBodegaDTO> GetCobranzaBodegaInfo(DateTime desde, DateTime hasta)
        {
            var dto = new CobranzaBodegaDTO();
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter() { ParameterName = "fechaInicio", SqlDbType = SqlDbType.Date, Value = desde },
                    new SqlParameter() { ParameterName = "fechaFin", SqlDbType = SqlDbType.Date, Value = hasta }
                };
                var jsonDsets = _context.QueryMultipleResults(sql: "dbo.spRepCobranzaDeBodega").ExecuteMultipleJsonResults(parameters, typeof(CobranzaBodegaHeader), typeof(CobranzaBodegaDetail));
                dto.Header = JsonConvert.DeserializeObject<List<CobranzaBodegaHeader>>(jsonDsets[0]);
                dto.Details = JsonConvert.DeserializeObject<List<CobranzaBodegaDetail>>(jsonDsets[1]);
            }
            catch (Exception ex)
            { }
            return await Task.FromResult(dto);
        }
        public async Task<OrdenMovimientoDTO> GetOrdenMovimientoInfo(int folio, string tipo, int sucursal)
        {
            var dto = new OrdenMovimientoDTO();
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter() { ParameterName = "folio", SqlDbType = SqlDbType.BigInt, Value = folio },
                new SqlParameter() { ParameterName = "tipo", SqlDbType = SqlDbType.VarChar, Value = tipo },
                new SqlParameter() { ParameterName = "sucursal", SqlDbType = SqlDbType.Int, Value = sucursal }
                };
                var jsonDsets = _context.QueryMultipleResults(sql: "dbo.spRepFormatoOrdenMovimiento").ExecuteMultipleJsonResults(parameters, typeof(OrdenMovimientoHeader), typeof(OrdenMovimientoDetail));
                dto.Header = JsonConvert.DeserializeObject<List<OrdenMovimientoHeader>>(jsonDsets[0]);
                dto.Details = JsonConvert.DeserializeObject<List<OrdenMovimientoDetail>>(jsonDsets[1]);
            }
            catch(Exception ex)
            { }
            return await Task.FromResult(dto);
        }
    }
}
