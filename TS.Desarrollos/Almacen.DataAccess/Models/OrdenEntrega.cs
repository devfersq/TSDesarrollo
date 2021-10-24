using System;
using System.Collections.Generic;

#nullable disable

namespace Almacen.DataAccess.Models
{
    public partial class OrdenEntrega
    {
        public int Id { get; set; }
        public long Folio { get; set; }
        public string Tipo { get; set; }
        public string Sucursal { get; set; }
        public string Origen { get; set; }
        public long Destino { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }
        public bool? Impreso { get; set; }
        public bool? Aplicado { get; set; }
        public bool? PagoEntrega { get; set; }
        public decimal? MontoAcobrar { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
