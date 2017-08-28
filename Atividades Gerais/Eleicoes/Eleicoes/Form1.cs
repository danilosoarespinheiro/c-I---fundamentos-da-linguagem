using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleicoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int idade;
            String nacionalidade;

            idade = 16;
            nacionalidade = "americano";

            if ((idade >= 16) && (nacionalidade == "brasileira"))
            {
                MessageBox.Show("Pode Votar");
            }
            else {
                MessageBox.Show("Não pode Votar");
            }
        }
    }
}
