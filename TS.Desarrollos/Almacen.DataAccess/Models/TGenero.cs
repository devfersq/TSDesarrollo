using System;
using System.Collections.Generic;

#nullable disable

namespace Almacen.DataAccess.Models
{
    public partial class TGenero
    {
        public TGenero()
        {
            Tproductos = new HashSet<Tproducto>();
        }

        public int GenIclave { get; set; }
        public string GenAdescripcion { get; set; }
        public bool? GenLatri { get; set; }

        public virtual ICollection<Tproducto> Tproductos { get; set; }
    }
}
