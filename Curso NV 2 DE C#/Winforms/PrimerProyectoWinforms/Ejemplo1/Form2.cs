using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Elementos = txtNombre.Text;
            lwElementos.Items.Add(Elementos);


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Amarillo");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            // Text Box
            string Nombre = txtNombre.Text;

            //Date Time Picker

            DateTime fechaNacimiento = dtpFechaNacimiento.Value;// VALUE devuelve un dato Datetime


            //Check Box con  OPERADOR TERNARIO

            string Futbol = ckbFutbol.Checked == true ? "Le gusta el futbol, deporte de machos alfa " : " No le gusta marica malnacido";



            //Radio Button
            string equipoFavorito;

            if (rbtBoca.Checked == true)

                equipoFavorito = "Boca";

            else if (rbtLanus.Checked)
                equipoFavorito = "Lanus";

            else equipoFavorito = "River";

            //Combo Box

            String colorFavorito = cboColorFavorito.SelectedItem.ToString();

            //Numeric Up Down

            string numeroFavorito = numNumeroFav.Value.ToString();


            // Variable para crear el mensaje

            string mensaje = "El nombre de la persona seleccionada es " + Nombre + " , su fecha de nacimiento es " + fechaNacimiento + " su opinión sobre el deporte es que " + Futbol + " su color favorito es: " + colorFavorito + " y su numero favorito es el: " + numeroFavorito;

            MessageBox.Show(mensaje);


        }
    }
}
