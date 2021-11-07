using System.Collections.Generic;

namespace Almacen.Data.ModelReporting
{
    public class OrdenDevolucionDTO
    {
        public List<OrdenDevolucionHeader> Header { get; set; }
        public List<OrdenDevolucionDetail> Details { get; set; }
    }

    public class OrdenDevolucionHeader
    {
        public string Folio { get; set; }
        public string OrigenNombre { get; set; }
        public string OrigenDireccion { get; set; }
        public string OrigenReferencia { get; set; }
        public string OrigenTelefono { get; set; }
        public string Destino { get; set; }
        public string Sucursal { get; set; }
        public string Cliente { get; set; }
        public string Fecha { get; set; }
    }

    public class OrdenDevolucionDetail
    {
        public string Producto { get; set; }
        public decimal Cantidad { get; set; }
        public string Grupo { get; set; }
        public string Descripcion { get; set; }
        public string Proveedores { get; set; }
    }
}
