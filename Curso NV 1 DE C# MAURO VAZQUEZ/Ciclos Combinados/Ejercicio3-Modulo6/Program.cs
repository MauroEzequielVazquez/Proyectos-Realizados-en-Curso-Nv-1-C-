using System;

namespace Ejercicio3_Modulo6
{
    class Program
    {
        static void Main(string[] args)
        {

            int N , con = 0, NumeroGrupo = 0;     // 3. Hacer un programa para recibir listas de números positivos que están 
                                                  //separadas entre sí por un cero. 
                 // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            do
            {
            NumeroGrupo++;

            con = 0;
            Console.WriteLine("Ingrese un Numero:");
            N = int.Parse(Console.ReadLine());
            
            while( N > 0) {
            con ++;

            Console.WriteLine("Ingrese OTRO Numero si es positivo sigo pidiendo, 0 paso de grupo y negativo corto programa:");
            N = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La cantidad de Numeros que tiene la lista: "  + NumeroGrupo + " es " + con);

           } while (N >= 0); // LLEVA  ;          si pones un negativo no cumple la condicion del WHILE y se corta el programa

            
           Console.WriteLine("Fin del Programa");


            }


     
        
        }
    }

