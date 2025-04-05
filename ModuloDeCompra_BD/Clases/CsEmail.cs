using System;
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
        string De;
        string De_Nombre;
        string[] Para;
        string Asunto;
        string Cuerpo;

        string Servidor;
        int Puerto;
        bool SSL;
        string Usuario;
        string Clave;
        string[] Concopia;
        string[] RutaAdjunto;
        MailMessage mensaje;

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
        public string[] PARA
        {
            get { return Para; }
            set
            {
                Para = value;
                for (int i = 0; i <= Para.GetUpperBound(0); i++)
                {
                    mensaje.To.Add(new MailAddress(Para[i]));
                }
            }
        }
        public string[] CONCOPIA
        {
            get { return Concopia; }
            set
            {
                Concopia = value;
                for (int i = 0; i <= Concopia.GetUpperBound(0); i++)
                {
                    mensaje.CC.Add(new MailAddress(Concopia[i]));
                }
            }
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
        public string[] ADJUNTO
        {
            get { return RutaAdjunto; }
            set
            {
                RutaAdjunto = value;
                for (int i = 0; i <= RutaAdjunto.GetUpperBound(0); i++)
                    mensaje.Attachments.Add(new Attachment(RutaAdjunto[i]));
            }
        }

        public Boolean Enviar()
        {
            SmtpClient clienteSMTP = new SmtpClient(Servidor);
            clienteSMTP.Port = Puerto;
            clienteSMTP.EnableSsl = SSL;
            clienteSMTP.Credentials = new NetworkCredential(Usuario, Clave);
            try
            {
                clienteSMTP.Send(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mensaje.Dispose();
                return false;
            }
            return true;
        }
    }
}
