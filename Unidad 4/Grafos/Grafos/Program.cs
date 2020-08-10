using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Program
    {
        //Agregar borde a un grafo no dirigido
        static void addEdge(LinkedList<int>[] adj, int u, int v)
        {
            adj[u].AddLast(v);
            adj[v].AddLast(u);
        }
        //Imprimir la lista
        static void printGraph(LinkedList<int>[] adj)
        {
            for(int i=0; i <adj.Length-1; i++)
            {
                Console.WriteLine("\nLista adyacente del vértice " + i);
                Console.WriteLine("Head");
                foreach(var item in adj[i])
                {
                    Console.Write(" -> " + item);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Crear un grafo con 5 vértices
            int v = 5;
            LinkedList<int>[] adj = new LinkedList<int>[v];
            for(int i=0; i <v; i++)
            {
                adj[i] = new LinkedList<int>();
            }
            //Agregar nodos
            addEdge(adj, 0, 1);
            addEdge(adj, 0, 4);
            addEdge(adj, 1, 2);
            addEdge(adj, 1, 3);
            addEdge(adj, 2, 3);
            addEdge(adj, 3, 4);
            printGraph(adj);
            Console.ReadKey();
        }
    }
}
