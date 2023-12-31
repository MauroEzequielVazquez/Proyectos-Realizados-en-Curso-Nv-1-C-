using System;

namespace WhileConFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, Acu, Promedio;
           
           Console.WriteLine( "Ingrese 1 para comenzar a programar y 0 para terminar el Programa:"); // como tengo ciclo while tengo q inicializar para q ejecute
           N = int.Parse(Console.ReadLine()); // declaro variables
           while (N != 0 ){
            Acu = 0; // REINICIALIZO EL acu dentro del while pero fuera del for, asi cuando pega cada vuelta lo resetea a 0;
            for (int x = 0; x < 20; x++){
            Console.WriteLine("Ingrese una edad: ");
            N = int.Parse(Console.ReadLine());
            Acu += N;
            }
            Promedio = Acu / 20;
            Console.WriteLine("El promedio es :" + Promedio);
            Console.WriteLine( "Ingrese 1 para comenzar a programar y 0 para terminar el Programa:");
           N = int.Parse(Console.ReadLine());
           }
            Console.WriteLine("fIN DEL PROGRAMA");
        }
    }
}
