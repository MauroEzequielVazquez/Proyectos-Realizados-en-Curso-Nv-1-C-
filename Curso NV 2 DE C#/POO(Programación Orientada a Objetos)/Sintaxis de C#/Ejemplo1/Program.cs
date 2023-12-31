using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b , c;
            float d, e; // si te marca en verde abajo es xq no la usas..
            Console.WriteLine("Hola Maurito vamos a ver que onda esto: ");
            Console.WriteLine("Ingrese un Numero");
            a = int.Parse(Console.ReadLine());
            b = 50;
            c = a + b;
            Console.WriteLine("El valor final de mi variable C es: " + c);
            Console.WriteLine("Fin del Programa");
            Console.ReadKey();
            

        }
    }
}
