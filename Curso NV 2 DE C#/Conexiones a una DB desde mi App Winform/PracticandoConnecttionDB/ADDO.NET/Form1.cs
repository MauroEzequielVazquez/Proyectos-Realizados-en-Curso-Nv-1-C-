using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADDO.NET
{
    public partial class Pokemons : Form
    {
        public Pokemons()
        {
            InitializeComponent();
        }

        private void Pokemons_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();//creamos una instancia
            dgvPokemons.DataSource = negocio.Listar();  //negocio. listar va a la  db y te devuelve una lista de datos
            
        }
    }
}
