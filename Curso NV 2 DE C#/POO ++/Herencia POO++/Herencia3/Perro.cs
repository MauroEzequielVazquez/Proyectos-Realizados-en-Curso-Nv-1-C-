using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Perro : AnimalDomestico
    {

        //Sobreescrituta de Metodo

        public override string Comunicarse()
        {
            return "Guau Guau";
        }
    }
}
