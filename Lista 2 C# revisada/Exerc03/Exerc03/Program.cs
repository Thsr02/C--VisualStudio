using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc03
{
    internal class Program
    {
//        Exercício 3: Escreva um programa que exiba na tela a tabuada de um número que deverá
//        ser informado pelo usuário(deverá ser usada qual quer estrutura de repetição).  
        static void Main(string[] args)
        {
            int i, n1, res;

            Console.WriteLine("Digite o número que deseja exibir a tabuada");
            n1 = int.Parse(Console.ReadLine());

                for(i=0; i <= 10; i++) {
                    res = n1 * i;
                    Console.WriteLine(n1 + " x " + i + " = " + res);
                }
            Console.ReadKey();
        }
    }
}
