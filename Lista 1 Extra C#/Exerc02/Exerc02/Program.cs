using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc02
{
    //Exercício 2: Escreva um programa que leia o nome de duas pessoas e ao final exiba: 
    //no final exiba os 2 nomes com todas as letras maisculas
    //a quantidade de caracteres de cada nome
    //apenas os tres primeiros caracteres de cada nome
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;

            Console.WriteLine("Digite o primeiro nome");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo nome");
            nome2 = Console.ReadLine();

            Console.WriteLine(nome1.ToUpper() + " Possui " + nome1.Length + " Caracteres e \n" + nome2.ToUpper() + " Possui " + nome2.Length + " Caracteres \n"+
                " Os Três primeiros caracters do primeiro nome são: " +nome1.Substring(0,3)+ "\n Os Três primeiros caractes do segundo nome são: " + nome2.Substring(0,3));
            Console.ReadKey();
        }
    }
}
