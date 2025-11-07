using DMarco_RRHH.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMarco_RRHH.modelo
{
    internal class Email
    {
        private string asunto;
        private string destinatario;
        private string fecha;
        private string hora;

        public Email(string asunto, string destinatario, string fecha, string hora)
        {
            this.Asunto = asunto;
            this.Destinatario = destinatario;
            this.Fecha = fecha;
            this.Hora = hora;
        }

        public string Asunto { get => asunto; set => asunto = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }

        public void EnviarCorreo()
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.hostinger.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("rrhh@reynaldomd.com", "2024-Rrhh");

                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("rrhh@reynaldomd.com");
                mensaje.To.Add(Destinatario);
                mensaje.Subject = Asunto;
                mensaje.IsBodyHtml = true;

                mensaje.Body = $@"
            <html>
            <body style='font-family: Arial, sans-serif;'>
                <h2 style='color: #333;'>CONVOCATORIA PARA ENTREVISTA DE TRABAJO</h2>
                <p>Revisado su CV y considerando que podría ser interesante para el puesto de trabajo que ofertamos le convocamos para una entrevista personal el día <strong>{Fecha}</strong> a las <strong>{Hora} horas</strong>.</p>
                <p>Para confirmar la recepción de este correo o cualquier duda que le surja contáctenos a través de la siguiente dirección de correo electrónico: <a href='mailto:rrhh@reynaldomd.com'>rrhh@reynaldomd.com</a></p>
                <br/>
                <p>Atentamente:</p>
                <p><strong>Departamento de Recursos Humanos de RMD</strong><br/>
               <strong>TalentosBro y Asociados S.U</strong></p>
                <br/>
                <img src='http://www.reynaldomd.com/firmacorreo/firmarrhh.png' alt='Firma' style='max-width: 400px;'/>
            </body>
            </html>";

                smtp.Send(mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al enviar el correo: {ex.Message}");
            }
        }

        public override string ToString()
        {
            return $"Email a {Destinatario} - Fecha: {Fecha} {Hora}";
        }
    }
}
