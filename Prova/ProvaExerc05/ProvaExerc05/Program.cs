using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaExerc05
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo;

            Console.WriteLine("Entre Com seu saldo Bancario");
            saldo = int.Parse(Console.ReadLine());

            if(saldo ==0 || saldo <= 200) {
                Console.WriteLine("Saldo médio " + saldo + " Nenhum crédito especial");
            }else if(saldo <= 400) {
                saldo = saldo + (saldo * 0.20);
                Console.WriteLine("Saldo médio " + saldo + " 20% do valor do crédito especial");
            }else if(saldo <= 600) {
                saldo = saldo + (saldo * 0.30);
                Console.WriteLine("Saldo médio " + saldo + " 30% do valor do crédito especial");
            }else{
                saldo = saldo + (saldo * 0.40);
                Console.WriteLine("Saldo médio " + saldo + " 40% do valor do crédito especial");
            }
            Console.ReadKey();
        }
    }
}
