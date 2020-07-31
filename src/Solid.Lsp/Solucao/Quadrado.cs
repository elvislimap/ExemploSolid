using System;
namespace Solid.Lsp.Solucao
{
    public class Quadrado : Paralelogramo
    {
        public Quadrado(int altura, int largura) : base(altura, largura)
        {
            if(altura != largura)
                throw new Exception("A altura e a largura do quadrado devem ser iguais");
        }
    }
}