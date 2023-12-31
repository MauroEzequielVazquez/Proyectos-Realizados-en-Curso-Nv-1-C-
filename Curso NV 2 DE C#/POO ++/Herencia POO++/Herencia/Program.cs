using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona P1 = new Persona();

            Tester T1 = new Tester();
            Developer D1 = new Developer();
            Lider L1 = new Lider();


            D1.Nombre = "Mauro";
            T1.Apellido = "Vazquez";
            L1.Legajo = "Bueno";


            Console.WriteLine(D1.GetHashCode());


            Console.WriteLine("El apellido es: " + T1.Apellido);
            Console.WriteLine("El nombre es: "+ D1.Nombre);
            Console.WriteLine("El legajo es: " + L1.Legajo);
            Console.ReadKey();



        }
    }
}
