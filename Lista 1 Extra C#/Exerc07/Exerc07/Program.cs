using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exerc07
{
    internal class Program
    {
//Exercício 7: Fazer um programa para ler a, b, c e calcular a equação do 2º grau onde
//Delta = (B² - 4*A* C) e exibir X1 e X2.Onde(x =-b +ou- (Raiz de Delta)/a).

        static void Main(string[] args)
        {
            int a, b, c;
            double x1, x2, delta;

            Console.WriteLine("Entre com o valor de A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de B");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de C");
            c = int.Parse(Console.ReadLine());

            double getDelta()
            {
                delta = Math.Pow(b, 2) - (4 * a * c);
                return delta;
            }
            delta = getDelta();

            x1 = (-b + (Math.Sqrt(delta))) / 2 * a;
            x2 = (-b - (Math.Sqrt(delta))) / 2 * a;

            Console.WriteLine("Valor de Delta é " + delta + "\nValor de x1: " + x1 + "\nValor de x2:" + x2);
            Console.ReadKey();
        }
    }
}
