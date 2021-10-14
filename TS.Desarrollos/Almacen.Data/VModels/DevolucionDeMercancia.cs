using System.Collections.Generic;

namespace Almacen.Data.VModels
{
    public class DevolucionDeMercancia
    {
        public VMOrdenDevolucion OrdenDevolucion { get; set; }
        public List<VMOrdenProducto> Items { get; set; } = new List<VMOrdenProducto>();
    }
}
