using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        // Sobreescribir el Metodo TOstring que heredamos de la clase Object

        public override string ToString()
        {
            return " El nombre de mi Animal Domestico es " + Nombre;
             // ahora mi metodo string fue modificado del original de clase objetct para
             // poder invocarlo  y que sirva de algo
        }
    }
}
