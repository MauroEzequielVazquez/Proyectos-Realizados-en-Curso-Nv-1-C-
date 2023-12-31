using System;

namespace Ejercicio5_Modulo5
{
    class Program        // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de
                         //los números pares y el mínimo de los números impares.
                                       
    {
        static void Main(string[] args)
        {
            int N, MaximoPar = 0, MinimoImpar = 0, ContadorPar = 0, ContadorImpar = 0;
             // TENGO Q ASIGNAR A 0 EL MIN Y EL MAX SINO ME DA ERROR

            for( int x = 0; x < 20; x++)
               {                         // DOY 20 VUELTAS CON EL CICLO FOR y voy recolectando la cant de pares e impares
               Console.WriteLine("Ingrese un Numero: ");
               N = int.Parse(Console.ReadLine());
               
                if (N % 2 == 0){             // FORMULA PARA SABER SI UN NUM ES O NO PAR
                    ContadorPar++;                  // SI ES PAR CUENTO,,SI ES PAR CUENTO Y ASI..
               if (ContadorPar == 1)
                       MaximoPar = N;  
               else if (N > MaximoPar) // SI EL nuevo par aue entra es mayor al MAx par que existia lo pisa
                        MaximoPar = N;
               
               }else{
                                             // TRABAJO CON EL GRUPO DE IMPARES
              ContadorImpar++;
               if(ContadorImpar == 1)
                         MinimoImpar = N;
               else if(N < MinimoImpar) // si El nuevo IMPAR QUE ENTRA ES MENOR AL MINIMOIMPAR EXISTENTE LO PIsa    
                         MinimoImpar = N;
               
               }
            } // CIERRO EL CICLO FOR
               Console.WriteLine("El Maximo de los Numeros Pares es: " + MaximoPar);
               Console.WriteLine("El Minimo de los Numeros Impares es: " + MinimoImpar);

            Console.WriteLine("Fin del Programa");
            
        } // NOTA : en el primer if abri llave xq desp tengo otra condicion ELSE para los impares,,cierro ahi y vuelvo
          // a abrir para ese segundo grupo a trabajar,, 
    }
}
