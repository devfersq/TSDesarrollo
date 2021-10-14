using System.Collections.Generic;

namespace Almacen.Data.VModels
{
    public class VMRutasDeEntrega
    {
        public VMRutasDeEntrega()
        {
            Ruta = new VMRutaEntrega();
            Items = new List<VMRutaEntregaOrden>();
        }
        public VMRutaEntrega Ruta { get; set; }
        public List<VMRutaEntregaOrden> Items { get; set; }
    }
}
