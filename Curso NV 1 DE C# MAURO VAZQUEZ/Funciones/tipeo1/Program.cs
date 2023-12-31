using System;

namespace tipeo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, Contador = 0 , ContadorImpares = 0, GrupoImparesMax = 0, minimo, ContadorOrdenados = 0;
            double PorcentajeDeImpares = 0, PorcentajeMaxImpares = 0;
            bool BanderaOrdenados;

     for(int x = 0; x < 5; x++)
 {
    Console.WriteLine("Ingrese un numero:");
     n = int.Parse(Console.ReadLine());
     Contador = 0;
     ContadorImpares = 0;
     minimo = n; // por cada iteración el Min es N...
     BanderaOrdenados = true; // asumo que estan ordenados,, si pasa a false es xq no lo están

         while( n != 0)
         {
            Contador++;

            if(n % 2 != 0) // si es distinto de cero es IMPAR.
            ContadorImpares++;

         if ( n <= minimo)
          minimo = n;
          else 
          BanderaOrdenados = false; // la inicialice dentro del for con TRUE xq asumo q están ordeandos,si  n lo estan pasa a false
        Console.WriteLine("Ingrese otro numero, el pedido corta con CERO :");
        n = int.Parse(Console.ReadLine());
         }
         PorcentajeDeImpares = (ContadorImpares * 100 / Contador);
         if (PorcentajeDeImpares > PorcentajeMaxImpares){
            PorcentajeMaxImpares = PorcentajeDeImpares;
            GrupoImparesMax = (x + 1);  // la x nos marca el camino y hacemos el x + 1 xq para el usuario es 1 mas de 1 a 5
                                        // para el programa va de 0 a 4 por eso x mas 1
         }
         if (BanderaOrdenados){ // ES COMO DECIR BanderaOrdenados =1 o Bandera de Ordenados = True
         ContadorOrdenados++;
         }



         Console.WriteLine("La cant de numeros ingresados en este grupo: " + (x) + " fue: "  + Contador);
         Console.WriteLine("La cant de numeros impares ingresados fue: " + ContadorImpares);
         Console.WriteLine("El porcentaje de Numeros impares fue: " + PorcentajeDeImpares);
    
        }
            Console.WriteLine("El num de grupo con mayor porcentaje de impares fue el: " + GrupoImparesMax + " y su porcentaje fue: " + PorcentajeMaxImpares);
            Console.WriteLine("La cantidad de grupos  que están formados por todos números ordenados de mayor a menor es : " + ContadorOrdenados );
            Console.WriteLine("Fin del Programa!");
            
        }
    }
}
