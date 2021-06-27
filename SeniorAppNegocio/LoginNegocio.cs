using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeniorAppDB;
using SeniorAppNegocio;


namespace SeniorAppNegocio
{
    public class LoginNegocio

    {
        public bool respuesta;
        public SeniorAppDB.SeniorAppDB db = new SeniorAppDB.SeniorAppDB();
        public void validadDatos(string textocorreo, string passwd) {
            string sPass = CifradoNegocio.GetSHA256(passwd);
            
            {

                var lst = from d in db.cuenta
                          where d.mail == textocorreo
                          && d.passwd == sPass
                          select d;
                
                if (lst.Count() > 0)
                {

                    respuesta = true;

                } 
                else { respuesta = false; }
            } } } }
                

                
                
    

