using System;
using System.Collections.Generic;

#nullable disable

namespace Almacen.DataAccess.Models
{
    public partial class Ordene
    {
        public Ordene()
        {
            OrdenProductos = new HashSet<OrdenProducto>();
        }

        public long Id { get; set; }
        public long Folio { get; set; }
        public string Tipo { get; set; }
        public string Sucursal { get; set; }
        public string AlmacenOrigen { get; set; }
        public string AlmacenDestino { get; set; }
        public int? DomicilioOrigen { get; set; }
        public int? DomicilioDestino { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }
        public bool Impreso { get; set; }
        public bool Aplicado { get; set; }
        public bool PagoAlaEntrega { get; set; }
        public decimal? MontoAcobrar { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? SucursalId { get; set; }

        public virtual ICollection<OrdenProducto> OrdenProductos { get; set; }
    }
}
