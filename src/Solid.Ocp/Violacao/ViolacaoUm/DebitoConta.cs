namespace Solid.Ocp.Violacao.ViolacaoUm
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoContaEnum tipoConta)
        {
            if (tipoConta == TipoContaEnum.Corrente)
            {
                // Debita conta corrente
            }

            if (tipoConta == TipoContaEnum.Poupanca)
            {
                // Valida aniversário da conta
                // Debita conta poupança
            }
        }
    }
}