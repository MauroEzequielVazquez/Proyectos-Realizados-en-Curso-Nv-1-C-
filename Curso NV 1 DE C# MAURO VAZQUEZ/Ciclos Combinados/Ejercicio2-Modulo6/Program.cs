using System;

namespace Ejercicio2_Modulo6
{
    class Program  //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
                   //Se pide determinar e informar:
    {           //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        static void Main(string[] args) //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
        {
         int N, Contador = 0 ,ContadorImpares= 0, GrupoImparesMax  = 0, Min  = 0, ContadorOrdenados = 0;
         double PorcentajeDeImpares, PorcentajeMaxImpares = 0; // PUEDO INICIARLIZAR EL MAX EN 0 O EN -1 por si pongo 5 ceros
         bool BanderaOrdenados;
         for( int x = 0; x < 5; x++)
         {      

             Console.WriteLine("Ingrese un numero: ");
                 N = int.Parse(Console.ReadLine());
                Contador = 0;
                ContadorImpares= 0;
                Min = N;
                BanderaOrdenados = true;
               
                 while( N!=0 )
         {
              Contador++;
              if(N % 2 != 0)
             ContadorImpares++;

             // punto B
             if (N < Min){
                Min = N;
            
             }else {
              BanderaOrdenados = false;
             
             }

                Console.WriteLine("Ingrese un numero: ");
              N = int.Parse(Console.ReadLine());

         }

         PorcentajeDeImpares = (ContadorImpares * 100 / Contador);// regla de 3 simple
         if (PorcentajeDeImpares > PorcentajeMaxImpares){
             PorcentajeMaxImpares = PorcentajeDeImpares;
             GrupoImparesMax = (x + 1); //
         }

         if (BanderaOrdenados){ // ES COMO DECIR BanderaOrdenados =1 o Bandera de Ordenados True
         ContadorOrdenados++;

         }

         } 


            Console.WriteLine("El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo: " + GrupoImparesMax);
            Console.WriteLine("La cantidad de grupos  que están formados por todos números ordenados de mayor a menor es : " + ContadorOrdenados );
            Console.WriteLine("Fin del Programa!");
            
        }
    }
}
