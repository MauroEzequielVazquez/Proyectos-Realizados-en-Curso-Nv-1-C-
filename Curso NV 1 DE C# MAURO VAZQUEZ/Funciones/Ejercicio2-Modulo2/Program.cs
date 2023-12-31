using System;

namespace Numero_al_cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASIGNO VARIABLE
            int n1,numeroalcubo;
            Console.WriteLine("ingrese un numero");//PIDO VALORES 
            n1 = int.Parse(Console.ReadLine());
            //CALCULO
            numeroalcubo = (n1*n1*n1);
            Console.WriteLine("El cubo del numero es:" + numeroalcubo);
        }
    }
}
