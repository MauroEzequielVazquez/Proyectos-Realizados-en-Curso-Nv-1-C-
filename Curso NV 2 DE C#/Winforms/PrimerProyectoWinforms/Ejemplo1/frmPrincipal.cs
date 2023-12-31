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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)

            {
                if(item.GetType() == typeof(Form2))
                {
                    MessageBox.Show("Ya tenes una vetana abierta!! ");

                    return; // le das corte
                }

            }

            Form2 ventana = new Form2();
            ventana.MdiParent = this;
            ventana.Show();


          

        }

        

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();


        }

        private void ventana2DATETIMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProbandoDateTime ventana2 = new ProbandoDateTime();
            ventana2.MdiParent = this;
            ventana2.Show();
        }
    }
}
