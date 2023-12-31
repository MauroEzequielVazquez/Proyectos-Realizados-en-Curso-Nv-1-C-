using System;

namespace Ejercicio4_Modulo7
{                                     //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
                                      //Cantidad vendida
                                     //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
                                     //Se pide determinar e informar:
                                     //a) El número de artículo que más se vendió en total.
                                     //b) Los números de artículos que no registraron ventas.
                                     // c) Cuantas unidades se vendieron del número de artículo 10.


    class Program
    {
        static void Main(string[] args)
        {
            int numeroArticulo, cantidadVendida;
            int [] RegistrosVentas = new int [15];

            for(int x = 0; x < 15; x++)
            {

               RegistrosVentas[x] = 0;  // Inicializa en cada vuelta en 0  de la vuelta 0 a la 14, xq el vector va a servir como acumulador de cada 
                                          //producto que ingrese,entonces necesita volver a cero  del producto 0 al 14 para acumular uno por uno, y asi
                                              // es como tener 15 acu, uno para cada producto
            }

            Console.WriteLine("ingrese el numero de articulo:");
            numeroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            while ( numeroArticulo != 0)
            { 
        // cuando la persona carga el Producto 1, yo acumulo en el elemento 0 y asi,, si carga el producto 15 acumulo en el  indice 14
        // entonces uso esto de guia para ir cargando el acumulador en el vector , porque al ser while y no for,, necesito una guita para el indice
          RegistrosVentas[numeroArticulo - 1] += cantidadVendida; 
              //esto significa que acumula en el numero de articulo menos 1 ,la cantidad q se vendio,,, el nro de art sirve
              // para guiarme el  camibo xq va de 1 a 15 y el indice de 0 a 14 por eso -1                                     
            Console.WriteLine("ingrese el numero de articulo:");
            numeroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());
            // una vez terminado el ciclo while sabes la cantidad vendidad para cada articulo..ahora te pide buscar el maximo dentro del vector y su pos
             }
             // a) El número de artículo que más se vendió en total.      
             int maximaCantidad = RegistrosVentas[0];    //BUSCO EL MAXIMO Y SU POSICION,,,SU POSICION XQ ME DA EL N° DE articulo ,,indice +1 = pos
             int nroArticuloMaximo = 1;                  // ya hicimos en otros ej esto del maximo y la pos.... 

             for (int x = 0; x < 15; x++)
             {
                if (RegistrosVentas[x]  > maximaCantidad){
                    maximaCantidad = RegistrosVentas[x];  // si el articulo que ingreso en esa vuelta de X es mayor , ahora suplanta al maximo q tenia
                    nroArticuloMaximo = x + 1; // seria la posicion .. x +1 xq para identificar el n° de art habiamos usado el indice como referncia
                                                  // le restabamos 1 al articulo entonces +1 sacas el articulo
                }
             }
                Console.WriteLine (" El producto mas vendido es el : " + nroArticuloMaximo + " con la cantidad de: " + maximaCantidad);

                //b) Los números de artículos que no registraron ventas.
               for (int x = 0; x < 10; x++)
               {
                if (RegistrosVentas[x] == 0)
                {                                              // si es igual a cero es xq no tuvo ventas
                Console.WriteLine("El producto  " + (x + 1) + " NO tuvo ventas: " );  // evalua 15 veces,  1 vez cada producto y el que da 0 es xq NO 
                                                                                      //tuvo ventas,,simple
                                                                                    // x + 1 te dice el nmero de articulo,, al igual q el punto pasado

                }
               }

             // c) Cuantas unidades se vendieron del número de artículo 10.   
             Console.WriteLine ("La cantidad vendida del ARTICULO 10 ES : " + RegistrosVentas[9]); // el Producto 10 es el indice 9,, en mi vector 
                                                                   //yo ya cargue como 15 acu.
                                                                 // Es tan sencillo como leer el vector en el indice 9...

            Console.WriteLine("fIN del Programa!");
        }
    }
}
