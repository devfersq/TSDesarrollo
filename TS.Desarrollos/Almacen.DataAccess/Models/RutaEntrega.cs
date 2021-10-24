using System;
using System.Collections.Generic;

#nullable disable

namespace Almacen.DataAccess.Models
{
    public partial class RutaEntrega
    {
        public long Id { get; set; }
        public long Folio { get; set; }
        public string Chofer { get; set; }
        public short Estado { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
