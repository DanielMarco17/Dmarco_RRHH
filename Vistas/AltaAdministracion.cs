using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMarco_RRHH.Vistas
{
    public partial class AltaAdministracion : Form
    {
        private byte[] fotoBytes = null;
        public AltaAdministracion()
        {
            InitializeComponent();
            ConfigurarFormulario();
            comboEstudiosFinalizados.SelectedIndex = 0;
            comboLocalidad.SelectedIndex = 0;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonAnexarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.png";
            openFileDialog.Title = "Seleccionar foto del candidato";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fotoBytes = File.ReadAllBytes(openFileDialog.FileName);
                    campoAnexoFoto.Text = openFileDialog.FileName;
                    MessageBox.Show("Foto cargada correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la foto: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro();
        }
    }
}
