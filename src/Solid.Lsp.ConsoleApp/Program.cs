using System;
using Solid.Lsp.Solucao;

namespace Solid.Lsp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var retangulo = new Retangulo(10, 5);
            var quadrado = new Quadrado(10, 10);

            Console.WriteLine("Área do retangulo:");
            CalculoArea.ObterArea(retangulo);
            Console.WriteLine("");
            Console.WriteLine("Área do quadrado:");
            CalculoArea.ObterArea(quadrado);
        }
    }
}
