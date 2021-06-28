using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SeniorAppDB;
using SeniorAppNegocio;


namespace SeniorAppNegocio
{
    public class LoginNegocio

    {
        public bool respuesta;
        public string tipo_deCuenta;
        public string responsable; 
        public string idapoderado;
        public string tokenfinales;
        static public string Tokenfinales;
        static public int Idapod;
        static public int Idporta;

        static public SeniorAppDB.SeniorAppDB db = new SeniorAppDB.SeniorAppDB();
        public void validadDatos(string textocorreo, string passwd)
        {
            string sPass = CifradoNegocio.GetSHA256(passwd);

            {

                var lst = (from des in db.cuenta
                           where des.mail == textocorreo
                           && des.passwd == sPass
                           select new
                           {
                               idApoderado2 = des.id_apoderado,
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
                    var idapoderado = des.idApoderado;
                    this.idapoderado = idapoderado.ToString();
                    var id_apoderado = des.idApoderado2;
                    Ultimoqr(id_apoderado);
                    Idapod = id_apoderado;

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
                                          idapoderado2 = p.id_apoderado


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
         public string Ultimoqr(int idapo)
        {
            try
            {
                

                var informaciontoken = (from a in db.cuenta
                                        join p in db.portador
                                        on a.id_apoderado equals p.id_apoderado
                                        join t in db.token on p.id_portador equals t.id_portador
                                        where p.id_apoderado == idapo
                                        orderby t.id_token descending
                                        select new
                                        {


                                            TOKENFINAL = t.token_id,
                                            IDPORTA = t.id_portador


                                        }).Take(1).ToList();
                foreach (var t in informaciontoken)
                {


                    string tokenfinales = t.TOKENFINAL;
                    int idporta = t.IDPORTA;
       
                    Tokenfinales = tokenfinales;



                }//
                var informacionporta = (from a in db.cuenta
                                        join p in db.portador
                                        on a.id_apoderado equals p.id_apoderado
                                        where p.id_apoderado == idapo
                                        
                                        select new
                                        {


                                            
                                            IDPORTA = p.id_portador


                                        }).Take(1).ToList();
                foreach (var t in informacionporta)
                {


                  
                    int idporta = t.IDPORTA;
                    Idporta = idporta;
          



                }




            }
            catch { MessageBox.Show("no se encontro qr, genere uno ahora"); }
            return "listo";
        }
    }
}
                

                
                
    

