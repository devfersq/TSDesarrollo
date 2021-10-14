using System.Collections.Generic;

namespace Almacen.Data.VModels
{
    public class VMOrdenDeEntregas
    {
        public VMOrdenDeEntregas()
        {
            Orden = new VMOrdenEntrega();
            Domicilio = new VMDomicilio();
            Items = new List<VMOrdenProducto>();
        }
        public VMOrdenEntrega Orden { get; set; }
        public VMDomicilio Domicilio { get; set; }
        public List<VMOrdenProducto> Items { get; set; }
    }
}
