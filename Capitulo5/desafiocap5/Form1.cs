using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafiocap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            int numero = 20;
            

            int divisao3 = numero % 3;
            int divisao4 = numero % 4;

            if (divisao3 == 0)
            {
                MessageBox.Show("Divisivel por 3");
            }
            else if (divisao4 == 0) {
                MessageBox.Show("Divisivel por 4");
            }
            */

            for(int valor = 1; valor <=30; valor++) {

                int result3 = valor % 3;
                int result4 = valor % 4;

                if (result3 == 0)
                {
                    MessageBox.Show("Número " + valor + " divisivel por 3");
                }
                else if (result4 == 0) {
                    MessageBox.Show("Número " + valor + " divisivel por 4");
                }

            }

        }
    }
}
