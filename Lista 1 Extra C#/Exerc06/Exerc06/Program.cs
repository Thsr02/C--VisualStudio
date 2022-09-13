using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc06
{
    internal class Program
    {
//  Exercício 6: Calcule a média aritmética de 3 notas de um aluno e mostre o valor da média.
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;

            Console.WriteLine("Entre com a primeira nota");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a segunda nota");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a terceira nota");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.Write("Media do aluno é:" + media);
            Console.ReadKey();
        }
    }
}
