using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int numeroDaConta;
            numeroDaConta = 1;

            double saldo = 100.0;
            double valor = 10.0;
            double valorAposSaque = saldo - valor;

            MessageBox.Show("O saldo da conta atual: " + valorAposSaque);*/

            double saldo = 100.0;
            double valor = 110.0;
            bool podeSacar = (valor <= saldo) && (valor >= 0);

            if (podeSacar)
            {
                saldo = saldo - valor;
                MessageBox.Show("Saque realizaod com sucesso");
            }
            else {
                MessageBox.Show("Saldo Insuficiente");
            }

        }
    }
}
