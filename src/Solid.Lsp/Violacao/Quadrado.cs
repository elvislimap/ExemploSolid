namespace Solid.Lsp.Violacao
{
    public class Quadrado : Retangulo
    {
        public override int Altura { set { base.Altura = base.Largura = value; } }
        public override int Largura { set { base.Largura = base.Altura = value; } }
    }
}