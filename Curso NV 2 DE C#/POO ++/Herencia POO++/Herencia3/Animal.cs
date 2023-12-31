using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Animal
    { 
        // metodo que hacen todos los animales en comun, y lo van a heredar de la clase base animal
        public virtual string Comunicarse()
        {
            return "Ruido Ruido";
        }
    }
    // PARA PODER SOBREESCRIBIR UN METODO TIENE QUE TENER LA PALABRA VIRTUAL ESE METODOOOOOOO
}
