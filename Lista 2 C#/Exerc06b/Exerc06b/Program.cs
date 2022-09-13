using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc06b
{
    class Program
    {
        static void Main(string[] args)
        {
            double notas, media=0;
            double soma =0;
            int i;
            for (i = 1; i < 3; i++)
            {
                Console.WriteLine("Digite a " +i+ "º Nota: ");
                notas = double.Parse(Console.ReadLine());
                if (notas < 0 || notas > 10)
                {
                    Console.WriteLine("Valor inserido Inválido! VALORES VÁLIDOS DE 0 Á 10.");
                    i--;
                }
                else
                {
                    soma = soma + notas;
                }
            }
            media = soma / 2;
            Console.WriteLine("Media das notas " + media);
            Console.ReadKey();
        
    }
    }
}
