using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiplos3de1a100
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

            for (int i = 1; i <= 100; i++) {
                if (numero % 3 == 0) {
                    MessageBox.Show("Múltiplo de 3:" + numero);
                    
                }
                numero++;
            }
        }
    }
}
