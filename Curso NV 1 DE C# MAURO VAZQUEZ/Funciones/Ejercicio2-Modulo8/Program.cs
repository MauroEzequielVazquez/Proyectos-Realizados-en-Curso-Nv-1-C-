using System;

namespace Ejercicio2_Modulo8 //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
//Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,
            contadorPares = 0; // ME PIDE CUANTOS SON PARES x eso llamo a mi funcion y si son pares lo sumo

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                a = int.Parse(Console.ReadLine());

                if (par(a))
                    contadorPares++;
            }
            Console.WriteLine("La cantidad de numeros pares es : " + contadorPares);

            Console.WriteLine("Fin del programa");
        }

        static bool par(int n)
        {
            if (n % 2 == 0)
                return true; // 1 es true .. la consiga pedia 1 o 0 pero es lo mismo,,
            //el argumento es tipo int y la funcion tbool xq devuelve true o false,,si es int devuelve num 1 o 0;
            else
                return false; // 0 es false
        }
    }
}
