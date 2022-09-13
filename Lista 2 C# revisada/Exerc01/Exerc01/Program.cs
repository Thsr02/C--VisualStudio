using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc01
{
    internal class Program
    {

 //Exercício 1: Escreva um programa que exiba na tel a em ordem crescente, apenas os
//números pares existentes de 11 a 250.  
        static void Main(string[] args)
        {
            int i;
            for(i = 11; i <= 250; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                } 
            }
            Console.ReadKey();
        }
    }
}
