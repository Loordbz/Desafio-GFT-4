using System;
using Teste4.Classes;

namespace Teste4
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraIMC leonardo = new("Leonardo", 1.90, 100.00);
            Console.WriteLine(leonardo);

            Console.Write("\n");
            Console.WriteLine("Seu IMC é = {0}", leonardo.Calcular());
        }
    }
}
