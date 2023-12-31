using System;

namespace ProbandoFunciones
{
    class Program
    {
        static void Main(string[] args)   // funcion MAIN es la principal  y es tipo VOID xq no retorna nada
        {

            int n1, n2, resultado;
            Console.WriteLine ("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro.... :");
            n2 = int.Parse(Console.ReadLine());

            resultado = sumar( n1 , n2);
            Console.WriteLine("El resultado es: " + resultado);



            Console.WriteLine("Fin del Programa!");
        }

        static int sumar(int a, int b){ // abre y cierra , como cualquier bloque de codigos.
        int r;
        r = a + b + 50 ; // podes manipular la logica y ademas de copiar los valores por parametro, sumarme algo o lo q quieras
        return r;
        
             
        }
    }
}
