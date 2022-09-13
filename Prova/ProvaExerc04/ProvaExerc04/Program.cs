using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaExerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Entre com um número inteiro");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) {
                Console.WriteLine("Número digitado é par");
            }else{
                Console.WriteLine("Número digitado é impar");
            }if(n < 0) {
                Console.WriteLine("Número digitado é Negativo");
            }else{
                Console.WriteLine("Número digitado é positivo");
            }
            Console.ReadKey();
        }
    }
}
