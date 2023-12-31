using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Aguila : AnimalSalvaje, Flyable //las interfaces aparecen con un simbolito tipo llavecita azul
    {
        public string Volar()
        {
            return "Vuelva como un aguila";
        }
    }
}
