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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Que haces Narigon");
            string texto = txtNombre.Text;
            lblSaludo.Text = "Hola " + txtNombre.Text; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido a la App de esritorio");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // MessageBox.Show("Gracias por usar la App");
        }

        
    }
}
