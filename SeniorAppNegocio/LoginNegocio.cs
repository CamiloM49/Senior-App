using SeniorAppDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorAppNegocio
{
    public abstract class LoginNegocio : AbstractService<cuenta>
    {
        public override void AddEntity(cuenta entity)
        {
            cuenta Cuenta = GetEntity(entity.mail);
            if (Cuenta == null)
            {
                
            }
            else { throw new ArgumentException("El rut de la empresa ya existe"); }
        }

    }
}
