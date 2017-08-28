using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaClasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Cliente cliente = new Cliente();

            conta.titular = cliente;
            cliente.nome = "Fernanda";
            

            Boolean idade = cliente.EhMaiorDeIdade(30);

            conta.saldo = 1000.0;

            conta.saca(500, idade);


            MessageBox.Show("Saldo da conta : " + conta.saldo);

            /*if (idade == true)
            {
                MessageBox.Show("Fernanda Maior de Idade");
            }
            else {
                MessageBox.Show("Fernanda Menor de Idade");
            }*/

           

        }
    }
}
