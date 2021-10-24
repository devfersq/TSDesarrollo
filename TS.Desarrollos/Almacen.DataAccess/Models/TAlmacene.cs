using System;
using System.Collections.Generic;

#nullable disable

namespace Almacen.DataAccess.Models
{
    public partial class TAlmacene
    {
        public int AlmIclave { get; set; }
        public string AlmAnombre { get; set; }
        public int AlmItipo { get; set; }
        public string AlmMobservaciones { get; set; }
        public bool? AlmLtrasPerAnt { get; set; }
        public string AlmAletra { get; set; }
        public string AlmAcliente { get; set; }
        public int? AlmStipoArea { get; set; }
        public bool? AlmLordenTrabajo { get; set; }

        public virtual TTipoAlmacen AlmItipoNavigation { get; set; }
    }
}
