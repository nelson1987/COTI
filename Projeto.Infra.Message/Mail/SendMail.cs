using Projeto.Domain.Contracts.Messages;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;


namespace Projeto.Infra.Message.Mail
{
    public class SendMail : IMessage
    {
        private string remetente = "emaildonelsinho@gmail.com";
        private string fromPassword = "Nelson#2013";

        private readonly List<MailAddress> Destinatarios;

        public void Enviar(string assunto, string corpo)
        {
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(remetente, fromPassword)
            };
            foreach (MailAddress item in Destinatarios)
            {
                using (var message = new MailMessage(remetente, item.Address, assunto, corpo))
                {
                    smtp.Send(message);
                }
            }
        }

        public void AdicionarDestinatarios(List<MailAddress> destinatario)
        {
            this.Destinatarios.AddRange(destinatario);
        }
    }
}
