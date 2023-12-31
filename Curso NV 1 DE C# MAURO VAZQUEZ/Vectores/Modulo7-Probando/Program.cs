using System;

namespace Modulo7_Probando
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int [] Vector = new int[10]; // asi se crea un vector

            for (int x = 0; x < 10 ; x++)
            {
                Console.WriteLine("Ingrese un Numero: ");
                N = int.Parse(Console.ReadLine());

                 Vector[x] = N;
                 


            }

            int Acu = 0;
            
             for (int x = 0; x < 10 ; x++){

                Acu+= Vector[x];


             }

             int Promedio = Acu/ 10;

             Console.WriteLine("El promedio final es: " + Promedio);
             Console.WriteLine (" EL valor del elemento 5 o quinto elemento ingresado el cual corresponde al indice 4 es: " + Vector[4]);
        

        

            Console.WriteLine("Fin del Programa de Prueba Vectores!");
        }
    }
}
