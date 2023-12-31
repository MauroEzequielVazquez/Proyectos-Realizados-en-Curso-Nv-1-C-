using System;

namespace Ejercicio4_Modulo5           //4. Hacer un programa que solicite UN número y luego calcule 
                                         //y emita un cartel aclaratorio si el mismo es primo o no es primo. 
                                         // Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

{
    class Program
    {
        static void Main(string[] args)
        {
            int N, CONTADOR = 0;

            Console.WriteLine("ingrese un numero:");
            N = int.Parse(Console.ReadLine());

            for (int x = 1; x <= N ; x++){
                 // GIRAMOS DESDE Q X VALGA 1 HASTA Q VALGA IGUAL A N,,CUANDO SE PASE DE N YA no te interesa mas
             if ((N % x) == 0)  // va %%%%% NO / xq es el resultado de N SOBRE LO Q VALGA X en esa vuelta
                    CONTADOR++;         // DIVIDIS A N POR TODOS LOS NUMEROS DESDE EL 1 HASTA N,,,XQ EL PRIMO ES DIVISIBLE POR 1 Y POR SI MISMO

            }
            if (CONTADOR == 2)
                Console.WriteLine("El numero ingresado es Primo: ");
            else
                Console.WriteLine("El Numero ingresado no es Primo: ");
            
            Console.WriteLine("Fin del programa:!");
            
        }
    }       
}                // puedo arrancar X EN 0 E IR HASTA < N,,,Y PREGUNTAR SI EL CONTADOR ES == A 0 ES PRIMO,, SI DIVIDIIO ALGUNA VEZ SIGNIFICA Q YA NO ES PRIMO


