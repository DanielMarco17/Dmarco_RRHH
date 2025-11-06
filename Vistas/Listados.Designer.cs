using DMarco_RRHH.Bbdd;
using DMarco_RRHH.utilidades;
using Spire.Xls;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DMarco_RRHH.Vistas
{
    partial class Listados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTipoCandidatos = new System.Windows.Forms.ComboBox();
            this.groupBoxFiltrosAdministracion = new System.Windows.Forms.GroupBox();
            this.botonMostrarListadoUno = new System.Windows.Forms.Button();
            this.groupBoxNivelInternet = new System.Windows.Forms.GroupBox();
            this.radioTodos3 = new System.Windows.Forms.RadioButton();
            this.radioUsuario3 = new System.Windows.Forms.RadioButton();
            this.radioAvanzado3 = new System.Windows.Forms.RadioButton();
            this.radioMedio3 = new System.Windows.Forms.RadioButton();
            this.groupBoxNivelHoja = new System.Windows.Forms.GroupBox();
            this.radioTodos2 = new System.Windows.Forms.RadioButton();
            this.radioUsuario2 = new System.Windows.Forms.RadioButton();
            this.radioAvanzado2 = new System.Windows.Forms.RadioButton();
            this.radioMedio2 = new System.Windows.Forms.RadioButton();
            this.groupBoxNivelTexto = new System.Windows.Forms.GroupBox();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.radioUsuario = new System.Windows.Forms.RadioButton();
            this.radioAvanzado = new System.Windows.Forms.RadioButton();
            this.radioMedio = new System.Windows.Forms.RadioButton();
            this.comboEstudios = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxFiltrosAlmacen = new System.Windows.Forms.GroupBox();
            this.groupBoxFiltrosAlmacenTodosFiltrar = new System.Windows.Forms.GroupBox();
            this.radioFiltrarAlmacen = new System.Windows.Forms.RadioButton();
            this.radioTodosAlmacen = new System.Windows.Forms.RadioButton();
            this.botonMostrarListadoDos = new System.Windows.Forms.Button();
            this.comboBoxEstudios2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxCarnetCamion = new System.Windows.Forms.CheckBox();
            this.checkBoxCarnetCarretilla = new System.Windows.Forms.CheckBox();
            this.checkBoxCarneConducir = new System.Windows.Forms.CheckBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxFiltrosAdministracion.SuspendLayout();
            this.groupBoxNivelInternet.SuspendLayout();
            this.groupBoxNivelHoja.SuspendLayout();
            this.groupBoxNivelTexto.SuspendLayout();
            this.groupBoxFiltrosAlmacen.SuspendLayout();
            this.groupBoxFiltrosAlmacenTodosFiltrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 57);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 651);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 10);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo de candidatos";
            // 
            // comboTipoCandidatos
            // 
            this.comboTipoCandidatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoCandidatos.FormattingEnabled = true;
            this.comboTipoCandidatos.Items.AddRange(new object[] {
            "Seleccione",
            "Administración",
            "Almacén"});
            this.comboTipoCandidatos.Location = new System.Drawing.Point(155, 93);
            this.comboTipoCandidatos.Name = "comboTipoCandidatos";
            this.comboTipoCandidatos.Size = new System.Drawing.Size(139, 21);
            this.comboTipoCandidatos.TabIndex = 8;
            this.comboTipoCandidatos.SelectedIndexChanged += new System.EventHandler(this.comboTipoCandidatos_SelectedIndexChanged);
            // 
            // groupBoxFiltrosAdministracion
            // 
            this.groupBoxFiltrosAdministracion.Controls.Add(this.botonMostrarListadoUno);
            this.groupBoxFiltrosAdministracion.Controls.Add(this.groupBoxNivelInternet);
            this.groupBoxFiltrosAdministracion.Controls.Add(this.groupBoxNivelHoja);
            this.groupBoxFiltrosAdministracion.Controls.Add(this.groupBoxNivelTexto);
            this.groupBoxFiltrosAdministracion.Controls.Add(this.comboEstudios);
            this.groupBoxFiltrosAdministracion.Controls.Add(this.label12);
            this.groupBoxFiltrosAdministracion.Enabled = false;
            this.groupBoxFiltrosAdministracion.ForeColor = System.Drawing.Color.Black;
            this.groupBoxFiltrosAdministracion.Location = new System.Drawing.Point(28, 141);
            this.groupBoxFiltrosAdministracion.Name = "groupBoxFiltrosAdministracion";
            this.groupBoxFiltrosAdministracion.Size = new System.Drawing.Size(510, 257);
            this.groupBoxFiltrosAdministracion.TabIndex = 9;
            this.groupBoxFiltrosAdministracion.TabStop = false;
            this.groupBoxFiltrosAdministracion.Text = "Filtros";
            // 
            // botonMostrarListadoUno
            // 
            this.botonMostrarListadoUno.Location = new System.Drawing.Point(163, 221);
            this.botonMostrarListadoUno.Name = "botonMostrarListadoUno";
            this.botonMostrarListadoUno.Size = new System.Drawing.Size(152, 23);
            this.botonMostrarListadoUno.TabIndex = 33;
            this.botonMostrarListadoUno.Text = "Mostrar listado";
            this.botonMostrarListadoUno.UseVisualStyleBackColor = true;
            this.botonMostrarListadoUno.Click += new System.EventHandler(this.botonMostrarListadoUno_Click);
            // 
            // groupBoxNivelInternet
            // 
            this.groupBoxNivelInternet.Controls.Add(this.radioTodos3);
            this.groupBoxNivelInternet.Controls.Add(this.radioUsuario3);
            this.groupBoxNivelInternet.Controls.Add(this.radioAvanzado3);
            this.groupBoxNivelInternet.Controls.Add(this.radioMedio3);
            this.groupBoxNivelInternet.ForeColor = System.Drawing.Color.Maroon;
            this.groupBoxNivelInternet.Location = new System.Drawing.Point(29, 170);
            this.groupBoxNivelInternet.Name = "groupBoxNivelInternet";
            this.groupBoxNivelInternet.Size = new System.Drawing.Size(453, 45);
            this.groupBoxNivelInternet.TabIndex = 32;
            this.groupBoxNivelInternet.TabStop = false;
            this.groupBoxNivelInternet.Text = "Internet";
            // 
            // radioTodos3
            // 
            this.radioTodos3.AutoSize = true;
            this.radioTodos3.Location = new System.Drawing.Point(34, 19);
            this.radioTodos3.Name = "radioTodos3";
            this.radioTodos3.Size = new System.Drawing.Size(55, 17);
            this.radioTodos3.TabIndex = 27;
            this.radioTodos3.TabStop = true;
            this.radioTodos3.Text = "Todos";
            this.radioTodos3.UseVisualStyleBackColor = true;
            // 
            // radioUsuario3
            // 
            this.radioUsuario3.AutoSize = true;
            this.radioUsuario3.Location = new System.Drawing.Point(124, 19);
            this.radioUsuario3.Name = "radioUsuario3";
            this.radioUsuario3.Size = new System.Drawing.Size(61, 17);
            this.radioUsuario3.TabIndex = 22;
            this.radioUsuario3.TabStop = true;
            this.radioUsuario3.Text = "Usuario";
            this.radioUsuario3.UseVisualStyleBackColor = true;
            // 
            // radioAvanzado3
            // 
            this.radioAvanzado3.AutoSize = true;
            this.radioAvanzado3.Location = new System.Drawing.Point(357, 19);
            this.radioAvanzado3.Name = "radioAvanzado3";
            this.radioAvanzado3.Size = new System.Drawing.Size(73, 17);
            this.radioAvanzado3.TabIndex = 24;
            this.radioAvanzado3.TabStop = true;
            this.radioAvanzado3.Text = "Avanzado";
            this.radioAvanzado3.UseVisualStyleBackColor = true;
            // 
            // radioMedio3
            // 
            this.radioMedio3.AutoSize = true;
            this.radioMedio3.Location = new System.Drawing.Point(241, 19);
            this.radioMedio3.Name = "radioMedio3";
            this.radioMedio3.Size = new System.Drawing.Size(54, 17);
            this.radioMedio3.TabIndex = 23;
            this.radioMedio3.TabStop = true;
            this.radioMedio3.Text = "Medio";
            this.radioMedio3.UseVisualStyleBackColor = true;
            // 
            // groupBoxNivelHoja
            // 
            this.groupBoxNivelHoja.Controls.Add(this.radioTodos2);
            this.groupBoxNivelHoja.Controls.Add(this.radioUsuario2);
            this.groupBoxNivelHoja.Controls.Add(this.radioAvanzado2);
            this.groupBoxNivelHoja.Controls.Add(this.radioMedio2);
            this.groupBoxNivelHoja.ForeColor = System.Drawing.Color.Maroon;
            this.groupBoxNivelHoja.Location = new System.Drawing.Point(29, 119);
            this.groupBoxNivelHoja.Name = "groupBoxNivelHoja";
            this.groupBoxNivelHoja.Size = new System.Drawing.Size(453, 45);
            this.groupBoxNivelHoja.TabIndex = 32;
            this.groupBoxNivelHoja.TabStop = false;
            this.groupBoxNivelHoja.Text = "Hoja de cálculo";
            // 
            // radioTodos2
            // 
            this.radioTodos2.AutoSize = true;
            this.radioTodos2.Location = new System.Drawing.Point(34, 19);
            this.radioTodos2.Name = "radioTodos2";
            this.radioTodos2.Size = new System.Drawing.Size(55, 17);
            this.radioTodos2.TabIndex = 26;
            this.radioTodos2.TabStop = true;
            this.radioTodos2.Text = "Todos";
            this.radioTodos2.UseVisualStyleBackColor = true;
            // 
            // radioUsuario2
            // 
            this.radioUsuario2.AutoSize = true;
            this.radioUsuario2.Location = new System.Drawing.Point(124, 19);
            this.radioUsuario2.Name = "radioUsuario2";
            this.radioUsuario2.Size = new System.Drawing.Size(61, 17);
            this.radioUsuario2.TabIndex = 22;
            this.radioUsuario2.TabStop = true;
            this.radioUsuario2.Text = "Usuario";
            this.radioUsuario2.UseVisualStyleBackColor = true;
            // 
            // radioAvanzado2
            // 
            this.radioAvanzado2.AutoSize = true;
            this.radioAvanzado2.Location = new System.Drawing.Point(357, 19);
            this.radioAvanzado2.Name = "radioAvanzado2";
            this.radioAvanzado2.Size = new System.Drawing.Size(73, 17);
            this.radioAvanzado2.TabIndex = 24;
            this.radioAvanzado2.TabStop = true;
            this.radioAvanzado2.Text = "Avanzado";
            this.radioAvanzado2.UseVisualStyleBackColor = true;
            // 
            // radioMedio2
            // 
            this.radioMedio2.AutoSize = true;
            this.radioMedio2.Location = new System.Drawing.Point(241, 19);
            this.radioMedio2.Name = "radioMedio2";
            this.radioMedio2.Size = new System.Drawing.Size(54, 17);
            this.radioMedio2.TabIndex = 23;
            this.radioMedio2.TabStop = true;
            this.radioMedio2.Text = "Medio";
            this.radioMedio2.UseVisualStyleBackColor = true;
            // 
            // groupBoxNivelTexto
            // 
            this.groupBoxNivelTexto.Controls.Add(this.radioTodos);
            this.groupBoxNivelTexto.Controls.Add(this.radioUsuario);
            this.groupBoxNivelTexto.Controls.Add(this.radioAvanzado);
            this.groupBoxNivelTexto.Controls.Add(this.radioMedio);
            this.groupBoxNivelTexto.ForeColor = System.Drawing.Color.Maroon;
            this.groupBoxNivelTexto.Location = new System.Drawing.Point(29, 63);
            this.groupBoxNivelTexto.Name = "groupBoxNivelTexto";
            this.groupBoxNivelTexto.Size = new System.Drawing.Size(453, 45);
            this.groupBoxNivelTexto.TabIndex = 31;
            this.groupBoxNivelTexto.TabStop = false;
            this.groupBoxNivelTexto.Text = "Tratamiento de textos";
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Location = new System.Drawing.Point(34, 19);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(55, 17);
            this.radioTodos.TabIndex = 25;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Todos";
            this.radioTodos.UseVisualStyleBackColor = true;
            // 
            // radioUsuario
            // 
            this.radioUsuario.AutoSize = true;
            this.radioUsuario.Location = new System.Drawing.Point(124, 19);
            this.radioUsuario.Name = "radioUsuario";
            this.radioUsuario.Size = new System.Drawing.Size(61, 17);
            this.radioUsuario.TabIndex = 22;
            this.radioUsuario.TabStop = true;
            this.radioUsuario.Text = "Usuario";
            this.radioUsuario.UseVisualStyleBackColor = true;
            // 
            // radioAvanzado
            // 
            this.radioAvanzado.AutoSize = true;
            this.radioAvanzado.Location = new System.Drawing.Point(357, 19);
            this.radioAvanzado.Name = "radioAvanzado";
            this.radioAvanzado.Size = new System.Drawing.Size(73, 17);
            this.radioAvanzado.TabIndex = 24;
            this.radioAvanzado.TabStop = true;
            this.radioAvanzado.Text = "Avanzado";
            this.radioAvanzado.UseVisualStyleBackColor = true;
            // 
            // radioMedio
            // 
            this.radioMedio.AutoSize = true;
            this.radioMedio.Location = new System.Drawing.Point(241, 19);
            this.radioMedio.Name = "radioMedio";
            this.radioMedio.Size = new System.Drawing.Size(54, 17);
            this.radioMedio.TabIndex = 23;
            this.radioMedio.TabStop = true;
            this.radioMedio.Text = "Medio";
            this.radioMedio.UseVisualStyleBackColor = true;
            // 
            // comboEstudios
            // 
            this.comboEstudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstudios.FormattingEnabled = true;
            this.comboEstudios.Items.AddRange(new object[] {
            "Seleccione",
            "Eso",
            "Grado Medio",
            "Bachillerato",
            "Grado Superior",
            "Universitarios"});
            this.comboEstudios.Location = new System.Drawing.Point(148, 25);
            this.comboEstudios.Name = "comboEstudios";
            this.comboEstudios.Size = new System.Drawing.Size(257, 21);
            this.comboEstudios.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(26, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Estudios Finalizados";
            // 
            // groupBoxFiltrosAlmacen
            // 
            this.groupBoxFiltrosAlmacen.Controls.Add(this.groupBoxFiltrosAlmacenTodosFiltrar);
            this.groupBoxFiltrosAlmacen.Controls.Add(this.botonMostrarListadoDos);
            this.groupBoxFiltrosAlmacen.Controls.Add(this.comboBoxEstudios2);
            this.groupBoxFiltrosAlmacen.Controls.Add(this.label2);
            this.groupBoxFiltrosAlmacen.Controls.Add(this.groupBox1);
            this.groupBoxFiltrosAlmacen.Enabled = false;
            this.groupBoxFiltrosAlmacen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxFiltrosAlmacen.Location = new System.Drawing.Point(571, 141);
            this.groupBoxFiltrosAlmacen.Name = "groupBoxFiltrosAlmacen";
            this.groupBoxFiltrosAlmacen.Size = new System.Drawing.Size(482, 257);
            this.groupBoxFiltrosAlmacen.TabIndex = 10;
            this.groupBoxFiltrosAlmacen.TabStop = false;
            this.groupBoxFiltrosAlmacen.Text = "Filtros";
            // 
            // groupBoxFiltrosAlmacenTodosFiltrar
            // 
            this.groupBoxFiltrosAlmacenTodosFiltrar.Controls.Add(this.radioFiltrarAlmacen);
            this.groupBoxFiltrosAlmacenTodosFiltrar.Controls.Add(this.radioTodosAlmacen);
            this.groupBoxFiltrosAlmacenTodosFiltrar.Location = new System.Drawing.Point(38, 63);
            this.groupBoxFiltrosAlmacenTodosFiltrar.Name = "groupBoxFiltrosAlmacenTodosFiltrar";
            this.groupBoxFiltrosAlmacenTodosFiltrar.Size = new System.Drawing.Size(170, 55);
            this.groupBoxFiltrosAlmacenTodosFiltrar.TabIndex = 35;
            this.groupBoxFiltrosAlmacenTodosFiltrar.TabStop = false;
            // 
            // radioFiltrarAlmacen
            // 
            this.radioFiltrarAlmacen.AutoSize = true;
            this.radioFiltrarAlmacen.Location = new System.Drawing.Point(101, 19);
            this.radioFiltrarAlmacen.Name = "radioFiltrarAlmacen";
            this.radioFiltrarAlmacen.Size = new System.Drawing.Size(50, 17);
            this.radioFiltrarAlmacen.TabIndex = 38;
            this.radioFiltrarAlmacen.TabStop = true;
            this.radioFiltrarAlmacen.Text = "Filtrar";
            this.radioFiltrarAlmacen.UseVisualStyleBackColor = true;
            this.radioFiltrarAlmacen.CheckedChanged += new System.EventHandler(this.radioFiltrarAlmacen_CheckedChanged);
            this.radioFiltrarAlmacen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioFiltrarAlmacen_MouseClick);
            this.radioFiltrarAlmacen.MouseEnter += new System.EventHandler(this.radioFiltrarAlmacen_MouseEnter);
            this.radioFiltrarAlmacen.MouseLeave += new System.EventHandler(this.radioFiltrarAlmacen_MouseLeave);
            // 
            // radioTodosAlmacen
            // 
            this.radioTodosAlmacen.AutoSize = true;
            this.radioTodosAlmacen.Location = new System.Drawing.Point(22, 19);
            this.radioTodosAlmacen.Name = "radioTodosAlmacen";
            this.radioTodosAlmacen.Size = new System.Drawing.Size(55, 17);
            this.radioTodosAlmacen.TabIndex = 37;
            this.radioTodosAlmacen.TabStop = true;
            this.radioTodosAlmacen.Text = "Todos";
            this.radioTodosAlmacen.UseVisualStyleBackColor = true;
            // 
            // botonMostrarListadoDos
            // 
            this.botonMostrarListadoDos.Location = new System.Drawing.Point(157, 221);
            this.botonMostrarListadoDos.Name = "botonMostrarListadoDos";
            this.botonMostrarListadoDos.Size = new System.Drawing.Size(152, 23);
            this.botonMostrarListadoDos.TabIndex = 34;
            this.botonMostrarListadoDos.Text = "Mostrar listado";
            this.botonMostrarListadoDos.UseVisualStyleBackColor = true;
            this.botonMostrarListadoDos.Click += new System.EventHandler(this.botonMostrarListadoDos_Click);
            // 
            // comboBoxEstudios2
            // 
            this.comboBoxEstudios2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstudios2.FormattingEnabled = true;
            this.comboBoxEstudios2.Items.AddRange(new object[] {
            "Seleccione",
            "Eso",
            "Grado Medio",
            "Bachillerato",
            "Grado Superior",
            "Universitarios"});
            this.comboBoxEstudios2.Location = new System.Drawing.Point(157, 26);
            this.comboBoxEstudios2.Name = "comboBoxEstudios2";
            this.comboBoxEstudios2.Size = new System.Drawing.Size(257, 21);
            this.comboBoxEstudios2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Estudios Finalizados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxCarnetCamion);
            this.groupBox1.Controls.Add(this.checkBoxCarnetCarretilla);
            this.groupBox1.Controls.Add(this.checkBoxCarneConducir);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(38, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 82);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CARNETS";
            // 
            // checkBoxCarnetCamion
            // 
            this.checkBoxCarnetCamion.AutoSize = true;
            this.checkBoxCarnetCamion.Location = new System.Drawing.Point(271, 37);
            this.checkBoxCarnetCamion.Name = "checkBoxCarnetCamion";
            this.checkBoxCarnetCamion.Size = new System.Drawing.Size(109, 17);
            this.checkBoxCarnetCamion.TabIndex = 27;
            this.checkBoxCarnetCamion.Text = "Carnet de camión";
            this.checkBoxCarnetCamion.UseVisualStyleBackColor = true;
            // 
            // checkBoxCarnetCarretilla
            // 
            this.checkBoxCarnetCarretilla.AutoSize = true;
            this.checkBoxCarnetCarretilla.Location = new System.Drawing.Point(155, 37);
            this.checkBoxCarnetCarretilla.Name = "checkBoxCarnetCarretilla";
            this.checkBoxCarnetCarretilla.Size = new System.Drawing.Size(114, 17);
            this.checkBoxCarnetCarretilla.TabIndex = 26;
            this.checkBoxCarnetCarretilla.Text = "Carnet de carretilla";
            this.checkBoxCarnetCarretilla.UseVisualStyleBackColor = true;
            // 
            // checkBoxCarneConducir
            // 
            this.checkBoxCarneConducir.AutoSize = true;
            this.checkBoxCarneConducir.Location = new System.Drawing.Point(33, 37);
            this.checkBoxCarneConducir.Name = "checkBoxCarneConducir";
            this.checkBoxCarneConducir.Size = new System.Drawing.Size(116, 17);
            this.checkBoxCarneConducir.TabIndex = 25;
            this.checkBoxCarneConducir.Text = "Carnet de conducir";
            this.checkBoxCarneConducir.UseVisualStyleBackColor = true;
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeColumns = false;
            this.tabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.Enabled = false;
            this.tabla.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabla.Location = new System.Drawing.Point(28, 439);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            this.tabla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tabla.Size = new System.Drawing.Size(1025, 206);
            this.tabla.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1012, 404);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.groupBoxFiltrosAlmacen);
            this.Controls.Add(this.groupBoxFiltrosAdministracion);
            this.Controls.Add(this.comboTipoCandidatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Listados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listados";
            this.groupBoxFiltrosAdministracion.ResumeLayout(false);
            this.groupBoxFiltrosAdministracion.PerformLayout();
            this.groupBoxNivelInternet.ResumeLayout(false);
            this.groupBoxNivelInternet.PerformLayout();
            this.groupBoxNivelHoja.ResumeLayout(false);
            this.groupBoxNivelHoja.PerformLayout();
            this.groupBoxNivelTexto.ResumeLayout(false);
            this.groupBoxNivelTexto.PerformLayout();
            this.groupBoxFiltrosAlmacen.ResumeLayout(false);
            this.groupBoxFiltrosAlmacen.PerformLayout();
            this.groupBoxFiltrosAlmacenTodosFiltrar.ResumeLayout(false);
            this.groupBoxFiltrosAlmacenTodosFiltrar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTipoCandidatos;
        private System.Windows.Forms.GroupBox groupBoxFiltrosAdministracion;
        private System.Windows.Forms.GroupBox groupBoxNivelInternet;
        private System.Windows.Forms.RadioButton radioTodos3;
        private System.Windows.Forms.RadioButton radioUsuario3;
        private System.Windows.Forms.RadioButton radioAvanzado3;
        private System.Windows.Forms.RadioButton radioMedio3;
        private System.Windows.Forms.GroupBox groupBoxNivelHoja;
        private System.Windows.Forms.RadioButton radioTodos2;
        private System.Windows.Forms.RadioButton radioUsuario2;
        private System.Windows.Forms.RadioButton radioAvanzado2;
        private System.Windows.Forms.RadioButton radioMedio2;
        private System.Windows.Forms.GroupBox groupBoxNivelTexto;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.RadioButton radioUsuario;
        private System.Windows.Forms.RadioButton radioAvanzado;
        private System.Windows.Forms.RadioButton radioMedio;
        private System.Windows.Forms.ComboBox comboEstudios;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBoxFiltrosAlmacen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxCarnetCamion;
        private System.Windows.Forms.CheckBox checkBoxCarnetCarretilla;
        private System.Windows.Forms.CheckBox checkBoxCarneConducir;
        private System.Windows.Forms.Button botonMostrarListadoUno;
        private System.Windows.Forms.Button botonMostrarListadoDos;
        private System.Windows.Forms.ComboBox comboBoxEstudios2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxFiltrosAlmacenTodosFiltrar;
        private System.Windows.Forms.RadioButton radioFiltrarAlmacen;
        private System.Windows.Forms.RadioButton radioTodosAlmacen;
        private DataGridView tabla;
        private PictureBox pictureBox1;


        private void ConfigurarTagsRadioButtons()
        {
            // RadioButtons de Tratamiento de textos
            radioTodos.Tag = "Todos";
            radioUsuario.Tag = "Usuario";
            radioMedio.Tag = "Medio";
            radioAvanzado.Tag = "Avanzado";

            // RadioButtons de Hoja de cálculo
            radioTodos2.Tag = "Todos";
            radioUsuario2.Tag = "Usuario";
            radioMedio2.Tag = "Medio";
            radioAvanzado2.Tag = "Avanzado";

            // RadioButtons de Internet
            radioTodos3.Tag = "Todos";
            radioUsuario3.Tag = "Usuario";
            radioMedio3.Tag = "Medio";
            radioAvanzado3.Tag = "Avanzado";

            // Marcar "Todos" por defecto en los RadioButtons de Administración
            radioTodos.Checked = true;
            radioTodos2.Checked = true;
            radioTodos3.Checked = true;

            //RadioButtons de Filtros de Almacén
            radioTodosAlmacen.Tag = "Todos";
            radioFiltrarAlmacen.Tag = "Filtrar";
            radioTodosAlmacen.Checked = true;

            // Configurar Tags de los GroupBox
            groupBoxNivelTexto.Tag = "Nivel de informática - Tratamiento de textos";
            groupBoxNivelHoja.Tag = "Nivel de informática - Hoja de cálculo";
            groupBoxNivelInternet.Tag = "Nivel de informática - Internet";
            groupBoxFiltrosAlmacenTodosFiltrar.Tag = "Filtros de Almacén";
        }

        public void comboTipo()
        {


            if (comboTipoCandidatos.SelectedIndex == 1)
            {
                if (groupBoxFiltrosAdministracion.Enabled == false)
                {
                    groupBoxFiltrosAdministracion.Enabled = true;
                    groupBoxFiltrosAlmacen.Enabled = false;
                }
            }

            if (comboTipoCandidatos.SelectedIndex == 2)
            {
                if (groupBoxFiltrosAlmacen.Enabled == false)
                {
                    groupBoxFiltrosAlmacen.Enabled = true;
                    groupBoxFiltrosAdministracion.Enabled = false;
                }
            }
        }

        string condicion;

        public void muestraCandidatosAdmin()
        {
            condicion = "";

            if (comboEstudios.SelectedIndex >= 1)
            {
                condicion += " AND nivelEstudios='" + comboEstudios.Text + "'";
            }

            string valorTexto = Utilidades.ObtenerValorRadioButtonsMarcado(groupBoxNivelTexto);
            if (!string.IsNullOrEmpty(valorTexto) && valorTexto != "Todos")
            {
                condicion += " AND nivelInformaticaTexto='" + valorTexto + "'";
            }

            string valorCalculo = Utilidades.ObtenerValorRadioButtonsMarcado(groupBoxNivelHoja);
            if (!string.IsNullOrEmpty(valorCalculo) && valorCalculo != "Todos")
            {
                condicion += " AND nivelInformaticaHojaCalculo='" + valorCalculo + "'";
            }

            string valorInternet = Utilidades.ObtenerValorRadioButtonsMarcado(groupBoxNivelInternet);
            if (!string.IsNullOrEmpty(valorInternet) && valorInternet != "Todos")
            {
                condicion += " AND nivelInformaticaInternet='" + valorInternet + "'";
            }

            tabla.DataSource = Conexion.VerCandidatosAdministracion(condicion);
        }
        public void muestraCandidatosAlmacen()
        {
            condicion = "";

            if (comboBoxEstudios2.SelectedIndex >= 1)
            {
                condicion += " AND nivelEstudios='" + comboBoxEstudios2.Text + "'";
            }

            if (radioFiltrarAlmacen.Checked)
            {
                if (checkBoxCarneConducir.Checked) { 
                    condicion += " AND carnetConducir='SI'";
                }
                else
                {
                    condicion += " AND carnetConducir='NO'";
                }

                if (checkBoxCarnetCarretilla.Checked) { 
                    condicion += " AND carnetCarretilla='SI'";
                }
                else
                {
                    condicion += " AND carnetCarretilla='NO'";
                }

                if (checkBoxCarnetCamion.Checked)
                {
                    condicion += " AND carnetCamion='SI'";
                }
                else
                {
                    condicion += " AND carnetCamion='NO'";
                }
            }

            tabla.DataSource = Conexion.VerCandidatosAlmacen(condicion);

        }

        public void exportar()
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xlsx)|*.xlsx";

            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Workbook workbook = new Workbook();
                Worksheet sheet = workbook.Worksheets[0];
                sheet.Range["B1"].Text = "Informe de Candidatos";
                sheet.Range["C1"].Text = DateTime.Now.ToString();

                sheet.InsertDataTable((DataTable)tabla.DataSource, true, 3, 2, -1, -1);

                sheet.AllocatedRange.AutoFitColumns();
                sheet.AllocatedRange.AutoFitRows();

                workbook.SaveToFile(fichero.FileName, ExcelVersion.Version2016);

                System.Diagnostics.Process.Start(fichero.FileName);
            }
        }

        public void checksHabilitados()
        {
            if (radioFiltrarAlmacen.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }
    }
}