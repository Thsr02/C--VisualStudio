using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaExerc11
{
    internal class Program
    {
        /*11. Fazer um programa para ler um Nº que tenha raiz exata e exibir sua raiz*/
        static void Main(string[] args)
        {
            int raiz =0,num;

            Console.WriteLine("Digite o número que gostaria de exibir sua raiz exata ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                if(i * i == num)
                {
                    Console.WriteLine("Raiz exata de " + num + " é " + i);
                    raiz = 1;
                }
            }
           if (raiz == 0)
            {
                Console.WriteLine(num + " Não possui Raiz exata");
            }

        }
    }
}
