using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionários
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, double salario)
        {
            TotalDeFuncionarios += 1;
            this.CPF = cpf;
            this.Salario = salario;
        }

        public abstract void AumentarSalário();

        public abstract double getBonification();
    }
}
