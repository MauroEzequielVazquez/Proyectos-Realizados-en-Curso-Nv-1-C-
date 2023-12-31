using System;

namespace Ejercicio1_Modulo6
{
    class Program //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos 
               //de esos números son primos.
    {
        static void Main(string[] args)
        {
            int N, contador = 0, ConPrimos = 0 ;  // declaro variables , como necesito saber cuantos primos, ahora tengo el
              //contador para saber si es primo y otro contadoPrimos para saber cuántos primos hay

         for(int y = 0; y < 10; y++)
            { 
              Console.WriteLine("Ingrese un Valor:");
              N = int.Parse(Console.ReadLine());
              contador = 0; // inicializa el contador en 0

              for (int x = 1; x <= N; x++)
              {
              
              if (N % x == 0){

                contador++;
              }
               
             }
             if ( contador == 2){
                ConPrimos++;

             }
            }  // es como el de sacar los primos pero como tenes q saber cuantos lo fueron haces 2 ciclos y un contador de primos
            Console.WriteLine("El contador total de Numeros Primos Ingresados es: " + ConPrimos);
            Console.WriteLine("Fin del Programa");
        }
    }
}
