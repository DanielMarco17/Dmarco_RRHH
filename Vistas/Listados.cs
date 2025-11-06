using DMarco_RRHH.Bbdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMarco_RRHH.Vistas
{
    public partial class Listados : Form
    {
        public Listados()
        {
            InitializeComponent();
            ConfigurarTagsRadioButtons();
            comboTipoCandidatos.SelectedIndex = 0;
            comboEstudios.SelectedIndex = 0;
            comboBoxEstudios2.SelectedIndex = 0;
        }

        private void comboTipoCandidatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboTipo();
        }

        private void botonMostrarListadoUno_Click(object sender, EventArgs e)
        {
            muestraCandidatosAdmin();
        }

        private void botonMostrarListadoDos_Click(object sender, EventArgs e)
        {
            muestraCandidatosAlmacen();
        }

        private void radioFiltrarAlmacen_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void radioFiltrarAlmacen_MouseEnter(object sender, EventArgs e)
        {

        }

        private void radioFiltrarAlmacen_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            exportar();
        }

        private void radioFiltrarAlmacen_CheckedChanged(object sender, EventArgs e)
        {
            checksHabilitados();
        }
    }
}
