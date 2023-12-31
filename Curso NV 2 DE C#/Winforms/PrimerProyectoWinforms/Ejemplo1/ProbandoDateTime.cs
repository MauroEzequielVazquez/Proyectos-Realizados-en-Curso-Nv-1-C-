using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class ProbandoDateTime : Form
    {
        public ProbandoDateTime()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
         
            DateTime fecha1;
            fecha1 = dtpFecha1.Value;

            MessageBox.Show("La fecha seleccionada es: " + fecha1.ToString("dd/mm/yyyy"));
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {

            //duda de como se guarda el cal en la variable  " . y que sigue desp"
           // DateTime fecha2;
           // fecha2 = calFecha2.SelectionStart.ToString());
            
            MessageBox.Show("La fecha seleccionada es:" + calFecha2.SelectionStart.ToString("dd/mm/yyyy"));
        }
    }
}
