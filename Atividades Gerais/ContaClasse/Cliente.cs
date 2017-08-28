using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaClasse
{
    class Cliente
    {
        public String nome;
        public String endereco;
        public String rg;
        public String cpf;
        public int idade;

        public Boolean EhMaiorDeIdade(int idade) {
            Boolean resultado;

            if (idade >= 18)
            {
                resultado = true;
            }
            else {
                resultado = false;
            }
            return resultado;
        }
    }
}
