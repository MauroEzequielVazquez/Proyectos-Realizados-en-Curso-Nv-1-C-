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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboUsuario.Items.Add("Tramitacion"); // el combo box cbo se carga al iniciar el form
            cboUsuario.Items.Add("Comunicación");
            cboUsuario.Items.Add("Subsanación");
            cboUsuario.Items.Add("Guarda Temporal");
            cboUsuario.Items.Add("Subsanación");

            cboSector.Items.Add("Tramitacion"); // el combo box cbo se carga al iniciar el form
            cboSector.Items.Add("Comunicación");
            cboSector.Items.Add("Subsanación");
            cboSector.Items.Add("Guarda Temporal");
            cboSector.Items.Add("Subsanación");

            CboMesaReparticion.Items.Add("Tramitacion"); // el combo box cbo se carga al iniciar el form
            CboMesaReparticion.Items.Add("Comunicación");
            CboMesaReparticion.Items.Add("Subsanación");
            CboMesaReparticion.Items.Add("Guarda Temporal");
            CboMesaReparticion.Items.Add("Subsanación");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstw_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Elementos = txtAgregar.Text;
            listview.Items.Add(Elementos);
        }

        private void perfilAgenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)

            {
                if (item.GetType() == typeof(Ventana))
                    return;
                
            }



            Ventana ventana1 = new Ventana();
            ventana1.MdiParent = this; // le decis que la instancia tiene el padre this osea donde 
            //está parado ahora,,la frm Principal es su padre
            ventana1.Show(); // ventana es objeto, oseauna instancia de la clase Ventana1
        }
    }
}
