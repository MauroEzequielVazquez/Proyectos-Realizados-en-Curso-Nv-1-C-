using System;

namespace Ejercicio3_Modulo3
{ //3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

//Si el importe es menor a ARS 1000, no hay descuento.
//Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
//Si el importe es ARS 5000 o más, aplica un descuento del 18%.
    class Program
    {
        static void Main(string[] args)
        {
            double ImporteDeVenta, ImporteFacturado;  //DECLARO VARIABLES
            Console.WriteLine("Ingrese un valor: ");
            ImporteDeVenta = double.Parse(Console.ReadLine());
            if (ImporteDeVenta >= 5000) {
            ImporteFacturado = (ImporteDeVenta * 0.82);  // le descontas el 18%
            }else if (ImporteDeVenta >= 1000) {
            ImporteFacturado = (ImporteDeVenta * 0.90); // le descontas el 10 %
            }else {
            ImporteFacturado = ImporteDeVenta;
            }
            Console.WriteLine("El minto facturado es: " + ImporteFacturado);

            Console.WriteLine("Fin del programa!");
        }
    }
}
