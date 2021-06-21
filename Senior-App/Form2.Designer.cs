
namespace Senior_App
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabMantenedores = new MetroFramework.Controls.MetroTabPage();
            this.tabUsers = new MetroFramework.Controls.MetroTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.tabComunas = new MetroFramework.Controls.MetroTabPage();
            this.tabApoderados = new MetroFramework.Controls.MetroTabPage();
            this.tabProvincia = new MetroFramework.Controls.MetroTabPage();
            this.tabRegion = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.tabMantenedores.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabMantenedores);
            this.metroTabControl1.Controls.Add(this.tabUsers);
            this.metroTabControl1.Controls.Add(this.tabApoderados);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 51);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(826, 538);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabMantenedores
            // 
            this.tabMantenedores.Controls.Add(this.metroTabControl2);
            this.tabMantenedores.HorizontalScrollbarBarColor = true;
            this.tabMantenedores.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMantenedores.HorizontalScrollbarSize = 10;
            this.tabMantenedores.Location = new System.Drawing.Point(4, 38);
            this.tabMantenedores.Name = "tabMantenedores";
            this.tabMantenedores.Size = new System.Drawing.Size(818, 496);
            this.tabMantenedores.TabIndex = 0;
            this.tabMantenedores.Text = "Mantenedores";
            this.tabMantenedores.VerticalScrollbarBarColor = true;
            this.tabMantenedores.VerticalScrollbarHighlightOnWheel = false;
            this.tabMantenedores.VerticalScrollbarSize = 10;
            // 
            // tabUsers
            // 
            this.tabUsers.HorizontalScrollbarBarColor = true;
            this.tabUsers.HorizontalScrollbarHighlightOnWheel = false;
            this.tabUsers.HorizontalScrollbarSize = 10;
            this.tabUsers.Location = new System.Drawing.Point(4, 38);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(818, 496);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Usuarios";
            this.tabUsers.VerticalScrollbarBarColor = true;
            this.tabUsers.VerticalScrollbarHighlightOnWheel = false;
            this.tabUsers.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Senior-App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Location = new System.Drawing.Point(721, 0);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(105, 48);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.Text = "X";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 48);
            this.panel1.TabIndex = 7;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.tabComunas);
            this.metroTabControl2.Controls.Add(this.tabProvincia);
            this.metroTabControl2.Controls.Add(this.tabRegion);
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTabControl2.Location = new System.Drawing.Point(0, 3);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(818, 493);
            this.metroTabControl2.TabIndex = 2;
            this.metroTabControl2.UseSelectable = true;
            // 
            // tabComunas
            // 
            this.tabComunas.HorizontalScrollbarBarColor = true;
            this.tabComunas.HorizontalScrollbarHighlightOnWheel = false;
            this.tabComunas.HorizontalScrollbarSize = 10;
            this.tabComunas.Location = new System.Drawing.Point(4, 38);
            this.tabComunas.Name = "tabComunas";
            this.tabComunas.Size = new System.Drawing.Size(810, 451);
            this.tabComunas.TabIndex = 0;
            this.tabComunas.Text = "Modificar comunas";
            this.tabComunas.VerticalScrollbarBarColor = true;
            this.tabComunas.VerticalScrollbarHighlightOnWheel = false;
            this.tabComunas.VerticalScrollbarSize = 10;
            // 
            // tabApoderados
            // 
            this.tabApoderados.HorizontalScrollbarBarColor = true;
            this.tabApoderados.HorizontalScrollbarHighlightOnWheel = false;
            this.tabApoderados.HorizontalScrollbarSize = 10;
            this.tabApoderados.Location = new System.Drawing.Point(4, 38);
            this.tabApoderados.Name = "tabApoderados";
            this.tabApoderados.Size = new System.Drawing.Size(818, 496);
            this.tabApoderados.TabIndex = 3;
            this.tabApoderados.Text = "Apoderados";
            this.tabApoderados.VerticalScrollbarBarColor = true;
            this.tabApoderados.VerticalScrollbarHighlightOnWheel = false;
            this.tabApoderados.VerticalScrollbarSize = 10;
            // 
            // tabProvincia
            // 
            this.tabProvincia.HorizontalScrollbarBarColor = true;
            this.tabProvincia.HorizontalScrollbarHighlightOnWheel = false;
            this.tabProvincia.HorizontalScrollbarSize = 10;
            this.tabProvincia.Location = new System.Drawing.Point(4, 38);
            this.tabProvincia.Name = "tabProvincia";
            this.tabProvincia.Size = new System.Drawing.Size(810, 451);
            this.tabProvincia.TabIndex = 1;
            this.tabProvincia.Text = "Modificar Provincias";
            this.tabProvincia.VerticalScrollbarBarColor = true;
            this.tabProvincia.VerticalScrollbarHighlightOnWheel = false;
            this.tabProvincia.VerticalScrollbarSize = 10;
            // 
            // tabRegion
            // 
            this.tabRegion.HorizontalScrollbarBarColor = true;
            this.tabRegion.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRegion.HorizontalScrollbarSize = 10;
            this.tabRegion.Location = new System.Drawing.Point(4, 38);
            this.tabRegion.Name = "tabRegion";
            this.tabRegion.Size = new System.Drawing.Size(810, 451);
            this.tabRegion.TabIndex = 2;
            this.tabRegion.Text = "Modificar regiones";
            this.tabRegion.VerticalScrollbarBarColor = true;
            this.tabRegion.VerticalScrollbarHighlightOnWheel = false;
            this.tabRegion.VerticalScrollbarSize = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.metroTabControl1.ResumeLayout(false);
            this.tabMantenedores.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabMantenedores;
        private MetroFramework.Controls.MetroTabPage tabUsers;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage tabComunas;
        private MetroFramework.Controls.MetroTabPage tabProvincia;
        private MetroFramework.Controls.MetroTabPage tabRegion;
        private MetroFramework.Controls.MetroTabPage tabApoderados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Panel panel1;
    }
}