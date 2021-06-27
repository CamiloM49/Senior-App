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
        public string tipo_deCuenta;
        public string responsable; 
        public SeniorAppDB.SeniorAppDB db = new SeniorAppDB.SeniorAppDB();
        public void validadDatos(string textocorreo, string passwd)
        {
            string sPass = CifradoNegocio.GetSHA256(passwd);

            {

                var lst = (from des in db.cuenta
                           where des.mail == textocorreo
                           && des.passwd == sPass
                           select new
                           {

                               idApoderado = des.apoderado,
                               usuario = des.usuario,
                               mail = des.mail,
                               telefono = des.telefono,
                               pass = des.passwd,
                               tipo = des.tipo_cuenta


                           }).ToList();
                foreach (var des in lst)
                {
                    var tipo_cuenta = des.tipo;
                    this.tipo_deCuenta = tipo_cuenta;
                    var papito = des.idApoderado;
                    this.responsable = papito.ToString();
                    if (lst.Count() > 0)
                    {

                        respuesta = true;

                    }
                    else { respuesta = false; }


                }



            }
        }
        public string informacionportado;
        public string nombre;
        public string apdpataterno;
        public string apdmaterno;
        public string contacto;
        public SeniorAppDB.SeniorAppDB db2 = new SeniorAppDB.SeniorAppDB();
        public void tipo_usuario(string tokencode)
        {
            LoginNegocio logincon = new LoginNegocio();

            var informacionportado = (from t in db2.token
                                      join p in db2.portador
                                      on t.id_portador equals p.id_portador
                                      where t.token_id == tokencode
                                      select new
                                      {

                                          FirstName = p.nombre,
                                          APATERNO = p.apdpat,
                                          AMATERNO = p.apdmat,
                                          CONTACTO = p.contacto_emergencia,


                                      }).ToList();
            this.informacionportado = informacionportado.ToString();
            foreach (var p in informacionportado)
            {
                var nombre = "Nombre: " + p.FirstName;
                var apdpataterno = "Apellido Paterno: " + p.APATERNO;
                var apdmaterno = "Apellido Paterno: " + p.AMATERNO;
                var contacto = "Telefono: +" + p.CONTACTO;
                this.nombre = nombre;
                this.apdpataterno = apdpataterno;
                this.apdmaterno = apdmaterno;
                this.contacto = contacto;




            }
        }
    }
}
                

                
                
    

