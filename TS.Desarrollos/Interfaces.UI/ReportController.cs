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
