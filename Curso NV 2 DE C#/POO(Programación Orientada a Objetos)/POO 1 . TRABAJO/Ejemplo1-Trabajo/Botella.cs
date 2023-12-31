using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Trabajo
{
    internal class Botella
    // capacidad maxima de carga 100;
    // cantidad actual inicia en 0;
    // metodo de carga: carga al 100 y devuelve el costo de la recarga de esa bot. 50 cada 100.

    {
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        // Constructor para setear color y capacidad de entrada sin necesidad de hacer props
        //el constructor se tiene q llamar igual que la clase y van con ()  a diferencia de las prop
        // las prop del constructor ya quedan seteaas, se pueden leer pero NO modificar

        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100; // le das 1 capacidad inicial y la prop de capacidad queda obsoleta
            cantidadActual = 0;

        }

        // Sobrecarga  de constructores
        public Botella() { } // no recibe parametros en este caso y sirvd  si qremos una opc sin nada como la objet por defecto
        // logica.. la cual no contiene

        // DESTRUCTOR..
        //....

        // PROPIEDADES
        public string Material
        {
            get { return material; }
        }

        public string Color // los nombres de las func , con MAYUSCULA y los atributos con minuscula
        { // al ser declarado como una funcion de constructor,, podes leerlo pero NO setearlo
            get { return color; }

        }

        public int CantidadActual
        {
            get { return cantidadActual; }

        }


        public int Capacidad
        {
            get { return capacidad; }
            //set { capacidad = value; } como cree 1 capacidad de entrada ya no seteo

        }

        // Metodo o comportamiento
        public float Recargar()
        {
            if (cantidadActual > 0)
            {
                int diferencia = capacidad - cantidadActual;
                // 100 o capacidad  valen 50,, la dif cuanto vale?
                float monto = diferencia * 50 / 100;
                cantidadActual += diferencia; // la cant actual es igual a la cant q habia mas la dif cargada
                return monto;
            }
            cantidadActual = 100; // lleva a 100 osea llena la botella
            return 50;// monto a pagar por llenarla

        }

        // Sobre carga de Metodo o comportamiento
        public float Recargar( int cantidad ) // devuelve un float x eso es tipo float
        {
            cantidadActual += cantidad; // a la cantidad Actual le sumas la cant q viene x parametro
            return cantidad + 50 / 100;

        }
    }
}











