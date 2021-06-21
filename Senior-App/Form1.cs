using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senior_App
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            //var Activo = new active();
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jesusBailando.Image = Image.FromFile(@"C:\Users\NOTE-200\Downloads\Senior-App media\tenor.gif");
            jesusBailando.SizeMode = PictureBoxSizeMode.StretchImage; 
        }

        private void buttonConsultarDatos_Click(object sender, EventArgs e)
        {
            Form2 fmr = new Form2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fmr.FormBorderStyle = (FormBorderStyle.None);
            this.panel1.Controls.Add(fmr);
            fmr.Show(); 


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

        private void buttonMostrarLogin_Click(object sender, EventArgs e)
        {
            
            login lgn = new login() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lgn.FormBorderStyle = (FormBorderStyle.None);
            this.panel1.Controls.Add(lgn);
            lgn.Show();


            }
        }

}
