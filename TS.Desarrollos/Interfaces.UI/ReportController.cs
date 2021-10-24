using AspNetCore.Reporting;
using Interfaces.UI.Builder;
using Interfaces.UI.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.UI
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IQueriesRepository _queriesRepo;
        public ReportController(IWebHostEnvironment webHostEnvironment, IQueriesRepository queriesRepository)
        {
            _webHostEnvironment = webHostEnvironment;
            _queriesRepo = queriesRepository;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        [HttpGet]
        public async Task<IActionResult> GetOrdenMovimiento(int renderType, int folio, string tipo, int sucursal)
        {
            var data = await _queriesRepo.GetOrdenMovimientoInfo(folio, tipo, sucursal);
            string mimtype = "";
            int extension = 1;
            var reportName = "OrdenMovimiento.rdlc";
            var path = $"{_webHostEnvironment.WebRootPath}\\Reports\\";

            LocalReport localReport = new LocalReport($"{path}{reportName}");
            localReport.AddDataSource("Header", data.Header);
            localReport.AddDataSource("DataSet1", data.Details);

            var result = localReport.Execute(RenderType.Pdf, extension, null, mimtype);
            return await Task.FromResult(File(result.MainStream, "application/pdf"));
        }

        [HttpGet]
        public async Task<IActionResult> PrintReport(int idRep, int renderType, string folio, string tipo, string sucursal, string desde, string hasta)
        {
            var builder = new ReportBuilder(idRep, renderType, folio, tipo, sucursal);
            builder.DefineRangeDates(Convert.ToDateTime(desde), Convert.ToDateTime(hasta));
            builder.UseHost(_webHostEnvironment);
            builder.UseRepo(_queriesRepo);
            var report = await builder.Build();
            return File(report.MainStream, builder.GetApplication());
        }
    }
}
