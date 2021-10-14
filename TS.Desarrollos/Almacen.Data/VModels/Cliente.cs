using System;

namespace Almacen.Data.VModels
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Rfc { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Cp { get; set; }
        public string Giro { get; set; }
        public decimal? Saldo { get; set; }
        public short? Plazo { get; set; }
        public decimal? Limite { get; set; }
        public decimal? Acumulado { get; set; }
        public string DiasEntrega { get; set; }
        public string DiasPago { get; set; }
        public string Condiciones { get; set; }
        public string Pcompras { get; set; }
        public string Ppagos { get; set; }
        public string PrecibeMerc { get; set; }
        public DateTime? FultCompra { get; set; }
        public DateTime? FultPago { get; set; }
        public short? ClaveAgVta { get; set; }
        public short? ClaveZona { get; set; }
        public string Nip { get; set; }
        public string Colonia { get; set; }
        public string NoExt { get; set; }
        public string Email { get; set; }
        public string Pais { get; set; }
        public string Municipio { get; set; }
        public short? FacRec { get; set; }
        public string ClaveAux { get; set; }
        public int? ClaveRuta { get; set; }
        public string MetodoDePago { get; set; }
    }
}
