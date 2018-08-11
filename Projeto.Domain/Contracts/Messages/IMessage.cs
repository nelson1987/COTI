using System.Collections.Generic;
using System.Net.Mail;

namespace Projeto.Domain.Contracts.Messages
{
    public interface IMessage
    {
        void AdicionarDestinatarios(List<MailAddress> destinatario);

        void Enviar(string assunto, string corpo);
    }
}
