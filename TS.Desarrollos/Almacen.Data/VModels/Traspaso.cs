using System;

namespace Almacen.Data.VModels
{
    public class Traspaso
    {
        public long Id { get; set; }
        public long Folio { get; set; }
        public string Serie { get; set; }
        public int? Usuario { get; set; }
        public string Observaciones { get; set; }
        public int? AlmacenOrigen { get; set; }
        public string NombreAlmacenOrigen { get; set; }
        public int? AlmacenDestino { get; set; }
        public string NombreAlmacenDestino { get; set; }
        public DateTime? Fecha { get; set; }
        public string Remitente { get; set; }
        public string NombreRemitente { get; set; }
        public string AplicadoContabilidad { get; set; }
        public string Receptor { get; set; }
        public string NombreReceptor { get; set; }
        public string Transportador { get; set; }
        public string nombreTransportador { get; set; }
        public bool? AplicaHos { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
