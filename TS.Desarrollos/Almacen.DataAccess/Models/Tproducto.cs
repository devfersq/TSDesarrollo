using System;
using System.Collections.Generic;

#nullable disable

namespace Almacen.DataAccess.Models
{
    public partial class Tproducto
    {
        public string ProAclave { get; set; }
        public string ProAnombre { get; set; }
        public string ProMdescripcion { get; set; }
        public int? ProIempaque { get; set; }
        public int ProIgrupo { get; set; }
        public int? ProIgenero { get; set; }
        public double ProFiva { get; set; }
        public double? ProFcostoPromedio { get; set; }
        public double? ProFutilidad { get; set; }
        public string ProAcodigoDeBarras { get; set; }
        public byte[] ProPfoto { get; set; }
        public decimal? ProCosto { get; set; }
        public int? ProIcaduca { get; set; }
        public int? ProIlote { get; set; }
        public int? Proiservicio { get; set; }
        public int? ProIcostoPp { get; set; }
        public int? ProIcodBar { get; set; }
        public int? ProIuni { get; set; }
        public decimal VenNid { get; set; }
        public bool? ProLlote { get; set; }
        public double? ProFpeso { get; set; }
        public string ProAcolor { get; set; }
        public int? ProIdivisa { get; set; }
        public double? ProFcantPerfil { get; set; }
        public double? ProFcostoColor { get; set; }
        public double? ProFcostoPerfil { get; set; }
        public double? ProFpiezasAtado { get; set; }
        public int? ProImarca { get; set; }
        public string ProAgenericoPadre { get; set; }
        public bool ProLgenerico { get; set; }
        public double? ProFfactorGenerico { get; set; }
        public int? ProIpadre { get; set; }
        public double? ProFieps { get; set; }
        public string ProAcveProdSer { get; set; }
        public string ProAcveUmedida { get; set; }

        public virtual TGenero ProIgeneroNavigation { get; set; }
        public virtual Tgrupo ProIgrupoNavigation { get; set; }
    }
}
