using System.Collections.Generic;

namespace Almacen.Data.ModelReporting
{
    public class CobranzaBodegaDTO
    {
        public List<CobranzaBodegaHeader> Header { get; set; }
        public List<CobranzaBodegaDetail> Details { get; set; }
    }

    public class CobranzaBodegaHeader
    {
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public string Fecha { get; set; }
    }

    public class CobranzaBodegaDetail
    {
        public string Sucursal { get; set; }
        public string Orden { get; set; }
        public decimal Cantidad { get; set; }
    }
}
