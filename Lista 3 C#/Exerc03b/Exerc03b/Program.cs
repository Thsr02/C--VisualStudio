using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc03b
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Exercício 3: Escreva um programa que lei a dois valores reais e apresente a diferença do
                maior para o menor.Um método chamado diferenca deverá ser implementado para realizar
                o cálculo e exibir o resultado.*/
            double n1, n2, dif;
            Console.WriteLine("Digite um número");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            n2 = double.Parse(Console.ReadLine());
            dif = diferenca(n1, n2);
            Console.Write("A diferença entre {0} e {1} é de {2}", n1, n2, dif);
            Console.ReadKey();
        }

        static double diferenca(double num1, double num2)
        {
            if (num1 > num2)
            {
                double dif = num1 - num2;
                return dif;
            }
            else
            {
                double dif = num2 - num1;
                return dif;
            }
        }
    }
    }

