using System;

namespace Ejercicio5_Modulo4
{
    class Program       //5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
    {
        static void Main(string[] args)
        {
            int A, B, C, D;        // DECLARO VARIABLES
            Console.WriteLine ("Ingrese un Numero para A: ");
            A = int.Parse(Console.ReadLine());             //LES DOY VALOR
            Console.WriteLine ("Ingrese un Numero para B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine ("Ingrese un Numero para C: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine ("Ingrese un Numero para D: ");
            D = int.Parse(Console.ReadLine());
            if (A > B && B > C && C > D){
            Console.WriteLine("Los Numeros se encuentran ordenados de forma decreciente: ");
          } else {
            Console.WriteLine(" Los valores ingresados No estan ordenados de manera decreciente: ");  // SI NO USO EL ELSE ME VA A DAR SIEMPRE EL CARTEL ORDENADOS PONGA LO Q PONGA XQ NO HAY MAS OPC
          }
            Console.WriteLine("FIN DEL PROGRAMA:");
        }
    }
}
