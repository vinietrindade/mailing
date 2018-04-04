using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    class Enviar
    {
        public static bool teste;

        public object email(string para,string assunto,string mensagem,string anexo)
        {
            teste = false;
            SmtpClient smtp = new SmtpClient();
            MailMessage mail = new MailMessage();
            Attachment anexar = new Attachment(anexo);
            mail.Attachments.Add(anexar);


            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("vini.trindade1998@gmail.com","oj88iiuo");
            mail.From = new MailAddress("vini.trindade1998@gmail.com");

            if (!string.IsNullOrWhiteSpace(para))
            {
                mail.To.Add(new MailAddress(para));
                teste = true;
            }
            else
            {
                teste = false;
            }
            mail.Subject = assunto;
            mail.Body = mensagem;
            smtp.Send(mail);
            return teste;
        }
    }
}
