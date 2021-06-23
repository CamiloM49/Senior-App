
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
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabMantenedores = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.tabComunas = new MetroFramework.Controls.MetroTabPage();
            this.labelError = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCoumnaID = new System.Windows.Forms.TextBox();
            this.txtComunaName = new System.Windows.Forms.TextBox();
            this.cboComunaProvID = new MetroFramework.Controls.MetroComboBox();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todo = new Senior_App.Todo();
            this.dgvComuna = new System.Windows.Forms.DataGridView();
            this.comunaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunanombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabProvincia = new MetroFramework.Controls.MetroTabPage();
            this.tabRegion = new MetroFramework.Controls.MetroTabPage();
            this.tabUsers = new MetroFramework.Controls.MetroTabPage();
            this.tabApoderados = new MetroFramework.Controls.MetroTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.apoderadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apoderadoTableAdapter = new Senior_App.TodoTableAdapters.apoderadoTableAdapter();
            this.fKportadorapoderadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.portadorTableAdapter = new Senior_App.TodoTableAdapters.portadorTableAdapter();
            this.comunasTableAdapter = new Senior_App.TodoTableAdapters.comunasTableAdapter();
            this.provinciasTableAdapter = new Senior_App.TodoTableAdapters.provinciasTableAdapter();
            this.integracionDataSet1 = new Senior_App.IntegracionDataSet();
            this.todo1 = new Senior_App.Todo();
            this.metroTabControl1.SuspendLayout();
            this.tabMantenedores.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.tabComunas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apoderadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKportadorapoderadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integracionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todo1)).BeginInit();
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
            this.tabComunas.Controls.Add(this.labelError);
            this.tabComunas.Controls.Add(this.materialRaisedButton2);
            this.tabComunas.Controls.Add(this.materialRaisedButton1);
            this.tabComunas.Controls.Add(this.txtCoumnaID);
            this.tabComunas.Controls.Add(this.txtComunaName);
            this.tabComunas.Controls.Add(this.cboComunaProvID);
            this.tabComunas.Controls.Add(this.dgvComuna);
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
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.White;
            this.labelError.Depth = 0;
            this.labelError.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelError.Location = new System.Drawing.Point(4, 2);
            this.labelError.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(223, 19);
            this.labelError.TabIndex = 22;
            this.labelError.Text = "* Favor llenar todos los campos\r\n";
            this.labelError.Visible = false;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(409, 59);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(401, 36);
            this.materialRaisedButton2.TabIndex = 15;
            this.materialRaisedButton2.Text = "Eliminar comuna";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(4, 59);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(399, 36);
            this.materialRaisedButton1.TabIndex = 14;
            this.materialRaisedButton1.Text = "AGREGAR COMuna";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // txtCoumnaID
            // 
            this.txtCoumnaID.Location = new System.Drawing.Point(4, 24);
            this.txtCoumnaID.MaxLength = 3;
            this.txtCoumnaID.Multiline = true;
            this.txtCoumnaID.Name = "txtCoumnaID";
            this.txtCoumnaID.Size = new System.Drawing.Size(255, 29);
            this.txtCoumnaID.TabIndex = 10;
            // 
            // txtComunaName
            // 
            this.txtComunaName.Location = new System.Drawing.Point(265, 24);
            this.txtComunaName.MaxLength = 20;
            this.txtComunaName.Multiline = true;
            this.txtComunaName.Name = "txtComunaName";
            this.txtComunaName.Size = new System.Drawing.Size(261, 29);
            this.txtComunaName.TabIndex = 9;
            // 
            // cboComunaProvID
            // 
            this.cboComunaProvID.DataSource = this.provinciasBindingSource;
            this.cboComunaProvID.DisplayMember = "provincia_id";
            this.cboComunaProvID.FormattingEnabled = true;
            this.cboComunaProvID.ItemHeight = 23;
            this.cboComunaProvID.Location = new System.Drawing.Point(529, 24);
            this.cboComunaProvID.Name = "cboComunaProvID";
            this.cboComunaProvID.Size = new System.Drawing.Size(278, 29);
            this.cboComunaProvID.Style = MetroFramework.MetroColorStyle.Silver;
            this.cboComunaProvID.TabIndex = 6;
            this.cboComunaProvID.UseCustomBackColor = true;
            this.cboComunaProvID.UseSelectable = true;
            this.cboComunaProvID.ValueMember = "provincia_id";
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.todoBindingSource;
            // 
            // todoBindingSource
            // 
            this.todoBindingSource.DataSource = this.todo;
            this.todoBindingSource.Position = 0;
            // 
            // todo
            // 
            this.todo.DataSetName = "Todo";
            this.todo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvComuna
            // 
            this.dgvComuna.AllowUserToOrderColumns = true;
            this.dgvComuna.AutoGenerateColumns = false;
            this.dgvComuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comunaidDataGridViewTextBoxColumn,
            this.comunanombreDataGridViewTextBoxColumn,
            this.provinciaidDataGridViewTextBoxColumn});
            this.dgvComuna.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvComuna.DataSource = this.comunasBindingSource;
            this.dgvComuna.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvComuna.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvComuna.Location = new System.Drawing.Point(0, 101);
            this.dgvComuna.Name = "dgvComuna";
            this.dgvComuna.Size = new System.Drawing.Size(810, 350);
            this.dgvComuna.TabIndex = 2;
            this.dgvComuna.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComuna_CellContentClick);
            // 
            // comunaidDataGridViewTextBoxColumn
            // 
            this.comunaidDataGridViewTextBoxColumn.DataPropertyName = "comuna_id";
            this.comunaidDataGridViewTextBoxColumn.HeaderText = "comuna_id";
            this.comunaidDataGridViewTextBoxColumn.Name = "comunaidDataGridViewTextBoxColumn";
            // 
            // comunanombreDataGridViewTextBoxColumn
            // 
            this.comunanombreDataGridViewTextBoxColumn.DataPropertyName = "comuna_nombre";
            this.comunanombreDataGridViewTextBoxColumn.HeaderText = "comuna_nombre";
            this.comunanombreDataGridViewTextBoxColumn.Name = "comunanombreDataGridViewTextBoxColumn";
            // 
            // provinciaidDataGridViewTextBoxColumn
            // 
            this.provinciaidDataGridViewTextBoxColumn.DataPropertyName = "provincia_id";
            this.provinciaidDataGridViewTextBoxColumn.HeaderText = "provincia_id";
            this.provinciaidDataGridViewTextBoxColumn.Name = "provinciaidDataGridViewTextBoxColumn";
            // 
            // comunasBindingSource
            // 
            this.comunasBindingSource.DataMember = "comunas";
            this.comunasBindingSource.DataSource = this.todoBindingSource;
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
            // apoderadoBindingSource
            // 
            this.apoderadoBindingSource.DataMember = "apoderado";
            this.apoderadoBindingSource.DataSource = this.todo;
            // 
            // apoderadoTableAdapter
            // 
            this.apoderadoTableAdapter.ClearBeforeFill = true;
            // 
            // fKportadorapoderadoBindingSource
            // 
            this.fKportadorapoderadoBindingSource.DataMember = "FK_portador_apoderado";
            this.fKportadorapoderadoBindingSource.DataSource = this.apoderadoBindingSource;
            // 
            // portadorTableAdapter
            // 
            this.portadorTableAdapter.ClearBeforeFill = true;
            // 
            // comunasTableAdapter
            // 
            this.comunasTableAdapter.ClearBeforeFill = true;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // integracionDataSet1
            // 
            this.integracionDataSet1.DataSetName = "IntegracionDataSet";
            this.integracionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // todo1
            // 
            this.todo1.DataSetName = "Todo";
            this.todo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Load += new System.EventHandler(this.Form2_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabMantenedores.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.tabComunas.ResumeLayout(false);
            this.tabComunas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apoderadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKportadorapoderadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integracionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todo1)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvComuna;
        private Todo todo;
        private System.Windows.Forms.BindingSource apoderadoBindingSource;
        private TodoTableAdapters.apoderadoTableAdapter apoderadoTableAdapter;
        private System.Windows.Forms.BindingSource fKportadorapoderadoBindingSource;
        private TodoTableAdapters.portadorTableAdapter portadorTableAdapter;
        private System.Windows.Forms.BindingSource todoBindingSource;
        private System.Windows.Forms.BindingSource comunasBindingSource;
        private TodoTableAdapters.comunasTableAdapter comunasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunanombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaidDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroComboBox cboComunaProvID;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private TodoTableAdapters.provinciasTableAdapter provinciasTableAdapter;
        private IntegracionDataSet integracionDataSet1;
        private Todo todo1;
        private System.Windows.Forms.TextBox txtCoumnaID;
        private System.Windows.Forms.TextBox txtComunaName;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel labelError;
    }
}