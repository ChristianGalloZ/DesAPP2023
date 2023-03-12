using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            string cedula = txtcc.Text;
            string nombre = txtName.Text;
            txtcc.Text = "";
            txtName.Text = "";


            Dictionary<string, string> Empleados = new Dictionary<string, string>();

            while(Empleados.Count < 12) { 
               

                Empleados.Add(cedula, nombre);
                break;

            }

            foreach(var item in Empleados)
            {
                MessageBox.Show(item.Key);
                MessageBox.Show(item.Value);
            }
        }


    void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
