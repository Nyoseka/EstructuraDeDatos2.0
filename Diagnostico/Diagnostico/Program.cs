using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagnostico
{
    class Alumno
    {
        public string nombre;
        public int numerocontrol;
        public Alumno()
        {

        }
        public Alumno(string nombre,int numerocontrol)
        {
            this.nombre = nombre;
            this.numerocontrol= numerocontrol;
        }
    }
    class DesplegarAlumnos:Alumno
    {
        public int calificacion=0;
        public DesplegarAlumnos()
        {

        }
        public DesplegarAlumnos(string nombre,int numerocontrol,int calificacion)
        {
            this.nombre = nombre;
            this.numerocontrol = numerocontrol;
            this.calificacion = calificacion;
        }
        public void DesplegarDatos()
        {
            Console.WriteLine("Nombre del ALumno: {0}",nombre);
            Console.WriteLine("Número de Control: {0}",numerocontrol);
            Console.WriteLine("Calificación: {0}",calificacion);
            if(calificacion>=70)
            {
                Console.WriteLine("ALUMNO APROBADO");
            }
            else
            {
                Console.WriteLine("ALUMNO REPROBADO");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DesplegarAlumnos alumno1 = new DesplegarAlumnos("Juan", 111, 70);
            DesplegarAlumnos alumno2 = new DesplegarAlumnos("María", 222, 50);
            Console.WriteLine("--- LISTA DE ALUMNOS ---" + '\n');
            alumno1.DesplegarDatos();
            Console.WriteLine('\n');
            alumno2.DesplegarDatos();
            Console.ReadKey();
            DesplegarAlumnos alumno3 = new DesplegarAlumnos("María", 222, 90);
            Console.Clear();
            Console.WriteLine("--- LISTA DE ALUMNOS ---" + '\n');
            alumno1.DesplegarDatos();
            Console.WriteLine('\n');
            alumno3.DesplegarDatos();
            Console.WriteLine('\n'+"Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
