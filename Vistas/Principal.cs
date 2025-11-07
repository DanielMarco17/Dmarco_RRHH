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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            label1.Text = "Bienvenid@, " + Login.nomApeUsuario;
            label2.Text = "Acceso: " + Login.fecha;
            label3.Text = "Ip de conexión: " + Login.ip;

            Dictionary<string, int> contadores = Conexion.ObtenerContadorCandidatos();

            contadorAdministracion.Text = contadores["Administracion"].ToString();
            contadorAlmacen.Text = contadores["Almacen"].ToString();

            DataTable tablaAdmin = new DataTable();
            DataTable tablaAlmacen = new DataTable();
            Conexion.ListadoUltimosCandidatosAdministracion(tablaAdmin);
            tablaCandidatosAdministracion.DataSource = tablaAdmin;
            
            Conexion.ListadoUltimosCandidatosAlmacen(tablaAlmacen);
            tablaCandidatosAlmacen.DataSource = tablaAlmacen;



        }

        private void botonAltaAdministracion_Click(object sender, EventArgs e)
        {
            AltaAdministracion altaAdministracion = new AltaAdministracion();
            altaAdministracion.Show();
        }

        private void botonAltaCandidatos_Click(object sender, EventArgs e)
        {
            AltaAlmacen altaAlmacen = new AltaAlmacen();
            altaAlmacen.Show();

        }

        private void contadorAdministracion_Click(object sender, EventArgs e)
        {

        }

        private void botonlistadosCandidatos_Click(object sender, EventArgs e)
        {
            Listados l = new Listados();
            l.Show();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            BuscarCandidato bc = new BuscarCandidato();
            bc.Show();
        }
    }
}
