using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioWeb.Models
{
    public partial class Apoderado
    {
        public Apoderado()
        {
            Portadors = new HashSet<Portador>();
        }

        public int IdApoderado { get; set; }
        public string Nombre { get; set; }
        public string Apdpat { get; set; }
        public string Apdmat { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Rut { get; set; }
        public string Phone { get; set; }
        public string Direccion { get; set; }
        public string Membresia { get; set; }
        public int ComunaId { get; set; }

        public virtual Comuna Comuna { get; set; }
        public virtual Cuentum IdApoderadoNavigation { get; set; }
        public virtual ICollection<Portador> Portadors { get; set; }
    }
}
