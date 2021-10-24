using System;
using System.Collections.Generic;

#nullable disable

namespace Almacen.DataAccess.Models
{
    public partial class Tgrupo
    {
        public Tgrupo()
        {
            Tproductos = new HashSet<Tproducto>();
        }

        public int GruIclave { get; set; }
        public string GruAnombre { get; set; }
        public int? GruIpadre { get; set; }
        public string GruMobservaciones { get; set; }
        public bool? GruLasignarCosto { get; set; }
        public decimal? GruNcolor { get; set; }
        public bool? GruBmedidas { get; set; }

        public virtual ICollection<Tproducto> Tproductos { get; set; }
    }
}
