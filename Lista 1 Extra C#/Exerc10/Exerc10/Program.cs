using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc10
{
    internal class Program
    {
        //     Exercício 10: Ler os dados de uma conta corrente: o nome do correntista, o número da
        //conta, o saldo atual, valor total de cheques a debitar, o total de dinheiro a creditar e o
        //limite de crédito.Imprimir o nome do correntista, o número da conta, e o saldo disponível.
        //saldo disponível = (saldo atual + total de dinheiro a creditar + limite de crédito) – valor
        //total de cheques a debitar.
        static void Main(string[] args)
        {
            string nome;
            int numConta, saldoAtual, debitos, credito, saldoTotal, limitecredito;

            Console.WriteLine("Entre com o nome do correntista");
            nome = Console.ReadLine(); 
            Console.WriteLine("Digite o número da conta");
            numConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o saldo atual de sua conta corrente");
            saldoAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor em cheques a ser debitado da sua conta corrente");
            debitos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o saldo a creditar");
            credito = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu limite de credito junto a esta instituição financeira");
            limitecredito = int.Parse(Console.ReadLine());
            saldoTotal = (saldoAtual + credito + limitecredito) - debitos;

            Console.WriteLine("Correntista " + nome + "\nConta: " + numConta + "\nSeu Saldo disponivel é: R$" + saldoTotal);
            Console.ReadKey();

        }
    }
}
