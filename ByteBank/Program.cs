using ByteBank.Funcionários;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();
            //TestaInnerException();
            //UsarSistema();
            //CalcularBonificacao();
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("contas.txt"))
            {
                leitor.LerProximaLinha();

            }
            //try
            //{
            //    leitor.LerProximaLinha();
            //}
            //catch(IOException ex)
            //{
            //    Console.WriteLine(ex);
            //}
            //finally 
            //{
            //}

        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(1, 1);
                ContaCorrente conta2 = new ContaCorrente(2, 2);
                conta.Transferir(1000, conta2);
                conta.Sacar(101);
            }
            catch (OperaçãoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor robson = new Diretor("612.253.687");
            robson.Nome = "Robson";
            robson.Senha = "123";

            GerenteDeConta lidia = new GerenteDeConta("615.253.687");
            lidia.Nome = "Lidia";
            lidia.Senha = "124";

            sistemaInterno.logar(robson, "123");
            sistemaInterno.logar(robson, "abc");
            sistemaInterno.logar(lidia, "124");
            sistemaInterno.logar(lidia, "abc");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "125";
            sistemaInterno.logar(parceiro, "125");

        }
        private static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            Diretor robson = new Diretor("612.253.687");
            robson.Nome = "Robson";

            Auxliar carlos = new Auxliar("613.253.687");
            carlos.Nome = "Carlos";

            Designer sonia = new Designer("614.253.687");
            sonia.Nome = "Sonia";

            GerenteDeConta lidia = new GerenteDeConta("615.253.687");
            lidia.Nome = "Lidia";

            gerenciadorBonificacao.Register(robson);
            gerenciadorBonificacao.Register(carlos);
            gerenciadorBonificacao.Register(sonia);
            gerenciadorBonificacao.Register(lidia);

            Console.WriteLine(gerenciadorBonificacao.getTotalBonificacao());


        }
    }
}
