using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc03
{
    internal class Program
    {

 //Exercício 3: Escreva um programa que leia dois números inteiros, sendo armazenados
 //respectivamente nas variáveis A e B.O programa deverá inverter os valores entre as
//variáveis, de modo que o valor da variável A seja atribuído na variável B e vice-versa.
//Ao final exibir os valores de cada variável.
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite o valor de A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            b = int.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("Valor de A: " + a + " Valor de B: " + b);
            Console.ReadKey();
        }
    }
}
