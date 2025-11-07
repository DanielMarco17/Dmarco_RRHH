using DMarco_RRHH.modelo;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DMarco_RRHH.Vistas
{
    partial class DatosMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosMensaje));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.campoFecha = new System.Windows.Forms.DateTimePicker();
            this.comboHora = new System.Windows.Forms.ComboBox();
            this.botonEnviarCorreo = new System.Windows.Forms.Button();
            this.labelDebeHora = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha y hora de convocatoria";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 10);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Especifique fecha y hora de convocatoria para entrevista de trabajo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(133, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(133, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hora";
            // 
            // campoFecha
            // 
            this.campoFecha.Location = new System.Drawing.Point(202, 131);
            this.campoFecha.Name = "campoFecha";
            this.campoFecha.Size = new System.Drawing.Size(200, 20);
            this.campoFecha.TabIndex = 11;
            // 
            // comboHora
            // 
            this.comboHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHora.FormattingEnabled = true;
            this.comboHora.Items.AddRange(new object[] {
            "Seleccione",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00"});
            this.comboHora.Location = new System.Drawing.Point(202, 190);
            this.comboHora.Name = "comboHora";
            this.comboHora.Size = new System.Drawing.Size(88, 21);
            this.comboHora.TabIndex = 12;
            // 
            // botonEnviarCorreo
            // 
            this.botonEnviarCorreo.Location = new System.Drawing.Point(202, 248);
            this.botonEnviarCorreo.Name = "botonEnviarCorreo";
            this.botonEnviarCorreo.Size = new System.Drawing.Size(140, 23);
            this.botonEnviarCorreo.TabIndex = 13;
            this.botonEnviarCorreo.Text = "Enviar Correo";
            this.botonEnviarCorreo.UseVisualStyleBackColor = true;
            this.botonEnviarCorreo.Click += new System.EventHandler(this.botonEnviarCorreo_Click);
            // 
            // labelDebeHora
            // 
            this.labelDebeHora.AutoSize = true;
            this.labelDebeHora.ForeColor = System.Drawing.Color.Red;
            this.labelDebeHora.Location = new System.Drawing.Point(312, 193);
            this.labelDebeHora.Name = "labelDebeHora";
            this.labelDebeHora.Size = new System.Drawing.Size(135, 13);
            this.labelDebeHora.TabIndex = 14;
            this.labelDebeHora.Text = "Debe seleccionar una hora";
            this.labelDebeHora.Visible = false;
            // 
            // DatosMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.labelDebeHora);
            this.Controls.Add(this.botonEnviarCorreo);
            this.Controls.Add(this.comboHora);
            this.Controls.Add(this.campoFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "DatosMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convocatoria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker campoFecha;
        private System.Windows.Forms.ComboBox comboHora;
        private System.Windows.Forms.Button botonEnviarCorreo;


        public void ConfigurarFecha()
        {
            campoFecha.MinDate = DateTime.Now.AddDays(1);
            campoFecha.Value = DateTime.Now.AddDays(1);
            comboHora.SelectedIndex = 0;
        }
        public string fechaConvocatoria
        {
            get { return campoFecha.Value.ToString("dd/MM/yyyy"); }
        }
        public string horaConvocatoria
        {
            get { return comboHora.SelectedItem?.ToString(); }
        }

        private void EnviarCorreo()
        {
            if (comboHora.SelectedIndex == 0)
            {
                labelDebeHora.Visible = true;

            }
            else
            {
                labelDebeHora.Visible = false;
                try
                {
                    string emailDestinatario = BuscarCandidato.emailCandidato;
                    string fecha = campoFecha.Value.ToString("dd/MM/yyyy");
                    string hora = comboHora.SelectedItem.ToString();

                    Email email = new Email(
                       asunto: "Convocatoria para entrevista de trabajo",
                       destinatario: emailDestinatario,
                       fecha: fecha,
                       hora: hora
                   );

                    email.EnviarCorreo();

                    MessageBox.Show("Correo enviado correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private Label labelDebeHora;
    }
}