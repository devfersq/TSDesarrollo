using System.Collections.Generic;

namespace Almacen.Data.ModelReporting
{
    public class OrdenEntregaDTO
    {
        public List<OrdenEntregaHeader> Header { get; set; }
        public List<OrdenEntregaSubsidiary> Subsidiary { get; set; }
        public List<OrdenEntregaCustomer> Customer { get; set; }
        public List<OrdenEntregaDetail> Details { get; set; }
    }
    

    public class OrdenEntregaHeader
    {
        public string Cliente { get; set; }
        public string RFCCliente { get; set; }
        public string LogoEmpresa { get; set; }
        public string Folio { get; set; }
        public string Fecha { get; set; }
        public string Tienda { get; set; }
        public string Observaciones { get; set; }
        public string CantidadCobrar { get; set; }
    }

    public class OrdenEntregaSubsidiary
    {
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }
    }

    public class OrdenEntregaCustomer
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string EntreCalles { get; set; }
    }

    public class OrdenEntregaDetail
    {
        public string Codigo { get; set; }
        public decimal Cantidad { get; set; }
        public string Clasificacion { get; set; }
        public string Descripcion { get; set; }
        public string Proveedor { get; set; }
    }

    public class OrdenEntregaImages
    {
        public byte[] LogoEmpresa { get; set; }
    }
}
