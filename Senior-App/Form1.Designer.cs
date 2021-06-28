
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
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtError = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.txtCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroConsulta = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cboCamara = new MetroFramework.Controls.MetroComboBox();
            this.buttonStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.telefonoTxt = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.apellidoMaMaptxt = new MetroFramework.Controls.MetroLabel();
            this.apellidoPaMaptxt = new MetroFramework.Controls.MetroLabel();
            this.nombreMaptxt = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.etiquetaDescripcion = new MetroFramework.Controls.MetroLabel();
            this.generarAlerta = new MaterialSkin.Controls.MaterialFlatButton();
            this.gMapa = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.integracionDataSet = new Senior_App.IntegracionDataSet();
            this.integracionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentaTableAdapter = new Senior_App.IntegracionDataSetTableAdapters.cuentaTableAdapter();
            this.integracionDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cuentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.metroTabControl1.SuspendLayout();
            this.metroLogin.SuspendLayout();
            this.metroConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTabPage1.SuspendLayout();
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
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 51);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(842, 577);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroLogin
            // 
            this.metroLogin.BackColor = System.Drawing.Color.White;
            this.metroLogin.Controls.Add(this.materialFlatButton2);
            this.metroLogin.Controls.Add(this.materialFlatButton1);
            this.metroLogin.Controls.Add(this.txtError);
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
            this.metroLogin.Size = new System.Drawing.Size(834, 536);
            this.metroLogin.TabIndex = 0;
            this.metroLogin.Text = "Login";
            this.metroLogin.VerticalScrollbarBarColor = true;
            this.metroLogin.VerticalScrollbarHighlightOnWheel = false;
            this.metroLogin.VerticalScrollbarSize = 10;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(603, 116);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(172, 36);
            this.materialFlatButton2.TabIndex = 23;
            this.materialFlatButton2.Text = "materialFlatButton2";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click_1);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(64, 143);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(172, 36);
            this.materialFlatButton1.TabIndex = 22;
            this.materialFlatButton1.Text = "materialFlatButton1";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.BackColor = System.Drawing.Color.White;
            this.txtError.Depth = 0;
            this.txtError.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtError.Location = new System.Drawing.Point(256, 358);
            this.txtError.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(240, 19);
            this.txtError.TabIndex = 21;
            this.txtError.Text = "*  Usuario o contraseña incorrecto";
            this.txtError.Visible = false;
            this.txtError.Click += new System.EventHandler(this.txtError_Click);
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
            this.metroTextBox2.PasswordChar = '*';
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
            this.metroConsulta.Controls.Add(this.metroLabel4);
            this.metroConsulta.Controls.Add(this.metroLabel3);
            this.metroConsulta.Controls.Add(this.metroLabel2);
            this.metroConsulta.Controls.Add(this.metroLabel1);
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
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(480, 246);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(0, 0);
            this.metroLabel4.TabIndex = 38;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(480, 227);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 37;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(480, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 36;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(480, 189);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 35;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Location = new System.Drawing.Point(8, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 406);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.BackColor = System.Drawing.Color.White;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(130, 452);
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
            this.cboCamara.Location = new System.Drawing.Point(213, 452);
            this.cboCamara.Name = "cboCamara";
            this.cboCamara.Size = new System.Drawing.Size(261, 29);
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
            this.buttonStart.Location = new System.Drawing.Point(499, 452);
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
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.telefonoTxt);
            this.metroTabPage1.Controls.Add(this.metroTextBox1);
            this.metroTabPage1.Controls.Add(this.apellidoMaMaptxt);
            this.metroTabPage1.Controls.Add(this.apellidoPaMaptxt);
            this.metroTabPage1.Controls.Add(this.nombreMaptxt);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.etiquetaDescripcion);
            this.metroTabPage1.Controls.Add(this.generarAlerta);
            this.metroTabPage1.Controls.Add(this.gMapa);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 37);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(834, 536);
            this.metroTabPage1.TabIndex = 3;
            this.metroTabPage1.Text = "Maps";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // telefonoTxt
            // 
            this.telefonoTxt.AutoSize = true;
            this.telefonoTxt.Location = new System.Drawing.Point(564, 218);
            this.telefonoTxt.Name = "telefonoTxt";
            this.telefonoTxt.Size = new System.Drawing.Size(76, 19);
            this.telefonoTxt.TabIndex = 11;
            this.telefonoTxt.Text = "Descripcion";
            this.telefonoTxt.Visible = false;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "Ingrese descripcion"};
            this.metroTextBox1.Location = new System.Drawing.Point(564, 251);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(221, 23);
            this.metroTextBox1.TabIndex = 10;
            this.metroTextBox1.Text = "Ingrese descripcion";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.Visible = false;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // apellidoMaMaptxt
            // 
            this.apellidoMaMaptxt.AutoSize = true;
            this.apellidoMaMaptxt.Location = new System.Drawing.Point(564, 188);
            this.apellidoMaMaptxt.Name = "apellidoMaMaptxt";
            this.apellidoMaMaptxt.Size = new System.Drawing.Size(76, 19);
            this.apellidoMaMaptxt.TabIndex = 9;
            this.apellidoMaMaptxt.Text = "Descripcion";
            this.apellidoMaMaptxt.Visible = false;
            // 
            // apellidoPaMaptxt
            // 
            this.apellidoPaMaptxt.AutoSize = true;
            this.apellidoPaMaptxt.Location = new System.Drawing.Point(564, 159);
            this.apellidoPaMaptxt.Name = "apellidoPaMaptxt";
            this.apellidoPaMaptxt.Size = new System.Drawing.Size(76, 19);
            this.apellidoPaMaptxt.TabIndex = 8;
            this.apellidoPaMaptxt.Text = "Descripcion";
            this.apellidoPaMaptxt.Visible = false;
            this.apellidoPaMaptxt.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // nombreMaptxt
            // 
            this.nombreMaptxt.AutoSize = true;
            this.nombreMaptxt.Location = new System.Drawing.Point(564, 131);
            this.nombreMaptxt.Name = "nombreMaptxt";
            this.nombreMaptxt.Size = new System.Drawing.Size(76, 19);
            this.nombreMaptxt.TabIndex = 7;
            this.nombreMaptxt.Text = "Descripcion";
            this.nombreMaptxt.Visible = false;
            this.nombreMaptxt.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(564, 100);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Latitud";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(564, 71);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(60, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Longitud";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click_1);
            // 
            // etiquetaDescripcion
            // 
            this.etiquetaDescripcion.AutoSize = true;
            this.etiquetaDescripcion.Location = new System.Drawing.Point(633, 40);
            this.etiquetaDescripcion.Name = "etiquetaDescripcion";
            this.etiquetaDescripcion.Size = new System.Drawing.Size(76, 19);
            this.etiquetaDescripcion.TabIndex = 4;
            this.etiquetaDescripcion.Text = "Descripcion";
            this.etiquetaDescripcion.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // generarAlerta
            // 
            this.generarAlerta.AutoSize = true;
            this.generarAlerta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generarAlerta.BackColor = System.Drawing.SystemColors.Control;
            this.generarAlerta.Depth = 0;
            this.generarAlerta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.generarAlerta.Location = new System.Drawing.Point(603, 402);
            this.generarAlerta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.generarAlerta.MouseState = MaterialSkin.MouseState.HOVER;
            this.generarAlerta.Name = "generarAlerta";
            this.generarAlerta.Primary = false;
            this.generarAlerta.Size = new System.Drawing.Size(127, 36);
            this.generarAlerta.TabIndex = 3;
            this.generarAlerta.Text = "Generar alerta";
            this.generarAlerta.UseVisualStyleBackColor = false;
            this.generarAlerta.Visible = false;
            this.generarAlerta.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // gMapa
            // 
            this.gMapa.Bearing = 0F;
            this.gMapa.CanDragMap = true;
            this.gMapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapa.GrayScaleMode = false;
            this.gMapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapa.LevelsKeepInMemory = 5;
            this.gMapa.Location = new System.Drawing.Point(8, 14);
            this.gMapa.MarkersEnabled = true;
            this.gMapa.MaxZoom = 2;
            this.gMapa.MinZoom = 2;
            this.gMapa.MouseWheelZoomEnabled = true;
            this.gMapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapa.Name = "gMapa";
            this.gMapa.NegativeMode = false;
            this.gMapa.PolygonsEnabled = true;
            this.gMapa.RetryLoadTile = 0;
            this.gMapa.RoutesEnabled = true;
            this.gMapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapa.ShowTileGridLines = false;
            this.gMapa.Size = new System.Drawing.Size(530, 502);
            this.gMapa.TabIndex = 2;
            this.gMapa.Zoom = 0D;
            this.gMapa.Load += new System.EventHandler(this.gMapControl1_Load);
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
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
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
            this.metroConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource integracionDataSetBindingSource;
        private IntegracionDataSet integracionDataSet;
        private System.Windows.Forms.BindingSource cuentaBindingSource;
        private IntegracionDataSetTableAdapters.cuentaTableAdapter cuentaTableAdapter;
        private System.Windows.Forms.BindingSource cuentaBindingSource1;
        private System.Windows.Forms.BindingSource integracionDataSetBindingSource1;
        private MaterialSkin.Controls.MaterialLabel txtError;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private GMap.NET.WindowsForms.GMapControl gMapa;
        private MaterialSkin.Controls.MaterialFlatButton generarAlerta;
        private MetroFramework.Controls.MetroLabel etiquetaDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel apellidoPaMaptxt;
        private MetroFramework.Controls.MetroLabel nombreMaptxt;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel apellidoMaMaptxt;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel telefonoTxt;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
    }
}

