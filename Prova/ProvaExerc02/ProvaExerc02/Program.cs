using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaExerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, maior;

            Console.WriteLine("Digite o Valor de A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor de B");
            b = int.Parse(Console.ReadLine());

            if(a > b) {
                Console.WriteLine("A Maior que B");    
            }else if(b > a) {
                Console.WriteLine("B Maior que A");
            }else{
                Console.WriteLine("A e B são iguais");
            }
            Console.ReadKey();
        }
        
    }
}
