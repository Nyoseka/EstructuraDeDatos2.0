using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDivisionRecursiva
{
    class Program
    {
        public static int CuentaDivisiones(double num)
        {
            int count = 0;
            if(num>0 && num%2==0)
            {
                count++;
                num /= 2;
                return count += CuentaDivisiones(num);
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.Write("Captura número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            int count = CuentaDivisiones(numero);
            Console.WriteLine($"Total de divisiones: {count}");
            Console.ReadKey();
        }
    }
}
