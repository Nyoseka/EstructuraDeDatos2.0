using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoblementeEnlazada
{
    class Program
    {
        //Creación de la clase jugador
        class Player
        {
            int number;
            public int Number
            {
                get
                {
                    return number;
                }
            }
            public Player(int i) //Constructor
            {
                number = i;
            }
        }

        //Creación de la clase Nodo
        class Node
        {
            public Player data;
            public Node next; //Apuntador al nodo siguiente
            public Node prev; //Apuntador al nodo anterior
            public Node(Player p) //Constructor
            {
                data = p;
            }
        }

        //Creación de la clase Lista
        class List
        {
            Node header; //Nodo cabeza
            Node footer; //Nodo cola

            //Agrega un nodo al principio
            public void AddFirst(Player p)
            {
                if(header==null)
                {
                    header = footer = new Node(p);
                }
                else
                {
                    Node temp = header;
                    header = new Node(p);
                    temp.prev = header;
                    header.next = temp;
                }
            }

            //Agrega un nodo al final de la lista
            public void AddLast(Player p)
            {
                if(header==null)
                {
                    AddFirst(p);
                }
                else
                {
                    Node temp = footer;
                    footer = new Node(p);
                    temp.next = footer;
                    footer.prev = temp;
                }
            }

            //Agrega nodo al inicio o en medio
            public void AddBeforePlayer(Player p)
            {
                if(header==null)
                {
                    AddFirst(p);
                }
                else
                {
                    Node temp = header;
                    while(temp.next!=null&&p.Number>temp.data.Number)
                    {
                        temp = temp.next;
                    }
                    if (temp.prev == null && p.Number <= temp.data.Number)
                    {
                        AddFirst(p);
                    }
                    else if (temp.next == null && p.Number >= temp.data.Number)
                    {
                        AddLast(p);
                    }
                    else
                    {
                        Node insert = new Node(p);
                        insert.prev = temp.prev;
                        insert.next = temp;
                        temp.prev = insert;
                        temp.prev.next = insert;
                    }
                }
            }

            //Impresión normal (Principio al final)
            public void Print()
            {
                if(header!=null)
                {
                    Node temp = header;
                    while(temp!=null)
                    {
                        Console.WriteLine("Número de Jugador: {0}", temp.data.Number);
                        temp = temp.next;
                    }
                }
            }

            //Impresión de reversa (Final al principio)
            public void PrintRev()
            {
                if(footer!=null)
                {
                    Node temp = footer;
                    while(temp!=null)
                    {
                        Console.WriteLine("Número de Jugador: {0}", temp.data.Number);
                        temp = temp.prev;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Creación de objetos
            Player p1 = new Player(2);
            Player p2 = new Player(3);
            Player p3 = new Player(5);
            Player p4 = new Player(10);
            Player p5 = new Player(15);
            Player p6 = new Player(4);
            Player p7 = new Player(6);
            //Creación de la lista
            List team1 = new List();
            //Agregar nodos al principio
            team1.AddFirst(p3);
            team1.AddFirst(p2);
            team1.AddFirst(p1);
            //Agregar nodos al final
            team1.AddLast(p4);
            team1.AddLast(p5);
            team1.AddBeforePlayer(p6);
            team1.AddBeforePlayer(new Player(0));
            team1.AddBeforePlayer(new Player(1));
            team1.AddBeforePlayer(new Player(2));
            team1.AddBeforePlayer(new Player(3));
            team1.AddBeforePlayer(new Player(4));
            team1.AddBeforePlayer(new Player(5));
            team1.AddBeforePlayer(new Player(6));
            team1.AddBeforePlayer(new Player(14));
            team1.AddBeforePlayer(new Player(15));
            team1.AddBeforePlayer(new Player(16));
            //Impresión normal
            Console.WriteLine("Lista:");
            team1.Print();
            //Impresión de reversa
            Console.WriteLine("Lista de Reversa:");
            team1.PrintRev();
            Console.ReadLine();
        }
    }
}