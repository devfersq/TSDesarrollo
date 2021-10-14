using System.Collections.Generic;

namespace Almacen.Data.VModels
{
    public class VMTraspasos
    {
        public Traspaso Traspaso { get; set; } = new Traspaso();
        public List<TraspasoProducto> Items { get; set; } = new List<TraspasoProducto>();
    }
}
