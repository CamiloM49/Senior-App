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
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            } 
            
            





        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(pictureBox2.Image!= null)
            {


                ZXing.BarcodeReader barcodeReader = new ZXing.BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox2.Image); 
                if(result != null)
                {
                    
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                    this.resultadoqr = result.ToString();
                    ConsultaPortadorNegocio csp = new ConsultaPortadorNegocio();
                    csp.detalleportador(resultadoqr);
                    metroLabel1.Text = csp.nombre;
                    metroLabel2.Text = csp.apdpataterno;
                    metroLabel3.Text = csp.apdmaterno;
                    metroLabel4.Text = csp.contacto;

                }
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            ConsultaPortadorNegocio csp = new ConsultaPortadorNegocio();
            csp.detalleportador(resultadoqr);
            metroLabel1.Text = csp.nombre;
            metroLabel2.Text = csp.apdpataterno;
            metroLabel3.Text = csp.apdmaterno;
            metroLabel4.Text = csp.contacto;

            
        }

        private void buttonGenerarQR_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44393/api/Token";
            TokenDTO objt = new TokenDTO();
            GeneradorQRNegocio genqr = new GeneradorQRNegocio();
            TokenAleatorioNegocio tokeng = new TokenAleatorioNegocio();
            tokeng.tokenfinal();
            objt.Token_id = tokeng.tokenf;
            objt.Id_portador = 12;
            objt.Valido = true;
            string resultado = genqr.Send<TokenDTO>(url, objt, "POST");
            
            string qrgenerado = objt.Token_id;
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(qrgenerado, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            picboxGenerador.Image = code.GetGraphic(5);
            

        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            LoginNegocio obj = new LoginNegocio();
            obj.validadDatos(txtCorreo.Text, metroTextBox2.Text.Trim());
        {
            if (obj.respuesta == true)
            {

                Form2 adm = new Form2();
                adm.Show();
                    txtError.Visible = false;

                }
            else
            {
                txtError.Visible = true;

            }
        }





    }
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
    }
}
