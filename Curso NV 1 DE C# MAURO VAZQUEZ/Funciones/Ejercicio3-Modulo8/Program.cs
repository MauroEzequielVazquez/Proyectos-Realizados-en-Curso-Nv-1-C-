using System;

namespace Ejercicio3_Modulo8 //3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
//                              Hacer un programa para ingresar números,  El lote corta cuando se ingresa un número cero. Informar
//                               el promedio teniendo en cuenta sólo los números primos.

{
    class Program
    {
        static void Main(string[] args)
        {
            int a,
                contadorPrimos = 0,
                acumulador = 0,
                promedio;

            Console.WriteLine("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());

            while (a != 0)
            {
                if (Primo(a)) // es como decir if (Primo(a)) == True ,,xq el IF se va al True siempre, en su defecto al False
                {
                    contadorPrimos++;
                    acumulador += a;
                }

                Console.WriteLine("Ingrese otro numero, el pedido corta con un 0 : ");
                a = int.Parse(Console.ReadLine());
            }
            promedio = (acumulador / contadorPrimos);
            Console.WriteLine(
                "El promedio teniendo en cuenta solo los numeros primos es : " + promedio
            );
            Console.WriteLine("La cantidad de numeros primos ingresados fue :" + contadorPrimos);
        }

        static bool Primo(int n) // la funcion si es INT devuelve 1 o 0 que es lo q pide la consiga, pero tipo bool hacemos Verdadero 1 o falso 0;
        {
            int contador = 0;

            for (int x = 1; x <= n; x++)
            {
                if (n % x == 0)
                    contador++;
            }
            if (contador == 2) // PARA REDUCIR LINEAS SI EL IF TIENE MENOS DE DOS LINEAS DE COD NO USO {{{{{}}}}}
                return true;
            else
                return false;
        }
    }
}
