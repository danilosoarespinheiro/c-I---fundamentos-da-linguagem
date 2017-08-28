using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotaFiscal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double valorDaNota;

            valorDaNota = 7000.0;

            if (valorDaNota < 1000)
            {
                valorDaNota = valorDaNota + (valorDaNota * 0.02);
                MessageBox.Show("Imposto de 2%, Valor = " + valorDaNota);
            }
            else if ((valorDaNota == 1000) && (valorDaNota < 3000))
            {
                valorDaNota = valorDaNota + (valorDaNota * 0.025);
                MessageBox.Show("Imposto de 2.5%, valor = " + valorDaNota);
            }
            else if ((valorDaNota >= 3000) && (valorDaNota < 7000))
            {
                valorDaNota = valorDaNota + (valorDaNota * 0.028);
                MessageBox.Show("Imposto de 2.8%, valor = " + valorDaNota);
            }
            else 
            {
                valorDaNota = valorDaNota + (valorDaNota * 0.03);
                MessageBox.Show("Imposto de 3%, valor = " + valorDaNota);
            }
        }
    }
}
