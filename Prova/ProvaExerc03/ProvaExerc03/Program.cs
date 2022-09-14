using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaExerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Entre com a idade do nadador");
            idade = int.Parse(Console.ReadLine());

            if(idade >= 5 && idade <= 7) {
                Console.WriteLine("CATEGORIA INFANTIL A");
            }else if(idade <= 10) {
                Console.WriteLine("CATEGORIA INFANTIL B");
            }else if(idade <= 13) {
                Console.WriteLine("JUVENIL A");
            }else if(idade <= 17) {
                Console.WriteLine("JUVENIL B");
            }else{
                Console.WriteLine("ADULTO \nMAIORES DE 18");
            }
            Console.ReadKey();
        }
    }
}
