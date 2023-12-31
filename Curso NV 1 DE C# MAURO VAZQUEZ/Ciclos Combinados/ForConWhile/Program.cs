using System;

namespace ForConWhifle
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, Promedio, Acu,; Con;
            for (int x = 0; x < 10 x++) // LOTE FOR DE 10 EQUIPOS, 
            {
                Console.WriteLine("ingrese un valor para la edad:");  // SERIA LA INICIALIZACION, EL PRIMER PASO DE WHILE
                N = int.Parse(Console.ReadLine());
                Acu = 0;
                Con = 0;
                while ( N != 0) // CONDICION CLASICA DEL CICLO WHILE, PASO 2
                { 
               Con++;
               Acu+= N;
              Console.WriteLine("ingrese un valor para la edad:");  // ENTRA AL CICLO,SI LA COND DA OK,,VUELVE A PEDIR,,SI DA OK VUELVE A PEDIR Y ASI REBOTA ENTRE ESTOS 2 PASOS
                N = int.Parse(Console.ReadLine());

                }
                Promedio = Acu / Con;
                Console.WriteLine("El promedio es:" + Promedio);

            }

            Console.WriteLine("Fin del Programa!");
        }
    }
}
