using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc08
{
    internal class Program
    {
//Exercício 8: Escreva um programa que calcule o fatorial de um número informado pelo usuário.
//Dica: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N


        static void Main(string[] args)
        {
            int n1, n2, fatorial=0;

            Console.WriteLine("Digite o número que deseja exibir o fatorial");
            n1 = int.Parse(Console.ReadLine());
            n2 = n1;
             
                for(int i = n1; i > 1; i--) {
                    fatorial = n1 * (i - 1);
                    n1 = fatorial;
            }
            
            Console.WriteLine("Fatorial de: " + n2 + " é " + fatorial);
            Console.ReadKey();
        }
    }
}
