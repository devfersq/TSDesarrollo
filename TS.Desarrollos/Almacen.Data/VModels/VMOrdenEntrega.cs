using System;

#nullable disable

namespace Almacen.Data.VModels
{
    public class VMOrdenEntrega
    {
        public int Id { get; set; }
        public long Folio { get; set; }
        public string Tipo { get; set; }
        public string Sucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string Origen { get; set; }
        public string NombreOrigen { get; set; }
        public long Destino { get; set; }
        public long NombreDestino { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }
        public bool? Impreso { get; set; }
        public bool? Aplicado { get; set; }
        public bool? PagoEntrega { get; set; }
        public decimal? MontoAcobrar { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
