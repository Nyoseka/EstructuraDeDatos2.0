using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBusquedaLineal
{
    class Program
    {
        public static int LinearSearch(ref int[] x, int valueToFind)
        {
            for(int i=0;i<x.Length;i++)
            {
                if(valueToFind==x[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public static void DisplayElements(ref int[] xArray,char status, string sortname)
        {
            if (status == 'a')
            {
                Console.WriteLine("Después de ordenar usando el algoritmo: " + sortname);
            }
            else
            {
                Console.WriteLine("Antes de ordenar");
                for(int i=0;i<=xArray.Length-1;i++)
                {
                    if ((i != 0) && (i % 10 == 0))
                    {
                        Console.Write('\n');
                        Console.Write(xArray[i] + " ");
                    }
                }
                Console.ReadLine();
            }
        }
        static void MixDataUp(ref int[]x,Random rdn)
        {
            for (int i = 0; i <=x.Length - 1; i++)
            {
                x[i] = (int)(rdn.NextDouble() * x.Length);
            }
        }
        static void Main(string[] args)
        {
            const int nItems = 20;
            Random rdn = new Random(nItems);
            int[] xdata = new int[nItems];
            MixDataUp(ref xdata, rdn);
            DisplayElements(ref xdata, 'b', "");
            Console.WriteLine("Utilizando el algoritmo de búsqueda lineal para ver el 4to elemento de la lista aleatoria");
            int location = LinearSearch(ref xdata, xdata[4]);
            if (location == -1)
            {
                Console.WriteLine("El elemento no fue encontrado en la lista");
            }
            else
            {
                Console.WriteLine("Encontrado en la ubicación= {0}", location);
            }
            location = LinearSearch(ref xdata, 19);
            if(location==-1)
            {
                Console.WriteLine("El valor 19 no fue encontrado en la lista");
            }
            else
            {
                Console.WriteLine("El valor 19 fue encontrado en la ubicación = {0}", location);
            }
            Console.WriteLine("\n\n");
        }
    }
}
