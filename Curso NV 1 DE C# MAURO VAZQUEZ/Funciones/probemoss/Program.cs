using System;

namespace probemoss
{                           // carguemos un saludo en la cadena de caracteres
    class Program
    {
        static void Main(string[] args)
        {
            char[] nombre = new char[20];
            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese una letra para ingresar al ciclo while :");
            letra = char.Parse(Console.ReadLine());

            while( letra != '.' && indice < 20)
            {
            nombre [indice] = letra;
            Console.WriteLine(" Ingrese otra letra, el cilo corta con punto: ");
            letra = char.Parse(Console.ReadLine()); 
           
            indice++;
            }
           nombre [indice] = '\0'; // una vez cargado el vector,, lo leemos

           Console.Write(" Hola " );
           indice = 0;


            while( nombre[indice] !='\0' ) // recorremos y lo leemos para imprimirlo
            {
                Console.Write(nombre[indice]);
                indice++;






            }

            Console.WriteLine(" \n Fin del Programa ");
        }
    }
}
