using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modifique el ejemplo de listas de forma que permita al usuario agregar el mismo los nombres que desea y tambien buscar el indice de cualquier persona dentro de la lista. Además ordene en orden alfabetico los elementos de la lista (Por medio de una función) y muestrelos en pantalla
            List<string> lista = new List<string>();
            string nombre;
            int c;
            /*lista.Add("Carlos");
            lista.Add("Ana");
            lista.Add("Luis");
            lista.Add("Juan");
            lista.Add("Oscar");*/
            do
            {
                Console.Write("Ingrese el nombre que desee agregar: ");
                nombre = Console.ReadLine();
                lista.Add(nombre);
                Console.WriteLine('\n' + "¿Desea agregar otro nombre?");
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine('\n');
            }
            while (c == 1);
            lista.Sort();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine('\n' + "   -------------   " + '\n');
            Console.WriteLine("Lista de nombres: ");
            foreach (string var in lista)
            {
                Console.WriteLine(var);
            }
            Console.WriteLine('\n' + "   -------------   " + '\n');
            Console.WriteLine("Indique el nombre que desee buscar: ");
            string key;
            key = Console.ReadLine();
            bool resp = lista.Contains(key);
            if (resp == true)
            {
                Console.WriteLine("El elemento {0} está dentro de la lista, se encuentra en el índice {1}", key, lista.IndexOf(key));
            }
            else
            {
                Console.WriteLine("El elemento no está en la lista");
            }
            Console.ReadKey();
        }
    }
}