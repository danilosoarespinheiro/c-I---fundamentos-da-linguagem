using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaIdades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int idadeJoao = 20;
            int idadeJose = 25;
            int idadeJoaquim = 30;

            double mediaIdades = (idadeJoao + idadeJoaquim + idadeJose) / 3;

            MessageBox.Show("A média das idades é " + mediaIdades);

        }
    }
}
