using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer01_Lis2
{
    class Program
    {
        static void Main(string[] args)
        {
            int par, i;

            Console.WriteLine("Numreros Pares de 11 a 250");

            for (i = 11; i <= 250; i ++)
            {
               if(i % 2 == 0)
                {
                    par = i;
                    
                    Console.WriteLine( par + " | ");
                   
                }
            }
            
            Console.ReadKey();
        }
    }
}
