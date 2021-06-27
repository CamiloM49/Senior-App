
namespace Senior_App
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.gridConsulta = new MetroFramework.Controls.MetroGrid();
            this.idportadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apdpatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apdmatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enfermedadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previsionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.previsionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicocabeceraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergiasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentosprescritosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoemergenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idapoderadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portadorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.todo = new Senior_App.Todo();
            this.buttonFiltrar = new MetroFramework.Controls.MetroButton();
            this.cboPortadores = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.cuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentaTableAdapter = new Senior_App.TodoTableAdapters.cuentaTableAdapter();
            this.portadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.portadorTableAdapter = new Senior_App.TodoTableAdapters.portadorTableAdapter();
            this.portadorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portadorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portadorBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 51);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(826, 538);
            this.metroTabControl1.TabIndex = 8;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.gridConsulta);
            this.metroTabPage1.Controls.Add(this.buttonFiltrar);
            this.metroTabPage1.Controls.Add(this.cboPortadores);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(818, 496);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Consultar datos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // gridConsulta
            // 
            this.gridConsulta.AllowUserToAddRows = false;
            this.gridConsulta.AllowUserToDeleteRows = false;
            this.gridConsulta.AllowUserToResizeRows = false;
            this.gridConsulta.AutoGenerateColumns = false;
            this.gridConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idportadorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apdpatDataGridViewTextBoxColumn,
            this.apdmatDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn,
            this.rutDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.enfermedadesDataGridViewTextBoxColumn,
            this.previsionDataGridViewCheckBoxColumn,
            this.previsionnameDataGridViewTextBoxColumn,
            this.medicocabeceraDataGridViewTextBoxColumn,
            this.alergiasDataGridViewTextBoxColumn,
            this.medicamentosprescritosDataGridViewTextBoxColumn,
            this.contactoemergenciaDataGridViewTextBoxColumn,
            this.idapoderadoDataGridViewTextBoxColumn});
            this.gridConsulta.DataSource = this.portadorBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridConsulta.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridConsulta.EnableHeadersVisualStyles = false;
            this.gridConsulta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridConsulta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridConsulta.Location = new System.Drawing.Point(0, 82);
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.ReadOnly = true;
            this.gridConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridConsulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridConsulta.Size = new System.Drawing.Size(818, 414);
            this.gridConsulta.TabIndex = 7;
            this.gridConsulta.Visible = false;
            // 
            // idportadorDataGridViewTextBoxColumn
            // 
            this.idportadorDataGridViewTextBoxColumn.DataPropertyName = "id_portador";
            this.idportadorDataGridViewTextBoxColumn.HeaderText = "id_portador";
            this.idportadorDataGridViewTextBoxColumn.Name = "idportadorDataGridViewTextBoxColumn";
            this.idportadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apdpatDataGridViewTextBoxColumn
            // 
            this.apdpatDataGridViewTextBoxColumn.DataPropertyName = "apdpat";
            this.apdpatDataGridViewTextBoxColumn.HeaderText = "apdpat";
            this.apdpatDataGridViewTextBoxColumn.Name = "apdpatDataGridViewTextBoxColumn";
            this.apdpatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apdmatDataGridViewTextBoxColumn
            // 
            this.apdmatDataGridViewTextBoxColumn.DataPropertyName = "apdmat";
            this.apdmatDataGridViewTextBoxColumn.HeaderText = "apdmat";
            this.apdmatDataGridViewTextBoxColumn.Name = "apdmatDataGridViewTextBoxColumn";
            this.apdmatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
            this.fechanacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rutDataGridViewTextBoxColumn
            // 
            this.rutDataGridViewTextBoxColumn.DataPropertyName = "rut";
            this.rutDataGridViewTextBoxColumn.HeaderText = "rut";
            this.rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            this.rutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enfermedadesDataGridViewTextBoxColumn
            // 
            this.enfermedadesDataGridViewTextBoxColumn.DataPropertyName = "enfermedades";
            this.enfermedadesDataGridViewTextBoxColumn.HeaderText = "enfermedades";
            this.enfermedadesDataGridViewTextBoxColumn.Name = "enfermedadesDataGridViewTextBoxColumn";
            this.enfermedadesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // previsionDataGridViewCheckBoxColumn
            // 
            this.previsionDataGridViewCheckBoxColumn.DataPropertyName = "prevision";
            this.previsionDataGridViewCheckBoxColumn.HeaderText = "prevision";
            this.previsionDataGridViewCheckBoxColumn.Name = "previsionDataGridViewCheckBoxColumn";
            this.previsionDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // previsionnameDataGridViewTextBoxColumn
            // 
            this.previsionnameDataGridViewTextBoxColumn.DataPropertyName = "prevision_name";
            this.previsionnameDataGridViewTextBoxColumn.HeaderText = "prevision_name";
            this.previsionnameDataGridViewTextBoxColumn.Name = "previsionnameDataGridViewTextBoxColumn";
            this.previsionnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicocabeceraDataGridViewTextBoxColumn
            // 
            this.medicocabeceraDataGridViewTextBoxColumn.DataPropertyName = "medico_cabecera";
            this.medicocabeceraDataGridViewTextBoxColumn.HeaderText = "medico_cabecera";
            this.medicocabeceraDataGridViewTextBoxColumn.Name = "medicocabeceraDataGridViewTextBoxColumn";
            this.medicocabeceraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alergiasDataGridViewTextBoxColumn
            // 
            this.alergiasDataGridViewTextBoxColumn.DataPropertyName = "alergias";
            this.alergiasDataGridViewTextBoxColumn.HeaderText = "alergias";
            this.alergiasDataGridViewTextBoxColumn.Name = "alergiasDataGridViewTextBoxColumn";
            this.alergiasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicamentosprescritosDataGridViewTextBoxColumn
            // 
            this.medicamentosprescritosDataGridViewTextBoxColumn.DataPropertyName = "medicamentos_prescritos";
            this.medicamentosprescritosDataGridViewTextBoxColumn.HeaderText = "medicamentos_prescritos";
            this.medicamentosprescritosDataGridViewTextBoxColumn.Name = "medicamentosprescritosDataGridViewTextBoxColumn";
            this.medicamentosprescritosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactoemergenciaDataGridViewTextBoxColumn
            // 
            this.contactoemergenciaDataGridViewTextBoxColumn.DataPropertyName = "contacto_emergencia";
            this.contactoemergenciaDataGridViewTextBoxColumn.HeaderText = "contacto_emergencia";
            this.contactoemergenciaDataGridViewTextBoxColumn.Name = "contactoemergenciaDataGridViewTextBoxColumn";
            this.contactoemergenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idapoderadoDataGridViewTextBoxColumn
            // 
            this.idapoderadoDataGridViewTextBoxColumn.DataPropertyName = "id_apoderado";
            this.idapoderadoDataGridViewTextBoxColumn.HeaderText = "id_apoderado";
            this.idapoderadoDataGridViewTextBoxColumn.Name = "idapoderadoDataGridViewTextBoxColumn";
            this.idapoderadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // portadorBindingSource2
            // 
            this.portadorBindingSource2.DataMember = "portador";
            this.portadorBindingSource2.DataSource = this.todo;
            // 
            // todo
            // 
            this.todo.DataSetName = "Todo";
            this.todo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonFiltrar.ForeColor = System.Drawing.Color.White;
            this.buttonFiltrar.Location = new System.Drawing.Point(318, 29);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(156, 29);
            this.buttonFiltrar.TabIndex = 6;
            this.buttonFiltrar.Text = "FILTRAR";
            this.buttonFiltrar.UseCustomBackColor = true;
            this.buttonFiltrar.UseCustomForeColor = true;
            this.buttonFiltrar.UseSelectable = true;
            this.buttonFiltrar.UseStyleColors = true;
            this.buttonFiltrar.UseWaitCursor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // cboPortadores
            // 
            this.cboPortadores.FormattingEnabled = true;
            this.cboPortadores.ItemHeight = 23;
            this.cboPortadores.Location = new System.Drawing.Point(167, 29);
            this.cboPortadores.Name = "cboPortadores";
            this.cboPortadores.Size = new System.Drawing.Size(121, 29);
            this.cboPortadores.TabIndex = 4;
            this.cboPortadores.UseSelectable = true;
            this.cboPortadores.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(-4, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(180, 28);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Seleccionar portador";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(818, 496);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Modificar codigo QR";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(818, 496);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Generar alerta";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // cuentaBindingSource
            // 
            this.cuentaBindingSource.DataMember = "cuenta";
            this.cuentaBindingSource.DataSource = this.todo;
            // 
            // cuentaTableAdapter
            // 
            this.cuentaTableAdapter.ClearBeforeFill = true;
            // 
            // portadorBindingSource
            // 
            this.portadorBindingSource.DataMember = "portador";
            this.portadorBindingSource.DataSource = this.todo;
            // 
            // portadorTableAdapter
            // 
            this.portadorTableAdapter.ClearBeforeFill = true;
            // 
            // portadorBindingSource1
            // 
            this.portadorBindingSource1.DataMember = "portador";
            this.portadorBindingSource1.DataSource = this.todo;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 589);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portadorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portadorBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private Todo todo;
        private System.Windows.Forms.BindingSource cuentaBindingSource;
        private TodoTableAdapters.cuentaTableAdapter cuentaTableAdapter;
        private System.Windows.Forms.BindingSource portadorBindingSource;
        private TodoTableAdapters.portadorTableAdapter portadorTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cboPortadores;
        private MetroFramework.Controls.MetroButton buttonFiltrar;
        private System.Windows.Forms.BindingSource portadorBindingSource1;
        private MetroFramework.Controls.MetroGrid gridConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idportadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apdpatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apdmatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enfermedadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn previsionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previsionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicocabeceraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergiasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentosprescritosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoemergenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idapoderadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource portadorBindingSource2;
    }
}