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
            double valorInvestido = 2000.0;
            
            for (int j = 0; j <= 12; j++) { 
                valorInvestido *= 1.01;
            }

            MessageBox.Show("O valor investido, com for, agora é: " + valorInvestido);

            valorInvestido = 2000.0;
            int i = 0;
            while (i<=12)
            {
                valorInvestido *= 1.01;
                i++;
            }
            MessageBox.Show("O valor investido, com while, agora é: " + valorInvestido);
        }
    }
}
