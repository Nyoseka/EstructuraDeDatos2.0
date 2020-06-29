using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    class Program
    {
        //Clase nodo, es donde iran los datos
        public class StackNode
        {
            public int value;
            public StackNode(int value)
            {
                this.value = value;
            }
        }

        //Clase pila
        public class Stack
        {
            //Constructor
            List<StackNode> stackArray;
            public Stack()
            {
                stackArray = new List<StackNode>();
            }

            //Imprimir los elementos de la pila
            public void PrintStackStatus()
            {
                Console.WriteLine("El estatus actual de la pila es: ");
                foreach(StackNode x in stackArray)
                {
                    Console.Write("{0}",x.value);
                }
                Console.WriteLine();
            }

            //Eliminar elementos de la pila
            public void Pop()
            {
                if(stackArray.Count==0)
                {
                    Console.WriteLine("La pila se encuentra vacia");
                    Console.ReadLine();
                    return;
                }
                stackArray.RemoveAt(stackArray.Count - 1);
                PrintStackStatus();
                Console.ReadLine();
            }

            //Agrega elementos a la pila
            public void Push(StackNode node)
            {
                if(node==null)
                {
                    Console.ReadLine();
                    return;
                }
                else
                {
                    stackArray.Add(node);
                    PrintStackStatus();
                    Console.ReadLine();
                }
            }
        }
        static void Main(string[] args)
        {
            //Creacion de la pila
            Stack stack = new Stack();
            //Creacion de nodos
            StackNode sn1 = new StackNode(5);
            StackNode sn2 = new StackNode(4);
            StackNode sn3 = new StackNode(9);
            StackNode sn4 = new StackNode(13);
            StackNode sn5 = new StackNode(7);
            StackNode sn6 = new StackNode(3);
            //Inserción de nodos
            stack.Push(sn1);
            stack.Push(sn2);
            stack.Push(sn3);
        }
    }
}
