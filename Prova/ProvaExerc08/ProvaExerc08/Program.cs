using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaExerc08
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double a, b, c, maior;

            Console.WriteLine("Entre com o Valor de i:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número para A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número para B");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número para C");
            c = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    //crescente
                    if (b < a )
                    {
                        maior = a;
                        a = b;
                        b = maior;
                    }
                    if (c < a)
                    {
                        maior = a;
                        a = c;
                        c = maior;
                    }
                    if (c < b)
                    {
                        maior = b;
                        b = c;
                        c = maior;
                    }
                    Console.WriteLine(a + " " + b + " " + c);
                    break;
                case 3:
                    //Maior no meio
                   if(a>b && a > c)
                    {
                        maior=b;
                        b = a;
                        a = maior;
                    }
                    else if(c>a && c > b)
                    {
                        maior = b;
                        b=c;
                        c = maior;
                    }
                    Console.WriteLine(a + " " + b + " "+ c);
                break;
            }

            Console.ReadKey();
        }
    }
}
