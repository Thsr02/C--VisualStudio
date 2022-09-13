using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exerc05
{
    internal class Program
    {
// Exercício 5: Faça um algoritmo que leia a idade de uma pessoa expressa em anos, 
//meses e dias e mostre-a expressa apenas em dias.
        static void Main(string[] args)
        {
            int idade, calcIdade;

            Console.WriteLine("Digite quantos anos você tem");
            idade = int.Parse(Console.ReadLine());
            calcIdade = idade * 360;
            Console.WriteLine("Sua idade de " + idade + " em dias seria:" + calcIdade);
            Console.ReadKey();
        }
    }
}
