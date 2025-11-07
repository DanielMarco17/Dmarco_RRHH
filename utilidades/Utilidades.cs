using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DMarco_RRHH.utilidades
{
    internal class Utilidades
    {
        // ==================== VALIDACIÓN DE CAMPOS VACÍOS ====================

        /// <summary>
        /// Valida todos los campos de un GroupBox. Recorre todos los controles y valida según su tipo.
        /// Muestra mensaje del primer campo inválido y marca con fondo rojo los TextBox vacíos.
        /// </summary>
        public static bool ValidarFormularioCompleto(GroupBox panel)
        {
            // Ordenar controles por posición vertical para validar en orden visual
            var controls = panel.Controls.Cast<Control>()
                .OrderBy(c => c.Top)
                .ThenBy(c => c.Left)
                .ToList();

            // Primera pasada: buscar el primer campo inválido
            foreach (var control in controls)
            {
                string mensajeError = null;

                switch (control)
                {
                    case TextBox tb when string.IsNullOrWhiteSpace(tb.Text):
                        mensajeError = $"El campo {tb.Tag} es obligatorio";
                        tb.BackColor = Color.LightCoral;
                        break;

                    case ComboBox cb when cb.SelectedIndex == -1 || cb.SelectedItem == null:
                        mensajeError = $"Debe seleccionar una opción válida en {cb.Tag}";
                        cb.BackColor = Color.LightCoral;
                        break;

                    case DateTimePicker dtp when !dtp.Checked && dtp.ShowCheckBox:
                        mensajeError = $"Debe seleccionar una fecha en {dtp.Tag}";
                        break;

                    case GroupBox gb:
                        // Validar RadioButtons dentro de un GroupBox
                        var radioButtons = gb.Controls.OfType<RadioButton>().ToList();
                        if (radioButtons.Any() && !radioButtons.Any(rb => rb.Checked))
                        {
                            mensajeError = $"Debe seleccionar una opción en {gb.Tag}";
                        }
                        break;
                }

                // Si encontramos un error, mostrar mensaje y retornar false
                if (mensajeError != null)
                {
                    MessageBox.Show(mensajeError, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    control.Focus();
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Configura los eventos para restaurar el color de fondo cuando un TextBox toma el foco
        /// </summary>
        public static void ConfigurarEventosValidacion(GroupBox panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox tb)
                {
                    tb.GotFocus += (s, e) =>
                    {
                        TextBox textBox = s as TextBox;
                        if (textBox.BackColor == Color.LightCoral)
                        {
                            textBox.BackColor = SystemColors.Window;
                        }
                    };
                }
                else if (control is ComboBox cb)
                {
                    cb.GotFocus += (s, e) =>
                    {
                        ComboBox comboBox = s as ComboBox;
                        if (comboBox.BackColor == Color.LightCoral)
                        {
                            comboBox.BackColor = SystemColors.Window;
                        }
                    };
                }
                else if (control is GroupBox gb)
                {
                    // Configurar eventos recursivamente para controles dentro de GroupBox
                    ConfigurarEventosValidacion(gb);
                }
            }
        }

        // ==================== VALIDACIONES INDIVIDUALES ====================

        public static bool CampoVacio(TextBox campo)
        {
            return string.IsNullOrWhiteSpace(campo.Text);
        }

        public static void LanzaAlertaVacio(TextBox campo)
        {
            MessageBox.Show($"El campo {campo.Tag} es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            campo.BackColor = Color.LightCoral;
        }

        public static bool ComboVacio(ComboBox combo)
        {
            return combo.SelectedIndex == -1 || combo.SelectedItem == null;
        }

        public static void LanzaAlertaCombo(ComboBox combo)
        {
            MessageBox.Show($"Debe seleccionar una opción válida en {combo.Tag}", "Validación", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ==================== VALIDACIÓN DE FECHAS ====================

        public static bool ValidarFechaVacia(DateTimePicker datePicker)
        {
            if (datePicker.Value == null)
            {
                MessageBox.Show($"Debe seleccionar una fecha en {datePicker.Tag}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Valida que la fecha de nacimiento corresponda a una persona mayor de 18 años
        /// </summary>
        public static bool ValidarEdadMinima(DateTimePicker datePicker, int edadMinima = 18)
        {
            DateTime fechaMaxima = DateTime.Today.AddYears(-edadMinima);

            if (datePicker.Value > fechaMaxima)
            {
                MessageBox.Show(
                    $"El candidato debe tener al menos {edadMinima} años.\n" +
                    $"Fecha máxima permitida: {fechaMaxima.ToShortDateString()}",
                    "Edad no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Configura un DateTimePicker para limitar la selección de fecha de nacimiento
        /// La fecha máxima será 18 años antes del día actual
        /// </summary>
        public static void ConfigurarDatePickerEdadMinima(DateTimePicker datePicker, int edadMinima = 18)
        {
            // Establecer la fecha máxima (18 años antes de hoy)
            datePicker.MaxDate = DateTime.Today.AddYears(-edadMinima);

            // Establecer la fecha mínima razonable (por ejemplo, 100 años atrás)
            datePicker.MinDate = DateTime.Today.AddYears(-100);

            // Establecer fecha por defecto (25 años atrás, por ejemplo)
            datePicker.Value = DateTime.Today.AddYears(-25);

            // Formato de visualización
            datePicker.Format = DateTimePickerFormat.Long;
        }

        public static bool ValidarFechas(DateTimePicker fechaEntrada, DateTimePicker fechaSalida)
        {
            DateTime fechaActual = DateTime.Today;

            if (fechaEntrada.Value < fechaActual)
            {
                MessageBox.Show($"Debe elegir una fecha válida en {fechaEntrada.Tag}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (fechaSalida.Value <= fechaEntrada.Value)
            {
                MessageBox.Show("La fecha de salida debe ser posterior a la fecha de entrada", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static DateTime QuitarHora(DateTime fecha)
        {
            return fecha.Date;
        }

        public static bool FechaSalidaValida(DateTime fechaEntrada, DateTime fechaSalida)
        {
            return fechaSalida >= fechaEntrada.AddDays(1);
        }

        public static bool FechaHoyOPosterior(DateTime fechaAComprobar)
        {
            DateTime fechaAComprobarSinHora = QuitarHora(fechaAComprobar);
            DateTime fechaActualSinHora = QuitarHora(DateTime.Now);
            return fechaAComprobarSinHora >= fechaActualSinHora;
        }

        // ==================== VALIDACIÓN DE RADIOBUTTONS ====================

        public static bool ValidarRadioButtons(GroupBox grupoRadio, params RadioButton[] radioButtons)
        {
            foreach (var rb in radioButtons)
            {
                if (rb.Checked) return true;
            }
            MessageBox.Show($"Debe seleccionar una opción en {grupoRadio.Tag}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public static bool ValidarRadioButtons(params RadioButton[] radioButtons)
        {
            return radioButtons.Any(rb => rb.Checked);
        }

        /// <summary>
        /// Recorre un GroupBox que contiene RadioButtons y recupera el valor del Tag del RadioButton marcado
        /// </summary>
        /// <param name="grupoRadio">GroupBox que contiene los RadioButtons</param>
        /// <returns>El valor del Tag del RadioButton marcado, o cadena vacía si ninguno está marcado</returns>
        public static string ObtenerValorRadioButtonsMarcado(GroupBox grupoRadio)
        {
            foreach (Control control in grupoRadio.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    return rb.Tag?.ToString() ?? "";
                }
            }
            return "";
        }

        // ==================== VALIDACIONES DE FORMATO ====================

        public static bool ValidarDNI(string dni)
        {
            dni = dni.Trim().ToUpper();
            string letrasValidas = "TRWAGMYFPDXBNJZSQVHLCKE";

            if (dni.Length != 9)
            {
                MessageBox.Show("El DNI debe tener 9 caracteres", "Validación DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(dni.Substring(0, 8), out int numero))
            {
                MessageBox.Show("Los primeros 8 caracteres deben ser números", "Validación DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            char letraIngresada = dni[8];
            int indice = numero % 23;
            char letraCorrecta = letrasValidas[indice];

            if (letraIngresada != letraCorrecta)
            {
                MessageBox.Show($"Letra del DNI incorrecta. La letra correcta es: {letraCorrecta}", "Validación DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static bool ValidarTelefono(string telefono)
        {
            var regex = new Regex(@"^(?:\+34|0034)?[6-9]\d{8}$");
            if (!regex.IsMatch(telefono.Trim()))
            {
                MessageBox.Show("El teléfono no es válido. Debe ser un número español válido.", "Validación Teléfono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool ValidarEmail(string email)
        {
            var regex = new Regex(@"^[\w.-]+@[\w.-]+\.[a-zA-Z]{2,}$");
            if (!regex.IsMatch(email.Trim()))
            {
                MessageBox.Show("El email no es válido", "Validación Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool ValidarCP(string cp)
        {
            var regex = new Regex(@"^(0[1-9]|[1-4][0-9]|5[0-2])\d{3}$");
            if (!regex.IsMatch(cp.Trim()))
            {
                MessageBox.Show("El código postal no es válido", "Validación CP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public static bool ValidarFoto(string rutaArchivo, byte[] bytesArchivo)
        {
            // Validar que se haya seleccionado una foto
            if (string.IsNullOrWhiteSpace(rutaArchivo) || bytesArchivo == null)
            {
                MessageBox.Show("Debe seleccionar una foto", "Validación Foto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar extensión
            string extension = System.IO.Path.GetExtension(rutaArchivo).ToLower();
            if (extension != ".jpg" && extension != ".jpeg" && extension != ".png")
            {
                MessageBox.Show("La foto debe ser formato .jpg o .png", "Formato de Foto Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar tamaño máximo (2MB = 2000000 bytes)
            if (bytesArchivo.Length > 2000000)
            {
                double sizeMB = bytesArchivo.Length / 1024.0 / 1024.0;
                MessageBox.Show(
                    $"La foto es demasiado grande ({sizeMB:F2} MB).\n\n" +
                    "El tamaño máximo permitido es 2 MB.",
                    "Foto Demasiado Grande",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // ==================== VALIDACIONES NUMÉRICAS ====================

        public static bool CompruebaEntero(TextBox campo)
        {
            if (!int.TryParse(campo.Text.Trim(), out _))
            {
                MessageBox.Show($"{campo.Tag} debe ser un número entero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campo.BackColor = Color.LightCoral;
                return false;
            }
            return true;
        }

        public static bool CompruebaDecimal(TextBox campo)
        {
            if (!decimal.TryParse(campo.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show($"{campo.Tag} debe ser un número decimal", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campo.BackColor = Color.LightCoral;
                return false;
            }
            return true;
        }

        // ==================== UTILIDADES GENERALES ====================

        public static void LanzarAlerta(Control ventanaPadre, string mensaje)
        {
            MessageBox.Show(ventanaPadre, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void LanzarAlerta(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ReseteaFormulario(GroupBox panel)
        {
            foreach (Control c in panel.Controls)
            {
                switch (c)
                {
                    case TextBox tb:
                        tb.Text = "";
                        tb.BackColor = SystemColors.Window;
                        break;
                    case ComboBox cb:
                        cb.SelectedIndex = -1;
                        cb.BackColor = SystemColors.Window;
                        break;
                    case DateTimePicker dtp:
                        if (dtp.MaxDate < DateTime.Now)
                        {
                            dtp.Value = DateTime.Today.AddYears(-25);
                        }
                        else
                        {
                            dtp.Value = DateTime.Now;
                        }
                        if (dtp.ShowCheckBox) dtp.Checked = false;
                        break;
                    case RadioButton rb:
                        rb.Checked = false;
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case GroupBox gb:
                        // Resetear recursivamente controles dentro de GroupBox
                        ReseteaFormulario(gb);
                        break;
                }
            }
        }

        /// <summary>
        /// Restaura el color de fondo de todos los controles a su valor por defecto
        /// </summary>
        public static void RestaurarColoresFondo(GroupBox panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox tb)
                {
                    tb.BackColor = SystemColors.Window;
                }
                else if (control is ComboBox cb)
                {
                    cb.BackColor = SystemColors.Window;
                }
                else if (control is GroupBox gb)
                {
                    RestaurarColoresFondo(gb);
                }
            }
        }
    }
}