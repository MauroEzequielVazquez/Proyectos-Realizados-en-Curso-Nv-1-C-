using System;

namespace Ejercicio4_Modulo8
{                     //4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una 
                      // la variable  recibida por referencia. Que analice el número y escriba variable recibida por referencia con:

                     //a. 1 si el número es positivo.
                     //b. -1 si el número es negativo.
                     //c. 0 si el número es cero.
    class Program
    {
        static void Main(string[] args)
        {
            int numero, estado = 9;


            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            positivoNegativoCero(numero, ref estado);
            Console.WriteLine("El estado del valor " + numero + " es: "  + estado);

            Console.WriteLine("Fin del Programa!");
        }
        static void positivoNegativoCero(int n, ref int j) // el valor por REFERENCI Lleva por delante la palabra reservada ref
        {
            if (n == 0)
            j = 0;
            else if (n > 0)
            j = 1;
            else  // lo que digamos con else va debajo, no en la misma linea
            j = -1;

        }
    }
}
