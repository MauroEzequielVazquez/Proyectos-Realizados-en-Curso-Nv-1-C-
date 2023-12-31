using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        { // PASO 0 declaramos variables
          int n1, n2, 1resultado;
          //PASO 1 pedimos valores  
          Console.WriteLine("Ingrese un numero:");
          n1 = int.Parse(Console.ReadLine());
          Console.WriteLine("Ingrese otro numero:");
          n2 = int.Parse(Console.ReadLine());
          //INT.PARSE LE DICE AL PROGRAMA QUE VA A RECIBIR UN NUMERO Y UN UN STRING
          //PASO 2 REALIZAR EL CALCULO
          resultado = n1 + n2;
          // PASO 3 ESCRIBIR EL RESULTADO
          Console.WriteLine("El resultado es:" + resultado);

        }
    }
}
