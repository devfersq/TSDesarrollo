using System;

namespace Almacen.Data.VModels
{
    public class Compra
    {
        public long Id { get; set; }
        public long Folio { get; set; }
        public string Serie { get; set; }
        public int Almacen { get; set; }
        public string NombreAlmacen { get; set; }
        public string Factura { get; set; }
        public string Remision { get; set; }
        public decimal Flete { get; set; }
        public decimal Descuento { get; set; }
        public double PorcentajeDescuento { get; set; }

        public int DistribucionDeFlete { get; set; }
        public DateTime Fecha { get; set; }
        public string Divisa { get; set; }
        public double? TipoDeCambio { get; set; }
        public string Proveedor { get; set; }
        public string NombreProveedor { get; set; }
        public bool AplicadoCxp { get; set; }
        public string ApliContabilidad { get; set; }
        public string Observacion { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
