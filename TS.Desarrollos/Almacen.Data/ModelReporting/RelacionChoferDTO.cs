using System.Collections.Generic;

namespace Almacen.Data.ModelReporting
{
    public class RelacionChoferDTO
    {
        public List<RelacionChoferHeader> Header { get; set; }
        public List<RelacionChoferDeatils> Details { get; set; }
    }

    public class RelacionChoferHeader
    {
        public string Folio { get; set; }
        public string Ruta { get; set; }
        public string Fecha { get; set; }
        public string Chofer { get; set; }
    }

    public class RelacionChoferDeatils
    {
        public string Orden { get; set; }
        public string Tipo { get; set; }
        public string Sucursal { get; set; }
        public string ACobrar { get; set; }
        public string Entregado { get; set; }
    }
}
