using System;

namespace Ejercicio1_Modulo8
{
    class Program
    {             //1.Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
              //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
        static void Main(string[] args)
        {
            int precio, cantidad, montototal;
            Console.WriteLine("ingrese el monto a pagar por el producto: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad.: ");
            cantidad = int.Parse(Console.ReadLine());
            
            montototal = producto(precio, cantidad);
            Console.WriteLine("El monto total a pagar por la compra del productos es : " + montototal);

            Console.WriteLine("Fin del Programa");
        }
        
        static int producto (int a, int b)
        {
        int r;
        r = (a * b);
        return r;
        }

    }
}
