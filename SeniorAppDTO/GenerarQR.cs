using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorAppDTO
{
    public class GenerarQR
    {
        private string token_id;
        private Boolean valido;
        private int id_portador;
        public string Token_id
        {
            get
            {
                return token_id;
            }

            set
            {
                token_id = value;
            }
        }
        public Boolean Valido
        {
            get
            {
                return valido;
            }

            set
            {
                valido = value;
            }
        }
        public int Id_portador
        {
            get
            {
                return id_portador;
            }

            set
            {
                id_portador = value;
            }
        }
    }
}
    

