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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "utepitos";
            string password = "tecnologica";
            string usuarioprue;
            string passprue;

            passprue = txtpass.Text;
            usuarioprue = txtusuario.Text;
            if (user == usuarioprue && password == passprue)
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Error");
            }

            Form2 moneda = new Form2();
            moneda.Show();
            this.Hide();

            /*Christian Gallo Zapata
              Juan Felipe Eslava Quintero
             */
        }
    }
}
