using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprimirNumerosParesImpares
{
    class Program
    {
        public static int ParImpar(int val, int n)
        {
            if(val>n)
            {
                return val;
            }
            else
            {
                Console.Write(val + " ");
                return ParImpar(val + 2, n);
            }
        }
        static void Main(string[] args)
        {
            int rango;
            Console.Write("Indique el rango de números que desea imprimir: ");
            rango = int.Parse(Console.ReadLine());
            Console.WriteLine("NÚMEROS PARES");
            ParImpar(2, rango);
            Console.WriteLine('\n');
            Console.WriteLine("NÚMEROS IMPARES");
            ParImpar(1, rango);
            Console.ReadKey();
        }
    }
}
