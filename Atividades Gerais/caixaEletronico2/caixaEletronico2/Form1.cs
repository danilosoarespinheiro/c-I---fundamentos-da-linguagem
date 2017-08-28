using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixaEletronico2
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

        private void button1_Click(object sender, EventArgs e)
        {
            double valorInvestido =  2000.0;

            /*
            for (int i = 1; i <=12; i++) {
                valorInvestido = valorInvestido * 1.01;
            }
            */

            int i = 1;

            while (i <= 12) {
                valorInvestido = valorInvestido * 1.01;
                i++;
            }

            MessageBox.Show("O valor instido agora é " + valorInvestido);
        }
    }
}
