namespace DMarco_RRHH.Vistas
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonlistadosCandidatos = new System.Windows.Forms.Button();
            this.botonAltaCandidatos = new System.Windows.Forms.Button();
            this.botonAltaAdministracion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contadorAdministracion = new System.Windows.Forms.Label();
            this.contadorAlmacen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tablaCandidatosAdministracion = new System.Windows.Forms.DataGridView();
            this.tablaCandidatosAlmacen = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tablaAdministracion = new MySqlConnector.MySqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCandidatosAdministracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCandidatosAlmacen)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(89, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(89, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(89, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(959, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.botonBuscar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.botonlistadosCandidatos, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.botonAltaCandidatos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.botonAltaAdministracion, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(114, 149);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 173);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.botonBuscar.BackColor = System.Drawing.Color.IndianRed;
            this.botonBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonBuscar.Location = new System.Drawing.Point(735, 31);
            this.botonBuscar.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(178, 110);
            this.botonBuscar.TabIndex = 3;
            this.botonBuscar.Text = "Buscar Candidatos";
            this.botonBuscar.UseVisualStyleBackColor = false;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonlistadosCandidatos
            // 
            this.botonlistadosCandidatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.botonlistadosCandidatos.BackColor = System.Drawing.Color.IndianRed;
            this.botonlistadosCandidatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonlistadosCandidatos.Location = new System.Drawing.Point(500, 31);
            this.botonlistadosCandidatos.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.botonlistadosCandidatos.Name = "botonlistadosCandidatos";
            this.botonlistadosCandidatos.Size = new System.Drawing.Size(175, 110);
            this.botonlistadosCandidatos.TabIndex = 2;
            this.botonlistadosCandidatos.Text = "Listados de candidatos";
            this.botonlistadosCandidatos.UseVisualStyleBackColor = false;
            this.botonlistadosCandidatos.Click += new System.EventHandler(this.botonlistadosCandidatos_Click);
            // 
            // botonAltaCandidatos
            // 
            this.botonAltaCandidatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAltaCandidatos.BackColor = System.Drawing.Color.IndianRed;
            this.botonAltaCandidatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonAltaCandidatos.Location = new System.Drawing.Point(265, 31);
            this.botonAltaCandidatos.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.botonAltaCandidatos.Name = "botonAltaCandidatos";
            this.botonAltaCandidatos.Size = new System.Drawing.Size(175, 110);
            this.botonAltaCandidatos.TabIndex = 1;
            this.botonAltaCandidatos.Text = "Alta de candidatos para almacen";
            this.botonAltaCandidatos.UseVisualStyleBackColor = false;
            this.botonAltaCandidatos.Click += new System.EventHandler(this.botonAltaCandidatos_Click);
            // 
            // botonAltaAdministracion
            // 
            this.botonAltaAdministracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAltaAdministracion.BackColor = System.Drawing.Color.IndianRed;
            this.botonAltaAdministracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonAltaAdministracion.Location = new System.Drawing.Point(30, 31);
            this.botonAltaAdministracion.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.botonAltaAdministracion.Name = "botonAltaAdministracion";
            this.botonAltaAdministracion.Size = new System.Drawing.Size(175, 110);
            this.botonAltaAdministracion.TabIndex = 0;
            this.botonAltaAdministracion.Text = "Alta de candidatos para administración";
            this.botonAltaAdministracion.UseVisualStyleBackColor = false;
            this.botonAltaAdministracion.Click += new System.EventHandler(this.botonAltaAdministracion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(226, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Candidatos Administración";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(717, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Candidatos Almacén";
            // 
            // contadorAdministracion
            // 
            this.contadorAdministracion.AutoSize = true;
            this.contadorAdministracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contadorAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorAdministracion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.contadorAdministracion.Location = new System.Drawing.Point(326, 396);
            this.contadorAdministracion.Name = "contadorAdministracion";
            this.contadorAdministracion.Size = new System.Drawing.Size(53, 57);
            this.contadorAdministracion.TabIndex = 7;
            this.contadorAdministracion.Text = "0";
            this.contadorAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.contadorAdministracion.Click += new System.EventHandler(this.contadorAdministracion_Click);
            // 
            // contadorAlmacen
            // 
            this.contadorAlmacen.AutoSize = true;
            this.contadorAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contadorAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorAlmacen.ForeColor = System.Drawing.SystemColors.MenuText;
            this.contadorAlmacen.Location = new System.Drawing.Point(797, 396);
            this.contadorAlmacen.Name = "contadorAlmacen";
            this.contadorAlmacen.Size = new System.Drawing.Size(53, 57);
            this.contadorAlmacen.TabIndex = 8;
            this.contadorAlmacen.Text = "0";
            this.contadorAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(226, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Últimos candidatos Registrados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(688, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Últimos candidatos Registrados";
            // 
            // tablaCandidatosAdministracion
            // 
            this.tablaCandidatosAdministracion.AllowUserToAddRows = false;
            this.tablaCandidatosAdministracion.AllowUserToDeleteRows = false;
            this.tablaCandidatosAdministracion.AllowUserToResizeColumns = false;
            this.tablaCandidatosAdministracion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaCandidatosAdministracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCandidatosAdministracion.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCandidatosAdministracion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaCandidatosAdministracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCandidatosAdministracion.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaCandidatosAdministracion.Enabled = false;
            this.tablaCandidatosAdministracion.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaCandidatosAdministracion.Location = new System.Drawing.Point(157, 524);
            this.tablaCandidatosAdministracion.Name = "tablaCandidatosAdministracion";
            this.tablaCandidatosAdministracion.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            this.tablaCandidatosAdministracion.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaCandidatosAdministracion.Size = new System.Drawing.Size(408, 95);
            this.tablaCandidatosAdministracion.TabIndex = 11;
            // 
            // tablaCandidatosAlmacen
            // 
            this.tablaCandidatosAlmacen.AllowUserToAddRows = false;
            this.tablaCandidatosAlmacen.AllowUserToDeleteRows = false;
            this.tablaCandidatosAlmacen.AllowUserToResizeColumns = false;
            this.tablaCandidatosAlmacen.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaCandidatosAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCandidatosAlmacen.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCandidatosAlmacen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaCandidatosAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCandidatosAlmacen.DefaultCellStyle = dataGridViewCellStyle5;
            this.tablaCandidatosAlmacen.Enabled = false;
            this.tablaCandidatosAlmacen.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaCandidatosAlmacen.Location = new System.Drawing.Point(653, 524);
            this.tablaCandidatosAlmacen.Name = "tablaCandidatosAlmacen";
            this.tablaCandidatosAlmacen.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Maroon;
            this.tablaCandidatosAlmacen.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaCandidatosAlmacen.Size = new System.Drawing.Size(408, 95);
            this.tablaCandidatosAlmacen.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(250, 618);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tablaAdministracion
            // 
            this.tablaAdministracion.DeleteCommand = null;
            this.tablaAdministracion.InsertCommand = null;
            this.tablaAdministracion.SelectCommand = null;
            this.tablaAdministracion.UpdateBatchSize = 0;
            this.tablaAdministracion.UpdateCommand = null;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 686);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tablaCandidatosAlmacen);
            this.Controls.Add(this.tablaCandidatosAdministracion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contadorAlmacen);
            this.Controls.Add(this.contadorAdministracion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 725);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 725);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RRHH";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCandidatosAdministracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCandidatosAlmacen)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button botonAltaAdministracion;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonlistadosCandidatos;
        private System.Windows.Forms.Button botonAltaCandidatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label contadorAdministracion;
        private System.Windows.Forms.Label contadorAlmacen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tablaCandidatosAdministracion;
        private System.Windows.Forms.DataGridView tablaCandidatosAlmacen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MySqlConnector.MySqlDataAdapter tablaAdministracion;
    }
}