using AspNetCore.Reporting;
using Interfaces.UI.Repository;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using Almacen.Data.ModelReporting;
using System.Linq;

namespace Interfaces.UI.Builder
{
    public class ReportBuilder
    {
        #region Properties
        public int ReportId { get; private set; }
        public int RenderTypeId { get; private set; }
        public string Folio { get; private set; }
        public string Tipo { get; private set; }
        public string Sucursal { get; private set; }
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaFin { get; private set; }
        #endregion

        #region Static
        private readonly string mimtype = "";
        private readonly int extension = 1;

        private IWebHostEnvironment _webHostEnvironment;
        private IQueriesRepository _queriesRepo;
        #endregion

        #region Ctor
        public ReportBuilder(int reportId, int renderType, string folio)
        {
            ReportId = reportId;
            RenderTypeId = renderType;
            Folio = folio;
        }

        public ReportBuilder(int reportId, int renderType, string folio, string tipo, string sucursal)
        {
            ReportId = reportId;
            RenderTypeId = renderType;
            Folio = folio;
            Tipo = tipo;
            Sucursal = sucursal;
        }

        public void DefineRangeDates(DateTime desde, DateTime hasta)
        {
            FechaInicio = desde;
            FechaFin = hasta;
        }

        public void UseHost(IWebHostEnvironment webHostEnvironment) => _webHostEnvironment = webHostEnvironment;
        public void UseRepo(IQueriesRepository query) => _queriesRepo = query;
        #endregion

        internal async Task<ReportResult> Build()
        {
            //AspNetCore.Report.ReportViewer report = new AspNetCore.Report.ReportViewer();
            LocalReport localReport = new LocalReport(GetUrlReport());
            await BindData(localReport);
            return localReport.Execute((RenderType)RenderTypeId, extension, null, mimtype);
        }

        #region Internal
        private string GetUrlReport() => $"{_webHostEnvironment.WebRootPath}\\Reports\\{GetReportName()}";
        private string GetReportName()
        {
            switch (ReportId)
            {
                case 1: return "RelacionChofer.rdlc";
                case 2: return "DiarioBodega.rdlc";
                case 3: return "CobranzaBodega.rdlc";
                case 4: return "OrdenEntrega.rdlc";
                case 5: return "OrdenMovimiento.rdlc";
                case 6: return "OrdenDevolucion.rdlc";
            }
            return string.Empty;
        }
        public string GetApplication()
        {
            var fileType = string.Empty;
            switch (RenderTypeId)
            {
                case 0: fileType = "word"; break;
                case 1: fileType = "wordopenxml"; break;
                case 2: fileType = "excel"; break;
                case 3: fileType = "excelopenxml"; break;
                case 4: fileType = "pdf"; break;
                case 5: fileType = "image"; break;
                case 6: fileType = "html"; break;
                case 7: fileType = "rpl"; break;
                default: fileType = "pdf"; break;
            }
            return $"application/{fileType}";
        }
        private async Task BindData(LocalReport localReport)
        {
            switch (ReportId)
            {
                case 1:
                    await GetRelacionChoferData(localReport);
                    break;

                case 2:
                    await GetDiarioBodegaData(localReport);
                    break;

                case 3:
                    await GetCobranzaBodegaData(localReport);
                    break;

                case 4:
                    await GetOrdenEntregaData(localReport);
                    break;

                case 5:
                    await GetOrdenMovimientoData(localReport);
                    break;

                case 6:
                    await GetOrdenDevolucionData(localReport);
                    break;
            }
        }
        private async Task GetRelacionChoferData(LocalReport localReport)
        {
            var data = await _queriesRepo.GetRelacionChoferInfo(Convert.ToInt32(Folio));
            localReport.AddDataSource("Header", data.Header);
            localReport.AddDataSource("Details", data.Details);
        }
        private async Task GetDiarioBodegaData(LocalReport localReport)
        {
            var data = await _queriesRepo.GetDiarioBodegaInfo(FechaInicio, FechaFin);
            localReport.AddDataSource("Header", data.Header);
            localReport.AddDataSource("Details", data.Details);
        }
        private async Task GetCobranzaBodegaData(LocalReport localReport)
        {
            var data = await _queriesRepo.GetCobranzaBodegaInfo(FechaInicio, FechaFin);
            localReport.AddDataSource("Header", data.Header);
            localReport.AddDataSource("Details", data.Details);
        }
        private async Task GetOrdenEntregaData(LocalReport localReport)
        {
            var data = await _queriesRepo.GetOrdenEntregaInfo(Convert.ToInt32(Folio), Tipo, Convert.ToInt32(Sucursal));
            var urlImage = $"{_webHostEnvironment.WebRootPath}\\Images\\{data.Header.First().LogoEmpresa}";
            Image img = Image.FromFile(urlImage);
            var imagesList = new List<OrdenEntregaImages>() { new OrdenEntregaImages { LogoEmpresa = ImageToByteArray(img) } };
            localReport.AddDataSource("Header", data.Header);
            localReport.AddDataSource("Subsidiary", data.Subsidiary);
            localReport.AddDataSource("Customer", data.Customer);
            localReport.AddDataSource("Details", data.Details);
            localReport.AddDataSource("Images", imagesList);
        }
        private async Task GetOrdenMovimientoData(LocalReport localReport)
        {
            var data = await _queriesRepo.GetOrdenMovimientoInfo(Convert.ToInt32(Folio), Tipo, Convert.ToInt32(Sucursal));
            localReport.AddDataSource("Header", data.Header);
            localReport.AddDataSource("Details", data.Details);
        }
        private async Task GetOrdenDevolucionData(LocalReport localReport)
        {
            var data = await _queriesRepo.GetOrdenDevolucionInfo(Convert.ToInt32(Folio), Tipo, Convert.ToInt32(Sucursal));
            localReport.AddDataSource("Header", data.Header);
            localReport.AddDataSource("Details", data.Details);
        }
        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        #endregion
    }
}
