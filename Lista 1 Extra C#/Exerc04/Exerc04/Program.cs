using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc04
{
    internal class Program
    {

        //Exercício 4: O custo ao consumidor de um carro novo é a soma do custo de fábrica
        //com a percentagem do distribuidor e dos impostos(aplicados ao custo de fábrica).
        //Supondo que a percentagem do distribuidor seja de 28% e os impostos de 45%,
        //escrever um algoritmo que leia o custo de fábrica de um carro e escreva o custo ao consumidor.
        static void Main(string[] args)
        {
            double valorFabrica, valorConsumidor;

            Console.WriteLine("Digite o Valor de fabricação do veículo");
            valorFabrica = int.Parse(Console.ReadLine());
            valorConsumidor = valorFabrica + (valorFabrica * 73 / 100);

            Console.WriteLine("Valor de revenda do veículo é de: " + valorConsumidor);
            Console.ReadKey();
        }
    }
}
