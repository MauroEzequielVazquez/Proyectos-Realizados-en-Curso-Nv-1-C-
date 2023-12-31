using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {

        // constructor
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;

        }
        // una sobre carga de constructor para poner en práctica

        public Telefono() { }


        // atributos
        public string modelo { get; }
        public string marca { get; }
        public string numeroTelefonico { get; set; }
        private int codigoOperador;

        

        //props

        public int CodOperador
        {
            get { return codigoOperador; }

            set
            {
                if (value > 0 && value < 4) //Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }

            }
        }

            //Metodos

                public string Llamar()
        {
            return "Realizando llamada... ";


        }

        // Sobrecarga de Metodo llamar

        public string Llamar( string contacto)
        {
            return "LLamando a, " + contacto;



        }

    }

    }

