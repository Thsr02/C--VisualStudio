using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc09
{
    internal class Program
    {
  // Exercício 9: Crie um algoritmo que leia a qtde.de DVD locados, o preço da locação e
//a qtde.de dias que os dvds ficaram locados.Calcule e exiba o valor total da locação.
        static void Main(string[] args)
        {
            int dvdLocado, precoLocacao, diasLocacao, calc;

            Console.WriteLine("Quantos DvD's Você esta alugando");
            dvdLocado = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual valor cobrado pelo aluguel, valor unitario");
            precoLocacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dia de aluguel");
            diasLocacao = int.Parse(Console.ReadLine());

            calc = (dvdLocado * precoLocacao) * diasLocacao;
            Console.WriteLine("Foram alugados " + dvdLocado + " No Valor de R$" + precoLocacao + " cada DVD, por " + diasLocacao + " dias de locação.\nTotal a pagar R$"+calc);
            Console.ReadKey();
        }
    }

}