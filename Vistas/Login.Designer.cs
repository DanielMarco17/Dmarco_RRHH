using DMarco_RRHH.Bbdd;
using DMarco_RRHH.Vistas;
using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DMarco_RRHH
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imagenPass = new System.Windows.Forms.PictureBox();
            this.imagenUsuario = new System.Windows.Forms.PictureBox();
            this.botonEntrar = new System.Windows.Forms.Button();
            this.campoPass = new System.Windows.Forms.TextBox();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 391);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imagenPass);
            this.groupBox1.Controls.Add(this.imagenUsuario);
            this.groupBox1.Controls.Add(this.botonEntrar);
            this.groupBox1.Controls.Add(this.campoPass);
            this.groupBox1.Controls.Add(this.campoUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(487, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 283);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACCEDER";
            // 
            // imagenPass
            // 
            this.imagenPass.Image = ((System.Drawing.Image)(resources.GetObject("imagenPass.Image")));
            this.imagenPass.Location = new System.Drawing.Point(307, 133);
            this.imagenPass.Name = "imagenPass";
            this.imagenPass.Size = new System.Drawing.Size(31, 33);
            this.imagenPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenPass.TabIndex = 11;
            this.imagenPass.TabStop = false;
            this.imagenPass.Visible = false;
            // 
            // imagenUsuario
            // 
            this.imagenUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imagenUsuario.Image")));
            this.imagenUsuario.Location = new System.Drawing.Point(307, 64);
            this.imagenUsuario.Name = "imagenUsuario";
            this.imagenUsuario.Size = new System.Drawing.Size(31, 33);
            this.imagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenUsuario.TabIndex = 10;
            this.imagenUsuario.TabStop = false;
            this.imagenUsuario.Visible = false;
            // 
            // botonEntrar
            // 
            this.botonEntrar.BackColor = System.Drawing.Color.IndianRed;
            this.botonEntrar.ForeColor = System.Drawing.Color.White;
            this.botonEntrar.Location = new System.Drawing.Point(118, 222);
            this.botonEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.botonEntrar.Name = "botonEntrar";
            this.botonEntrar.Size = new System.Drawing.Size(171, 34);
            this.botonEntrar.TabIndex = 9;
            this.botonEntrar.Text = "ENTRAR";
            this.botonEntrar.UseVisualStyleBackColor = false;
            this.botonEntrar.Click += new System.EventHandler(this.botonEntrar_Click);
            // 
            // campoPass
            // 
            this.campoPass.Location = new System.Drawing.Point(118, 146);
            this.campoPass.Margin = new System.Windows.Forms.Padding(2);
            this.campoPass.Name = "campoPass";
            this.campoPass.Size = new System.Drawing.Size(171, 20);
            this.campoPass.TabIndex = 8;
            this.campoPass.UseSystemPasswordChar = true;
            this.campoPass.Enter += new System.EventHandler(this.campoPass_Enter);
            this.campoPass.Leave += new System.EventHandler(this.campoPass_Leave);
            // 
            // campoUsuario
            // 
            this.campoUsuario.Location = new System.Drawing.Point(118, 77);
            this.campoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(171, 20);
            this.campoUsuario.TabIndex = 7;
            this.campoUsuario.Enter += new System.EventHandler(this.campoUsuario_Enter);
            this.campoUsuario.Leave += new System.EventHandler(this.campoUsuario_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CONTRASEÑA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "USUARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(625, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(92, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 391);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(880, 430);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonEntrar;
        private System.Windows.Forms.TextBox campoPass;
        private System.Windows.Forms.TextBox campoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imagenPass;
        private System.Windows.Forms.PictureBox imagenUsuario;
        private System.Windows.Forms.PictureBox pictureBox4;

        public static string nomApeUsuario;
        public static string ip = ObtenerIPv4();
        public static string fecha;
        public static string nomUsuario;

        public void Entrar()
        {

            Conexion.Conectar();

            if (Conexion.Acceder(campoUsuario.Text, campoPass.Text))
            {
                nomUsuario = campoUsuario.Text;
                nomApeUsuario = Conexion.RescatarDatosUserLogado(campoUsuario.Text);
                fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");


                Principal vp = new Principal();
                vp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de identificación, Inténtelo de nuevo.",
                               "LOGIN",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                campoUsuario.Text = "";
                campoPass.Text = "";
            }

            Conexion.Desconectar();
        }

        public static string ObtenerIPv4()
        {
            string ip = "";
            string patronIpv4 = @"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$";

            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIPs)
            {
                if (Regex.IsMatch(address.ToString(), patronIpv4))
                {
                    ip = address.ToString();
                }
            }
            return ip;
        }

    }
}

