using System;

#nullable disable

namespace Almacen.Data.VModels
{
    public partial class Consecutivo
    {
        public long ConsecutivoId { get; set; }
        public string Nombre { get; set; }
        public long? ConsecutivoActual { get; set; }
        public DateTime? Updated { get; set; }
    }
}
