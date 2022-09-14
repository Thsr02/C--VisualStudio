using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaExerc12
{
    internal class Program
    {
        /* 12. Fazer um programa para ler o nome e a data de nascimento( Dia, Mês e
ano) de uma pessoa e dizer qual a sua idade hoje.
*/
        static void Main(string[] args)
        {
            int diaAtt, mesAtt, anoAtt, diaNasc, mesNasc, anoNasc, idade;
            string nome;

            Console.WriteLine("Óla, Entre com seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Que dia estamos HOJE");
            diaAtt = int.Parse(Console.ReadLine());
            Console.WriteLine("Que Mes estamos HOJE");
            mesAtt = int.Parse(Console.ReadLine());
            Console.WriteLine("Que ano estamos HOJE");
            anoAtt = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora me diga o dia em que você NASCEU");
            diaNasc = int.Parse(Console.ReadLine());
            Console.WriteLine("O mes em que você NASCEU");
            mesNasc = int.Parse(Console.ReadLine());
            Console.WriteLine("O ano em que você NASCEU");
            anoNasc = int.Parse(Console.ReadLine());


                if(mesAtt >= mesNasc && diaAtt >= diaNasc)
            {
                idade = anoAtt - anoNasc;
            }else if(mesAtt >= mesNasc && diaAtt < diaNasc)
            {
                idade = anoAtt - anoNasc - 1;
            }
            else
            {
                idade = anoAtt - anoNasc -1;
            }
            Console.WriteLine(nome + " Você tem hoje " + idade + " anos");
            Console.ReadKey();
        }
    }
}
