using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRH.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(double Salario, string CPF) : base(Salario, CPF)
        {
            Console.WriteLine("Designer criado");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        public override double GetBonificao()
        {
            return Salario * 0.17;
        }
    }
}
