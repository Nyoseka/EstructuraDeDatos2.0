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
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.Data)
                    {
                        current = current.LeftChild;
                        if (current == null)
                        {
                            parent.LeftChild = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightChild;
                        if (current == null)
                        {
                            parent.RightChild = newNode;
                            break;
                        }
                    }
                }
            }
        }
        public Node GetSuccesor(Node delNode)
        {
            Node succesorParent = delNode;
            Node succesor = delNode;
            Node current = delNode.RightChild;
            while (!(current == null))
            {
                succesorParent = current;
                succesor = current;
                current = current.LeftChild;
            }
            if (!(succesor == delNode.RightChild))
            {
                succesorParent.LeftChild = succesor.RightChild;
                succesor.RightChild = delNode.RightChild;
            }
            return succesor;
        }
        //Borrar nodos
        public bool Delete(int key)
        {
            Node current = root;
            Node parent = root;
            bool isLeftChild = true;
            while (current.Data != key)
            {
                parent = current;
                if (key < current.Data)
                {
                    isLeftChild = true;
                    current = current.RightChild;
                }
                else
                {
                    isLeftChild = false;
                    current = current.RightChild;
                    if (current == null)
                    {
                        return false;
                    }
                }
                if ((current.LeftChild == null) && (current.RightChild == null))
                {
                    if (current == null)
                    {
                        root = null;
                    }
                    else if (isLeftChild)
                    {
                        parent.LeftChild = null;
                    }
                    else
                    {
                        parent.RightChild = null;
                    }
                }
                else if (current.RightChild == null)
                {
                    if (current == root)
                    {
                        root = current.LeftChild;
                    }
                    else if (isLeftChild)
                    {
                        parent.LeftChild = current.LeftChild;
                    }
                    else
                    {
                        parent.RightChild = current.RightChild;
                    }
                }
                else if (current.LeftChild == null)
                {
                    if (current == null)
                    {
                        root = current.RightChild;
                    }
                    else if (isLeftChild)
                    {
                        parent.LeftChild = current.LeftChild;
                    }
                    else
                    {
                        parent.RightChild = current.RightChild;
                    }
                }
                else
                {
                    Node succesor = GetSuccesor(current);
                    if (current == root)
                    {
                        root = succesor;
                    }
                    else if (isLeftChild)
                    {
                        parent.LeftChild = succesor;
                    }
                    else
                    {
                        parent.RightChild = succesor;
                    }
                    succesor.LeftChild = current.LeftChild;
                }
            }
            return true;
        }
        //Recorrido Inorden
        public void InOrder(Node ourRoot)
        {
            if (ourRoot != null)
            {
                InOrder(ourRoot.LeftChild);
                ourRoot.printNode();
                InOrder(ourRoot.RightChild);
            }
        }
        //Recorrido PreOrden
        public void PreOrder(Node ourRoot)
        {
            if (ourRoot != null)
            {
                ourRoot.printNode();
                PreOrder(ourRoot.LeftChild);
                PreOrder(ourRoot.RightChild);
            }
        }
        //Recorrido PostOrden
        public void PostOrder(Node ourRoot)
        {
            if (ourRoot != null)
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
            tree1.Add(45);
            tree1.Add(55);
            tree1.Add(65);
            Console.WriteLine("Recorrido Inorden: ");
            tree1.InOrder(tree1.root);
            Console.WriteLine("\nRecorrido después de borrar");
            tree1.Delete(65);
            tree1.InOrder(tree1.root);
            Console.ReadLine();
        }
    }
}