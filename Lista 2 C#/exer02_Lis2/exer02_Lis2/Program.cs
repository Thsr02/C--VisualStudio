using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer02_Lis2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, i, impar;

            Console.WriteLine("Digite o menor numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o maior numero: ");
            n2 = int.Parse(Console.ReadLine());

            for(i = n2; i >= n1; i--)
            {
                if(i % 2 != 0)
                {
                    impar = i;
                    Console.WriteLine(impar + " |");
            }
                }
                
            
            Console.ReadKey();
        }
    }
}
