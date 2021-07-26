using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioWeb.Models
{
    public partial class Regione
    {
        public Regione()
        {
            Provincia = new HashSet<Provincia>();
        }

        public int RegionId { get; set; }
        public string RegionNombre { get; set; }
        public string RegionOrdinal { get; set; }

        public virtual ICollection<Provincia> Provincia { get; set; }
    }
}
