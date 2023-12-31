using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Articulo
    {
        public int CodArticulo { get; set; } // manera RESUMIDA y menos manejable de una prop

        public float Precio { get; set; }

        private int CodigoMarca; // defino atributo y creo su prop de forma "larga"

        public int CodMarca
        { 

         get { return CodigoMarca; }

            set
            {   
                if (value > 0 && value < 11)

                    CodigoMarca = value;
                else
                    CodigoMarca = -1; // si no esta en el rango devuelve -1
            }

       }
 

    }
}
