using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota, nota2;
            double media;
            Console.WriteLine("Entre Com o nome do aluno ");
            nome = Console.ReadLine();

            lernota();
            nota = int.Parse(Console.ReadLine());

            lernota();
            nota2 = int.Parse(Console.ReadLine());

            media = calcularMedia(nota, nota2);
            if(media >= 7)
            {
                Console.WriteLine("Aluno {0} Aprovado, com a media {1}", nome, media);
            }
            else
            {
                Console.Write("Aluno {0} Reprovado, com a media {1}", nome, media);
            }
            Console.ReadKey();
        }
        static void lernota()
        {
            Console.WriteLine("Entre com as notas do aluno: ");

        }

        static double calcularMedia(double n, double n2)
        {
            double m= (n + n2) / 2;
            return m;
        }
    }
}
