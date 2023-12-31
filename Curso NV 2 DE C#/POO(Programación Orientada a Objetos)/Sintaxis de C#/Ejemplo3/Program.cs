using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{    // Ejemplos de ciclos for,, while y do while, los combinas como quieras
    internal class Program
    {
        static 
            void Main(string[] args)
        {
            // operadores ++, -- , +=, -=, y los que no usamos *= y /= que funcionan igual que los otros
            int n = 10;
            for (int x = 0; x < 10; x++ )
            {
              // ingreso al while xq ya inicialice la variable n en 10
                while(n != 0)
                {
                    Console.WriteLine("Hola " + x); // muestra en cada vuelta el valor de x
                    n--; // va descontando n para llegar a 0 y da 10 vueltas igual que el for
                         // podes pedir manualmente los datos al usuario o asignar de esta manera
                         // recordemos siempre INICIALIZACION, CONDICION,, Y VARIACIÓN...
                }
                n = 10; // lo ponemos de nuevo en 10 xq n desp del while vale 0 de nuevo;
               
            }
            Console.ReadKey(); // el corte va fuera de los ciclos


        }
    }
}
