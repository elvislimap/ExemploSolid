namespace Solid.Dip.Solucao.Interfaces
{
    public interface IEmailService
    {
        void Enviar(string para, string assunto, string mensagemEmail);
    }
}