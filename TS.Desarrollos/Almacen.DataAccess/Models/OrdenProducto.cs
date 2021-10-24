using System;
using System.Collections.Generic;

#nullable disable

namespace Almacen.DataAccess.Models
{
    public partial class OrdenProducto
    {
        public long Id { get; set; }
        public long OrdenId { get; set; }
        public string Producto { get; set; }
        public long PresentacionId { get; set; }
        public float Cantidad { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Ordene Orden { get; set; }
    }
}
