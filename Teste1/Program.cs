using System;
using Teste1.Classes;

namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedorLeonardo = new("Leonardo", 27, 1000.00, 2);
            Gerente gerenteAmanda = new("Amanda", 26, 3000.00, 4);
            Supervisor supervisorPaulo = new("Paulo", 70, 5000, 5);

            Console.WriteLine(vendedorLeonardo);
            Console.Write("\n");

            Console.WriteLine(gerenteAmanda);
            Console.Write("\n");

            Console.WriteLine(supervisorPaulo);
            Console.Write("\n");

            vendedorLeonardo.Bonificacao();
            gerenteAmanda.Bonificacao();
            supervisorPaulo.Bonificacao();

            Console.WriteLine(vendedorLeonardo);
            Console.Write("\n");

            Console.WriteLine(gerenteAmanda);
            Console.Write("\n");

            Console.WriteLine(supervisorPaulo);
            Console.Write("\n");


        }
    }
}
