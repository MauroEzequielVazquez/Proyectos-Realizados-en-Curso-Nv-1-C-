using System;

namespace Modulo7_EjDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturaMatutina =  new double[10];

            int dia;
            double temperatura;
         

            for ( int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un dia: ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese una temperatura: ");
                temperatura = double.Parse(Console.ReadLine());

                temperaturaMatutina [ dia - 1] = temperatura ;

            }

            double acu = 0;

            for ( int x = 0; x < 10; x++)
            {
                acu += temperaturaMatutina[x];


            }

            Console.WriteLine (" la temperatura en la vuelta 5 fue :" + temperaturaMatutina[5]); // podemos leer el Vector para saber q ingreso en ese momento

           double  promedio = acu / 10;
            Console.WriteLine("El promedio de las temperaturas Matutinas es : " + promedio );
            Console.WriteLine("Fin del Programa!");
        }
    }
}
