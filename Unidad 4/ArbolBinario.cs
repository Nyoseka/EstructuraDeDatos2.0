using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    //Clase Nodo
    public class Node
    {
        public int Data;
        public Node LeftChild;
        public Node RightChild;
        //Impresion de nodo
        public void printNode()
        {
            Console.Write(Data + " ");
        }
    }
    //Clase Arbol Binario
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        //Agregar nodos
        public void Add(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if(root==null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while(true)
                {
                    parent = current;
                    if(data<current.Data)
                    {
                        current = current.LeftChild;
                        if(current==null)
                        {
                            parent.LeftChild = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightChild;
                        if(current==null)
                        {
                            parent.RightChild = newNode;
                            break;
                        }
                    }
                }
            }
        }
        //Recorrido Inorden
        public void InOrder(Node ourRoot)
        {
            if(ourRoot!=null)
            {
                InOrder(ourRoot.LeftChild);
                ourRoot.printNode();
                InOrder(ourRoot.RightChild);
            }
        }
        //Recorrido PreOrden
        public void PreOrder(Node ourRoot)
        {
            if(ourRoot!=null)
            {
                ourRoot.printNode();
                PreOrder(ourRoot.LeftChild);
                PreOrder(ourRoot.RightChild);
            }
        }
        //Recorrido PostOrden
        public void PostOrder(Node ourRoot)
        {
            if(ourRoot!=null)
            {
                PreOrder(ourRoot.LeftChild);
                PreOrder(ourRoot.RightChild);
                ourRoot.printNode();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree1 = new BinarySearchTree();
            tree1.Add(50);
            tree1.Add(40);
            tree1.Add(60);
            tree1.Add(60);
            tree1.Add(45);
            tree1.Add(55);
            tree1.Add(65);
            Console.WriteLine("Recorrido Inorden: ");
            tree1.InOrder(tree1.root);
            Console.WriteLine("\nRecorrido PreOrden: ");
            tree1.PreOrder(tree1.root);
            Console.WriteLine("\nRecorrido Postorden: ");
            tree1.PostOrder(tree1.root);
            Console.ReadLine();
        }
    }
}
