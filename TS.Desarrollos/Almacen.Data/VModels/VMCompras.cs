using System.Collections.Generic;

namespace Almacen.Data.VModels
{
    public class VMCompras
    {
        public Compra Compra { get; set; } = new Compra();
        public List<CompraProducto> Items { get; set; } = new List<CompraProducto>();

    }
}
