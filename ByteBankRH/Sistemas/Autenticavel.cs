using ByteBankRH.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRH.Sistemas
{
    public interface IAutenticavel //É uma boa pratica colocar o I na frente do nome de uma interface
    {
        bool Autenticar(string senha);

    }
}
