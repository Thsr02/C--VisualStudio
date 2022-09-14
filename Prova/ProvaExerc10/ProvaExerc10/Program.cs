using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProvaExerc10
{
    internal class Program
    {
 /*      10. Criar um programa que leia um número inteiro entre 1 e 7 e outro entre 1 e
12, e escreva o dia da semana e o mês correspondente.Caso o usuário digite
um número fora do intervalo, deverá aparecer uma mensagem informando que
não existe dia da semana ou o mês com esse número não existe. */
        static void Main(string[] args)
        {
            int dia, mes;
            string mostrarDia = "", mostrarMes= "";

            Console.WriteLine("Que dia da semana é: entre com N: de 1 a 7");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Em que mês estamos? Entre com N: de 1 a 12");
            mes = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    mostrarDia = "Domingo";
                break;

                case 2:
                    mostrarDia = "Segunda-Feira";
                break;

                case 3:
                    mostrarDia = "Terça-Feira";
                break;

                case 4:
                    mostrarDia = "Quarta-Feira";
                break;

                case 5:
                    mostrarDia = "Quinta-Feira";
                break;

                case 6:
                    mostrarDia = "Sexta-Feira";
                break;

                case 7:
                    mostrarDia = "Sabado";
                break;
                
                default:
                    Console.WriteLine("Número digitado é invalido entre com 1 a 7");
                break;
            }

            switch (mes)
            {
                case 1:
                    mostrarMes = "Janeiro";
                    break;

                case 2:
                    mostrarMes = "Fevereiro";
                    break;

                case 3:
                    mostrarMes = "Março";
                    break;

                case 4:
                    mostrarMes = "Abril";
                    break;

                case 5:
                    mostrarMes = "Maio";
                    break;

                case 6:
                    mostrarMes = "Junho";
                    break;

                case 7:
                    mostrarMes = "Julho";
                    break;
                case 8:
                    mostrarMes = "Agosto";
                    break;

                case 9:
                    mostrarMes = "Setembro";
                    break;

                case 10:
                    mostrarMes = "Outubro";
                    break;

                case 11:
                    mostrarMes = "Novembro";
                    break;

                case 12:
                    mostrarMes = "Dezembro";
                    break;

                default:
                    Console.WriteLine("Número digitado é invalido entre com 1 a 12");
                    break;
            }

            Console.WriteLine(dia +" "+ mostrarDia + " " + mes + " " + mostrarMes);
            Console.ReadKey();
        }

    }
}
