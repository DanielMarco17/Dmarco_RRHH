using DMarco_RRHH.Bbdd;
using DMarco_RRHH.utilidades;
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
    public partial class BuscarCandidato : Form
    {
        public BuscarCandidato()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void campoEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void campoCp_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ComboVacio(comboTipoCandidatos) ||
            comboTipoCandidatos.SelectedIndex == 0)
            {
                Utilidades.LanzaAlertaCombo(comboTipoCandidatos);
                comboTipoCandidatos.Focus();
                return;
            }
            if (!Utilidades.ValidarDNI(campoDni.Text))
            {
                MessageBox.Show("El DNI introducido no es válido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tipoCandidato = comboTipoCandidatos.SelectedItem.ToString();

            if (tipoCandidato == "Administración")
            {
                BuscarCandidatoAdministracion();
            }
            else if (tipoCandidato == "Almacén")
            {
                BuscarCandidatoAlmacen();
            }
        }

        private void comboTipoCandidatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
            campoDni.Focus();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            string dni = campoDni.Text.ToUpper();
            string tipoCandidato = comboTipoCandidatos.SelectedItem.ToString();
            string nombreCompleto = campoNombre.Text + " " + campoApellidos.Text;

            DialogResult resultado = MessageBox.Show(
                $"¿Desea eliminar el candidato de la base de datos?\n\n" +
                $"Nombre: {nombreCompleto}\n" +
                $"DNI: {dni}\n" +
                $"Tipo: {tipoCandidato}",
                "Eliminación de candidatos",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            bool eliminado = false;

            if (tipoCandidato == "Administración")
            {
                eliminado = Conexion.EliminarCandidatoAdministracion(dni);
            }
            else if (tipoCandidato == "Almacén")
            {
                eliminado = Conexion.EliminarCandidatoAlmacen(dni);
            }

            if (eliminado)
            {
                MessageBox.Show($"El candidato {nombreCompleto} ha sido eliminado correctamente",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                DesactivarCampos();
                campoDni.Text = "";
                campoDni.Focus();
                DesactivarCamposDniEncontrado();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el candidato. Intente nuevamente.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonEnviar_Click(object sender, EventArgs e)
        {
            EnviarMail();
        }

        private void botonFichaPDF_Click(object sender, EventArgs e)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            mantenimiento.Show();
        }
    }

}
