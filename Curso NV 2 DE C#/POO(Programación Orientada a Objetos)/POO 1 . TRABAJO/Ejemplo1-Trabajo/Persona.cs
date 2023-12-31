using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Trabajo
{
    internal class Persona
    {
        private int edad;
        private float sueldo;
        private string nombre;
        
        // CREAMOS UN constructor para darle 1 nombre inicial  y no un set xq no va a cambiar 

        public Persona( string nombre, int edad) // el constructor recibe el mismo nombre que la clase
        {
            this.nombre = nombre;
            this.edad = edad;

        }


 // Propiedades
     public float Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; } 
        }
       
        public string Nombre
        {  get { return nombre; } 
        
        }

        public int Edad
        { get { return edad; } }





        // METODOS
        public string Saludar()
        {
            return "Hola soy " + nombre;
        }

        // Sobre carga en este caso de metodo,, igual a una sobre carga de constructores
        public string Saludar (string personaje)
        {
            return "Hola  " + personaje + " , soy" + nombre;


        }


    }

}
