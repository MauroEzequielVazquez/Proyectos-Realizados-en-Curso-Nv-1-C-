using System;

namespace ForConFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, Promedio, Acu = 0; // DECLARO VARIABLES

            for (int y = 0; y < 10; y++)
            {
                Acu = 0; // el acumulador lo reseteo cada vez que termino el ciclo for chico.
                for (int x = 0; x < 20; x++)
                {
                 Console.WriteLine(" Ingrese una edad:");
                 N = int.Parse(Console.ReadLine());
                 Acu+= N;
                }
                Promedio = Acu / 20;
              Console.WriteLine("La edad promedio es: " + Promedio);

            }

            Console.WriteLine("Fin del programa:");
        }
    }
}
