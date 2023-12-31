using System;

namespace Ejercicio3_Modulo5
{
    class Program
    {
        static void Main(string[] args)  // . Hacer un programa que solicite 20 edades y luego calcule el promedio de edad 
        //de aquellas personas mayores a 18 años.
        {
            float Edad, Con = 0, Acu = 0, Promedio;
            for (int x = 0; x < 20 ; x++) 
            {
                Console.WriteLine("Ingrese un numero para la edad:");
                Edad = int.Parse(Console.ReadLine());
                if (Edad > 18){  // SI LA PERSONA ES MAYOR A 18 ACUMULO Y CUENTO
                    Acu += Edad;
                    Con ++;  
                   }

                }
                Promedio = Acu / Con;  // CON LA CANT DE PERSONAS ACUMULADAS Y EL CONTADOR SACO EL PROM
                Console.WriteLine("El promedio de las personas Mayores a 18 años de edad es: " + Promedio);
                Console.WriteLine("Fin del Programa: ");

            }
        }
    }

