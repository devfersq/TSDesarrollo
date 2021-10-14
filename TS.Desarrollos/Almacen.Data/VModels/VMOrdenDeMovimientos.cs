using System.Collections.Generic;

namespace Almacen.Data.VModels
{
    public class VMOrdenDeMovimientos
    {
        public VMOrdenDeMovimientos()
        {
            Orden = new VMOrdenMovimiento();
            Items = new List<VMOrdenProducto>();
        }
        public VMOrdenMovimiento Orden { get; set; }
        public List<VMOrdenProducto> Items { get; set; }

    }
}
