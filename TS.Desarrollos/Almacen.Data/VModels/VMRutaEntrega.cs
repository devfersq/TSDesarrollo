using System;

#nullable disable

namespace Almacen.Data.VModels
{
    public class VMRutaEntrega
    {
        public int Id { get; set; }
        public long Folio { get; set; }
        public string Chofer { get; set; }
        public string NombreChofer { get; set; }
        public string Estado { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
