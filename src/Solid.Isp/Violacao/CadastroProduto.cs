namespace Solid.Isp.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void ValidarDados()
        {
            // Validar valor
        }

        public void SalvarBanco()
        {
            // Inserir na tabela Produto
        }

        public void EnviarEmail()
        {
            // Não existe e-mail do produto, o que fazer?
            throw new System.NotImplementedException("Esse método deve ser ignorado");
        }
    }
}