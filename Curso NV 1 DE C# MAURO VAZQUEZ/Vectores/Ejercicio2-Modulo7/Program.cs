using System;

namespace Ejercicio2_Modulo7  // Hacer un programa que solicite 10  números enteros y los guarde en un vector.
                           //  Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int [] vectorNumeros = new int [10];

            for ( int  x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());
                vectorNumeros[x] = n;

            }
            int acu = 0;
            for (int x = 0; x < 10; x++)
            {
                acu+= vectorNumeros[x];

            }
            double promedio = acu / 10; // puede ser de tipo int pero los promedios suelo hacerlos con double o float, y puedo declararlo encima de todo,
            Console.WriteLine("El promedio es: " + promedio);
           
            for (int x = 0; x < 10; x++){
             if( vectorNumeros[x] > promedio ){ // o al reves.. IF promedio < VectorNumeros[x]....mostras esos valores
            Console.WriteLine("El valor que fue mayor al promedio es : " + vectorNumeros[x]);
                }


            }

            Console.WriteLine("Fin del Programa!");
        }
    }
}
