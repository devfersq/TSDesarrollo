using System;

#nullable disable

namespace Almacen.Data.VModels
{
    public class VMOrdenDevolucion
    {
        public int Id { get; set; }
        public long Folio { get; set; }
        public string Tipo { get; set; }
        public string Sucursal { get; set; }
        public string NombreSucursal { get; set; }
        public long Origen { get; set; }
        public string Destino { get; set; }
        public string NombreDestino { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }
        public bool? Impreso { get; set; }
        public bool? Aplicado { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
