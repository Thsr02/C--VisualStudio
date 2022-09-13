using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc04
{
    internal class Program
    {
 //   Exercício 4: Escreva um programa que exiba na tela a quantidade de números ímpares
 //   existentes entre dois números que o usuário digitar(testar inclusi ve os números digitados).  
        static void Main(string[] args)
        {
            int i, n1, n2, impar=0;

            Console.WriteLine("Digite o primeiro número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo  número");
            n2 = int.Parse(Console.ReadLine());
                
                if(n1 > n2) { 
                   for(i=n2; i <= n1; i++) { 
                        if(i%2 != 0) {
                            impar++;
                        }
                    }
                }else{
                    for(i=n1; i <=n2; i++) {
                        if(i%2 != 0) { 
                        impar++;
                        }
                    }
                }
         Console.WriteLine("Total de número impares entre os números digitados é: " + impar);
         Console.ReadKey();
        }
    }
}
