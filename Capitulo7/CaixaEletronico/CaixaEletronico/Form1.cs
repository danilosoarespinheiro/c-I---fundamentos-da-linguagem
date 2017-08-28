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
            Conta guilherme = new Conta();
            guilherme.Deposita(2000.0);

            Conta mauricio = new Conta();
            mauricio.Deposita(1000.0);

            guilherme.Transfere(200.0, mauricio);
            guilherme.Deposita(150.0);
            mauricio.Saca(50.0);

            MessageBox.Show("guilherme = " + guilherme.saldo);
            MessageBox.Show("mauricio = " + mauricio.saldo);

            double rendimentoAnual = mauricio.CalculaRendimentoAnual();
            MessageBox.Show("Rendimento da Conta do Mauricio " + rendimentoAnual);
        }
    }
}
