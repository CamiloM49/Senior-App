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
    }
}
