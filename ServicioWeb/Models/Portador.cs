using System;
using System.Collections.Generic;

#nullable disable

namespace ServicioWeb.Models
{
    public partial class Portador
    {
        public Portador()
        {
            LastLocations = new HashSet<LastLocation>();
            RegistroPerdida = new HashSet<RegistroPerdidum>();
            Tokens = new HashSet<Token>();
        }

        public int IdPortador { get; set; }
        public string Nombre { get; set; }
        public string Apdpat { get; set; }
        public string Apdmat { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Rut { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Enfermedades { get; set; }
        public bool Prevision { get; set; }
        public string PrevisionName { get; set; }
        public string MedicoCabecera { get; set; }
        public string Alergias { get; set; }
        public string MedicamentosPrescritos { get; set; }
        public string ContactoEmergencia { get; set; }
        public int IdApoderado { get; set; }

        public virtual Apoderado IdApoderadoNavigation { get; set; }
        public virtual ICollection<LastLocation> LastLocations { get; set; }
        public virtual ICollection<RegistroPerdidum> RegistroPerdida { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
    }
}
