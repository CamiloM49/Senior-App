﻿using System;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
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

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
