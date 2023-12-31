using System;

namespace Tiempo_aprox
{        //3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades
            // y la velocidad promedio de un vehículo. Calcular y emitir por pantalla 
     //el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
    class Program
    { 

        static void Main(string[] args)
        {
      int km v, tiempoaprox; //declaro variables
      
      Console.WriteLine("Ingrese un valor para km:"); //les asigno valor
      km = int.Parse(Console.ReadLine());
      Console.WriteLine("ingrese un valor para velocidad:");
      v = int.Parse(Console.ReadLine());
     tiempoaprox = (km * v);// CALCULO
     Console.WriteLine("el Tiempo aprox de la distancia es:" + tiempoaprox); //EMITO

        }
    }
}
