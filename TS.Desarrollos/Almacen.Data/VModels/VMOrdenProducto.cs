using System;

#nullable disable

namespace Almacen.Data.VModels
{
    public class VMOrdenProducto
    {
        public long Id { get; set; }
        public long OrdenId { get; set; }
        public string Producto { get; set; }
        public string NombreProducto { get; set; }
        public long PresentacionId { get; set; }
        public float? Cantidad { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
