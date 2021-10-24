using System.Collections.Generic;

namespace Almacen.Data.ModelReporting
{
    public class DiarioBodegaDTO
    {
        public List<DiarioBodegaHeader> Header { get; set; }
        public List<DiarioBodegaDetail> Details { get; set; }
    }

    public class DiarioBodegaHeader
    {
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public string Fecha { get; set; }
    }

    public class DiarioBodegaDetail
    {
        public string Sucursal { get; set; }
        public string Orden { get; set; }
    }
}
