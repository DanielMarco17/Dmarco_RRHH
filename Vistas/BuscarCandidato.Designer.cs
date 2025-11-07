using DMarco_RRHH.Bbdd;
using DMarco_RRHH.modelo;
using DMarco_RRHH.utilidades;
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace DMarco_RRHH.Vistas
{
    partial class BuscarCandidato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCandidato));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipoCandidatos = new System.Windows.Forms.ComboBox();
            this.campoDni = new System.Windows.Forms.TextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.campoFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.campoDireccion = new System.Windows.Forms.TextBox();
            this.campoCp = new System.Windows.Forms.TextBox();
            this.comboLocalidad = new System.Windows.Forms.ComboBox();
            this.campoTelefono = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.foto = new System.Windows.Forms.PictureBox();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonEnviar = new System.Windows.Forms.Button();
            this.botonFichaPDF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 74);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Búsqueda de candidatos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 621);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 10);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de candidatos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DNI";
            // 
            // comboTipoCandidatos
            // 
            this.comboTipoCandidatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoCandidatos.FormattingEnabled = true;
            this.comboTipoCandidatos.Items.AddRange(new object[] {
            "Seleccione",
            "Administración",
            "Almacén"});
            this.comboTipoCandidatos.Location = new System.Drawing.Point(173, 104);
            this.comboTipoCandidatos.Name = "comboTipoCandidatos";
            this.comboTipoCandidatos.Size = new System.Drawing.Size(139, 21);
            this.comboTipoCandidatos.TabIndex = 11;
            this.comboTipoCandidatos.Tag = "Tipo de Candidatos";
            this.comboTipoCandidatos.SelectedIndexChanged += new System.EventHandler(this.comboTipoCandidatos_SelectedIndexChanged);
            // 
            // campoDni
            // 
            this.campoDni.Location = new System.Drawing.Point(173, 148);
            this.campoDni.Name = "campoDni";
            this.campoDni.Size = new System.Drawing.Size(139, 20);
            this.campoDni.TabIndex = 15;
            this.campoDni.Tag = "Dni";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(362, 146);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(90, 23);
            this.botonBuscar.TabIndex = 16;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(34, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(34, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(34, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "F. de nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(34, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dirección";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(34, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "CP";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(34, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Localidad";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(34, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Teléfono";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(34, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Email";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(622, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Foto";
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(149, 30);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(211, 20);
            this.campoNombre.TabIndex = 12;
            this.campoNombre.Tag = "Nombre";
            // 
            // campoApellidos
            // 
            this.campoApellidos.Location = new System.Drawing.Point(149, 67);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(286, 20);
            this.campoApellidos.TabIndex = 13;
            this.campoApellidos.Tag = "Apellidos";
            // 
            // campoFechaNacimiento
            // 
            this.campoFechaNacimiento.Location = new System.Drawing.Point(149, 112);
            this.campoFechaNacimiento.Name = "campoFechaNacimiento";
            this.campoFechaNacimiento.Size = new System.Drawing.Size(253, 20);
            this.campoFechaNacimiento.TabIndex = 15;
            this.campoFechaNacimiento.Tag = "FechaNacimiento";
            // 
            // campoDireccion
            // 
            this.campoDireccion.Location = new System.Drawing.Point(149, 150);
            this.campoDireccion.Name = "campoDireccion";
            this.campoDireccion.Size = new System.Drawing.Size(334, 20);
            this.campoDireccion.TabIndex = 16;
            this.campoDireccion.Tag = "Dirección";
            this.campoDireccion.TextChanged += new System.EventHandler(this.campoDireccion_TextChanged);
            // 
            // campoCp
            // 
            this.campoCp.Location = new System.Drawing.Point(149, 193);
            this.campoCp.Name = "campoCp";
            this.campoCp.Size = new System.Drawing.Size(148, 20);
            this.campoCp.TabIndex = 17;
            this.campoCp.Tag = "Cp";
            this.campoCp.TextChanged += new System.EventHandler(this.campoCp_TextChanged);
            // 
            // comboLocalidad
            // 
            this.comboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLocalidad.FormattingEnabled = true;
            this.comboLocalidad.Items.AddRange(new object[] {
            "Seleccione",
            "Madrid",
            "Cuenca",
            "Albacete",
            "Segovia",
            "Zaragoza"});
            this.comboLocalidad.Location = new System.Drawing.Point(149, 236);
            this.comboLocalidad.Name = "comboLocalidad";
            this.comboLocalidad.Size = new System.Drawing.Size(211, 21);
            this.comboLocalidad.TabIndex = 18;
            this.comboLocalidad.Tag = "Localidad";
            this.comboLocalidad.SelectedIndexChanged += new System.EventHandler(this.comboLocalidad_SelectedIndexChanged);
            // 
            // campoTelefono
            // 
            this.campoTelefono.Location = new System.Drawing.Point(149, 280);
            this.campoTelefono.Name = "campoTelefono";
            this.campoTelefono.Size = new System.Drawing.Size(211, 20);
            this.campoTelefono.TabIndex = 19;
            this.campoTelefono.Tag = "Teléfono";
            this.campoTelefono.TextChanged += new System.EventHandler(this.campoTelefono_TextChanged);
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(149, 322);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(334, 20);
            this.campoEmail.TabIndex = 20;
            this.campoEmail.Tag = "Email";
            this.campoEmail.TextChanged += new System.EventHandler(this.campoEmail_TextChanged);
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.Controls.Add(this.foto);
            this.groupBoxDatosPersonales.Controls.Add(this.campoEmail);
            this.groupBoxDatosPersonales.Controls.Add(this.campoTelefono);
            this.groupBoxDatosPersonales.Controls.Add(this.comboLocalidad);
            this.groupBoxDatosPersonales.Controls.Add(this.campoCp);
            this.groupBoxDatosPersonales.Controls.Add(this.campoDireccion);
            this.groupBoxDatosPersonales.Controls.Add(this.campoFechaNacimiento);
            this.groupBoxDatosPersonales.Controls.Add(this.campoApellidos);
            this.groupBoxDatosPersonales.Controls.Add(this.campoNombre);
            this.groupBoxDatosPersonales.Controls.Add(this.label11);
            this.groupBoxDatosPersonales.Controls.Add(this.label10);
            this.groupBoxDatosPersonales.Controls.Add(this.label9);
            this.groupBoxDatosPersonales.Controls.Add(this.label8);
            this.groupBoxDatosPersonales.Controls.Add(this.label7);
            this.groupBoxDatosPersonales.Controls.Add(this.label6);
            this.groupBoxDatosPersonales.Controls.Add(this.label5);
            this.groupBoxDatosPersonales.Controls.Add(this.label12);
            this.groupBoxDatosPersonales.Controls.Add(this.label13);
            this.groupBoxDatosPersonales.ForeColor = System.Drawing.Color.Maroon;
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(70, 177);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(935, 363);
            this.groupBoxDatosPersonales.TabIndex = 17;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "DATOS PERSONALES";
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(625, 67);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(164, 196);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto.TabIndex = 21;
            this.foto.TabStop = false;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Enabled = false;
            this.botonEliminar.Location = new System.Drawing.Point(237, 564);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(167, 23);
            this.botonEliminar.TabIndex = 18;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonEnviar
            // 
            this.botonEnviar.Enabled = false;
            this.botonEnviar.Location = new System.Drawing.Point(451, 564);
            this.botonEnviar.Name = "botonEnviar";
            this.botonEnviar.Size = new System.Drawing.Size(167, 23);
            this.botonEnviar.TabIndex = 19;
            this.botonEnviar.Text = "Enviar email";
            this.botonEnviar.UseVisualStyleBackColor = true;
            this.botonEnviar.Click += new System.EventHandler(this.botonEnviar_Click);
            // 
            // botonFichaPDF
            // 
            this.botonFichaPDF.Enabled = false;
            this.botonFichaPDF.Location = new System.Drawing.Point(664, 564);
            this.botonFichaPDF.Name = "botonFichaPDF";
            this.botonFichaPDF.Size = new System.Drawing.Size(167, 23);
            this.botonFichaPDF.TabIndex = 20;
            this.botonFichaPDF.Text = "Ficha PDF";
            this.botonFichaPDF.UseVisualStyleBackColor = true;
            this.botonFichaPDF.Click += new System.EventHandler(this.botonFichaPDF_Click);
            // 
            // BuscarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 631);
            this.Controls.Add(this.botonFichaPDF);
            this.Controls.Add(this.botonEnviar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.groupBoxDatosPersonales);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.campoDni);
            this.Controls.Add(this.comboTipoCandidatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 670);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 670);
            this.Name = "BuscarCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Candidatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxDatosPersonales.ResumeLayout(false);
            this.groupBoxDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTipoCandidatos;
        private System.Windows.Forms.TextBox campoDni;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.DateTimePicker campoFechaNacimiento;
        private System.Windows.Forms.TextBox campoDireccion;
        private System.Windows.Forms.TextBox campoCp;
        private System.Windows.Forms.ComboBox comboLocalidad;
        private System.Windows.Forms.TextBox campoTelefono;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.GroupBox groupBoxDatosPersonales;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonEnviar;
        private System.Windows.Forms.Button botonFichaPDF;

        public static string emailCandidato;
        private void InicializarFormulario()
        {
            DesactivarCampos();

            comboTipoCandidatos.SelectedIndex = 0; 
        }

        private void DesactivarCampos()
        {
            campoNombre.Enabled = false;
            campoApellidos.Enabled = false;
            campoFechaNacimiento.Enabled = false;
            campoDireccion.Enabled = false;
            campoCp.Enabled = false;
            comboLocalidad.Enabled = false;
            campoTelefono.Enabled = false;
            campoEmail.Enabled = false;
        }
        private void ActivarCamposDniEncontrado()
        {
            botonEliminar.Enabled = true;
            botonEnviar.Enabled = true;
            botonFichaPDF.Enabled = true;
            botonBuscar.Enabled = false;
            campoDni.Enabled = false;
            comboTipoCandidatos.Enabled = false;
        }
        private void DesactivarCamposDniEncontrado()
        {
            botonEliminar.Enabled = false;
            botonEnviar.Enabled =false;
            botonFichaPDF.Enabled = false;
            botonBuscar.Enabled = true;
            campoDni.Enabled = true;
            comboTipoCandidatos.Enabled = true;
        }

        private void LimpiarCampos()
        {
            campoNombre.Text = "";
            campoApellidos.Text = "";
            campoFechaNacimiento.Value = DateTime.Now;
            campoDireccion.Text = "";
            campoCp.Text = "";
            comboLocalidad.SelectedIndex = -1;
            campoTelefono.Text = "";
            campoEmail.Text = "";
        }

        private void BuscarCandidatoAdministracion()
        {
            string dni = campoDni.Text.ToUpper();

            if (Conexion.CompruebaDniCandidatoAdm(dni))
            {
                CandidatoAdministracion candidato = Conexion.ObtenerCandidatoAdministracion(dni);
                CargarDatosCandidatoAdm(candidato);
                ActivarCamposDniEncontrado();
            }
            else
            {
                MessageBox.Show("No se encontró ningún candidato de administración con ese DNI",
                    "Candidato no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                DesactivarCampos();
            }
        }

        private void BuscarCandidatoAlmacen()
        {
            string dni = campoDni.Text.ToUpper();

            if (Conexion.CompruebaDniCandidato(dni))
            {
                CandidatoAlmacen candidato = Conexion.ObtenerCandidatoAlmacen(dni);
                CargarDatosCandidatoAlmacen(candidato);
                ActivarCamposDniEncontrado();
            }
            else
            {
                MessageBox.Show("No se encontró ningún candidato de almacén con ese DNI",
                    "Candidato no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                DesactivarCampos();
            }
        }

        private void CargarDatosCandidatoAdm(CandidatoAdministracion candidato)
        {
            campoNombre.Text = candidato.Nombre;
            campoApellidos.Text = candidato.Apellidos;
            campoFechaNacimiento.Value = candidato.FechaNacimiento;
            campoDireccion.Text = candidato.Direccion;
            campoCp.Text = candidato.Cp.ToString();
            comboLocalidad.SelectedItem = candidato.Localidad;
            campoTelefono.Text = candidato.Tlfno.ToString();
            campoEmail.Text = candidato.Email;
            if (candidato.Foto != null && candidato.Foto.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(candidato.Foto))
                    {
                        foto.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la foto: " + ex.Message);
                    foto.Image = null;
                }
            }
            else
            {
                foto.Image = null; 
            }
        }

        private void CargarDatosCandidatoAlmacen(CandidatoAlmacen candidato)
        {
            campoNombre.Text = candidato.Nombre;
            campoApellidos.Text = candidato.Apellidos;
            campoFechaNacimiento.Value = candidato.FechaNacimiento;
            campoDireccion.Text = candidato.Direccion;
            campoCp.Text = candidato.Cp.ToString();
            comboLocalidad.SelectedItem = candidato.Localidad;
            campoTelefono.Text = candidato.Tlfno.ToString();
            campoEmail.Text = candidato.Email;

            if (candidato.Foto != null && candidato.Foto.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(candidato.Foto))
                    {
                        foto.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la foto: " + ex.Message);
                    foto.Image = null;
                }
            }
            else
            {
                foto.Image = null;
            }
        }

        public void EnviarMail()
        {
            BuscarCandidato.emailCandidato = campoEmail.Text.Trim();
            DatosMensaje dm = new DatosMensaje();
            dm.Show();
        }

    }
}