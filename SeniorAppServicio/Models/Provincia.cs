using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioWeb.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            Comunas = new HashSet<Comuna>();
        }

        public int ProvinciaId { get; set; }
        public string ProvinciaNombre { get; set; }
        public int RegionId { get; set; }

        public virtual Regione Region { get; set; }
        public virtual ICollection<Comuna> Comunas { get; set; }
    }
}
