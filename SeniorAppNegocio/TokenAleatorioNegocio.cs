using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorAppNegocio
{
    public class TokenAleatorioNegocio
    {
        public string tokenf;
        public void tokenfinal() { 
            Guid miGuid = Guid.NewGuid();
        string token = Convert.ToBase64String(miGuid.ToByteArray());
        token = token.Replace("=", "").Replace("+", "");
            { tokenf = token;
            }
    }
        
    }
}
