using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc09
{
    internal class Program
    {

 //Exercício 9: Escreva um programa que lei a vários números inteiros e ao final informe
//quantos números pares, quantos números ímpares, quantos números positivos e quantos
//números negativos foram digitados pelo usuário.O programa só deve parar de rodar
//quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?".  
        static void Main(string[] args)
        {
            int impar, par, positivo, negativo, op=0, n1;
            string op2="";

            do {
                Console.WriteLine("digite um numero");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Deseja encerrar o programa? Entre com 'S' ou 'N', apenas ");
                op2 = Console.ReadLine();
                
                switch (op2) {
                    case "S":
                    op = 1;
                    break;
                    case "N":
                    op = 0;
                    break;

                }
            } while (op == 0);
        }
    }
}
