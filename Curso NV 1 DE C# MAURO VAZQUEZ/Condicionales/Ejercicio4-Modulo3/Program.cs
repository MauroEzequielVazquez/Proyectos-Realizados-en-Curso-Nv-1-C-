using System;

namespace Ejercicio4_Modulo3
{  //4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
    class Program
    {
        static void Main(string[] args)
        {
         int A, B, C, D, menor ; // Declaro VARIABLES
         Console.WriteLine("iNGRESE UN VALOR PARA A");    // LES ASIGNO UN VALOR
          A = int.Parse(Console.ReadLine());
          Console.WriteLine("iNGRESE UN VALOR PARA B");
          B = int.Parse(Console.ReadLine());
          Console.WriteLine("iNGRESE UN VALOR PARA C ");
          C = int.Parse(Console.ReadLine());
          Console.WriteLine("iNGRESE UN VALOR PARA D");
          D = int.Parse(Console.ReadLine());
          

         if (A < B){
         menor = A;

         }else{
            menor = B;
         }
         if (C < menor){
            menor = C;   
         } if (D < menor){
            menor = D;
         }
         Console.WriteLine("El Menor es: " + menor);

            Console.WriteLine("Fin del programa!");
        }
    }
}
