using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono Tel1 = new Telefono("S22", "Samsung");
            Telefono Tel2 = new Telefono();

            Tel1.numeroTelefonico = "1137802708";
            Tel1.CodOperador = 3;
            Tel2.numeroTelefonico = "1154566360";
            Tel2.CodOperador = 5;

            // Tel2.marca = Samsung; NO SE PUEDE XQ ES SOLO GET ese atributo solo lectura
            //Tel2.modelo pasa lo mismo es solo obtencion de datos para la lectura
            




            Console.WriteLine("El modelo de mi Telefono es: " + Tel1.modelo);
            Console.WriteLine("La marca de mi Telefono es: " + Tel1.marca);
            Console.WriteLine("El numero telefonico es: " + Tel1.numeroTelefonico);
            Console.WriteLine(" El codigo de Operador es: " + Tel1.CodOperador);
            Console.WriteLine("El numero telefonico de mi otro telefono es: " + Tel2.numeroTelefonico);
            Console.WriteLine("El cod de operador de mi otro telefono es: " + Tel2.CodOperador);
            Console.WriteLine(Tel1.Llamar());
            Console.WriteLine(Tel1.Llamar(" Micaela "));
            Console.ReadKey();


        }

        




    }
}
