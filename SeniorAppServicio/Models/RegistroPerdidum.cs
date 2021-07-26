using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioWeb.Models
{
    public partial class RegistroPerdidum
    {
        public int IdRegistro { get; set; }
        public int? IdPortador { get; set; }
        public int? IdApoderado { get; set; }
        public DateTime? HoraPerdida { get; set; }
        public string LastLocation { get; set; }
        public string Detalles { get; set; }
        public byte[] Imagen { get; set; }
        public byte[] EstadoAlerta { get; set; }
        public byte[] AlertaConfirmada { get; set; }
        public byte[] EnviadoAuth { get; set; }
        public string IpApoderado { get; set; }

        public virtual Portador IdPortadorNavigation { get; set; }
    }
}
