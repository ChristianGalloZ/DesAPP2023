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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int fibo0 = 0;
            int fibo1 = 1;
            int fibo2 = 0;

            String fibonacci = txtFibo.Text;

            int numeros = Convert.ToInt32(fibonacci);

            for (int i = 2; i <= numeros; i++)
            {
                fibo2 = fibo0 + fibo1;
                
                fibo0 = fibo1;
                fibo1 = fibo2;
               

            }
            MessageBox.Show("El numero en la secuencia de Fibonacci es: "+fibo2.ToString());

            /*Christian Gallo Zapata
            Juan Felipe Eslava Quintero
           */
        }
    }
}
