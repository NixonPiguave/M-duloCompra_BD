using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace ModuloDeCompra_BD.Clases
{
    public class CsEmail
    {
        private string De;
        private string De_Nombre;
        private string Para;
        private string Asunto;
        private string Cuerpo;
        private string Servidor;
        private int Puerto;
        private bool SSL;
        private string Usuario;
        private string Clave;
        private string RutaAdjunto;
        private MailMessage mensaje;

        public CsEmail(string server, int port, bool security, string user, string pass, string NombreCta)
        {
            De = user;
            De_Nombre = NombreCta;
            Servidor = server;
            Puerto = port;
            SSL = security;
            Usuario = user;
            Clave = pass;
            mensaje = new MailMessage();
            mensaje.From = new MailAddress(De, De_Nombre);
        }

        public string PARA
        {
            get { return Para; }
            set
            {
                Para = value;
                mensaje.To.Clear();
                mensaje.To.Add(new MailAddress(Para));
            }
        }

        public string ADJUNTO
        {
            get { return RutaAdjunto; }
            set
            {
                RutaAdjunto = value;
                mensaje.Attachments.Clear(); // Limpiamos adjuntos previos

                if (File.Exists(RutaAdjunto))
                {
                    mensaje.Attachments.Add(new Attachment(RutaAdjunto));
                }
                else
                {
                    MessageBox.Show("El archivo adjunto no existe: " + RutaAdjunto,
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public string DE
        {
            get { return De; }
            set { De = value; }
        }

        public string DE_NOMBRE
        {
            get { return De_Nombre; }
            set { De_Nombre = value; }
        }

        public string ASUNTO
        {
            get { return Asunto; }
            set { Asunto = value; mensaje.Subject = Asunto; }
        }

        public string CUERPO
        {
            get { return Cuerpo; }
            set { Cuerpo = value; mensaje.Body = Cuerpo; }
        }

        public Boolean Enviar()
        {
            try
            {
                using (var client = new SmtpClient(Servidor, Puerto))
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(Usuario, Clave);

                    // Configuración adicional crítica
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Timeout = 30000;

                    // Forzar TLS 1.2 (requerido por Gmail)
                    System.Net.ServicePointManager.SecurityProtocol =
                        System.Net.SecurityProtocolType.Tls12;

                    var mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress(De, De_Nombre);
                    mailMessage.To.Add(Para);
                    mailMessage.Subject = Asunto;
                    mailMessage.Body = Cuerpo;
                    mailMessage.IsBodyHtml = false;

                    if (!string.IsNullOrEmpty(RutaAdjunto))
                    {
                        mailMessage.Attachments.Add(new Attachment(RutaAdjunto));
                    }

                    client.Send(mailMessage);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error SMTP: {ex.Message}\n\nAsegúrate de:\n" +
                               "1. Tener verificación en dos pasos activada\n" +
                               "2. Haber creado una contraseña de aplicación\n" +
                               "3. Usar esa contraseña especial en tu app",
                               "Error de autenticación",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
