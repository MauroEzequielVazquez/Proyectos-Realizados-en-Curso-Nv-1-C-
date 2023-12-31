using System;
using System.Collections.Generic; // cuando creas 1 lista se pone en blanco esto
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Moto M1 = new Moto();
            // Autodeportivo autodeportivo = new Autodeportivo();// hereda de auto y a su vez de vehiculo

            Vehiculo V1 = new Vehiculo();
            Camioneta C1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();

            C1.Color = "Azul";
            c2.Color = "Rojo";
            c3.Color = "Amarillo";

            // CREAR UNA LISTA

            List<Camioneta> listaCamionetas = new List<Camioneta>();
            // agregar lista de camionetas
            listaCamionetas.Add(C1);
            listaCamionetas.Add(c2); // el agregar es un funcion
            listaCamionetas.Add(c3);
           
            // saber la cantidad de elementos de mi lista,, en caso q fueran muchos y nose
           // Console.WriteLine("La cantidad de mi lista de camionetas es: " +  listaCamionetas.Count);
            // si quiero mostrar un elemento dentro de ese listado hago como en los vectores
            //ejemplo segundo elemento

            c2.Color = "Verde"; // suplanta el color rojo x lo q vimos de referencias

            // Quitar elementos

            //listaCamionetas.Remove(c3); // recumeve el objeto c3 de la lista
            // Console.WriteLine("La cantidad de mi lista de camionetas  luego de recorrer es: " +  listaCamionetas.Count);

            // COMO RECORRO PARA VER EL COLOR DE TODOS LOS OBJETOS CAMIONETA recorriendo la coleccion de camionetas

            foreach (Camioneta item in listaCamionetas)
                
            {
                Console.WriteLine("Color: " + item.Color);

            }

            // Recorremos la lista hasta q termine y la cant de elementos que tengas es la cant
            // de vueltas q va a dar y en cada vuelta va a agarrar el elemento siguiente y
            // guardarlo en la variable item entonces cuando entra al ciclo agarrar el primer ele
            //En la sig vuelta el 2do,, y asi,, hasta q termine de recorrer la lista
            // Una lista es 1 tipo de coleccion que muestra los elem en el orden q los cargaste.. 


            //Console.WriteLine("El color del segundo elemento, indice 1 es: " + listaCamionetas[1].Color);
            Console.ReadKey();




           
            
            
            
            
            //C1.CargaMAXIMA = 1000; // ADEMAS DE tener el atributo motor, tiene carga max,,cosa q vehiculo no
           // Vehiculo V2 = new Camioneta(); // v2 es una variable sin objeto dentro...
            // puedo guardar 1 objeto de tipo camioneta en 1 variable de tipo vehiculo xq una camioneta es un vehiculo
            // si intento hacer al reves :
            // Camioneta C2 = new Vehiculo();
            // no se puede xq el compilador sabe q 1 camioneta es 1 vehiculo pero no q 1 vehiculo es 1 camio..

            
        }
    }
}
