using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorPedido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op, numMesa, pedido;
            string exibirPedido;
            Console.WriteLine("Deseja iniciar o pedido\nDigite\n1 - Para Sim\n0 - Para Sair");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Entre com número da mesa");
                numMesa = int.Parse(Console.ReadLine());
                getPedido(numMesa);
            }
            
        }
        static void getPedido(int numMesa)
        {
            string pedido;
            Console.WriteLine("Codigo\n  1 - X SALADA R$15\n  2 - X BACON R$18\n  3 - X BURGUER R$12\n  4 - HOTDOG R$10");
             int codLanche = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos lanches vão ser?");
            int qtd = int.Parse(Console.ReadLine());
            switch (codLanche)
                
            {
                case 1:
                    break;
            }

            
        }
    }
}
