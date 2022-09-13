using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc01
{
    internal class Program
    {
//Exercício 1: Escreva um programa que leia um valor em Reais(R$), leia também a
//cotação do Dólar, realize o cálculo da conversão de moeda(de Reais para Dólares) e
//exiba na tela o resultado.
        static void Main(string[] args)
        {
            double real, cotaDolar, total =0;

            Console.WriteLine("Digite o valor em reais a ser convertido");
            real = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a cotação atual do Dollar");
            cotaDolar = double.Parse(Console.ReadLine());

            double getCalDollar(){
                total = real / cotaDolar;
                return total;
            }
            total = getCalDollar();
            Console.Write(real + " R$ Convertidos em dolares, com a cotação atual de :" + cotaDolar + " Você tera em dolares o total de R$:" + total);
            Console.ReadKey();
        }
    }
}
