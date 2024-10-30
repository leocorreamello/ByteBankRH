using ByteBankRH.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRH.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }

        public Autenticavel(double Salario, string CPF) : base(Salario, CPF)
        {
           
        }

        public bool Autenticar(string senha)
        {
            if (this.Senha == senha)
                return true;
            else
                return false;
        }

    }
}
