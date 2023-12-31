using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args) // condicionales son IF, SWITCH
        {
            int a = 10, b = 12;
            if ( a == b && b != 10 || !(a ==20)) 
            {
                Console.Write("Se cumple la condicion");

            }
            else if{
                (a > b)
                    Console.WriteLine("Se cumple de esta segunda forma");
            }
            else
            {
                if (a < b)
                Console.WriteLine("NO se cumple");
                Console.ReadKey();



            }
        }

    }
}
