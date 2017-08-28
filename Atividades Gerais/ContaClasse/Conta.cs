using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaClasse
{
    class Conta
    {
        public int numero;
        
        public double saldo;

        public Cliente titular;

        //public Cliente cliente;

        public void saca(double valor, Boolean idade) {

            if ((valor >= 0) && (valor <= this.saldo) && (idade == true)) {
                this.saldo -= valor;
            } else if ((valor >= 0) && (valor <= this.saldo)  && (valor <= 200) && (idade == false))
            {
                this.saldo -= valor;
            }
                 
        }

        public void deposita(double valor)
        {
            if (valor >= 0) {
                this.saldo += valor;
            }

            
        }

        
    }
}
