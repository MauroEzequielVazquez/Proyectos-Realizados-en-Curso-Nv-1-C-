using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probemosqueaprendimos
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void PerfilAgente_Load(object sender, EventArgs e)
        {
            cboDestino.Items.Add("Dirección Nacional");
            cboDestino.Items.Add("CPF II");
            cboDestino.Items.Add("Otros..");
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            // Recopilar datos para apretar el boton  y que aparezcan

            // Texto Box
            string nombre = txtNombre.Text;

            // date time picker


            DateTime FechaNac = dtpFechaNacimiento.Value;


            //Numeric Up Down

            string Credencial = numericUpDownCredencial.Value.ToString();

            // check box

            string Actividad = ckbActividad.Checked == true ? "si está en Actividad" : "No está en Actividad"; // operador ternario

            // Radio Button

            string Escalafon;

            if (rbtCuerpoGeneral.Checked == true)
                Escalafon = "Cuerpo General";

            else if (rbtAdministrativo.Checked)
                Escalafon = "Administrativo";
            else if (rbtMaestranza.Checked)

                Escalafon = "Maestranza";
            else
                Escalafon = "Ninguna de las anteriores";

            // Combo box
            string DestinoActual = cboDestino.SelectedItem.ToString();
            

            //monthCalendar

            string FechaIngreso = monthCalendar1.SelectionStart.ToString();

            

            MessageBox.Show("El nombre del agente es " + nombre + ", su fecha de nacimiento es: " + FechaNac + 
                " su credencial es " + Credencial + " . El mismo " + Actividad + " , Pertenece al Escalafón "
                + Escalafon + " , su destino Actual es " + DestinoActual + " y su fecha de Ingreso es: " +
                FechaIngreso);

        }
    }
}
