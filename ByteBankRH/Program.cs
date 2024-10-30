using ByteBankRH.Funcionarios;
using ByteBankRH.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRH
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor(5000, "123.456.789-10");
            roberta.Nome = "Roberta";
            roberta.Senha = "2005";

            GerenteDeConta camila = new GerenteDeConta(4000, "123.456.789-10");
            camila.Nome = "Camila";
            camila.Senha = "123";

            sistemaInterno.Logar(roberta, "2005");
            sistemaInterno.Logar(camila, "123");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer(3000, "123.456.789-10");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor(5000, "123.456.789-10");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar(2000, "123.456.789-10");
            igor.Nome = pedro.Nome;

            Funcionario camila = new GerenteDeConta(4000, "123.456.789-10");
            camila.Nome = "Camila";

            Funcionario leo = new Desenvolvedor(3000, "123.456.789-10");
            leo.Nome = "Leo";

            gerenciadorBonificacao.Registrar(leo);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao()); 
        }
    }
}
