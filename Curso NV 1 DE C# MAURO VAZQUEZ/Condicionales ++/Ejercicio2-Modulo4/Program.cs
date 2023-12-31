using System;

namespace Ejercicio2_Modulo4
{ //2. Un importante negocio de 
//desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

//Si vende menos de 100 litros, no hay descuento.
//Si vende entre 101 y 300 litros, el descuento es del 10%.
//Si vende entre 301 y 500 litros, el descuento es del 15%.
//Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
//Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
    class Program
    {
        static void Main(string[] args)
        {
            double ImporteTotalVenta, CantidadLitrosVendida, ImporteFinalConDesc; // DECLARO MIS VARIABLES
            Console.WriteLine("Ingrese un valor para Cantidad de Litros Vendida:");
                CantidadLitrosVendida = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un valor para Importe Total de Venta:");
                ImporteTotalVenta = double.Parse(Console.ReadLine());

                if (CantidadLitrosVendida > 500){
                    ImporteFinalConDesc = ImporteTotalVenta * 0.75;
                     } else if (CantidadLitrosVendida > 300){
                        ImporteFinalConDesc = ImporteTotalVenta * 0.85;
  
                     }else if (CantidadLitrosVendida > 100){
                        ImporteFinalConDesc = ImporteTotalVenta * 0.90;
                     }
                     else{
                        ImporteFinalConDesc = ImporteTotalVenta;
                     }
                     Console.WriteLine("El importe total con Descuento aplicado es:" + ImporteFinalConDesc);
                       Console.WriteLine("Fin del programa!");
        }
    }
}
