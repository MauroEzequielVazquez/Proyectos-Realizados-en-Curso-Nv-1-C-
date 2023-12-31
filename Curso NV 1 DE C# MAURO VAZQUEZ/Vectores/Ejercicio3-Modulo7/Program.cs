using System;

namespace Ejercicio3_Modulo7
{
    class Program
    {
        static void Main(string[] args)         //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos)
                                         //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
                                         //Mostrar el resultado en pantalla. Ejemplo: CADENA FUENTE: “La mar estaba serena"
                                         // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
                                         // CADENA RESULTADO: “Li mir estibi sereni"
                                          
        {   
            char [] frase = new char [30];
            char letraActual, letraNueva, letra;
            int indice = 0;

            Console.WriteLine("Ingrese su nombre letra por letra : ");
             letra = char.Parse(Console.ReadLine());
             
             while ( letra != '.' && indice < 30)
             {
                frase [indice] = letra;
                Console.WriteLine("Ingrese otro caracter para armar la frase y cortar con PUNTO:");  //ingreso una letra,, entro,, hago todo,, si la letra q ingreso es dif de PUNTO ´.´  termina
                letra =  char.Parse(Console.ReadLine());
                indice++;

             }

             frase [indice] = '\0';  // una vez q termiamos de cargar el vector o la cadena de caracteres , ponemos el 
                                     // '\0´para marcar el final .. ya sabemos xq

             Console.Write("La frase COMPLETA es : "); // vamos a recorrer la frase para poder LEERLA y mostrar en pantalla
             indice = 0; // incializas nuevamente en 0
             while ( frase [indice] != '\0')     
             {
                Console.Write(frase[indice]);
                indice++;
             }  // acá lo que haces es leer la cadena de caracteres,, y la imprimis


             Console.Write(" \n Ingrese la letra actual la cual vamos a  reemplazar : "); // pedimos las 2 letras a reempplazar
             letraActual = char.Parse(Console.ReadLine());
                                                                     // el \n en la nueva impresion x pantalla le da el espacio
             Console.Write( "ingrese la letra nueva :");
             letraNueva = char.Parse(Console.ReadLine());

             indice = 0;   // Nuevamente vamos a recorrer la Cadena para reemplazar las letras, x eso vuelvo a inicialiar en 0 para recorrer desde el indice 0

             while ( frase [indice] != '\0')  
             {
                if (frase[indice] == letraActual){  // es algo GENERICO no ponemos a e i xq puede reempLazar lo q queramos,,
                    frase[indice] = letraNueva;
                } // si cerras el condicional if con el indice++ dentro se cuelga xq desordena todo
                    indice++;
                
                

             }
             Console.Write("La frase nueva es: ");
             indice = 0; // INICIALIZAS nuevamente en 0 xq vas a recorrerlo y suplantar las letras o caracteres genericos
              while ( frase[indice] != '\0')  
              {
                Console.Write(frase[indice]);
                indice++;
              }


              Console.WriteLine(" \n Fin del Programa ");
                                    
            
        }
    }
}
