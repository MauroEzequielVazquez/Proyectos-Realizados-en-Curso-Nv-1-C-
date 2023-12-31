using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionesDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int a, b, r;

            try // try significa INTENTAR,, va a intentar ejecutar por mas que tengas excepciones
            {

                a = int.Parse(txt1.Text);

                b = int.Parse(txt2.Text);

                r = a / b;

                lblResultado.Text = "= " + r;

            }
            catch (Exception ex)  // modo Generico que no hace falta detallar el tipo de Exception
            
            {
                MessageBox.Show("Hubo un error, por favor comuníquese con el Dev");
            }

            
            //catch (FormatException ex)
            //{
            //    MessageBox.Show("Por favor, ingresá sólo números");

            //}

            //catch  (DivideByZeroException ex) 
            
            //{
            //    MessageBox.Show("No se puede divdir por cero, sinó se rompe el código");
            
           
            //}

        }
    }
}
