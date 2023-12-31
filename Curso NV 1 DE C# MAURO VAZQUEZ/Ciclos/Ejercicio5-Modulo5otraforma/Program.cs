using System;

namespace Ejercicio5_Modulo5otraforma
{                 //5. Hacer un programa que solicite 20 números y luego emitir por 
                //pantalla el máximo de los números pares y el mínimo de los números impares.
    class Program
    {
        static void Main(string[] args)
        { 
            int n, maximoPar = 0; minimoImpar = 0;
            bool banderaPar = false, BanderaImpar = false;

           

            for ( int x = 0; x < 20; x++)
            {
                 Console.ReadLine( "Ingrese un numrero: ");
                 n = int.Parse (Console.ReadLine());
                if ( n % 2 == 0 ) 

                if (banderaPar == false){    
                    maximoPar = n;
                    banderaPar = true;

 
                  } 
                  
                  else if ( n > maximoPar)
                    maximoPar = n;
                  

                  else (BanderaImpar == false)
                  {
                    minimoImpar = n;
                    BanderaImpar = true;
                


                  }else if ( n < minimmoImpar)
                    minimoImpar = n;
                  



            }
            Console.WriteLine("El maximo de los Numeros PARES es : " + maximoPar);
            Console.WriteLine("El minimo de los Numeros IMPARES es: " minimoImpar);





             
            Console.WriteLine("Hello World!");
        }
    }
}
