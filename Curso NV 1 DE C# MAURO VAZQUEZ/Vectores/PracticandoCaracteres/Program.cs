using System;

namespace PracticandoCaracteres
{
    class Program       
    {
        static void Main(string[] args)
        {

         char [] nombre = new char [20];
         char letra;
         int indice = 0;

         Console.WriteLine("Ingrese su nombre letra por letra: ");// podemos hacer el corte con /o también
         letra = char.Parse(Console.ReadLine());
         
         while (letra != '.' &&  indice < 20) // el limitador con && menor a 20 es xq si ponemos 20 y no ponemos punto se rompe, es 1 corte adicional
         {
            nombre [indice] = letra;        // PIDO, SUMO, ES DISTINTO DE PUNTO,,GUARDO Y ASI
            Console.WriteLine("Ingrese otra letra, La carga termina con un Punto: ");
            letra = char.Parse(Console.ReadLine());
             indice++; 

           
         }
         

         nombre[indice] = '\0'; // al final cargo el barra 0 q le da fin a una cadena de caracteres , marca el fin
                                 // ya tengo cargado el nombre,, ahora COMO LO MUESTRO
         
                            //Console.WriteLine("Hola " + nombre);  NO PUEDO HACER ESO DA SYSMTEM ERROR
           
           
 
        Console.Write("hOLA ");  // CONSOLE solo para el Hola y el vector Lo tengo q mostrar con un ciclo while
        indice = 0;                // WriteLine hace escritura con un enter y Write solo sin enter, x eso en este caso queda mejor xq dice Hola Mauro todo junto  
        
        while (nombre[indice] != '\0')
        {
            Console.Write(nombre[indice]);
            indice++;
        }
        
            
        }
    }
}
