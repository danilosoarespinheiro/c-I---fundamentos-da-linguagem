using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio2cap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int valor = 0;

            for (int i = 1; i <= 100; i++) {
                

                if (i%3 != 0) {
                    valor = valor + i;
                }
                
                
            }
            MessageBox.Show("Valor final " + valor);
        }
    }
}
