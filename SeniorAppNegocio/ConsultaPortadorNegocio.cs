using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SeniorAppDB;


namespace SeniorAppNegocio
{
    public class ConsultaPortadorNegocio

    {
        public string informacionportado;
        public string nombre;
        public string apdpataterno;
        public string apdmaterno;
        public string contacto;
        public string tokenfinales;
        public SeniorAppDB.SeniorAppDB db = new SeniorAppDB.SeniorAppDB();
        public void detalleportador(string tokencode) {
            LoginNegocio logincon = new LoginNegocio();
            
            var informacionportado = (from t in db.token
                                      join p in db.portador
                                      on t.id_portador equals p.id_portador
                                      where t.token_id == tokencode
                                      select new
                                      {
                                          
                                          FirstName = p.nombre,
                                          APATERNO = p.apdpat,
                                          AMATERNO = p.apdmat,
                                          CONTACTO = p.contacto_emergencia,
                                          //TOKENFINAL = t.token_id
                                          
                                         
                                      }).ToList();
            this.informacionportado = informacionportado.ToString();
            foreach (var p in informacionportado)
            {
                var nombre= "Nombre: " + p.FirstName;
                var apdpataterno = "Apellido Paterno: " + p.APATERNO;
                var apdmaterno = "Apellido Paterno: " + p.AMATERNO;
                var contacto = "Telefono: +" + p.CONTACTO;
                //var tokenfinal = p.TOKENFINAL;
                this.nombre = nombre;
                this.apdpataterno = apdpataterno;
                this.apdmaterno = apdmaterno;
                this.contacto = contacto;
                //this.tokenfinales = tokenfinal;




            }
        }
        public void ultimoqr() {
            try
            {
                LoginNegocio logincon = new LoginNegocio();

                var informaciontoken = (from a in db.cuenta
                                        join p in db.portador
                                        on a.id_apoderado equals p.id_apoderado
                                        join t in db.token on p.id_portador equals t.id_portador
                                        where p.id_apoderado == 2
                                        select new
                                        {


                                            TOKENFINAL = t.token_id


                                        }).Take(1).ToList();
                foreach (var t in informaciontoken)
                {


                    Console.WriteLine("{0}", (t.TOKENFINAL));
                }
            
            }
            catch { MessageBox.Show("no se encontro qr, genere uno ahora"); }
        }

    }
}
