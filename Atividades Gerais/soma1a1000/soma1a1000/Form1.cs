using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soma1a1000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int numero = 0;

            for (int i = 1; i <= 1000; i++) {

                
                numero = numero + 1;
            }
            MessageBox.Show("Soma " + numero);
        }
    }
}
