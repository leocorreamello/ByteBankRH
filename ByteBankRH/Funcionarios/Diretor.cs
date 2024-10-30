using ByteBankRH.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRH.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public Diretor(double Salario, string CPF) : base(Salario, CPF) //Chama o construtor da classe pai
        {
            Console.WriteLine("Diretor criado");
        }

        public override double GetBonificao() //Override sobrescreve o método da classe pai
        {
            return Salario;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
