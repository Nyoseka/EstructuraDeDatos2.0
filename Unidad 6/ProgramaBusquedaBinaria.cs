using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBusquedaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string imput = Console.ReadLine();
                int value_of_imput = int.Parse(imput);
                int min = 0;
                int max = 20;
                int[] binary_search = new int[value_of_imput];
                Random randNum = new Random();
                for (int i = 0; i < value_of_imput; i++)
                {
                    binary_search[i] = randNum.Next(min, max);
                    Console.Write(binary_search[i] + " ");
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Ahora ingrese el número entero de esta matriz para realziar la busqueda binaria: ");
                string get_search = Console.ReadLine();
                int value_of_get_search = int.Parse(get_search);
                Array.Sort(binary_search);
                Console.WriteLine("");
                Console.WriteLine("");
                for (int i = 0; i < value_of_imput; i++)
                {
                    Console.Write(binary_search[i] + " ");
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Ahora busquemos su valor entero...");
                int get_middle = 0;
                int low = 0;
                int high = (binary_search.Length) - 1;
                int mid = (low + high) / 2;
                int track_middle = 0;
                while (low <= high)
                {
                    mid = (low + high) / 2;
                    get_middle = binary_search[mid];
                    if (get_middle == value_of_get_search)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Encontró su número entero: " + value_of_get_search);
                        break;
                    }
                    if (get_middle > value_of_get_search && get_middle != track_middle)
                    {
                        high = mid + 1;
                        Console.WriteLine("");
                        Console.WriteLine("Encontré este entero: " + get_middle + " Pero eso no es todo");
                        track_middle = get_middle;
                    }
                    else
                    {
                        low = mid - 1;
                        Console.WriteLine("Encontré este entero: " + get_middle + " Pero eso no es todo");
                    }
                }
                if (low > high)
                {
                    Console.WriteLine("");
                    Console.WriteLine("No se puede encontrar este valor, intentelo de nuevo");
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Ingrese un número e intente de nuevo");
                Console.ReadKey(true);
            }
            
        }
            
    }
}