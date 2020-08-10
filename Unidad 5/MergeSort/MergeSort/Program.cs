﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        private static List<int> MergeSort(List<int> unsorted)
        {
            if(unsorted.Count <=1)
            {
                return unsorted;
            }
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }
            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left,List<int>right)
        {
            List<int> result = new List<int>();
            while(left.Count>0||right.Count>0)
            {
                if(left.Count > 0 && right.Count > 0)
                {
                    if(left.First()<=right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int>();
            List<int> sorted = new List<int>();
            Random random = new Random();
            Console.WriteLine("Elementos Originales del Arreglo");
            for(int i=0;i <0;i++)
            {
                unsorted.Add(random.Next(0, 100));
                Console.Write(unsorted[i]+" ");
            }
            Console.WriteLine();
            sorted = MergeSort(unsorted);
            Console.WriteLine("Elementos ordenados del arreglo: ");
            foreach(int x in unsorted)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine('\n');
            Console.ReadKey();
        }
    }
}
