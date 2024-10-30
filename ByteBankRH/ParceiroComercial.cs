using ByteBankRH.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRH
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public ParceiroComercial()
        {
            Console.WriteLine("Parceiro Comercial criado");
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
