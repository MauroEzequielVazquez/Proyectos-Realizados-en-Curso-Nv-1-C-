using System;

namespace Ejercicio2_Modulo3
{
    class Program
    { //2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” 
    //si el número es menor a cero o “Cero” si el número es igual a cero.
        static void Main(string[] args)
        {
            int N; // DECLARO VARIABLE 
            Console.WriteLine("Ingrese un valor para mi Variable numero: "); // le asigno valor a mi variable
            N = int.Parse(Console.ReadLine());
            if (N > 0){                           // Utilizo la herramienta condicional IF... "SI"
                Console.WriteLine("Es Positivo: ");
             }else if (N < 0){                //ELSE IF SERIA UN SINO SI
                Console.WriteLine ("Es Negativo: ");
                
             }else{                              // POR ULTIMO LIQUIDO CON EL ELSE
                Console.WriteLine("Es Cero: ");
             }
                Console.WriteLine("Fin del programa:");
            }
            
        }
    }

