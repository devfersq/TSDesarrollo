using System.Collections.Generic;

namespace Almacen.Data.ModelReporting
{
    public class OrdenMovimientoDTO
    {
        public List<OrdenMovimientoHeader> Header { get; set; }
        public List<OrdenMovimientoDetail> Details { get; set; }
    }

    public class OrdenMovimientoHeader
    {
        public string Cliente { get; set; }
        public string Fecha { get; set; }
        public string Folio { get; set; }
        public string Sucursal { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }

    public class OrdenMovimientoDetail
    {
        public decimal Cantidad { get; set; }
        public string Producto { get; set; }
        public string Grupo { get; set; }
        public string Descripcion { get; set; }
        public string Proveedores { get; set; }
    }
}
