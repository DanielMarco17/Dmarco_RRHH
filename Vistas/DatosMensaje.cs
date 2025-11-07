using DMarco_RRHH.modelo;
using System;
using System.Windows.Forms;

namespace DMarco_RRHH.Vistas
{
    public partial class DatosMensaje : Form
    {
        public DatosMensaje()
        {
            InitializeComponent();
            ConfigurarFecha();
        }

        private void botonEnviarCorreo_Click(object sender, EventArgs e)
        {
            EnviarCorreo();
        }
    }
}
