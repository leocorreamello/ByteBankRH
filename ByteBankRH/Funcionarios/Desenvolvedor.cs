using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRH.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(double Salario, string CPF) : base(Salario, CPF)
        {
            Console.WriteLine("Desenvolvedor criado");
        }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double GetBonificao()
        {
            return Salario * 0.1;
        }
    }
}
