using System;

namespace PromedioFinal_Alumno
{  //5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un 
//alumno y luego calcule y emita por pantalla el promedio final.


    class Program
    {
        static void Main(string[] args)
        {
            float A, B, C, promedioFinal; //DECLARO VARIABLES CON SU TIPO DE DATO
            Console.WriteLine("Ingrese la primer nota: ");
            A = float.Parse(Console.ReadLine());   // LES ASUGNO SUS VALORES 
            Console.WriteLine("Ingrese la segunda nota: ");

            B = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercer y ultima nota");
            
            C = float.Parse(Console.ReadLine());
            promedioFinal = (A+B+C)/3;

            Console.WriteLine("El promedio Final es: " + promedioFinal);
        }
    }
}
