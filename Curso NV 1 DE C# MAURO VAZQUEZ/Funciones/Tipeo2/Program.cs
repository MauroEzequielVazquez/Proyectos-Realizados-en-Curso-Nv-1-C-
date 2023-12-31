using System;

namespace Tipeo2
{
    class Program
    {
        static void Main(string[] args)
        {
        int n;
        int [] numerosEnteros = new int [10];

       
        for ( int x = 0; x < 10; x++)
        {
             Console.WriteLine("Ingrese un numero: ");
             n = int.Parse(Console.ReadLine());
             numerosEnteros[x] = n;
            // ya cargue el vector, ahora falta recorrerlo CON OTRO FOR y determinar el valor max y su pos
        }

        int valorMaximo = numerosEnteros[0];
        int posicion = 1; // para el usuario va de 1 a 10 y para el programa de 0 a 9 x eso se ajusta x + 1..

        for ( int x = 0; x < 10; x++)
        {

        if(numerosEnteros[x] > valorMaximo){
        valorMaximo = numerosEnteros[x];
        posicion = x + 1; // pequeño ajuste entre el usuario y el programa
        }

        }
         Console.WriteLine(" Valor del vector en el indice  4, y quinto elemento  ingresado es: " +  numerosEnteros[4]); // vemos como leer el vector
            Console.WriteLine("El maximo numero ingresado es: " + valorMaximo);
            Console.WriteLine("La posición ingresada es: " + posicion);

            Console.WriteLine("Fin de programa!");
        }
    }
}
