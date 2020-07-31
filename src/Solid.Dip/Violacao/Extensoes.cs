namespace Solid.Dip.Violacao
{
    public static class Extensoes
    {
        public static bool ValidarEmail(this string email)
        {
            return email.Contains("@");
        }

        public static bool ValidarCpf(this string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
