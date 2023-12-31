using System;

namespace Ejercicio3_Modulo6deotraforma
{
    class Program
    {
        static void Main(string[] args)   // Hacer un programa para recibir listas de números positivos que están separadas 
                                             //entre sí por un cero. El fin de la carga se notifica con un número negativo
                                             //Luego mostrar cuántos números tiene cada lista.

        {
            
         int N = 1, Con = 0, NumeroGrupo= 0;

         // podes darle un valor positivo a la variable "n" para que entre de una al ciclo o pedir uno con C.write... etc

         while (N >= 0) // xq recibe listas de numeros positios y corta con uno negativo
         {
        
        Con = 0;  
        NumeroGrupo ++;

        Console.WriteLine("Ingrese un Numero");
         N = int.Parse(Console.ReadLine());
         while( N > 0)
         {
         Con ++ ;
        
        Console.WriteLine("Ingrese un Numero positivo para pedir mas num, 0 para pasar de grupo o negativo para cortar el programa:");
         N = int.Parse(Console.ReadLine());

         }
         Console.WriteLine("La cant de numeros que tiene cada lista: " +  NumeroGrupo  + " es " + Con);



         }


            Console.WriteLine("Hello World!");
        }
    }
}
