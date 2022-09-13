using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc05
{
    internal class Program
    {

 // Exercício 5: Escreva um programa que leia 15 números inteiros e exiba na tela ao final, o
 // maior número que foi di gitado pelo usuári o.
        static void Main(string[] args)
        {
            int n1, maior=0, op=0;

            do {
                Console.WriteLine("Digite um número");
                n1 = int.Parse(Console.ReadLine());
                op++;
                    if(n1 > maior) {
                     maior = n1;
                    }
            }while(op <5);

        Console.Write("O Maior número digitado foi: " + maior);
        Console.ReadKey();
        }
    }
}
