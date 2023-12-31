using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Gato : AnimalDomestico  
    {

        // sobre escritura del metodo comunicarse para dar el sonido a Gatito
        public override string Comunicarse()
        {
            return "Miauu Miau me dice la gata";
        }



    }
}
