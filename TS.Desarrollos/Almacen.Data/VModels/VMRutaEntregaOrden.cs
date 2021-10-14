using System;

#nullable disable

namespace Almacen.Data.VModels
{
    public class VMRutaEntregaOrden
    {
        public long RutaEntregaOrdenId { get; set; }
        public long RutaEntregaId { get; set; }
        public long Folio { get; set; }
        public string Tipo { get; set; }
        public float PagoEntrega { get; set; }
        public string Documento { get; set; }
        public string Entregado { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
