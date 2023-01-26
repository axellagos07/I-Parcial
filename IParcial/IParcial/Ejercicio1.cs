using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Numero2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SumarButton_Click(object sender, EventArgs e)
        {
            //Variables 

            decimal numero1 = Convert.ToDecimal(Numero1TextBox.Text);
            decimal numero2 = Convert.ToDecimal(Numero2TextBox.Text);

            decimal resultado = numero1 + numero2;

            //MessageBox.Show("La suma es:" + resultado);

            Resultadolabel.Text = Convert.ToString(resultado);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
