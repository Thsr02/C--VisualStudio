using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc07
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <=100; i++)
            {
                Console.WriteLine(i+"\n");
                if (i % 10 == 0)
                {
                    Console.WriteLine(i+" Multiplo de 10");
                }
            }

            Console.ReadKey();
        }
    }
}
