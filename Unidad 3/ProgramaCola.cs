using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Nodo
    {
        //Variable donde se almacena el dato
        private int dato;
        //Apuntador al nodo siguiente
        public Nodo siguiente = null;
        //Propiedades
        public int Dato
        {
            get => dato;
            set => dato = value;
        }
        internal Nodo Siguiente
        {
            get => siguiente;
            set => siguiente = value;
        }
        //Impresión mediante sobrecarga
        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }

    //Imprementación mediante lista
    class CQueue
    {
        //Encabezado de la cola
        Nodo ancla;
        //Variable de referencia
        Nodo trabajo;
        //Constructor
        public CQueue()
        {
            ancla = new Nodo();
            ancla.Siguiente = null;
        }
        //Recorrido de la cola
        public void Transversa()
        {
            //Trabajo al inicio
            trabajo = ancla;
            while(trabajo.Siguiente!=null)
            {
                trabajo = trabajo.Siguiente;
                //Se obtiene el dato
                int d = trabajo.Dato;
                Console.Write("<-{0}", d);
            }
            Console.WriteLine();
        }
        public void Enqueue(int pDato)
        {
            //Usar trabajo como referencia
            trabajo = ancla;
            //Recorrer la lista hasta el final
            while(trabajo.Siguiente!=null)
            {
                trabajo = trabajo.Siguiente;
            }
            //Crear el nuevo nodo
            Nodo temp = new Nodo();
            //Inserción del dato
            temp.Dato = pDato;
            temp.Siguiente = null;
            trabajo.siguiente = temp;
        }
        public int Dequeue()
        {
            int valor = 0;
            //Llevar a el trabajo solo si hay elementos en la cola
            if(ancla.Siguiente!=null)
            {
                //Obtener dato
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
                //Sacar el dato de la pila
                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }
            return valor;
        }
        
        public int Peek()
        {
            int valor = 0;
            //El trabajo solo se hace si hay elementos
            if(ancla.Siguiente!=null)
            {
                //Obtener el dato
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
            }
            return valor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CQueue cola = new CQueue();
            cola.Enqueue(5);
            cola.Enqueue(3);
            cola.Enqueue(7);
            cola.Enqueue(1);
            cola.Transversa();
            int valor = cola.Dequeue();
            Console.WriteLine("El valor adquirido {0}", valor);
            cola.Transversa();
            cola.Enqueue(8);
            cola.Transversa();
            Console.WriteLine("El valor observado es {0}", cola.Peek());
            cola.Transversa();
            Console.ReadKey();
        }
    }
}