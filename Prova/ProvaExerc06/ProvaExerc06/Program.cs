using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaExerc06
{
    class Program
    {
        static void Main(string[] args)
        {
            double cod,total,qtd, preco;

            Console.WriteLine("Entre com o código do produto");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com quantidade de produto comprado");
            qtd = int.Parse(Console.ReadLine());

            switch (cod) {
                case 1001: preco = 5.32;
                    total = qtd * preco;
                    Console.WriteLine("Valor total a pagar " + total);
                break;
                case 1324:
                    preco = 6.45;
                    total = qtd * preco;
                    Console.WriteLine("Valor total a pagar " + total);
                break;
                case 6548:
                    preco = 2.37;
                    total = qtd * preco;
                    Console.WriteLine("Valor total a pagar " + total);
                break;
                case 0987:
                    preco = 5.32;
                    total = qtd * preco;
                    Console.WriteLine("Valor total a pagar " + total);
                break;
                case 7623:
                    preco = 6.45;
                    total = qtd * preco;
                    Console.WriteLine("Valor total a pagar " + total);
                break;
                default:
                    Console.WriteLine("Codigo Invalido entre apenas com os códigos \n 1001, 1324, 6548, 0987, 7623");
                break;
            }
            Console.ReadKey();
        }
    }
}
