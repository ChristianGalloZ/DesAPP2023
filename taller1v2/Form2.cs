using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller1v2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dolar = 4788;

            string conversor = txtValor.Text;
            double pesos = Convert.ToDouble(conversor) * dolar;


            MessageBox.Show("El valor en pesos es: $"+pesos.ToString());

            Form3 fibo = new Form3();
            fibo.Show();
            this.Hide();

            /*Christian Gallo Zapata
            Juan Felipe Eslava Quintero
           */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
