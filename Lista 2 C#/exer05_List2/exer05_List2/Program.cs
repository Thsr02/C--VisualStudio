using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer05_List2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, i, maior = 0;

            for(i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite o Numreo: ");
                n1 = int.Parse(Console.ReadLine());
                if(maior < n1)
                {
                    maior = n1;
                }
            }
            Console.WriteLine("O Maior numero digitado é: " + maior);
            Console.ReadKey();
        }
    }
}
