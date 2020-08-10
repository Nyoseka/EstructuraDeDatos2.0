using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[7];
            int menor;
            int mayor;

            for (int c = 0; c <= 6; c++)
            {
                Console.Write("Escribe un número: ");
                arreglo[c] = int.Parse(Console.ReadLine());
            }
            Menor();
            Mayor();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("ARREGLO:" + '\n');
            for (int c = 0; c < 6; c++)
            {
                Console.WriteLine("{0}", arreglo[c]);
            }
            Console.WriteLine("Número menor: {0}" + '\n' + "Número menor: {1}",menor,mayor);
            Console.Write("Presione cualquier tecla para salir");
            Console.ReadKey();

            void Menor()
            {
                menor = arreglo[0];
                for(int i=0; i <=6; i++)
                {
                    if(menor>arreglo[i])
                    {
                        menor = arreglo[i];
                    }
                }
            }
            void Mayor()
            {
                mayor = arreglo[0];
                for(int i=0; i <6; i++)
                {
                    if(menor <arreglo[i])
                    {
                        mayor = arreglo[i];
                    }
                }
            }
        }
    }
}
