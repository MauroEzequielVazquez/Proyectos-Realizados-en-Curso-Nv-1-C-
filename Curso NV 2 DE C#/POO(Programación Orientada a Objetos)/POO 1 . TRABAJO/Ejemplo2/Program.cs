using System;

namespace Ejemplo2
{
    internal class Program
    { 
        static void Main(string[] args)
        {

            //Articulo a1 = new Articulo();
            // a1.CodArticulo = 14;
            // a1.Precio = 18000;
            //a1.CodMarca = 10; // si cargo un num mayor a  10, me marca -1

            //Console.WriteLine("El codigo de Articulo es: " + a1.CodArticulo);
            //Console.WriteLine("El precio del articulo es: " + a1.Precio);
            //Console.WriteLine("El codigo de Marca es: " + a1.CodMarca);
            //Console.ReadKey();
            // Este ejemplo tengo la estructura para cargar 1 articulo solo,,para crear 10 no vamos a 
            // andar haciendo 10 variables articulos.. entonces hago un vector de 10 articulos

            Articulo[] articulos = new Articulo[10]; // int[] Numeros = new int [10]; asi creaba 1 vector

            for (int x = 0; x < 2; x++)
            {

                articulos[x] = new Articulo();  //creamos el objeto( ver explicacion en pag)

                Console.WriteLine("ingrese un Codigo de Articulo:");
                articulos[x].CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un precio:");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un Codigo de Marca ( 1 al 10):");
                articulos[x].CodMarca = int.Parse(Console.ReadLine());



            }
            Console.WriteLine("El codigo de marca en la posicion 2, indice 1 es : " + articulos[1].CodMarca);

            Console.WriteLine("El codigo de articulo en la pos 2,indice 1 es: " + articulos[1].CodArticulo);
            Console.ReadKey();

            // Segunda parte del problema

            Venta ventas = new Venta();

            Console.WriteLine("Ingrese una venta:");
            Console.WriteLine("Ingrese un Codigo de Cliente del 1 al 100:");
            ventas.CodigoCliente = int.Parse(Console.ReadLine());

            while (ventas.CodigoCliente != 0)
            {
                Console.WriteLine("Ingrese un Codigo de Articulo:");
                ventas.CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese una cantidad para la venta:");
                ventas.Cantidad = int.Parse(Console.ReadLine());

                // Vuelvo a pedir la venta,, si es acorde vuelvo a entrar al ciclo

                Console.WriteLine("Ingrese una venta:");
                Console.WriteLine("Ingrese un Codigo de Cliente:");
                ventas.CodigoCliente = int.Parse(Console.ReadLine());
               

            }

            


        }
    }
}
