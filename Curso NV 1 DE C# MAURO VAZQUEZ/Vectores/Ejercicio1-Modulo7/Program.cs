using System;

namespace Ejercicio1_Modulo7
{
    class Program        //Hacer un programa que solicite 10 números enteros y los guarde en un vector
                      //. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
    {
        static void Main(string[] args)
        {
            
            int [] vectorNumeros = new int [10];
            
            for ( int x = 0; x < 10; x++) // guardas todo con 1 vector
            {
                Console.WriteLine("Ingrese un numero para cargar mis elementos en las posiciones del vector: ");
                 vectorNumeros[x] = int.Parse(Console.ReadLine()); // es una alternativa , SINO LA CLASICA ES DECLARAR N 
                                                                   //Y desp VectorN[x] = N;
                

            }
            
            int max = vectorNumeros[0]; // es como decir que en la primera vuelta el max es el valor en el indice 0, el primer elemento q encuentro
            int pos = 1;  // para la persona que lo usa va de 1 a 10,, si el indice es 0 la pos es 1, si el indice es 8 la pos es 9 y asi
            
            for ( int x = 0; x < 10; x++)
            { // Puedo hacer x = 1 y arrancar de 1 , xq en la vuelta 0 el max es vector [0] ya lo sabemos, asi q puedo arrancar en 1

                if(vectorNumeros[x] > max){
                max =  vectorNumeros[x];
                pos = x + 1; // tal cuál como hice en el ejercicio 2 de ciclos combinados

                }
            } 
            Console.WriteLine(" Valor del vector en el indice  4, y quinto elemento  ingresado es: " + vectorNumeros[4]); // vemos como leer el vector
            Console.WriteLine("El maximo numero ingresado es: " + max);
            Console.WriteLine("La posición ingresada es: " + pos);
            Console.WriteLine("Fin del Programa");
        }
    }
}
