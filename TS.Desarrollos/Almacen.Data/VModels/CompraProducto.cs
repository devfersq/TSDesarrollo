namespace Almacen.Data.VModels
{
    public class CompraProducto
    {
        public long Id { get; set; }
        public long CompraId { get; set; }
        public string Producto { get; set; }
        public decimal PrPnid { get; set; }
        public string Codigo { get; set; }
        public double Cantidad { get; set; }
        public int UnidadAuxiliar { get; set; }
        public double ComFdevuelto { get; set; }
        public decimal Descuento { get; set; }
        public double PorcentajeDescuento { get; set; }
        public double Iva { get; set; }
        public decimal Costo { get; set; }
        public int? Consecutivo { get; set; }
        public string Factura { get; set; }
        public decimal Factor { get; set; }
        public decimal? LoteId { get; set; }
        public double? FleteGlobal { get; set; }
        public double? DescPorcenGlobal { get; set; }
        public double? DescPesosGlobal { get; set; }
        public bool? DistribuirFlete { get; set; }
        public double? IvaPorcen { get; set; }
        public decimal? Pedido { get; set; }
        public double? CostoTotCrudo { get; set; }
    }
}
