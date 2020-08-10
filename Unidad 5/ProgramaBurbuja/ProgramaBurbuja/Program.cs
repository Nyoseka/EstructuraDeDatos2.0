using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBurbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5];
            int i, j, temp;
            //Capturar valores
            Console.WriteLine("Capture cinco números a ordenar: ");
            for(i=0;i<=4;i++)
            {
                Console.Write(i + 1+".- ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            //Ordenamiento mediante dos for anidados
            for(i=0; i <=4;i++)
            {
                for(j=i+1; j <5;j++)
                {
                    if (vector[j] < vector[i])
                    {
                        temp = vector[j];
                        vector[j] = vector[i];
                        vector[i] = temp;
                    }
                }
            }

            for (i = 0; i <= 4; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.ReadLine();
            //Ejemplo [0]=3, [1]=2, [2]=6, [3]=5, [4]=1
        }
    }
}
