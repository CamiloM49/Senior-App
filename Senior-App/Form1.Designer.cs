
namespace Senior_App
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroLogin = new MetroFramework.Controls.MetroTabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.txtCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroConsulta = new MetroFramework.Controls.MetroTabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtQR = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cboCamara = new MetroFramework.Controls.MetroComboBox();
            this.buttonStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroGenera = new MetroFramework.Controls.MetroTabPage();
            this.txtQRGenerar = new System.Windows.Forms.RichTextBox();
            this.buttonGenerarQR = new MaterialSkin.Controls.MaterialRaisedButton();
            this.picboxGenerador = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.integracionDataSet = new Senior_App.IntegracionDataSet();
            this.integracionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentaTableAdapter = new Senior_App.IntegracionDataSetTableAdapters.cuentaTableAdapter();
            this.integracionDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cuentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroLogin.SuspendLayout();
            this.metroConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroGenera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGenerador)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integracionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integracionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integracionDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroLogin);
            this.metroTabControl1.Controls.Add(this.metroConsulta);
            this.metroTabControl1.Controls.Add(this.metroGenera);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 54);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(842, 574);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroLogin
            // 
            this.metroLogin.BackColor = System.Drawing.Color.White;
            this.metroLogin.Controls.Add(this.materialLabel2);
            this.metroLogin.Controls.Add(this.materialLabel1);
            this.metroLogin.Controls.Add(this.materialRaisedButton1);
            this.metroLogin.Controls.Add(this.metroTextBox2);
            this.metroLogin.Controls.Add(this.txtCorreo);
            this.metroLogin.ForeColor = System.Drawing.Color.Maroon;
            this.metroLogin.HorizontalScrollbarBarColor = true;
            this.metroLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.metroLogin.HorizontalScrollbarSize = 10;
            this.metroLogin.Location = new System.Drawing.Point(4, 37);
            this.metroLogin.Name = "metroLogin";
            this.metroLogin.Size = new System.Drawing.Size(834, 533);
            this.metroLogin.TabIndex = 0;
            this.metroLogin.Text = "Login";
            this.metroLogin.VerticalScrollbarBarColor = true;
            this.metroLogin.VerticalScrollbarHighlightOnWheel = false;
            this.metroLogin.VerticalScrollbarSize = 10;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(256, 216);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(157, 19);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "Ingrese su contraseña";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(256, 124);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Ingrese su correo";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.FlatAppearance.BorderSize = 0;
            this.materialRaisedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRaisedButton1.ForeColor = System.Drawing.Color.Teal;
            this.materialRaisedButton1.Location = new System.Drawing.Point(256, 312);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(327, 43);
            this.materialRaisedButton1.TabIndex = 18;
            this.materialRaisedButton1.Text = "INGRESAR";
            this.materialRaisedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(256, 256);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(327, 23);
            this.metroTextBox2.TabIndex = 15;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCorreo
            // 
            // 
            // 
            // 
            this.txtCorreo.CustomButton.Image = null;
            this.txtCorreo.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.txtCorreo.CustomButton.Name = "";
            this.txtCorreo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCorreo.CustomButton.TabIndex = 1;
            this.txtCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCorreo.CustomButton.UseSelectable = true;
            this.txtCorreo.CustomButton.Visible = false;
            this.txtCorreo.Lines = new string[0];
            this.txtCorreo.Location = new System.Drawing.Point(256, 157);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.ShortcutsEnabled = true;
            this.txtCorreo.Size = new System.Drawing.Size(327, 23);
            this.txtCorreo.TabIndex = 13;
            this.txtCorreo.UseSelectable = true;
            this.txtCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroConsulta
            // 
            this.metroConsulta.Controls.Add(this.webBrowser1);
            this.metroConsulta.Controls.Add(this.materialRaisedButton2);
            this.metroConsulta.Controls.Add(this.txtQR);
            this.metroConsulta.Controls.Add(this.pictureBox2);
            this.metroConsulta.Controls.Add(this.materialLabel4);
            this.metroConsulta.Controls.Add(this.cboCamara);
            this.metroConsulta.Controls.Add(this.buttonStart);
            this.metroConsulta.HorizontalScrollbarBarColor = true;
            this.metroConsulta.HorizontalScrollbarHighlightOnWheel = false;
            this.metroConsulta.HorizontalScrollbarSize = 10;
            this.metroConsulta.Location = new System.Drawing.Point(4, 37);
            this.metroConsulta.Name = "metroConsulta";
            this.metroConsulta.Size = new System.Drawing.Size(834, 536);
            this.metroConsulta.TabIndex = 1;
            this.metroConsulta.Text = "Consultar Datos";
            this.metroConsulta.VerticalScrollbarBarColor = true;
            this.metroConsulta.VerticalScrollbarHighlightOnWheel = false;
            this.metroConsulta.VerticalScrollbarSize = 10;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(543, 62);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(268, 261);
            this.webBrowser1.TabIndex = 35;
            this.webBrowser1.Url = new System.Uri("https://localhost:44393/api/Token", System.UriKind.Absolute);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.FlatAppearance.BorderSize = 0;
            this.materialRaisedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRaisedButton2.ForeColor = System.Drawing.Color.Teal;
            this.materialRaisedButton2.Location = new System.Drawing.Point(585, 429);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(226, 30);
            this.materialRaisedButton2.TabIndex = 34;
            this.materialRaisedButton2.Text = "BUSCAR DATOS CON CODIGO";
            this.materialRaisedButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // txtQR
            // 
            this.txtQR.Depth = 0;
            this.txtQR.Hint = "";
            this.txtQR.Location = new System.Drawing.Point(585, 391);
            this.txtQR.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQR.Name = "txtQR";
            this.txtQR.PasswordChar = '\0';
            this.txtQR.SelectedText = "";
            this.txtQR.SelectionLength = 0;
            this.txtQR.SelectionStart = 0;
            this.txtQR.Size = new System.Drawing.Size(226, 23);
            this.txtQR.TabIndex = 32;
            this.txtQR.UseSystemPasswordChar = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(496, 452);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.BackColor = System.Drawing.Color.White;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 23);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(77, 29);
            this.materialLabel4.TabIndex = 30;
            this.materialLabel4.Text = "Camara:";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // cboCamara
            // 
            this.cboCamara.FormattingEnabled = true;
            this.cboCamara.ItemHeight = 23;
            this.cboCamara.Location = new System.Drawing.Point(91, 23);
            this.cboCamara.Name = "cboCamara";
            this.cboCamara.Size = new System.Drawing.Size(195, 29);
            this.cboCamara.TabIndex = 29;
            this.cboCamara.UseSelectable = true;
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStart.Depth = 0;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.ForeColor = System.Drawing.Color.Teal;
            this.buttonStart.Location = new System.Drawing.Point(309, 23);
            this.buttonStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Primary = true;
            this.buttonStart.Size = new System.Drawing.Size(157, 30);
            this.buttonStart.TabIndex = 26;
            this.buttonStart.Text = "EMPEZAR ESCANEO";
            this.buttonStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // metroGenera
            // 
            this.metroGenera.Controls.Add(this.txtQRGenerar);
            this.metroGenera.Controls.Add(this.buttonGenerarQR);
            this.metroGenera.Controls.Add(this.picboxGenerador);
            this.metroGenera.HorizontalScrollbarBarColor = true;
            this.metroGenera.HorizontalScrollbarHighlightOnWheel = false;
            this.metroGenera.HorizontalScrollbarSize = 10;
            this.metroGenera.Location = new System.Drawing.Point(4, 37);
            this.metroGenera.Name = "metroGenera";
            this.metroGenera.Size = new System.Drawing.Size(834, 536);
            this.metroGenera.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGenera.TabIndex = 2;
            this.metroGenera.Text = "Generar Codigo QR";
            this.metroGenera.VerticalScrollbarBarColor = true;
            this.metroGenera.VerticalScrollbarHighlightOnWheel = false;
            this.metroGenera.VerticalScrollbarSize = 10;
            // 
            // txtQRGenerar
            // 
            this.txtQRGenerar.Location = new System.Drawing.Point(476, 13);
            this.txtQRGenerar.Name = "txtQRGenerar";
            this.txtQRGenerar.Size = new System.Drawing.Size(350, 126);
            this.txtQRGenerar.TabIndex = 39;
            this.txtQRGenerar.Text = "";
            // 
            // buttonGenerarQR
            // 
            this.buttonGenerarQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGenerarQR.Depth = 0;
            this.buttonGenerarQR.FlatAppearance.BorderSize = 0;
            this.buttonGenerarQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerarQR.ForeColor = System.Drawing.Color.Teal;
            this.buttonGenerarQR.Location = new System.Drawing.Point(476, 145);
            this.buttonGenerarQR.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonGenerarQR.Name = "buttonGenerarQR";
            this.buttonGenerarQR.Primary = true;
            this.buttonGenerarQR.Size = new System.Drawing.Size(350, 30);
            this.buttonGenerarQR.TabIndex = 35;
            this.buttonGenerarQR.Text = "GENERAR QR";
            this.buttonGenerarQR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonGenerarQR.UseVisualStyleBackColor = true;
            this.buttonGenerarQR.Click += new System.EventHandler(this.buttonGenerarQR_Click);
            // 
            // picboxGenerador
            // 
            this.picboxGenerador.Location = new System.Drawing.Point(8, 13);
            this.picboxGenerador.Name = "picboxGenerador";
            this.picboxGenerador.Size = new System.Drawing.Size(462, 308);
            this.picboxGenerador.TabIndex = 2;
            this.picboxGenerador.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 48);
            this.panel1.TabIndex = 6;
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
            this.buttonSalir.Location = new System.Drawing.Point(737, 0);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(105, 48);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.Text = "X";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // integracionDataSet
            // 
            this.integracionDataSet.DataSetName = "IntegracionDataSet";
            this.integracionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // integracionDataSetBindingSource
            // 
            this.integracionDataSetBindingSource.DataSource = this.integracionDataSet;
            this.integracionDataSetBindingSource.Position = 0;
            // 
            // cuentaBindingSource
            // 
            this.cuentaBindingSource.DataMember = "cuenta";
            this.cuentaBindingSource.DataSource = this.integracionDataSet;
            // 
            // cuentaTableAdapter
            // 
            this.cuentaTableAdapter.ClearBeforeFill = true;
            // 
            // integracionDataSetBindingSource1
            // 
            this.integracionDataSetBindingSource1.DataSource = this.integracionDataSet;
            this.integracionDataSetBindingSource1.Position = 0;
            // 
            // cuentaBindingSource1
            // 
            this.cuentaBindingSource1.DataMember = "cuenta";
            this.cuentaBindingSource1.DataSource = this.integracionDataSetBindingSource1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Senior-App Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroLogin.ResumeLayout(false);
            this.metroLogin.PerformLayout();
            this.metroConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroGenera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxGenerador)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integracionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integracionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integracionDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSalir;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtCorreo;
        private MetroFramework.Controls.MetroTabPage metroConsulta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MetroFramework.Controls.MetroComboBox cboCamara;
        private MaterialSkin.Controls.MaterialRaisedButton buttonStart;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtQR;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroTabPage metroGenera;
        private System.Windows.Forms.RichTextBox txtQRGenerar;
        private MaterialSkin.Controls.MaterialRaisedButton buttonGenerarQR;
        private System.Windows.Forms.PictureBox picboxGenerador;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.BindingSource integracionDataSetBindingSource;
        private IntegracionDataSet integracionDataSet;
        private System.Windows.Forms.BindingSource cuentaBindingSource;
        private IntegracionDataSetTableAdapters.cuentaTableAdapter cuentaTableAdapter;
        private System.Windows.Forms.BindingSource cuentaBindingSource1;
        private System.Windows.Forms.BindingSource integracionDataSetBindingSource1;
    }
}

