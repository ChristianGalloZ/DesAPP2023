﻿using System;
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
            double pesos = Convert.ToDouble(conversor)*dolar;


            MessageBox.Show(pesos.ToString());

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
