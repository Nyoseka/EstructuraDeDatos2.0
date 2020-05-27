using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNumerosNaturalesRecursiva
{
    class Program
    {
        public static int SumaNumerosNaturales(int n)
        {
            int suma = n;
            if(n>0)
            {
                suma = suma + SumaNumerosNaturales(n-1);
                return suma;
            }
            else
            {
                return suma;
            }
        }
        static void Main(string[] args)
        {
            int num;
            int suma;
            Console.Write("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());
            suma = SumaNumerosNaturales(num);
            Console.WriteLine("La suma de los números del 1 al {0} es {1}",num,suma);
            Console.ReadKey();
        }
    }
}
