using System;

namespace Ejercicio5_Modulo3
{ // 5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;  //DECLARO VARIABLES
            Console.WriteLine("ingrese un Valor para la variable A: ");  // LES ASIGNO VALOR
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un Valor para la variable B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un Valor para la variable C: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un Valor para la variable D: ");
            D = int.Parse(Console.ReadLine());
            if (A > 100)              // Utilizando el condicional If voy descartando los que no son > a 100
                Console.WriteLine("El Primer valor de: " + A  + " Es mayor a 100."); // separar el es mayor de las  "" al menos un espacio sino al imprimirlo sale todo junto
            if (B > 100)
                Console.WriteLine("El Segundo valor de: " + B  +  " Es mayor a 100.");
            if (C > 100)
                Console.WriteLine("El Tercer valor de: " + C  +  " Es mayor a 100.");
            if (D > 100)
                Console.WriteLine("El Cuarto valor de: " + D  +  " Es mayor a 100.");
            

            Console.WriteLine("Se acabo el programita y el Modulo 3 papaa!");
        }
    }
}
