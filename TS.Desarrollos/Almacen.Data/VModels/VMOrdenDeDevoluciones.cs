using System.Collections.Generic;

namespace Almacen.Data.VModels
{
    public class VMOrdenDeDevoluciones
    {
        public VMOrdenDeDevoluciones()
        {
            Orden = new VMOrdenDevolucion();
            Items = new List<VMOrdenProducto>();
            Domicilio = new VMDomicilio();
        }
        public VMOrdenDevolucion Orden { get; set; }
        public VMDomicilio Domicilio { get; set; }
        public List<VMOrdenProducto> Items { get; set; }
    }
}
