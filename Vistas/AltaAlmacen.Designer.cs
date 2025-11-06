using DMarco_RRHH.Bbdd;
using DMarco_RRHH.modelo;
using DMarco_RRHH.utilidades;
using System;
using System.Windows.Forms;

namespace DMarco_RRHH.Vistas
{
    partial class AltaAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaAlmacen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.campoAnexoFoto = new System.Windows.Forms.TextBox();
            this.botonAnexarFoto = new System.Windows.Forms.Button();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoTelefono = new System.Windows.Forms.TextBox();
            this.comboLocalidad = new System.Windows.Forms.ComboBox();
            this.campoCp = new System.Windows.Forms.TextBox();
            this.campoDireccion = new System.Windows.Forms.TextBox();
            this.campoFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.campoDni = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxDatosComplementarios = new System.Windows.Forms.GroupBox();
            this.campoObservaciones = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.radiosTratemientos = new System.Windows.Forms.GroupBox();
            this.checkBoxCarnetCamion = new System.Windows.Forms.CheckBox();
            this.checkBoxCarnetCarretilla = new System.Windows.Forms.CheckBox();
            this.checkBoxCarneConducir = new System.Windows.Forms.CheckBox();
            this.comboEstudiosFinalizados = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxDatosPersonales.SuspendLayout();
            this.groupBoxDatosComplementarios.SuspendLayout();
            this.radiosTratemientos.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alta de candidatos para puestos de almacén";
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.Controls.Add(this.campoAnexoFoto);
            this.groupBoxDatosPersonales.Controls.Add(this.botonAnexarFoto);
            this.groupBoxDatosPersonales.Controls.Add(this.campoEmail);
            this.groupBoxDatosPersonales.Controls.Add(this.campoTelefono);
            this.groupBoxDatosPersonales.Controls.Add(this.comboLocalidad);
            this.groupBoxDatosPersonales.Controls.Add(this.campoCp);
            this.groupBoxDatosPersonales.Controls.Add(this.campoDireccion);
            this.groupBoxDatosPersonales.Controls.Add(this.campoFechaNacimiento);
            this.groupBoxDatosPersonales.Controls.Add(this.campoDni);
            this.groupBoxDatosPersonales.Controls.Add(this.campoApellidos);
            this.groupBoxDatosPersonales.Controls.Add(this.campoNombre);
            this.groupBoxDatosPersonales.Controls.Add(this.label11);
            this.groupBoxDatosPersonales.Controls.Add(this.label10);
            this.groupBoxDatosPersonales.Controls.Add(this.label9);
            this.groupBoxDatosPersonales.Controls.Add(this.label8);
            this.groupBoxDatosPersonales.Controls.Add(this.label7);
            this.groupBoxDatosPersonales.Controls.Add(this.label6);
            this.groupBoxDatosPersonales.Controls.Add(this.label5);
            this.groupBoxDatosPersonales.Controls.Add(this.label4);
            this.groupBoxDatosPersonales.Controls.Add(this.label3);
            this.groupBoxDatosPersonales.Controls.Add(this.label2);
            this.groupBoxDatosPersonales.ForeColor = System.Drawing.Color.Maroon;
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(44, 114);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(523, 442);
            this.groupBoxDatosPersonales.TabIndex = 2;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "DATOS PERSONALES";
            // 
            // campoAnexoFoto
            // 
            this.campoAnexoFoto.Location = new System.Drawing.Point(272, 405);
            this.campoAnexoFoto.Name = "campoAnexoFoto";
            this.campoAnexoFoto.Size = new System.Drawing.Size(211, 20);
            this.campoAnexoFoto.TabIndex = 22;
            // 
            // botonAnexarFoto
            // 
            this.botonAnexarFoto.Location = new System.Drawing.Point(149, 403);
            this.botonAnexarFoto.Name = "botonAnexarFoto";
            this.botonAnexarFoto.Size = new System.Drawing.Size(95, 23);
            this.botonAnexarFoto.TabIndex = 21;
            this.botonAnexarFoto.Text = "Anexar Foto";
            this.botonAnexarFoto.UseVisualStyleBackColor = true;
            this.botonAnexarFoto.Click += new System.EventHandler(this.botonAnexarFoto_Click);
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(149, 364);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(334, 20);
            this.campoEmail.TabIndex = 20;
            // 
            // campoTelefono
            // 
            this.campoTelefono.Location = new System.Drawing.Point(149, 322);
            this.campoTelefono.Name = "campoTelefono";
            this.campoTelefono.Size = new System.Drawing.Size(211, 20);
            this.campoTelefono.TabIndex = 19;
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
            this.comboLocalidad.Location = new System.Drawing.Point(149, 278);
            this.comboLocalidad.Name = "comboLocalidad";
            this.comboLocalidad.Size = new System.Drawing.Size(211, 21);
            this.comboLocalidad.TabIndex = 18;
            // 
            // campoCp
            // 
            this.campoCp.Location = new System.Drawing.Point(149, 235);
            this.campoCp.Name = "campoCp";
            this.campoCp.Size = new System.Drawing.Size(148, 20);
            this.campoCp.TabIndex = 17;
            // 
            // campoDireccion
            // 
            this.campoDireccion.Location = new System.Drawing.Point(149, 192);
            this.campoDireccion.Name = "campoDireccion";
            this.campoDireccion.Size = new System.Drawing.Size(334, 20);
            this.campoDireccion.TabIndex = 16;
            // 
            // campoFechaNacimiento
            // 
            this.campoFechaNacimiento.Location = new System.Drawing.Point(149, 148);
            this.campoFechaNacimiento.Name = "campoFechaNacimiento";
            this.campoFechaNacimiento.Size = new System.Drawing.Size(253, 20);
            this.campoFechaNacimiento.TabIndex = 15;
            // 
            // campoDni
            // 
            this.campoDni.Location = new System.Drawing.Point(149, 110);
            this.campoDni.Name = "campoDni";
            this.campoDni.Size = new System.Drawing.Size(211, 20);
            this.campoDni.TabIndex = 14;
            // 
            // campoApellidos
            // 
            this.campoApellidos.Location = new System.Drawing.Point(149, 67);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(286, 20);
            this.campoApellidos.TabIndex = 13;
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(149, 30);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(211, 20);
            this.campoNombre.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(34, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Foto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(34, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(34, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(34, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Localidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(34, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "CP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(34, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(34, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "F. de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(34, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(34, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "REGISTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 621);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 10);
            this.panel2.TabIndex = 5;
            // 
            // groupBoxDatosComplementarios
            // 
            this.groupBoxDatosComplementarios.Controls.Add(this.campoObservaciones);
            this.groupBoxDatosComplementarios.Controls.Add(this.label15);
            this.groupBoxDatosComplementarios.Controls.Add(this.radiosTratemientos);
            this.groupBoxDatosComplementarios.Controls.Add(this.comboEstudiosFinalizados);
            this.groupBoxDatosComplementarios.Controls.Add(this.label12);
            this.groupBoxDatosComplementarios.ForeColor = System.Drawing.Color.Maroon;
            this.groupBoxDatosComplementarios.Location = new System.Drawing.Point(573, 114);
            this.groupBoxDatosComplementarios.Name = "groupBoxDatosComplementarios";
            this.groupBoxDatosComplementarios.Size = new System.Drawing.Size(460, 442);
            this.groupBoxDatosComplementarios.TabIndex = 6;
            this.groupBoxDatosComplementarios.TabStop = false;
            this.groupBoxDatosComplementarios.Text = "DATOS COMPLEMENTARIOS";
            // 
            // campoObservaciones
            // 
            this.campoObservaciones.Location = new System.Drawing.Point(42, 325);
            this.campoObservaciones.Multiline = true;
            this.campoObservaciones.Name = "campoObservaciones";
            this.campoObservaciones.Size = new System.Drawing.Size(353, 96);
            this.campoObservaciones.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(39, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Observaciones";
            // 
            // radiosTratemientos
            // 
            this.radiosTratemientos.Controls.Add(this.checkBoxCarnetCamion);
            this.radiosTratemientos.Controls.Add(this.checkBoxCarnetCarretilla);
            this.radiosTratemientos.Controls.Add(this.checkBoxCarneConducir);
            this.radiosTratemientos.ForeColor = System.Drawing.Color.Maroon;
            this.radiosTratemientos.Location = new System.Drawing.Point(42, 113);
            this.radiosTratemientos.Name = "radiosTratemientos";
            this.radiosTratemientos.Size = new System.Drawing.Size(353, 181);
            this.radiosTratemientos.TabIndex = 31;
            this.radiosTratemientos.TabStop = false;
            this.radiosTratemientos.Text = "Tratamiento de textos";
            // 
            // checkBoxCarnetCamion
            // 
            this.checkBoxCarnetCamion.AutoSize = true;
            this.checkBoxCarnetCamion.Location = new System.Drawing.Point(115, 124);
            this.checkBoxCarnetCamion.Name = "checkBoxCarnetCamion";
            this.checkBoxCarnetCamion.Size = new System.Drawing.Size(109, 17);
            this.checkBoxCarnetCamion.TabIndex = 27;
            this.checkBoxCarnetCamion.Text = "Carnet de camión";
            this.checkBoxCarnetCamion.UseVisualStyleBackColor = true;
            // 
            // checkBoxCarnetCarretilla
            // 
            this.checkBoxCarnetCarretilla.AutoSize = true;
            this.checkBoxCarnetCarretilla.Location = new System.Drawing.Point(115, 82);
            this.checkBoxCarnetCarretilla.Name = "checkBoxCarnetCarretilla";
            this.checkBoxCarnetCarretilla.Size = new System.Drawing.Size(114, 17);
            this.checkBoxCarnetCarretilla.TabIndex = 26;
            this.checkBoxCarnetCarretilla.Text = "Carnet de carretilla";
            this.checkBoxCarnetCarretilla.UseVisualStyleBackColor = true;
            // 
            // checkBoxCarneConducir
            // 
            this.checkBoxCarneConducir.AutoSize = true;
            this.checkBoxCarneConducir.Location = new System.Drawing.Point(115, 41);
            this.checkBoxCarneConducir.Name = "checkBoxCarneConducir";
            this.checkBoxCarneConducir.Size = new System.Drawing.Size(116, 17);
            this.checkBoxCarneConducir.TabIndex = 25;
            this.checkBoxCarneConducir.Text = "Carnet de conducir";
            this.checkBoxCarneConducir.UseVisualStyleBackColor = true;
            // 
            // comboEstudiosFinalizados
            // 
            this.comboEstudiosFinalizados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstudiosFinalizados.FormattingEnabled = true;
            this.comboEstudiosFinalizados.Items.AddRange(new object[] {
            "Seleccione",
            "Eso",
            "Grado Medio",
            "Bachillerato",
            "Grado Superior",
            "Universitarios"});
            this.comboEstudiosFinalizados.Location = new System.Drawing.Point(157, 46);
            this.comboEstudiosFinalizados.Name = "comboEstudiosFinalizados";
            this.comboEstudiosFinalizados.Size = new System.Drawing.Size(167, 21);
            this.comboEstudiosFinalizados.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(35, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Estudios Finalizados";
            // 
            // AltaAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 631);
            this.Controls.Add(this.groupBoxDatosComplementarios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxDatosPersonales);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 670);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 670);
            this.Name = "AltaAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevos candidatos para puestos de almacén";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxDatosPersonales.ResumeLayout(false);
            this.groupBoxDatosPersonales.PerformLayout();
            this.groupBoxDatosComplementarios.ResumeLayout(false);
            this.groupBoxDatosComplementarios.PerformLayout();
            this.radiosTratemientos.ResumeLayout(false);
            this.radiosTratemientos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDatosPersonales;
        private System.Windows.Forms.TextBox campoAnexoFoto;
        private System.Windows.Forms.Button botonAnexarFoto;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoTelefono;
        private System.Windows.Forms.ComboBox comboLocalidad;
        private System.Windows.Forms.TextBox campoCp;
        private System.Windows.Forms.TextBox campoDireccion;
        private System.Windows.Forms.DateTimePicker campoFechaNacimiento;
        private System.Windows.Forms.TextBox campoDni;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxDatosComplementarios;
        private System.Windows.Forms.TextBox campoObservaciones;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox radiosTratemientos;
        private System.Windows.Forms.ComboBox comboEstudiosFinalizados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxCarnetCamion;
        private System.Windows.Forms.CheckBox checkBoxCarnetCarretilla;
        private System.Windows.Forms.CheckBox checkBoxCarneConducir;

        private void ConfigurarFormulario()
        {
            // Configurar eventos para restaurar colores cuando toman foco
            Utilidades.ConfigurarEventosValidacion(groupBoxDatosPersonales);
            Utilidades.ConfigurarEventosValidacion(groupBoxDatosComplementarios);
            Utilidades.ConfigurarDatePickerEdadMinima(campoFechaNacimiento, 18);

            // Configurar tags de los controles para mensajes personalizados
            campoNombre.Tag = "Nombre";
            campoApellidos.Tag = "Apellidos";
            campoDni.Tag = "DNI";
            campoFechaNacimiento.Tag = "Fecha de nacimiento";
            campoDireccion.Tag = "Dirección";
            campoCp.Tag = "Código Postal";
            comboLocalidad.Tag = "Localidad";
            campoTelefono.Tag = "Teléfono";
            campoEmail.Tag = "Email";
            comboEstudiosFinalizados.Tag = "Estudios Finalizados";

            // Los checkBox no necesitan Tag porque no son obligatorios
            // Por defecto quedarán sin marcar (valor "NO")
        }

        public void Registro()
        {
            // 1. Validar todos los campos obligatorios del formulario
            if (!Utilidades.ValidarFormularioCompleto(groupBoxDatosPersonales))
                return;

            if (!Utilidades.ValidarFormularioCompleto(groupBoxDatosComplementarios))
                return;

            if (!Utilidades.ValidarFoto(campoAnexoFoto.Text, fotoBytes))
                return;

            // 2. Validaciones específicas de formato
            if (!Utilidades.ValidarDNI(campoDni.Text))
            {
                campoDni.BackColor = System.Drawing.Color.LightCoral;
                return;
            }

            if (!Utilidades.ValidarTelefono(campoTelefono.Text))
            {
                campoTelefono.BackColor = System.Drawing.Color.LightCoral;
                return;
            }

            if (!Utilidades.ValidarEmail(campoEmail.Text))
            {
                campoEmail.BackColor = System.Drawing.Color.LightCoral;
                return;
            }

            if (!Utilidades.ValidarCP(campoCp.Text))
            {
                campoCp.BackColor = System.Drawing.Color.LightCoral;
                return;
            }
            if (!Utilidades.ValidarEdadMinima(campoFechaNacimiento, 18))
            {
                campoFechaNacimiento.Focus();
                return;
            }

            // 3. Verificar DNI duplicado
            if (Conexion.CompruebaDniCandidato(campoDni.Text.Trim().ToUpper()))
            {
                MessageBox.Show("Ya existe un candidato para el puesto de Almacén registrado con este DNI",
                    "DNI Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campoDni.BackColor = System.Drawing.Color.LightCoral;
                campoDni.Focus();
                return;
            }

            // 4. Crear objeto CandidatoAlmacen
            // Los CheckBox no marcados tendrán valor "NO" automáticamente
            CandidatoAlmacen candidato = new CandidatoAlmacen
            {
                // Propiedades heredadas de Candidato (clase base)
                Nombre = campoNombre.Text.Trim(),
                Apellidos = campoApellidos.Text.Trim(),
                Dni = campoDni.Text.Trim().ToUpper(),
                FechaNacimiento = campoFechaNacimiento.Value.Date,
                Direccion = campoDireccion.Text.Trim(),
                Cp = int.Parse(campoCp.Text.Trim()),
                Localidad = comboLocalidad.SelectedItem.ToString(),
                Tlfno = int.Parse(campoTelefono.Text.Trim()),
                Email = campoEmail.Text.Trim(),
                Foto = fotoBytes,
                NivelEstudios = comboEstudiosFinalizados.SelectedItem.ToString(),
                Observaciones = campoObservaciones.Text.Trim(),
                FechaAlta = DateTime.Now,
                UsuarioRegistrador = Login.nomUsuario,

                // Propiedades específicas de CandidatoAlmacen
                // Si el CheckBox está marcado = "SI", si no está marcado = "NO"
                CarnetConducir = checkBoxCarneConducir.Checked ? "SI" : "NO",
                CarnetCarretilla = checkBoxCarnetCarretilla.Checked ? "SI" : "NO",
                CarnetCamion = checkBoxCarnetCamion.Checked ? "SI" : "NO"
            };

            // 5. Registrar en la base de datos
            if (Conexion.RegistrarCandidatoAlmacen(candidato))
            {
                MessageBox.Show(
                    $"Candidato {candidato.Nombre} {candidato.Apellidos} registrado correctamente",
                    "Registro Exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Limpiar formulario después de registrar
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show(
                    "Error al registrar el candidato. Por favor, verifique los datos e inténtelo de nuevo.",
                    "Error de Registro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            // Resetear campos de texto y combos
            Utilidades.ReseteaFormulario(groupBoxDatosPersonales);
            Utilidades.ReseteaFormulario(groupBoxDatosComplementarios);

            // Desmarcar todos los CheckBox
            checkBoxCarneConducir.Checked = false;
            checkBoxCarnetCarretilla.Checked = false;
            checkBoxCarnetCamion.Checked = false;

            // Limpiar foto
            fotoBytes = null;
            campoAnexoFoto.Text = "";

            // Limpiar observaciones si es un TextBox separado
            campoObservaciones.Text = "";

            // Enfocar primer campo
            campoNombre.Focus();
        }
    }
}