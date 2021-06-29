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
            WSMantenedor.WebService1 ws2 = new WSMantenedor.WebService1();
            dataGridView1.DataSource = ws2.LoadData("SELECT * FROM last_location", null, null, "last_location");
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

            if (LoginNegocio.Tokenfinales == null)
            {
                EventogQR();

            }
            else { EventoverQR(); }



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
            WSMantenedor.WebService1 filt = new WSMantenedor.WebService1();
            gridConsulta.DataSource = filt.LoadData("SELECT * FROM portador where id_apoderado = "+ "'" + cboPortadores.Text + "'", null, null, "portador");
            gridConsulta.Visible = true;
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            filtrar(cboPortadores.Text);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            {
                EventogQR();


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
        public void EventogQR()
        {


            GeneradorQRNegocio generacionqr = new GeneradorQRNegocio();
            generacionqr.generaciontoken();
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(GeneradorQRNegocio.ResultadoQR, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBox1.Image = code.GetGraphic(5);
        }
        public void EventoverQR()
        {
            TokenDTO dto = new TokenDTO();
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(LoginNegocio.Tokenfinales, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBox1.Image = code.GetGraphic(5);
            //Console.WriteLine(LoginNegocio.Idapod);}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
