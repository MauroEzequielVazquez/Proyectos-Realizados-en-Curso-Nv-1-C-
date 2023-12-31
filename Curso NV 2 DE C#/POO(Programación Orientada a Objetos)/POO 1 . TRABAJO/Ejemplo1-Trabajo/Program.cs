using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Trabajo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Persona P1 = new Persona(" Mauro Trocetto",29);// le das 1 valor al constructor
            //P1.Sueldo = 312000;
            //Console.WriteLine("El nombre de la persona es: " + P1.Nombre);
            //Console.WriteLine("La edad de la Persona es: " + P1.Edad);
            //Console.WriteLine("El sueldo de la persona es: " + P1.Sueldo);
            //Console.WriteLine(P1.Saludar());
            //Console.WriteLine(P1.Saludar("Maxi"));




            //Perro 


            //Perro Perrito = new Perro();

            //Perrito.Nombre = "Pirka";
            //Perrito.Color = "Marron";
            //Perrito.Origen = "Inglesa";


            //BOTELLA

           Botella B1 = new Botella("Azul", "Plastico");
           
            Console.WriteLine("El material de mi botella es: " + B1.Material);
            Console.WriteLine("El color de mi botella es: " + B1.Color);
            Console.WriteLine("La capacidad de mi botella es: " + B1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + B1.CantidadActual);
            B1.Recargar(20);
            Console.WriteLine("La capacidad de la botella luego de recargarla es: " + B1.CantidadActual);


            B1.Recargar();
            Console.WriteLine("La capacidad de la botella luego de recargarla es: " + B1.CantidadActual);
            Console.WriteLine(B1.GetHashCode());

            //Console.WriteLine("El nombre de la perrita es: " + Perrito.Nombre);
            //Console.WriteLine("El color de la perrita es: " + Perrito.Color);
            //Console.WriteLine("El origen de la perrita es: " + Perrito.Origen);

            Console.ReadKey();

        }
    }
}
