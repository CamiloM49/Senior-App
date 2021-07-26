using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioWeb.Models
{
    public partial class Comuna
    {
        public Comuna()
        {
            Apoderados = new HashSet<Apoderado>();
        }

        public int ComunaId { get; set; }
        public string ComunaNombre { get; set; }
        public int ProvinciaId { get; set; }

        public virtual Provincia Provincia { get; set; }
        public virtual ICollection<Apoderado> Apoderados { get; set; }
    }
}
