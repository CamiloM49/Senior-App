using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeniorAppDB;

namespace Senior_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            using (SeniorAppDB.SeniorAppDB db1 = new SeniorAppDB.SeniorAppDB())
            {
                //consultamos todas las filas 
                var lst = from d in db1.comunas
                          select d;

                //creamos variable que cuente todas las filas
                var filasID = lst.Count();

                //Establecemos automatico el ID
                txtCoumnaID.Text = "" + (lst.Count() + 1);
                //txtCoumnaID.Enabled = false;


                /*
                if (lst.Count() > 1)
                {
                    this.comunasTableAdapter.Insert(int.Parse(this.txtCoumnaID.Text), this.txtComunaName.Text, int.Parse(this.cboComunaProvID.Text));
                }
                else
                {
                    txtCamposLlenos.Text = "ID repetida, favor cambiar";
                }
                */
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'todo.cuenta' Puede moverla o quitarla según sea necesario.
            this.cuentaTableAdapter.Fill(this.todo.cuenta);
            // TODO: esta línea de código carga datos en la tabla 'todo.regiones' Puede moverla o quitarla según sea necesario.
            this.regionesTableAdapter.Fill(this.todo.regiones);
            // TODO: esta línea de código carga datos en la tabla 'todo.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.todo.provincias);
            // TODO: esta línea de código carga datos en la tabla 'todo.comunas' Puede moverla o quitarla según sea necesario.
            this.comunasTableAdapter.Fill(this.todo.comunas);
            // TODO: esta línea de código carga datos en la tabla 'todo.portador' Puede moverla o quitarla según sea necesario.
            this.portadorTableAdapter.Fill(this.todo.portador);
            // TODO: esta línea de código carga datos en la tabla 'todo.apoderado' Puede moverla o quitarla según sea necesario.
            this.apoderadoTableAdapter.Fill(this.todo.apoderado);

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            using (SeniorAppDB.SeniorAppDB db1 = new SeniorAppDB.SeniorAppDB())
            {
                var idcomuna = int.Parse(txtCoumnaID.Text);
                //consultamos todas las filas 
                var lsta = from d in db1.comunas
                           where d.comuna_id == idcomuna
                           select d;

                if (lsta.Count() == 0)
                {
                    this.comunasTableAdapter.Insert(int.Parse(txtCoumnaID.Text), this.txtComunaName.Text, int.Parse(this.cboComunaProvID.Text));
                    MessageBox.Show("tamo gucci");

                    // TODO ESTE CODIGO RECARGA TODOS LOS GRIDVIEW
                    // TODO: esta línea de código carga datos en la tabla 'todo.provincias' Puede moverla o quitarla según sea necesario.
                    this.provinciasTableAdapter.Fill(this.todo.provincias);
                    // TODO: esta línea de código carga datos en la tabla 'todo.comunas' Puede moverla o quitarla según sea necesario.
                    this.comunasTableAdapter.Fill(this.todo.comunas);
                    // TODO: esta línea de código carga datos en la tabla 'todo.portador' Puede moverla o quitarla según sea necesario.
                    this.portadorTableAdapter.Fill(this.todo.portador);
                    // TODO: esta línea de código carga datos en la tabla 'todo.apoderado' Puede moverla o quitarla según sea necesario.
                    this.apoderadoTableAdapter.Fill(this.todo.apoderado);
                    dgvComuna.Update();
                    dgvComuna.Refresh();
                    DataGridView tabla = new DataGridView();
                    tabla.Update();




                }
                else
                {
                    labelError.Visible = true;
                    labelError.Text = "ID repetida, favor cambiar";
                }

            }



            if (txtCoumnaID.TextLength < 1 || txtComunaName.TextLength < 2)
            {
                labelError.Visible = true;

            }
            else
            {



                /*
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvComuna);
                fila.Cells[0].Value = txtCoumnaID.Text;
                fila.Cells[1].Value = txtComunaName.Text;
                fila.Cells[2].Value = cboComunaProvID.SelectedItem;
                if(txtCoumnaID.TextLength < 1 || txtComunaName.TextLength < 2)
                {
                    txtCamposLlenos.Visible = true;
                }
                else
                {

                    using (SeniorAppDB.SeniorAppDB db2 = new SeniorAppDB.SeniorAppDB())
                    {


                    }



                    dgvComuna.Rows.Add(fila);
                    txtCoumnaID.Text = "";
                    txtComunaName.Text = ";";
                    MessageBox.Show("Comuna agregada con exito", "Notifiacion");

                }*/




            }


        }

        private void dgvComuna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtCoumnaID.Text = row.Cells["comuna_id"].Value.ToString();
                txtComunaName.Text = row.Cells["comuna_nombre"].Value.ToString();
               

            
            */


        }

        private void provinciasBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            //this.regionesTableAdapter.Delete();
            //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //txtCoumnaID.Text = row.Cells["comuna_id"].Value.ToString();





        }

        private void dgvComuna_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvComuna.SelectedRows)
            {
                txtCoumnaID.Text = row.Cells[0].Value.ToString();
                txtComunaName.Text = row.Cells[1].Value.ToString();
                //NO LOGRO QUE ESTA WEA ME ACTUALICE EL COMBOBOX QUIZAS LO CAMBIO A TXT NO MAS. 
                //cboComunaProvID.SelectedItem = row.Cells[2].Value;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
