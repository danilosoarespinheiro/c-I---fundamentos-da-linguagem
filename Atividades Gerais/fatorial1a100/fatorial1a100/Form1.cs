﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fatorial1a100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int numero = 1;

            for (int n = 1; n <= 10; n++) {
                numero = numero * n;
                MessageBox.Show("fatorial(" + n + ") = " + numero);
            }
        }
    }
}
