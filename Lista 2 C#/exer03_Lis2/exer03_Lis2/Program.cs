using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer03_Lis2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, i, res;

            Console.WriteLine("Digite um numero para ver a tabuada: ");
            n1 = int.Parse(Console.ReadLine());

            for(i = 0; i <= 10; i++)
            {
                res = n1 * i;
                Console.WriteLine(n1 + " x " + i + " = " + res);
            }
            Console.ReadKey();
        }
    }
}
