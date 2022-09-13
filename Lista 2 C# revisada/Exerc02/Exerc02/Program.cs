using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc02
{
    internal class Program
    {

//  Exercício 2: Escreva um programa que exiba na tela em ordem decrescente, apenas os
//  números ímpares existentes entre dois números digitados pelo usuário(inclusive eles). 
 
        static void Main(string[] args)
        {
            int n1, n2,i;

            Console.WriteLine("Entre com o primeiro número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número");
            n2 = int.Parse(Console.ReadLine());

                if(n1 > n2) { 
                    for(i = n1; i >= n2; i--) { 
                        if(i%2 != 0) {
                            Console.WriteLine(i);
                        }
                    }
                }else{
                    for(i = n2; i >= n1; i--)
                        if(i%2 != 0) {
                        Console.WriteLine(i);

                        }
                }
            Console.ReadKey();
        }
    }
}
