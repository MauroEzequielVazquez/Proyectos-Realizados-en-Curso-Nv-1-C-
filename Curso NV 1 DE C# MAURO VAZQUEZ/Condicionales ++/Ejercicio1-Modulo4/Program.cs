using System;

namespace Ejercicio1_Modulo4
{  //1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

//La resta si el primero es mayor que el segundo.
//La suma si son iguales.
//El producto si el primero es menor.
    class Program
    {
        static void Main(string[] args)
        {
          int A, B, R;
          Console.WriteLine("Ingrese un valor: ");
          A = int.Parse(Console.ReadLine());
          Console.WriteLine("Ingrese otro valor: ");
          B = int.Parse(Console.ReadLine());

          if (A > B){
            R = (A - B);
          }
           else if (A < B){
            R = (A * B);
          }
          else {
          R = (A + B) ;
          }
          Console.WriteLine("El resultado final es: " + R);
            Console.WriteLine("Fin del programa!");
        }
    }
}
