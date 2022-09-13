using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer06_Lis2
{
    class Program
    {
        static void Main(string[] args)
        {
            double notas, media;
            int i;
        for(i = 0; i < 10; i++)
            {
            Console.WriteLine("Digite a Nota: ");
            notas = double.Parse(Console.ReadLine()); 
            if(notas < 0 || notas > 10)
            {
                media = media + nota;
            }else{
                Console.WriteLine("Valor inserido Inválido! VALORES VÁLIDOS DE 0 Á 10.");
                    i--;
            }
            }
            Console.ReadKey();
        }
    }
}
