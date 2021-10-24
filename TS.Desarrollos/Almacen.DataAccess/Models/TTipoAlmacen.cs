using System;
using System.Collections.Generic;

#nullable disable

namespace Almacen.DataAccess.Models
{
    public partial class TTipoAlmacen
    {
        public TTipoAlmacen()
        {
            TAlmacenes = new HashSet<TAlmacene>();
        }

        public int TipAclave { get; set; }
        public string TipAdescripcion { get; set; }
        public bool TipBexistencia { get; set; }

        public virtual ICollection<TAlmacene> TAlmacenes { get; set; }
    }
}
