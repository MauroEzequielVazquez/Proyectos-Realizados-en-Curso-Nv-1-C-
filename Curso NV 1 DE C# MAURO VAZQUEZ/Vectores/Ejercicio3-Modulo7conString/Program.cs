using System;

namespace Ejercicio3_Modulo7conString
{
    class Program
    {
        static void Main(string[] args)
        {
            string  frase;
            char letraActual, letraNueva;
            
            Console.Write("Ingrese la frase: ");
            frase = Console.ReadLine(); // tieene 2 parentesis no 3

            Console.Write("Ingrese la letra a REEMPLAZAR: ");
            letraActual = char.Parse(Console.ReadLine());
            Console.Write("ingrese la letra Nueva: ");
            letraNueva = char.Parse(Console.ReadLine());

            frase = frase.Replace(letraActual, letraNueva);
            Console.Write("La cadena nueva es: " + frase);
        

            Console.WriteLine(" \n Fin del programa de prueba con string!");
        }
    }
}
