using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerApp
{
    public partial class frmPracticaFinal : Form
    {
        public frmPracticaFinal()
        {
            InitializeComponent();
        }

        private void PracticaFinal_Load(object sender, EventArgs e)
        {
            //  MessageBox.Show("Bienvenido a la App");

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {


            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
       
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;




            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor= System.Drawing.SystemColors.Control;
            


            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;



            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            else
                txtDireccion.BackColor= System.Drawing.SystemColors.Control;



                llamarResultado();
            

        }

        private void llamarResultado()
        {

            txtResultado.Text = txtApellido.Text + " " + txtNombre.Text + "\r\n" + txtEdad.Text + "\r\n" + txtDireccion.Text;


        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

       
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // para que muestre solo numeros y no me deje poner letras

            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
                if(item.GetType() == typeof(Frm1))
            {
                MessageBox.Show("Ya tenes una ventana abierta");
                return;// para darle fin

            }
            




            Frm1 ventana = new Frm1();
            ventana.MdiParent = this; // a ventana le decis que tiene un padre o parent. this que es el q esta ejecutando
            ventana.Show();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
