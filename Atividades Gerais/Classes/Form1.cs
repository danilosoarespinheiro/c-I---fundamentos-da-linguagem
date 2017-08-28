using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta umaconta = new Conta();
            umaconta.numero = 1;
            umaconta.titular = "Joaquim Jose";
            umaconta.saldo = 2000.0;

            Conta outraconta = new Conta();
            outraconta.numero = 2;
            outraconta.titular = "Silva Xavier";
            outraconta.saldo = 1500.0;

            MessageBox.Show("O titular da conta 1 é : " + umaconta.titular);
                

        }
    }
}
