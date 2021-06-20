
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
            this.buttonMostrarConsultarDatos = new System.Windows.Forms.Button();
            this.buttonMostrarLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.jesusBailando = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jesusBailando)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMostrarConsultarDatos
            // 
            this.buttonMostrarConsultarDatos.Location = new System.Drawing.Point(906, 167);
            this.buttonMostrarConsultarDatos.Name = "buttonMostrarConsultarDatos";
            this.buttonMostrarConsultarDatos.Size = new System.Drawing.Size(193, 39);
            this.buttonMostrarConsultarDatos.TabIndex = 0;
            this.buttonMostrarConsultarDatos.Text = "Consultar datos";
            this.buttonMostrarConsultarDatos.UseVisualStyleBackColor = true;
            this.buttonMostrarConsultarDatos.Click += new System.EventHandler(this.buttonConsultarDatos_Click);
            // 
            // buttonMostrarLogin
            // 
            this.buttonMostrarLogin.Location = new System.Drawing.Point(906, 247);
            this.buttonMostrarLogin.Name = "buttonMostrarLogin";
            this.buttonMostrarLogin.Size = new System.Drawing.Size(193, 39);
            this.buttonMostrarLogin.TabIndex = 2;
            this.buttonMostrarLogin.Text = "Login ADM";
            this.buttonMostrarLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Senior-App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // jesusBailando
            // 
            this.jesusBailando.Location = new System.Drawing.Point(906, 428);
            this.jesusBailando.Name = "jesusBailando";
            this.jesusBailando.Size = new System.Drawing.Size(193, 200);
            this.jesusBailando.TabIndex = 4;
            this.jesusBailando.TabStop = false;
            this.jesusBailando.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 569);
            this.panel1.TabIndex = 5;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(906, 328);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(193, 39);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 640);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.jesusBailando);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMostrarLogin);
            this.Controls.Add(this.buttonMostrarConsultarDatos);
            this.Name = "Form1";
            this.Text = "Senior-App Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jesusBailando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMostrarConsultarDatos;
        private System.Windows.Forms.Button buttonMostrarLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox jesusBailando;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
    }
}

