using DMarco_RRHH.modelo;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMarco_RRHH.Bbdd
{
    internal class Conexion
    {
        public static MySqlConnection conn;
        public static string url = "Server=145.14.151.51; " +
            "Database=u812167471_candidatos; " +
            "User=u812167471_usercandidatos; " +
            "port=3306; " +
            "password=5n&BKAL9; " +
            "Convert Zero Datetime=true";
        public static MySqlConnection Conectar()
        {
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
                return conn;  // Devuelve la conexión abierta
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error de conexión: {ex.Message}");
                throw;
            }
        }

        public static void Desconectar()
        {
            try
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error al cerrar conexión: {ex.Message}");
            }
        }

        public static bool Acceder(string user, string pass)
        {
            string consulta = "SELECT usuario, contrasenya FROM usuarios WHERE usuario=?user AND contrasenya=?pass ";

            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(consulta, conn);

                command.Parameters.AddWithValue("?user", user);
                command.Parameters.AddWithValue("?pass", pass);

                MySqlDataReader resultados = command.ExecuteReader();

                if (resultados.Read())
                {
                    return true;
                }
                resultados.Close();
                conn.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);

            }
            return false;

        }

        public static string RescatarDatosUserLogado(string usuario)
        {
            string nombreCompleto = null;
            string consulta = "SELECT CONCAT(nombre, ' ', apellidos) FROM usuarios WHERE usuario = ?user";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, conn);
                    comando.Parameters.AddWithValue("?user", usuario);

                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.Read())
                    {
                        nombreCompleto = reader.GetString(0);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return nombreCompleto;
        }

        public static Dictionary<string, int> ObtenerContadorCandidatos()
        {
            Dictionary<string, int> contadores = new Dictionary<string, int>
            {
                { "Administracion", 0 },
                { "Almacen", 0 }
            };

            try
            {

                string consulta = @"
                    SELECT 'Administracion' as Tipo, COUNT(*) as Total 
                    FROM candidatoadministracion
                    UNION ALL
                    SELECT 'Almacen' as Tipo, COUNT(*) as Total 
                    FROM candidatoalmacen";

                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(consulta, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tipo = reader.GetString(0);
                            int total = reader.GetInt32(1);
                            contadores[tipo] = total;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener contadores: {ex.Message}");
                MessageBox.Show("Error al obtener contadores: " + ex.Message);
            }

            return contadores;
        }


        // MÉTODO PARA CARGAR LOS ÚLTIMOS 3 CANDIDATOS DE ADMINISTRACIÓN
        public static void ListadoUltimosCandidatosAdministracion(DataTable modelo)
        {
            try
            {
                modelo.Clear();
                modelo.Columns.Clear();
                modelo.Columns.Add("NOMBRE", typeof(string));
                modelo.Columns.Add("APELLIDOS", typeof(string));
                modelo.Columns.Add("DNI", typeof(string));
                modelo.Columns.Add("TELÉFONO", typeof(int));

                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    conn.Open();
                    string consulta = @"
                SELECT nombre, apellidos, dni, telefono
                FROM candidatoadministracion 
                ORDER BY fechaAlta DESC 
                LIMIT 3";

                    MySqlCommand cmd = new MySqlCommand(consulta, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            modelo.Rows.Add(
                                reader.GetString(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetInt32(3)
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show("Error al cargar candidatos de administración: " + ex.Message);
            }
        }

        // MÉTODO PARA CARGAR LOS ÚLTIMOS 3 CANDIDATOS DE ALMACÉN
        public static void ListadoUltimosCandidatosAlmacen(DataTable modelo)
        {
            try
            {
                modelo.Clear();
                modelo.Columns.Clear();
                modelo.Columns.Add("NOMBRE", typeof(string));
                modelo.Columns.Add("APELLIDOS", typeof(string));
                modelo.Columns.Add("DNI", typeof(string));
                modelo.Columns.Add("TELÉFONO", typeof(int));

                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    conn.Open();
                    string consulta = @"
                SELECT nombre, apellidos, dni, telefono
                FROM candidatoalmacen 
                ORDER BY fechaAlta DESC 
                LIMIT 3";

                    MySqlCommand cmd = new MySqlCommand(consulta, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            modelo.Rows.Add(
                                reader.GetString(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetInt32(3)
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show("Error al cargar candidatos de almacén: " + ex.Message);
            }
        }

        public static bool RegistrarCandidatoAdministracion(CandidatoAdministracion c)
        {
            string consulta = @"INSERT INTO candidatoadministracion 
    (nombre, apellidos, dni, fechaNacimiento, direccion, cp, localidad, 
    telefono, email, foto, nivelEstudios, nivelInformaticaTexto, 
    nivelInformaticaHojaCalculo, nivelInformaticainternet, 
    observaciones, fechaAlta, registrador) 
    VALUES 
    (@nombre, @apellidos, @dni, @fechaNacimiento, @direccion, @cp, @localidad, 
    @telefono, @email, @foto, @nivelEstudios, @nivelInformaticaTexto, 
    @nivelInformaticaHojaCalculo, @nivelInformaticaInternet, 
    @observaciones, @fechaAlta, @registrador)";

            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(consulta, conn);

                // Parámetros de la clase base Candidato
                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@apellidos", c.Apellidos);
                cmd.Parameters.AddWithValue("@dni", c.Dni);
                cmd.Parameters.AddWithValue("@fechaNacimiento", c.FechaNacimiento);
                cmd.Parameters.AddWithValue("@direccion", c.Direccion);
                cmd.Parameters.AddWithValue("@cp", c.Cp);
                cmd.Parameters.AddWithValue("@localidad", c.Localidad);
                cmd.Parameters.AddWithValue("@telefono", c.Tlfno);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@foto", c.Foto ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@nivelEstudios", c.NivelEstudios);
                cmd.Parameters.AddWithValue("@observaciones", string.IsNullOrWhiteSpace(c.Observaciones) ? (object)DBNull.Value : c.Observaciones);
                cmd.Parameters.AddWithValue("@fechaAlta", c.FechaAlta);
                cmd.Parameters.AddWithValue("@registrador", c.UsuarioRegistrador);

                // Parámetros específicos de CandidatoAdministracion
                cmd.Parameters.AddWithValue("@nivelInformaticaTexto", c.NivelInformaticaTexto);
                cmd.Parameters.AddWithValue("@nivelInformaticaHojaCalculo", c.NivelInformaticaCalculo);
                cmd.Parameters.AddWithValue("@nivelInformaticaInternet", c.NivelInformaticaInternet);

                // Ejecutar la consulta
                int filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error MySQL al registrar candidato de administración: " + ex.Message);
                Console.WriteLine("Código de error: " + ex.Number);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al registrar candidato de administración: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static bool RegistrarCandidatoAlmacen(CandidatoAlmacen c)
        {
            string consulta = @"INSERT INTO candidatoalmacen 
    (nombre, apellidos, dni, fechaNacimiento, direccion, cp, localidad, 
    telefono, email, foto, nivelEstudios, carnetConducir, carnetCarretilla, 
    carnetCamion, observaciones, fechaAlta, registrador) 
    VALUES 
    (@nombre, @apellidos, @dni, @fechaNacimiento, @direccion, @cp, @localidad, 
    @telefono, @email, @foto, @nivelEstudios, @carnetConducir, @carnetCarretilla, 
    @carnetCamion, @observaciones, @fechaAlta, @registrador)";

            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(consulta, conn);

                // Parámetros de la clase base Candidato
                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@apellidos", c.Apellidos);
                cmd.Parameters.AddWithValue("@dni", c.Dni);
                cmd.Parameters.AddWithValue("@fechaNacimiento", c.FechaNacimiento);
                cmd.Parameters.AddWithValue("@direccion", c.Direccion);
                cmd.Parameters.AddWithValue("@cp", c.Cp);
                cmd.Parameters.AddWithValue("@localidad", c.Localidad);
                cmd.Parameters.AddWithValue("@telefono", c.Tlfno);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@foto", c.Foto ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@nivelEstudios", c.NivelEstudios);
                cmd.Parameters.AddWithValue("@observaciones", string.IsNullOrWhiteSpace(c.Observaciones) ? (object)DBNull.Value : c.Observaciones);
                cmd.Parameters.AddWithValue("@fechaAlta", c.FechaAlta);
                cmd.Parameters.AddWithValue("@registrador", c.UsuarioRegistrador);

                // Parámetros específicos de CandidatoAlmacen
                cmd.Parameters.AddWithValue("@carnetConducir", c.CarnetConducir);
                cmd.Parameters.AddWithValue("@carnetCarretilla", c.CarnetCarretilla);
                cmd.Parameters.AddWithValue("@carnetCamion", c.CarnetCamion);

                // Ejecutar la consulta
                int filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error MySQL al registrar candidato de almacén: " + ex.Message);
                Console.WriteLine("Código de error: " + ex.Number);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al registrar candidato de almacén: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static bool CompruebaDniCandidatoAdm(string dni)
        {
            string consulta = "SELECT COUNT(*) FROM candidatoadministracion WHERE dni = @dni";
            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                cmd.Parameters.AddWithValue("@dni", dni);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error MySQL al verificar DNI en Administración: " + ex.Message);
                Console.WriteLine("Código de error: " + ex.Number);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al verificar DNI en Administración: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public static bool CompruebaDniCandidato(string dni)
        {
            string consulta = "SELECT COUNT(*) FROM candidatoalmacen WHERE dni = @dni";
            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                cmd.Parameters.AddWithValue("@dni", dni);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error MySQL al verificar DNI en Almacén: " + ex.Message);
                Console.WriteLine("Código de error: " + ex.Number);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al verificar DNI en Almacén: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        public static DataTable VerCandidatosAdministracion(string condicion)
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT nombre, apellidos, dni, telefono, email, nivelEstudios, " +
                              "nivelInformaticaTexto, nivelInformaticaHojaCalculo, nivelInformaticaInternet " +
                              "FROM candidatoadministracion WHERE 1" + condicion;
            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                dt.Columns[0].ColumnName = "NOMBRE";
                dt.Columns[1].ColumnName = "APELLIDOS";
                dt.Columns[2].ColumnName = "DNI";
                dt.Columns[3].ColumnName = "TELÉFONO";
                dt.Columns[4].ColumnName = "EMAIL";
                dt.Columns[5].ColumnName = "NIVEL DE ESTUDIOS";
                dt.Columns[6].ColumnName = "NIVEL INFORMÁTICA - TEXTO";
                dt.Columns[7].ColumnName = "NIVEL INFORMÁTICA - CÁLCULO";
                dt.Columns[8].ColumnName = "NIVEL INFORMÁTICA - INTERNET";

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error MySQL: " + ex.Message);
                return dt;
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public static DataTable VerCandidatosAlmacen(string condicion)
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT nombre, apellidos, dni, telefono, email, nivelEstudios, " +
                              "carnetConducir, carnetCarretilla, carnetCamion " +
                              "FROM candidatoalmacen WHERE 1" + condicion;
            MySqlConnection conn = new MySqlConnection(url);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                dt.Columns[0].ColumnName = "NOMBRE";
                dt.Columns[1].ColumnName = "APELLIDOS";
                dt.Columns[2].ColumnName = "DNI";
                dt.Columns[3].ColumnName = "TELÉFONO";
                dt.Columns[4].ColumnName = "EMAIL";
                dt.Columns[5].ColumnName = "NIVEL DE ESTUDIOS";
                dt.Columns[6].ColumnName = "CARNET DE CONDUCIR";
                dt.Columns[7].ColumnName = "CARNET DE CARRETILLA";
                dt.Columns[8].ColumnName = "CARNET DE CAMIÓN";

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error MySQL al obtener candidatos de almacén: " + ex.Message);
                Console.WriteLine("Código de error: " + ex.Number);
                return dt; // Retorna DataTable vacío en caso de error
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al obtener candidatos de almacén: " + ex.Message);
                return dt; // Retorna DataTable vacío en caso de error
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

    }
}
