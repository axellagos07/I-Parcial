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
        decimal sumaTotal=0;
        private void SumarButton_Click(object sender, EventArgs e)
        {
            //Variables 

            decimal numero1 = Convert.ToDecimal(Numero1TextBox.Text);
            decimal numero2 = Convert.ToDecimal(Numero2TextBox.Text);

            //decimal resultado = numero1 + numero2;

            //MessageBox.Show("La suma es:" + resultado);

            //Resultadolabel.Text = Convert.ToString(resultado);


            //sumar(numero1, numero2);
            sumaTotal = Sumatoria(numero1, numero2);
            MessageBox.Show("La suma es: "+ sumaTotal,"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        //Procedimiento
        private void sumar(decimal num1, decimal num2)
        {
            sumaTotal = num1 + num2;
        }

        //Función

        private decimal Sumatoria(decimal num1, decimal num2) 
        {
            decimal n1, n2, suma;
            n1 = num1;
            n2 = num2;

            suma = num1 + num2;
      
            return suma;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
