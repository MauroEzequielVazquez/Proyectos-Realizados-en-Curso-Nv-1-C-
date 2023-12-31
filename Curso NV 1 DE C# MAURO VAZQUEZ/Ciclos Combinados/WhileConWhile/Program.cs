using System;

namespace WhileConWhile
{
    class Program
    {
        static void Main(string[] args)
        {
         int N, Acu, Con, Promedio;
         Console.WriteLine("iNGRESE una edad  POSITIVA para arrancar el programa:"); // INICIALIZACION DEL WHILE PARA QUE ARRANQUE
        N = int.Parse(Console.ReadLine());
        while(N > 0) // PONES UN NUM POOSITIVO,inicializa el cont y el acu y cuando pones 0  corta el otro while interno y te preg si
                      // seguis o no con otro "Equipo", de qrer seguir pones un num positivo y asi hasta q no qres mas y apretas 0 de nuevo
        {
        Acu = 0;
        Con = 0;

        while (N != 0)
        {
        Acu += N;
        Con++;
        Console.WriteLine("ingrese una edad:");
        N = int.Parse(Console.ReadLine());   // Cuento y Acumulo hasta que la edad sea =  a 0 y ahi salgo del ciclo.,,dejo de contar las edades del equipo...
        }
        Promedio = Acu / Con;
        Console.WriteLine("El promedio de edades del equipo es: " + Promedio);
        Console.WriteLine ("iNGRESE una edad Positiva para continuar pidiendo equipos o negativa / cero para cortar:");
         N = int.Parse(Console.ReadLine());
        }  // cierra el ciclo WHILE EXTERNO

    
            Console.WriteLine("Fin del Programa!");
        }
    }
}
