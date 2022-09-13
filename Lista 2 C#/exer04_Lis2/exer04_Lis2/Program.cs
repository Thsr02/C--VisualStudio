using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer04_Lis2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, i, quant =0;

            Console.WriteLine("Digite o Menor numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Maior numero: ");
            n2 = int.Parse(Console.ReadLine());

            for (i = n1; i <= n2; i++)
            {
                if(i % 2 != 0)
                {
                    quant++;
                }
            }
            Console.WriteLine("Total de " + quant + " Numeros Pares");
            Console.ReadKey();
        }
    }
}
