using System;
using Teste3.Classes;

namespace Teste3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente leonardo = new(1010, "Leonardo", 3000);
            Console.WriteLine(leonardo);

            leonardo.Rendimento();
            Console.Write("\n");

            Console.WriteLine(leonardo);
            Console.Write("\n");

            ContaPoupanca amanda = new(2020, "Amanda", 3000);
            Console.WriteLine(amanda);

            amanda.Rendimento();
            Console.Write("\n");

            Console.WriteLine(amanda);
            Console.Write("\n");
        }
    }
}
