using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "utepitos";
            string password = "tecnologica";
            string usuarioprue;
            string passprue;

            passprue = txtpass.Text;
            usuarioprue = txtusuario.Text;
            if (user == usuarioprue && password ==passprue)
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

        }
            
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
