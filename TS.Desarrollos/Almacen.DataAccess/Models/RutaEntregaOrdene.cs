using System;
using System.Collections.Generic;

#nullable disable

namespace Almacen.DataAccess.Models
{
    public partial class RutaEntregaOrdene
    {
        public long Id { get; set; }
        public long RutaEntregaId { get; set; }
        public long OrdenEntregaId { get; set; }
        public bool? Entregado { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
