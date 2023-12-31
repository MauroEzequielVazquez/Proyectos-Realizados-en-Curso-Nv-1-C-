using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5_Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string VariableString = (saludar("Mica"));
            Console.WriteLine(VariableString);
            Console.ReadKey();

            int b = 10;
            int sumatoria = sumar(2, b);

        }
        // vamos a declarar una funcion string y llamarla,, seria un texto

        static string saludar (string nombre)
        {
           int r = "Hola Maurito, como estas? viniste acompañado con :" + nombre;
            return r;

        }
        
        static int sumar( int a, int b )
        {
           int R = a + b;
            return R;



        }


     
    }
}
