using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exerc06
{
    internal class Program
    {

//Exercício 6: Escreva um programa que calcule e exiba a média de 10 notas digitadas pelo
//usuário.Considerar notas válidas, somente valores entre 0 (zero) e 10 (dez). Se o usuário
//digitar algum valor inválido, deverá ser exibida uma mensagem informando o ocorrido.  
        static void Main(string[] args)
        {
            double nota=0, media=0;
            int op=0;

            do
            {
                Console.WriteLine("Entre com a nota do aluno.");
                nota = int.Parse(Console.ReadLine());
                if (nota >=0 && nota <= 10) { 
                media = media + nota;
                op++;
                    Console.WriteLine(op+"contagem op");
                }else{
                    Console.WriteLine("Entre apenas com notas válidas. Valores entre 0 e 10");
                    op++;
                    op--;
                    Console.WriteLine(op+"contagem op");
                }
            } while (op < 10);
            media = media / 10;
            Console.WriteLine("Media do Aluno: " + media);
            Console.ReadKey();
        }
    }
}
