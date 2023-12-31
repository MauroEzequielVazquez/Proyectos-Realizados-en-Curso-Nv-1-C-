using System;

namespace Ejercicio1_modulo3
{  //. Hacer un programa para ingresar un número y luego se emita por pantalla un
// cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
    class Program
    {
        static void Main(string[] args)
        {
            int N;   //ASIGNO LA UNICA VARIABLE EN ESTE CASO N
            Console.WriteLine("Ingrese un valor para mi variable N:"); //le doy un valor a mi variable
            N = int.Parse(Console.ReadLine());

            if (N > 10) {     // PREGUNTO CON LA HERRAMIENTA IF SI LA MISMA ES MAYOR A 10,,SI LO ES MUESTRA QUE SI Y SI NO TMB
         Console.WriteLine("Es Mayor a 10:"); 
            }
            else {
           Console.WriteLine("No es Mayor a 10:");
            }
            Console.WriteLine("Fin del Programa: ");
        }
    }
}
