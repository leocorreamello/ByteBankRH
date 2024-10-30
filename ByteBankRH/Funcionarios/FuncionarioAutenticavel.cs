using ByteBankRH.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRH.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {

        public string Senha { get; set; }

        public FuncionarioAutenticavel(double Salario, string CPF) : base(Salario, CPF)
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
