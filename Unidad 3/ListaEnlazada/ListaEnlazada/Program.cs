using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazada
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int i) //Constructor
            {
                data = i;
                next = null;
            }
            public void Print()
            {
                Console.Write("| " + data + " | ->");
                if (next != null)
                {
                    next.Print();
                }
                Console.ReadLine();
            }
            public void addToEnd(int data)
            {
                if (next == null)
                {
                    next = new Node(data);
                }
                else
                {
                    next.addToEnd(data);
                }
            }
        }
        static void Main(string[] args)
        {
            Node myNode = new Node(7);
            myNode.next = new Node(5);
            myNode.next.next = new Node(1);
            myNode.next.next.next = new Node(8);
            myNode.addToEnd(99);
            myNode.Print();
        }
    }
}
