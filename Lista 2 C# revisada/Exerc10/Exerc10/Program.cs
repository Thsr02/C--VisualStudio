using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc10
{
    internal class Program
    {

  /*      Exercício 10: Faça um programa que leia as variáveis C e N, respectivamente código e
número de horas trabalhadas de um operário.Calcule o salário sabendo-se que ele ganha
R$ 10,00 por hora.Quando o número de horas exceder a 50, calcule o excesso de
pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora
excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o
salário excedente.O programa só deve parar de rodar quando o usuário responder "S" na
seguinte pergunta, "Deseja encerrar o programa?". */ 
        static void Main(string[] args)
        {
            int c=0, n, e, op=0;
            string controle = "";
            double salario;
            do
            {
                Console.WriteLine("Entre com o número de horas trabalhadas");
                n = int.Parse(Console.ReadLine());
                if(n > 50) {
                    e = (n - 50);
                    c = e * 20;
                    salario = (n * 10);
                }else{
                    salario = n * 10;
                    e = 0;
                }
                Console.WriteLine("Total de horas trabalhadas: " + n + "\n Horas Excedente: " + e + "\n Salário a Receber: R$ " + salario + " + R$"+c+"(Horas Excedentes)");
                Console.WriteLine("Deseja encerrar o programa? S ou N");
                controle = Console.ReadLine();
                    if(controle == "S") {
                        op = 1;    
                    }else{
                        op = 0;
                        c = 0;
                        n = 0;
                        e = 0;
                    }
            } while (op == 0);
            
        }
    }
}
