using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaRadix
{
    class Program
    {
        static void Sort(int [] arr)
        {
            int i, j;
            int[] temp = new int[arr.Length];
            for(int shift=31; shift>-1;--shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; i++)
                {
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                    {
                        arr[i - j] = arr[i];
                    }
                    else
                    {
                        temp[j++] = arr[i];
                    }
                    Array.Copy(temp, 0, arr, arr.Length - j, j);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, -4, 11, 018, 22, 67, 51, 6 };
            Console.WriteLine("\nArreglo Original\n");
            foreach(var item in arr)
            {
                Console.Write(" " + item);
            }
            Sort(arr);
            Console.WriteLine("\nArreglo Ordenado\n");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine('\n');
            Console.ReadKey();
        }
    }
}