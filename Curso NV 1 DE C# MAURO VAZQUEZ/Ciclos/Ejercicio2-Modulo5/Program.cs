using System;

namespace Ejercicio2_Modulo5
{
    class Program    // 2. Hacer un programa que solicite el ingreso de 10 números y que muestre 
            //el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
    {
        static void Main(string[] args)
        {
            int N, Maximo = 0; // si bien el cero es tipo placebo, no hace nada,, es necesario xq el sitema te tira error sino
            for( int x = 0; x < 10; x++)
            { 
              Console.WriteLine("ingrese un numero:");
               N = int.Parse(Console.ReadLine());
                if  (x == 0)  // si x es == a 0 estoy en la primer vuelta del ciclo y el max es lo primero q encuentro,, N
                        Maximo = N;
                else if(N > Maximo) // si el num q entra atras es mayor al maximo lo suplanta
                        Maximo = N;
                        
                    
                     } 
                      Console.WriteLine("El mayor de los numeros es: " + Maximo);

                
                     Console.WriteLine("Fin del Programa!");
        }
    }
}
