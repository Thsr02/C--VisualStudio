using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaExerc07
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novosalario, codCargo, dif;
            Console.WriteLine("Entre com o código do seu cargo\n101 = Gerente, " +
                "102 = Enegenheiro, 103 = Técnico");
            codCargo = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu salario atual");
            salario = double.Parse(Console.ReadLine());

            switch (codCargo) {
                case 101: novosalario = salario + (salario * 0.10);
                    dif = salario * 0.1;
                    Console.WriteLine("Seu novo salario sera de : R$" + novosalario + " aumento de: R$" + dif);
                break;
                case 102:
                    novosalario = salario + (salario * 0.20);
                    dif = salario * 0.2;
                    Console.WriteLine("Seu novo salario sera de : R$" + novosalario + " aumento de: R$" + dif);
                    break;
                case 103:
                    novosalario = salario + (salario * 0.30);
                    dif = salario * 0.3;
                    Console.WriteLine("Seu novo salario sera de : R$" + novosalario + " aumento de: R$" + dif);
                    break;
                default:
                    Console.WriteLine("Cargo Invalido Apenas 101 102 e 103");
                    break;

            }
            Console.ReadKey();
        }
    }
}
