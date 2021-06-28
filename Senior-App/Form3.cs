using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeniorAppNegocio;
using SeniorAppDB;
using QRCoder;
using SeniorAppDTO;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Senior_App
{
    public partial class Form3 : Form
    {
        SeniorAppDB.SeniorAppDB db = new SeniorAppDB.SeniorAppDB();
        public Form3()
        {
            InitializeComponent();
            load_data();
            cargar_datos();
            gMapa.DragButton = MouseButtons.Left;
            gMapa.CanDragMap = true;
            gMapa.MapProvider = GMapProviders.GoogleMap;
            gMapa.Position = new GMap.NET.PointLatLng(-33.46250690553818, -70.66059838031153);
            gMapa.MinZoom = 0;
            gMapa.MaxZoom = 24;
            gMapa.Zoom = 12;
            gMapa.AutoScroll = true;
            TokenDTO dto = new TokenDTO();
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(LoginNegocio.Tokenfinales, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBox1.Image = code.GetGraphic(5);
            //Console.WriteLine(LoginNegocio.Idapod);




        }
        public void load_data()
        {
            SeniorAppDB.SeniorAppDB dbe = new SeniorAppDB.SeniorAppDB();
            var responsable = dbe.portador.ToList();
            cboPortadores.Items.Add("Seleccionar Uno");
            foreach (var item in responsable)
            {
                cboPortadores.Items.Add(item.id_apoderado);
            }
        }
        
        private void cargar_datos()
        {
            gridConsulta.DataSource = db.portador.ToList();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            gridConsulta.DataSource = db.portador.ToList();
            
             

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void filtrar(string id_apoderado)
        {
            gridConsulta.DataSource = db.portador.SqlQuery("select * from portador where " + id_apoderado);
            gridConsulta.Visible = true;
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            filtrar(cboPortadores.Text);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            {
                string url = "https://localhost:44393/api/Token";
                TokenDTO objt = new TokenDTO();
                GeneradorQRNegocio genqr = new GeneradorQRNegocio();
                TokenAleatorioNegocio tokeng = new TokenAleatorioNegocio();
                tokeng.tokenfinal();
                objt.Token_id = tokeng.tokenf;
                objt.Id_portador = 15;
                objt.Valido = true;
                string resultado = genqr.Send<TokenDTO>(url, objt, "POST");

                string qrgenerado = objt.Token_id;
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(qrgenerado, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                pictureBox1.Image = code.GetGraphic(5);


            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


            TokenDTO dto = new TokenDTO();
            
            
            QRCodeGenerator qr = new QRCodeGenerator();

            QRCodeData data = qr.CreateQrCode(LoginNegocio.Tokenfinales, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBox1.Image = code.GetGraphic(5);
        }
    }
}
