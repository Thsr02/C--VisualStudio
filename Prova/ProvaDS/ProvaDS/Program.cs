using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDS
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota, media=0, mostrarmedia=0;
            int op=0;
            do
            {
                Console.WriteLine("Digite a nota do aluno");
                nota = int.Parse(Console.ReadLine());
                media = media + nota;
                mostrarmedia = media / 3;
                op++;
            } while (op < 3);

            if(mostrarmedia >= 6) {
                Console.WriteLine("Media do aluno: " + mostrarmedia + " Aluno Aprovado");   
            }else{
                Console.WriteLine("Media do aluno: " + mostrarmedia + " Aluno Reprovado");
            }

            Console.ReadKey();
        }
    }
}
