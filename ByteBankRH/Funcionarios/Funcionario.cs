using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRH.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; } //Protected permite que a classe filha acesse o atributo, porem o program não.

        public Funcionario(double Salario, string CPF)
        {
            this.CPF = CPF;
            this.Salario = Salario;
            TotalDeFuncionarios++;
        }
        public abstract double GetBonificao(); //Virtual permite que a classe filha sobrescreva o método (override)

        public abstract void AumentarSalario(); //Abstract obriga a classe filha a implementar o método
    }
}
