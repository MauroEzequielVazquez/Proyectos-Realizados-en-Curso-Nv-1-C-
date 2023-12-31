using System;

namespace Tipeo3      //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular 
                          // el promedio. Mostrar por pantalla los valores que son mayores al promedio.
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int [] vector = new int [10];

        for ( int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un Numero: ");
            n = int.Parse(Console.ReadLine());
            vector[x] = n;

        }  // luego de cargarlo lo recorro con otro for para sacar el Prom
        int acu = 0;
        // el acumulador se inicializa en 0

        for ( int x = 0; x < 10; x++)
        {
            acu += vector[x];

        } // una vez que acumulaste sacas el promedio,, de lo acumulado sobre 10 xq son 10
        double promedio = acu / 10; 
        Console.WriteLine ("El promedio es: " + promedio);

        // RECORRES OTRA vez con un for para saber que valor del vector fue mayor al promedio..
        for ( int x = 0; x < 10; x++)
        {
        if ( vector[x] > promedio){
        Console.WriteLine("El valor que fue mayor al promedio es : " + vector[x]);
        }
        }
            Console.WriteLine("Fin del Programa");
        }
    }
}
