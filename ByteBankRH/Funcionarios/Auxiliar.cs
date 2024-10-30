using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRH.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(double Salario, string CPF) : base(Salario, CPF)
        {
            Console.WriteLine("Auxiliar criado");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificao()
        {
            return Salario * 0.2;
        }
    } 
}
