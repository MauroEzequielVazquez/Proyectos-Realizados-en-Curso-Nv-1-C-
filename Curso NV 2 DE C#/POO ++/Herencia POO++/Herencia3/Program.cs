using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // AnimalDomestico A1 = new AnimalDomestico();
           // A1.Nombre = "Pirka";
           Gato G1 = new Gato();
            G1.Nombre = "Michi";

            Perro P1 = new Perro();
            P1.Nombre = "Boris";

            // Creo una lista de animales y cargo cualquier tipo de animal
            // porque perro, gato, canario, tigre,,todos estan dentro de la flia de animales
            // dentro de la jerarquia animal donde Animal es la clase base,, todo lo q esta abajo son animales
            
            //List<Animal> listaAnimales = new List<Animal>();
            //listaAnimales.Add(G1);
            //listaAnimales.Add(P1);
            //listaAnimales.Add(new Pez());
            //listaAnimales.Add(new Tigre());
            //listaAnimales.Add(new Canario());// es otra manera de agregar objetos
            //listaAnimales.Add(new Tigre());
            // lo que estoy haciendo aca es lo mismo que hago asignando  el objeto a una variable
            // y a un elemento en la lista por ejemplo al gato lo asigno a la variable g1 y
            // //al primer ele de la lista
            //perro lo referencio  a la variable p1 y al 2do elemento de la lista
            // pero en este caso estoy referenciando el objeto directamente a una ubicacion de la lista

            
            List<Flyable> listaVoladores = new List<Flyable>();   
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());


            //foreach (Flyable item in listaVoladores)
            //{

            //}







            //foreach (Animal item in listaAnimales)
            //{
            //    Console.WriteLine(item.Comunicarse());
            //    // imprime x pantalla lo que tenga el item. funcion comunicarse

            //}   




            //Console.WriteLine(A1.ToString());
            // Console.WriteLine(G1.Comunicarse());
            // Console.WriteLine(P1.Comunicarse());
            // recordarmos que los metodos aparecen tipo cubo y los atributos tipo llave francesa
            Console.ReadKey();
        }
    }
}
