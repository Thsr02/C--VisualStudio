using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc07
{
    internal class Program
    {

//Exercício 7: Escreva um programa que exiba todos os números de 1 a 100 e a cada número
//que for múltiplo de 10, exiba a mensagem “MÚLTIPLO DE 10”.  
        static void Main(string[] args)
        {
            int i;

            for (i = 1; i <= 100; i++) {
                Console.WriteLine(i + ".");
                if (i % 10 == 0) {
                    Console.WriteLine(i+" É multiplo de 10");
                }
            }
            Console.ReadKey();
        }
    }
}
