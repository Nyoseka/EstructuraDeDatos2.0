using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos2
{
    class cVertice
    {
        public string nombre;
        public cVertice()
        {

        }
        public cVertice(string Nombre)
        {
            nombre = Nombre;
        }
        public override string ToString()
        {
            return nombre;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                return nombre.Equals(obj.ToString());
            }
        }
    }

    class cLista
    {
        //Atributos
        private cVertice aElemento;
        private cLista aSublista;
        private int aPeso;

        //Constructores
        public cLista()
        {
            aElemento = null;
            aSublista = null;
            aPeso = 0;
        }
        public cLista(cLista pLista)
        {
            if (pLista != null)
            {
                aElemento = pLista.aElemento;
                aSublista = pLista.aSublista;
                aPeso = pLista.aPeso;
            }
        }
        public cLista(cVertice pElemento, cLista pSublista, int pPeso)
        {
            aElemento = pElemento;
            aSublista = pSublista;
            aPeso = pPeso;
        }
        //Propiedades
        public cVertice Elemento
        {
            get
            {
                return aElemento;
            }
            set
            {
                aElemento = value;
            }
        }
        public cLista Sublista
        {
            get
            {
                return aSublista;
            }
            set
            {
                aSublista = value;
            }
        }
        public int Peso
        {
            get
            {
                return aPeso;
            }
            set
            {
                aPeso = value;
            }
        }

        //Metodos
        public bool EsVacia()
        {
            return aElemento == null;
        }
        public void Agregar(cVertice pElemento, int pPeso)
        {
            if (pElemento != null)
            {
                if (aElemento == null)
                {
                    aElemento = new cVertice(pElemento.nombre);
                    aPeso = pPeso;
                    aSublista = new cLista();
                }
                else
                {
                    if (!ExisteElemento(pElemento))
                    {
                        aSublista.Agregar(pElemento, pPeso);
                    }
                }
            }
        }
        public void Eliminar(cVertice pElemento)
        {
            if (pElemento != null)
            {
                if (aElemento.Equals(pElemento))
                {
                    aElemento = aSublista.Elemento;
                    aSublista = aSublista.Sublista;
                }
                else
                {
                    aSublista.Eliminar(pElemento);
                }
            }
        }
        public int NroElementos()
        {
            if (aElemento != null)
            {
                return 1 + aSublista.NroElementos();
            }
            else
            {
                return 0;
            }
        }
        public object IesimoElemento(int posicion)
        {
            if ((posicion > 0) && (posicion <= NroElementos()))
            {
                if (posicion == 1)
                {
                    return aElemento;
                }
                else
                {
                    return aSublista.IesimoElemento(posicion - 1);
                }
            }
            else
            {
                return 0;
            }
        }

        public int IesimoElementoPeso(int posicion)
        {
            if ((posicion > 0) && (posicion <= NroElementos()))
            {
                if (posicion == 1)
                {
                    return aPeso;
                }
                else
                {
                    return aSublista.IesimoElementoPeso(posicion - 1);
                }
            }
            else
            {
                return 0;
            }
        }
        public bool ExisteElemento(cVertice pElemento)
        {
            if ((aElemento != null) && (pElemento != null))
            {
                return (aElemento.Equals(pElemento)) || (aSublista.ExisteElemento(pElemento));
            }
            else
            {
                return false;
            }
        }
        public int PosicionElemento(cVertice pElemento)
        {
            if ((aElemento != null) || (ExisteElemento(pElemento)))
            {
                if (aElemento.Equals(pElemento))
                {
                    return 1;
                }
                else
                {
                    return 1 + aSublista.PosicionElemento(pElemento);
                }
            }
            else
            {
                return 0;
            }
        }
        public void Mostrar()
        {
            if (aElemento != null)
            {
                Console.Write(aElemento.nombre + ":");
                aSublista.Mostrar1();
            }
        }
        public void Mostrar1()
        {
            if (aElemento != null)
            {
                Console.Write(aElemento.nombre + " " + aPeso);
                aSublista.Mostrar();
            }
        }
    }

    class cGrafo
    {
        //Atributos
        protected cVertice aVertice;
        protected cLista aLista;
        protected cGrafo aSiguiente;

        //Constructor
        public cGrafo()
        {
            aVertice = null;
            aLista = null;
            aSiguiente = null;
        }
        public cGrafo(cVertice pVertice, cLista pLista, cGrafo pSiguiente)
        {
            aVertice = pVertice;
            aLista = pLista;
            aSiguiente = pSiguiente;
        }
        //Atributos
        public cVertice Vertice
        {
            get
            {
                return aVertice;
            }
            set
            {
                aVertice = value;
            }
        }
        public cLista Lista
        {
            get
            {
                return aLista;
            }
            set
            {
                aLista = value;
            }
        }
        public cGrafo Siguiente
        {
            get
            {
                return aSiguiente;
            }
            set
            {
                aSiguiente = value;
            }
        }
        //Operaciones básicas
        public bool EstaVacio()
        {
            return (aVertice == null);
        }
        public int NumeroVertices()
        {
            if (aVertice == null)
            {
                return 0;
            }
            else
            {
                return 1 + aSiguiente.NumeroVertices();
            }
        }
        public bool ExisteVertice(cVertice vertice)
        {
            if ((aVertice == null) || (vertice == null))
            {
                return false;
            }
            else
            {
                return aSiguiente.ExisteVertice(vertice);
            }
        }

        public void AgregarVertice(cVertice vertice)
        {
            if ((vertice != null) && (!ExisteVertice(vertice)))
            {
                if (aVertice != null)
                {
                    if (vertice.nombre.CompareTo(aVertice.nombre) < 0)
                    {
                        cGrafo aux = new cGrafo(aVertice, aLista, aSiguiente);
                        aVertice = new cVertice(vertice.nombre);
                        aSiguiente = aux;
                    }
                    else //Agregar
                    {
                        aSiguiente.AgregarVertice(vertice);
                    }
                }
                else
                {
                    aVertice = new cVertice(vertice.nombre);
                    aLista = new cLista();
                    aSiguiente = new cGrafo();
                }
            }
        }
        public void AgregarArco(cVertice pVerticeOrigen, cVertice pVerticeDestino, int pdistancia)
        {
            if (ExisteVertice(pVerticeOrigen) && (ExisteVertice(pVerticeDestino)))
            {
                AgregarArco(pVerticeOrigen, pVerticeDestino, pdistancia);
            }
            else
            {
                Console.WriteLine("ERROR. No se pudo agregar arco");
            }
        }
        private void agregarArco(cVertice pVerticeOrigen, cVertice pVerticeDestino, int pdistancia)
        {
            if (ExisteVertice(pVerticeOrigen))
            {
                if (aVertice.Equals(pVerticeOrigen))
                {
                    //Agregar Arco
                    if (!aLista.ExisteElemento(pVerticeDestino))
                    {
                        aLista.Agregar(pVerticeDestino, pdistancia);
                    }
                }
                else if (aSiguiente != null)
                {
                    aSiguiente.agregarArco(pVerticeOrigen, pVerticeDestino, pdistancia);
                }
            }
        }
        public void MostrarVertices()
        {
            if (aVertice != null)
            {
                Console.WriteLine(aVertice.nombre);
                aSiguiente.MostrarVertices();
            }
        }
        public void MostrarGrafo()
        {
            if(aVertice!=null)
            {
                for(int i=1;i<=aLista.NroElementos();i++)
                {
                    Console.WriteLine(aVertice.nombre + "==> " + aLista.IesimoElemento(i) + "Con peso==> (" + aLista.IesimoElementoPeso(i) + " )");
                    aSiguiente.MostrarGrafo();
                }
            }
        }
    }
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Crear Grafo");
            Console.WriteLine("2. Agregar Vertice");
            Console.WriteLine("3. Agregar Arco");
            Console.WriteLine("4. Mostrar vertices");
            Console.WriteLine("5. Mostrar grafo");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
        }
        static void Main(string[] args)
        {
            string opcion;
            string flag;
            cGrafo Grafo = new cGrafo();
            cVertice ver = new cVertice();
            cVertice ver1 = new cVertice();
            cVertice ver2 = new cVertice();
            do
            {
                Menu();
                opcion = Console.ReadLine();
                switch(opcion)
                {
                    case "1":
                        {
                            Console.WriteLine("¿Desea crear un nuevo grafo?: (S)/(N)");
                            flag = Console.ReadLine();
                            if(flag=="S")
                            {
                                Grafo = new cGrafo();
                                Console.WriteLine("Grafo Creado");
                            }
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Ingrese el nombre del vertice: ");
                            ver.nombre = Console.ReadLine();
                            Grafo.AgregarVertice(ver);
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Ingrese el vertice origen: ");
                            ver1.nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el vertice destino: ");
                            ver2.nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la distancia: ");
                            int dist = int.Parse(Console.ReadLine());
                            Grafo.AgregarArco(ver1, ver2, dist);
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Los vertices del grafo son: ");
                            Grafo.MostrarVertices();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("El grafo es el siguiente: ");
                            Grafo.MostrarGrafo();
                            break;
                        }
                }
            }
            while (opcion!="0");
            Console.ReadKey();
        }
    }
}
