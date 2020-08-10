using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaQuicksort
{
    class Program
    {
        class Quicksort
        {
            public void Quick_sort(int[]arr, int left, int right)
            {
                if(left<right)
                {
                    int pivot = Partition(arr, left, right);
                    if(pivot>1)
                    {
                        Quick_sort(arr, left, right);
                    }
                    if(pivot+1<right)
                    {
                        Quick_sort(arr, pivot + 1, right);
                    }
                }
            }

            public int Partition(int[]arr, int left,int right)
            {
                int pivot = arr[left];
                while(true)
                {
                    while(arr[left]<pivot)
                    {
                        left++;
                    }
                    while(arr[right]>pivot)
                    {
                        right--;
                    }
                    if(left <right)
                    {
                        if(arr[left]==arr[right])
                        {
                            return right;
                        }
                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                    }
                    else
                    {
                        return right;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Quicksort qs = new Quicksort();
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("Arreglo original:");
            foreach(var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            qs.Quick_sort(arr, 0, arr.Length - 1);
            Console.WriteLine();
            Console.WriteLine("Arreglo ordenado: ");
            foreach(var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
