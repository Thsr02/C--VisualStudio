using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            Console.WriteLine("Entre com o Valor de A");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o Valor de B");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o Valor de C");
            C = double.Parse(Console.ReadLine());
            if (A < B + C && B < A + C && C < B + C)
            {
                double triangulo = verificador(A, B, C);

                switch (triangulo)
                {
                    case 1:
                        Console.WriteLine("Triângulo do Tipo equilátero");
                        break;
                    case 2:
                        Console.WriteLine("Triângulo do Tipo  isósceles");
                        break;
                    case 3:
                        Console.WriteLine("Triângulo do Tipo escaleno");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Não é Possivel Formar um triângulo");
            }
            Console.ReadKey();
        }
        static double verificador(double m1, double m2, double m3)
        {
            if(m1 == m2 && m2 == m3) {
                double triangulo = 1;
                return triangulo;
            }else if(m1 == m2 || m1 == m3 || m2 == m3){
                double triangulo = 2;
                return triangulo;
            }else{
                double triangulo = 3;
                return triangulo;
            }
            
            
        }
    }
}
