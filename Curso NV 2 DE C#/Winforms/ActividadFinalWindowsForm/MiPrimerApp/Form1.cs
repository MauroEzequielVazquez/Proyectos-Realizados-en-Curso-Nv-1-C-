using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerApp
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenidos a C#");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           // MessageBox.Show("Chau chau Adios");
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se Activo el botonete ");
            //this.BackColor = Color.Blue;

            
            MessageBox.Show( txtinfo.Text + "\r\n"+ " su pasatiempo favorito es "+  txtpasatiempo.Text );

           
            if (txtinfo.Text == " ")
                txtinfo.BackColor = Color.Blue;
            else
                txtinfo.BackColor = System.Drawing.SystemColors.Control;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");

        }

        private void lblAgregar_MouseMove(object sender, MouseEventArgs e)
        {
            lblEtiqueta.BackColor = Color.Cyan;
            lblEtiqueta.Cursor = Cursors.Hand;
        }

        private void lblAgregar_MouseLeave(object sender, EventArgs e)
        {

        lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;
        lblEtiqueta.Cursor = Cursors.Arrow;

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                //e.Handled = true;
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboColorFav.Items.Add("Red");
            cboColorFav.Items.Add("");
            cboColorFav.Items.Add("Blue");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtinfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
