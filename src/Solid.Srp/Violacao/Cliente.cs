using System.Net.Mail;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Solid.Srp.Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente(string assuntoEmail, string mensagemEmail)
        {
            if (!Email.Contains("@"))
                return "Cliente com e-mail inválido";

            if (Cpf.Length != 11)
                return "Cliente com CPF inválido";

            using (var con = new SqlConnection())
            {
                var cmd = new SqlCommand();

                con.ConnectionString = "MinhaConnectionString";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCadastro)";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", Cpf);
                cmd.Parameters.AddWithValue("dataCadastro", DataCadastro);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            var smtpClient = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            smtpClient.Send(new MailMessage("teste@teste.com", Email)
            {
                Subject = assuntoEmail,
                Body = mensagemEmail
            });

            return "Cliente cadastrado com sucesso!";
        }
    }
}