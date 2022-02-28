using ByteBank.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public abstract class FuncionárioAutenticavel: Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionárioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {

        }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
