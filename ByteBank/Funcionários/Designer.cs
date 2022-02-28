using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionários
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {

        }
        public override void AumentarSalário()
        {
            Salario *= 1.11;
        }
        public override double getBonification()
        {
            return Salario *0.17;
        }
    }
}
