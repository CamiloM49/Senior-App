using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioWeb.Models
{
    public partial class LastLocation
    {
        public int IdPerdida { get; set; }
        public int? IdPortador { get; set; }
        public DateTime? Fecha { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public DateTime? HoraLectura { get; set; }
        public string IpLectura { get; set; }
        public string AuthIp { get; set; }
        public string AlertaActiva { get; set; }

        public virtual Portador IdPortadorNavigation { get; set; }
    }
}
