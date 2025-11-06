using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMarco_RRHH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void campoUsuario_Enter(object sender, EventArgs e)
        {
            imagenUsuario.Visible= true;
        }

        private void campoUsuario_Leave(object sender, EventArgs e)
        {
            imagenUsuario.Visible = false;
        }

        private void campoPass_Enter(object sender, EventArgs e)
        {
            imagenPass.Visible= true;
        }

        private void campoPass_Leave(object sender, EventArgs e)
        {
            imagenPass.Visible = false;
        }

        private void botonEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }
    }
}
