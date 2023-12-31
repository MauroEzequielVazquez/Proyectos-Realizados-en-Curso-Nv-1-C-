using System;

namespace Ejercicio3_Modulo4
{            // la consiga en la carpeta, es muy larga
    class Program
    {
        static void Main(string[] args)
        {
            int OpcionProcedador, OpcionMemoriaRam, OpcionDisco; //DECLARO VARIABLES ... OpcionDisco podria ser de tipo bool porque 
                                                          //si devuelve 1 se suma el costo  adicional  y si devuelve 0 no hace nada 
            float precio;

            Console.WriteLine("Ingrese una opcion para el procesador: "); 
            OpcionProcedador = int.Parse(Console.ReadLine());  

            Console.WriteLine("Ingrese un valor para Opcion de Memoria Ram: ");
            OpcionMemoriaRam = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Amplia Disco?");  // apretar 1 o 0 ,, 1 AMPLIA Y 0 NO
            OpcionDisco = int.Parse(Console.ReadLine());

            //ya tengo las 3 variables cargadas con sus datos,..

          switch (OpcionProcedador){  
            case 1:
              switch(OpcionMemoriaRam)
            {// abro y cierro { } en cada bucle,,este x ej el caso 1 y corta con la palabra reservada break y la ultima
            // es opc 3 default.. luego del ultimo caso dentro del caso 1,, va nuevamente break
            case 1:
                precio = 800;
                break;
            case 2:
               precio = 900;
              break;
            default:
               precio = 1000;
               break;
            } 
               break;
        
         case 2:
           switch(OpcionMemoriaRam)
            { 
            case 1:
                precio = 900;
                break;
            case 2:
               precio = 1000;
               break;
            default:
               precio = 1400;
               break;
            }  
               break;

          default: // ES COMO DECIR CASO 3
           switch(OpcionMemoriaRam)
           {
            case 1:
              precio = 1200;
              break;
            case 2:
               precio = 1400;
            break;
            default:            //CUANDO SE PONEN EN VIOLETA ES XQ SON PALABRAS RESERVADAS DE SWITCH
               precio = 2000;
               break;
            }  
                break;
          }      
          // HASTA ACA TENGO EL PRECIO DE PROCESADOR MAS MEMORIA!
          if (OpcionDisco == 1){
            precio = precio + 300;
          }

            Console.WriteLine("El precio final de la compu es : " + precio);
            Console.WriteLine(" FIN DEL PROGRAMA :");
        }
    }
}
