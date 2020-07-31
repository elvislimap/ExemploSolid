using System.Net.Mail;
namespace Solid.Srp.Solucao
{
    public class EmailService
    {
        public void Enviar(string para, string assunto, string mensagemEmail)
        {
            var smtpClient = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            smtpClient.Send(new MailMessage("teste@teste.com", para)
            {
                Subject = assunto,
                Body = mensagemEmail
            });
        }
    }
}