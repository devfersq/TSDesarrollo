namespace Almacen.Data.VModels
{
    public class TraspasoProducto
    {
        public long Id { get; set; }
        public long TraspasoId { get; set; }
        public string Producto { get; set; }
        public string NombreProducto { get; set; }
        public decimal? PrpNid { get; set; }
        public double? Cantidad { get; set; }
        public int? Consecutivo { get; set; }
        public string Unidad { get; set; }
        public decimal? Costo { get; set; }
        public decimal? Factor { get; set; }
        public string Lote { get; set; }
        public decimal? Precio { get; set; }
        public decimal? PrecioUnit { get; set; }
        public decimal? CostoGen { get; set; }
        public double? CantidadGen { get; set; }
        public decimal? PrPnidGen { get; set; }
        public string ClaveGen { get; set; }
        public double? IvaPesos { get; set; }
        public double? IvaPor { get; set; }
    }
}
