using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaExerc09
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, estadocivil;

            Console.WriteLine("Entre com seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Entre com seu estado civil\nC p/ Casado\nQ p/Desquitado\nS p/ Solteiro\nD p/ Divorciado\nV p/ Viúvo");
            estadocivil = Console.ReadLine();

            switch (estadocivil) {
                case "C":
                    Console.WriteLine(nome + " É Casado");
                break;
                case "Q":
                    Console.WriteLine(nome + " É Desquitado");
                break;
                case "S":
                    Console.WriteLine(nome + " É Solteiro");
                break;
                case "D":
                    Console.WriteLine(nome + " É Divorciado");
                break;
                case "V":
                    Console.WriteLine(nome + " É Viúvo");
                break;
                default:
                    Console.WriteLine("Estado civil invalido entre com as letras MAIUSCULA");
                break;
            }
            Console.ReadKey();
        }
    }
}
