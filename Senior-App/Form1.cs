using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using QRCoder;
using ZXing;
using ZXing.Presentation;
using SeniorAppDB;
using SeniorAppNegocio;
using SeniorAppDTO;
using System.Web.Script.Serialization;
using System.Net;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;



namespace Senior_App
{
    public partial class Form1 : Form
    {
        public string resultadoqr;

        public Form1()
        {
            InitializeComponent();




        }

        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'integracionDataSet.cuenta' Puede moverla o quitarla según sea necesario.
            this.cuentaTableAdapter.Fill(this.integracionDataSet.cuenta);
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                cboCamara.Items.Add(filterInfo.Name);
            cboCamara.SelectedIndex = 0;
            //
            gMapa.DragButton = MouseButtons.Left;
            gMapa.CanDragMap = true;
            gMapa.MapProvider = GMapProviders.GoogleMap;
            gMapa.Position = new GMap.NET.PointLatLng(-33.46250690553818, -70.66059838031153);
            gMapa.MinZoom = 0;
            gMapa.MaxZoom = 24;
            gMapa.Zoom = 12;
            gMapa.AutoScroll = true;

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Realmente quieres salir de la aplicación?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }


        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Realmente quieres salir de la aplicación?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
            //Application.Exit();
            //this.Close(); 
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[cboCamara.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevide_NewFrame;
            captureDevice.Start();
            timer1.Start();

        }

        private void CaptureDevide_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (captureDevice.IsRunning)
            //{
            //    captureDevice.Stop();
            //}







        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if  (pictureBox2.Image  != null)
            {


                ZXing.BarcodeReader barcodeReader = new ZXing.BarcodeReader();
                ZXing.Result result = barcodeReader.Decode((Bitmap)pictureBox2.Image);
                if  (result != null)
                {

                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                    this.resultadoqr = result.ToString();
                    ConsultaPortadorNegocio csp = new ConsultaPortadorNegocio();
                    csp.detalleportador(resultadoqr);
                    //
                    metroLabel1.Text = csp.nombre;
                    metroLabel2.Text = csp.apdpataterno;
                    metroLabel3.Text = csp.apdmaterno;
                    metroLabel4.Text = csp.contacto;
                    nombreMaptxt.Text = csp.nombre;
                    apellidoPaMaptxt.Text = csp.apdpataterno;
                    apellidoMaMaptxt.Text = csp.apdmaterno;
                    telefonoTxt.Text = csp.contacto;
                    nombreMaptxt.Visible = true;
                    apellidoPaMaptxt.Visible = true;
                    apellidoMaMaptxt.Visible = true;
                    telefonoTxt.Visible = true;
                    generarAlerta.Visible = true;


                }
            }
        }

        

        


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            LoginNegocio obj = new LoginNegocio();
            obj.validadDatos(txtCorreo.Text, metroTextBox2.Text.Trim());
            {
                if (obj.respuesta == true)
                {
                    if (obj.tipo_deCuenta == "A")
                    {
                        Form2 adm = new Form2();
                        adm.Show();
                        txtError.Visible = false;
                    }
                    else
                    {

                        if (obj.tipo_deCuenta == "N")
                        {
                           
                            Form3 normal = new Form3();
                            normal.Show();
                            txtError.Visible = false;
                        }
                    }

                }
                else {
                    if (obj.respuesta == false && metroTextBox2.Text == "" || txtCorreo.Text == "")
                    {
                        txtError.Text = "* Formulario vacio";
                        txtError.Visible = true; }
                    else {
                        if (obj.respuesta == false)
                        {
                            txtError.Text = "*  Usuario o contraseña incorrecto";
                            txtError.Visible = true;
                        }
                           
                    }
                }

                }  }  
        //Este esta para no tener que logear siempre xd
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Form2 adm = new Form2();
            adm.Show();
        }

        private void picboxGenerador_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtQR_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click_1(object sender, EventArgs e)
        {
            Form3 usr = new Form3();
            usr.Show();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtError_Click(object sender, EventArgs e)
        {

        }
    }
}
