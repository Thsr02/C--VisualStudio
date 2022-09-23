using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, fat;
            Console.WriteLine("Entre com número que deseja exibir o fatorial");
            num = int.Parse(Console.ReadLine());
            fat = calcularFatorial(num);

            Console.WriteLine("O fatorial de {0} é {1}", num, fat);
            Console.ReadKey();
        }

        static int calcularFatorial(int n)
        {
            int calcFat = 1;
           for (int i = 1; i <= n; i++)
            {
                calcFat = calcFat * i;
            }
            return calcFat;
        }
    }
}
