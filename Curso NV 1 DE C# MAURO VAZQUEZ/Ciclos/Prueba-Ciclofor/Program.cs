using System;

namespace Prueba_Ciclofor
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nota , Acu = 0, Promedio;  // declaro variable "NOTA"
            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese una nota: ");
                Nota = int.Parse(Console.ReadLine());
              Acu += Nota;  // es como decir ACU =  ACU + Nota 

            }
            
            Promedio = Acu / 10 ;  // sobre 10 xq pidio 10 Notas,, el cilo for es de 5
            Console.WriteLine("El promedio de Notas del Alumno es : " + Promedio);  
            Console.WriteLine("Fin del programa");
        }
    }
}
 