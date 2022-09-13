using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc08
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, n, fatorial;

            Console.WriteLine("Entre com número que deseja fatorar");
            n = double.Parse(Console.ReadLine());
            fatorial = n;
            for (i = n - 1; i >= 1; i--)
            {
                Console.WriteLine($"{fatorial} * {i}");
                fatorial = fatorial * i;
                Console.WriteLine($"fatorial={fatorial}");
                Console.WriteLine("  ");
            }
            Console.WriteLine($"\nFatorial de {n} é {fatorial}");
            Console.ReadKey();
        }
    }
}
