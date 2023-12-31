using System;

namespace Ejercicio4_Modulo4
{ //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros 
//es mayor al producto del segundo con el tercero.
    class Program
    {
        static void Main(string[] args)
        {
         int A, B, C, R1, R2;  //DECLARAR LAS VARIABLES
            Console.WriteLine("Ingrese un numro: ");  //pedir los valores
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo Valor en este caso para B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un ultimo valor para C: ");
            C = int.Parse(Console.ReadLine());

            R1 = (A + B);
            R2 = (B* C);
            
            if (R1 > R2){
                Console.WriteLine("LA SUMA ES MAYOR QUE EL PRODUCTO: ");
            }

            Console.WriteLine("Fin del programa");

        }
    }
}
